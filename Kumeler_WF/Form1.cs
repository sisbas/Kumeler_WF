using PRI.ProductivityExtensions.ICollectionableExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kumeler_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kume kumelerim = new Kume();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kumelerim.KumeElemanlari = new List<object>();
            kumelerim.KumeElemanlari.Add(txbKume.Text.Split(',').ToList());
            var eSayisi = txbKume.Text.Split(',').ToList().Distinct().Count();
            label5.Text = "A={" + txbKume.Text + "}";
            switch (cmbIslem.SelectedIndex)
            {
                case 0: MessageBox.Show(kumelerim.AltKume(eSayisi).ToString()); break;
                case 1: MessageBox.Show(kumelerim.OzAltKume(eSayisi).ToString()); break;
                case 2: MessageBox.Show(kumelerim.İkiElemanli(eSayisi).ToString()); break;
                case 3: MessageBox.Show(kumelerim.UcElemanli(eSayisi).ToString()); break;
                case 4: MessageBox.Show(kumelerim.DortElemanli(eSayisi).ToString()); break;
                case 5: MessageBox.Show(kumelerim.BesElemanli(eSayisi).ToString()); break;
                case 6: MessageBox.Show(kumelerim.AltiElemanli(eSayisi).ToString()); break;
                case 7: MessageBox.Show(kumelerim.YediElemanli(eSayisi).ToString()); break;
                case 8: MessageBox.Show(kumelerim.EnAzİkiElemanli(eSayisi).ToString()); break;
                case 9: MessageBox.Show(kumelerim.EnAzUcElemanli(eSayisi).ToString()); break;
                case 10: MessageBox.Show(kumelerim.EnAzDortElemanli(eSayisi).ToString()); break;
                case 11: MessageBox.Show(kumelerim.EnAzBesElemanli(eSayisi).ToString()); break;
                case 12: MessageBox.Show(kumelerim.EnAzAltiElemanli(eSayisi).ToString()); break;
                default:
                    MessageBox.Show("Lütfen bir işlem seçiniz");
                    break;
            }
            label5.Update();
            var list = txbKume.Text.Split(',').Distinct().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    richTextBox1.AppendText("{" + list[i] + " , " + list[j] + "}" + "\t");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            helpProvider1 = new HelpProvider();
            helpProvider1.SetShowHelp(txbKume, true);
            helpProvider1.SetHelpString(txbKume, "Lütfen Küme Elemanlarını Aralarına virgül koyarak giriniz.");

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sonuc = 0;
            bool c = false;
            var eSayisi = txbKume.Text.Split(',').ToList().Distinct().Count();
            var AltKumeSayisiVerilirse = txbElemanSayisi.Text;
            if (int.TryParse(AltKumeSayisiVerilirse, out sonuc))
                c = true;

            //label9.Text = kumelerim.UcElemanliAltKumeSayisiVerilirse(c, sonuc).ToString();
            switch (cmbIslem2.SelectedIndex)
            {
                
                case 0: MessageBox.Show(kumelerim.EnCokİkiElemanliAltKümeSayisiVerilen(c, sonuc).ToString()); break;
                case 1: MessageBox.Show(kumelerim.EnCokUcElemanliAltKumeSayisiVerilirse(c, sonuc).ToString()); break;
                default:
                    MessageBox.Show("Lütfen bir işlem seçiniz");
                    break;
            }
        }

        private void txbKume_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
