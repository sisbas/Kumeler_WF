using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kumeler_WF
{
    public partial class Form1 : Form
    {
        private readonly Kume _kume = new Kume();

        public Form1()
        {
            InitializeComponent();
            InitializeHelpProvider();
        }

        private void InitializeHelpProvider()
        {
            helpProvider1 = new HelpProvider();
            helpProvider1.SetShowHelp(txbKume, true);
            helpProvider1.SetHelpString(txbKume, "Lütfen Küme Elemanlarını Aralarına virgül koyarak giriniz.");
        }

        private int GetElementCount()
        {
            if (string.IsNullOrWhiteSpace(txbKume.Text))
                return 0;
            
            var elements = txbKume.Text.Split(',')
                .Select(e => e.Trim())
                .Where(e => !string.IsNullOrEmpty(e))
                .Distinct()
                .ToList();
            
            return elements.Count;
        }

        private List<string> GetElementList()
        {
            if (string.IsNullOrWhiteSpace(txbKume.Text))
                return new List<string>();
            
            return txbKume.Text.Split(',')
                .Select(e => e.Trim())
                .Where(e => !string.IsNullOrEmpty(e))
                .Distinct()
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _kume.KumeElemanlari = GetElementList();
                
                if (_kume.KumeElemanlari.Count == 0)
                {
                    MessageBox.Show("Lütfen en az bir küme elemanı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int elementCount = GetElementCount();
                lblKume.Text = "A={" + string.Join(", ", _kume.KumeElemanlari) + "}";
                
                ExecuteSelectedOperation(elementCount);
                DisplayTwoElementSubsets();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteSelectedOperation(int elementCount)
        {
            try
            {
                long? result = cmbIslem.SelectedIndex switch
                {
                    0 => _kume.AltKume(elementCount),
                    1 => _kume.OzAltKume(elementCount),
                    2 => _kume.İkiElemanli(elementCount),
                    3 => _kume.UcElemanli(elementCount),
                    4 => _kume.DortElemanli(elementCount),
                    5 => _kume.BesElemanli(elementCount),
                    6 => _kume.AltiElemanli(elementCount),
                    7 => _kume.YediElemanli(elementCount),
                    8 => _kume.EnAzİkiElemanli(elementCount),
                    9 => _kume.EnAzUcElemanli(elementCount),
                    10 => _kume.EnAzDortElemanli(elementCount),
                    11 => _kume.EnAzBesElemanli(elementCount),
                    12 => _kume.EnAzAltiElemanli(elementCount),
                    _ => null
                };

                if (result == null)
                    MessageBox.Show("Lütfen geçerli bir işlem seçiniz veya işlem için yeterli eleman sayısı olduğundan emin olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(result.Value.ToString("N0"), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                lblKume.Update();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Geçersiz giriş: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Taşma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayTwoElementSubsets()
        {
            var elements = GetElementList();
            richTextBox1.Clear();
            
            if (elements.Count < 2)
            {
                richTextBox1.Text = "İki elemanlı alt kümeler için en az 2 eleman gereklidir.";
                return;
            }
            
            for (int i = 0; i < elements.Count; i++)
            {
                for (int j = i + 1; j < elements.Count; j++)
                {
                    richTextBox1.AppendText($"{{{elements[i]}, {elements[j]}}}\t");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbBulunan.Visible = false;
            btnGicik.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txbElemanSayisi.Text, out int subsetCount))
                {
                    MessageBox.Show("Lütfen geçerli bir sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isValid = true;
                
                int? result = cmbIslem2.SelectedIndex switch
                {
                    0 => _kume.EnCokİkiElemanliAltKümeSayisiVerilen(isValid, subsetCount),
                    1 => _kume.EnCokUcElemanliAltKumeSayisiVerilirse(isValid, subsetCount),
                    _ => null
                };

                if (result == null)
                    MessageBox.Show("Lütfen bir işlem seçiniz veya verilen alt küme sayısına uygun eleman sayısı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(result.Value.ToString(), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gıcıkElemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleGicikElemanMode(true);
        }

        private void ToggleGicikElemanMode(bool showGicik)
        {
            txbElemanSayisi.Visible = !showGicik;
            lblBilgi1.Visible = !showGicik;
            lblBilgi2.Visible = !showGicik;
            lblBilgi3.Visible = !showGicik;
            lblBilgi4.Visible = !showGicik;
            groupBox2.Visible = !showGicik;
            cmbIslem.Visible = !showGicik;
            btnAltkume.Visible = !showGicik;
            cmbIslem2.Visible = !showGicik;
            btnSonuc.Visible = !showGicik;
            txbBulunan.Visible = showGicik;
            btnGicik.Visible = showGicik;
        }

        private void btnGicik_Click(object sender, EventArgs e)
        {
            try
            {
                int totalElements = GetElementCount();
                
                if (totalElements == 0)
                {
                    MessageBox.Show("Lütfen önce küme elemanlarını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int foundCount = string.IsNullOrWhiteSpace(txbBulunan.Text) 
                    ? 0 
                    : txbBulunan.Text.Split(',')
                        .Select(e => e.Trim())
                        .Where(e => !string.IsNullOrEmpty(e))
                        .Distinct()
                        .Count();

                int notFoundCount = string.IsNullOrWhiteSpace(txbBulunmayan.Text) 
                    ? 0 
                    : txbBulunmayan.Text.Split(',')
                        .Select(e => e.Trim())
                        .Where(e => !string.IsNullOrEmpty(e))
                        .Distinct()
                        .Count();

                if (foundCount + notFoundCount > totalElements)
                {
                    MessageBox.Show("Bulunan ve bulunmayan elemanların toplamı küme eleman sayısından fazla olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int remainingElements = rdoVe.Checked 
                    ? totalElements - (foundCount + notFoundCount)
                    : totalElements - foundCount;

                if (remainingElements < 0)
                {
                    MessageBox.Show("Kalan eleman sayısı negatif olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long result = rdoVe.Checked 
                    ? _kume.Gicik(remainingElements)
                    : _kume.AltKume(totalElements) - _kume.Gicik(remainingElements);

                MessageBox.Show(result.ToString("N0"), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Geçersiz giriş: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Taşma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Event Handlers (Empty/Unused)
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void txbKume_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e) { }
        #endregion
    }
}
