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
            return txbKume.Text.Split(',').Distinct().Count();
        }

        private List<string> GetElementList()
        {
            return txbKume.Text.Split(',').Distinct().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _kume.KumeElemanlari = new List<object>();
            _kume.KumeElemanlari.Add(GetElementList());
            
            int elementCount = GetElementCount();
            lblKume.Text = "A={" + txbKume.Text + "}";
            
            ExecuteSelectedOperation(elementCount);
            DisplayTwoElementSubsets();
        }

        private void ExecuteSelectedOperation(int elementCount)
        {
            double result = cmbIslem.SelectedIndex switch
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
                _ => -1
            };

            if (result == -1)
                MessageBox.Show("Lütfen bir işlem seçiniz");
            else
                MessageBox.Show(result.ToString());
            
            lblKume.Update();
        }

        private void DisplayTwoElementSubsets()
        {
            var elements = GetElementList();
            richTextBox1.Clear();
            
            for (int i = 0; i < elements.Count; i++)
            {
                for (int j = i + 1; j < elements.Count; j++)
                {
                    richTextBox1.AppendText($"{{{elements[i]} , {elements[j]}}}\t");
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
            if (!int.TryParse(txbElemanSayisi.Text, out int subsetCount))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                return;
            }

            bool isValid = true;
            
            double result = cmbIslem2.SelectedIndex switch
            {
                0 => _kume.EnCokİkiElemanliAltKümeSayisiVerilen(isValid, subsetCount),
                1 => _kume.EnCokUcElemanliAltKumeSayisiVerilirse(isValid, subsetCount),
                _ => -1
            };

            if (result == -1)
                MessageBox.Show("Lütfen bir işlem seçiniz");
            else
                MessageBox.Show(result.ToString());
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
            int totalElements = GetElementCount();
            int foundCount = string.IsNullOrEmpty(txbBulunan.Text) ? 0 : txbBulunan.Text.Split(',').Distinct().Count();
            int notFoundCount = string.IsNullOrEmpty(txbBulunmayan.Text) ? 0 : txbBulunmayan.Text.Split(',').Distinct().Count();

            int remainingElements = rdoVe.Checked 
                ? totalElements - (foundCount + notFoundCount)
                : totalElements - foundCount;

            double result = rdoVe.Checked 
                ? _kume.Gicik(remainingElements)
                : totalElements - _kume.Gicik(remainingElements);

            MessageBox.Show(result.ToString());
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
