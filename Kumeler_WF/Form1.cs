﻿using System;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kume kumelerim = new Kume();
            kumelerim.KumeElemanlari = new List<object>();
            kumelerim.KumeElemanlari.Add(textBox1.Text.Split(',').ToList());
            var eSayisi = textBox1.Text.Split(',').ToList().Distinct().Count();            
            var AltKumeSayisiVerilirse = textBox2.Text;
            var sonuc =0;
            bool c = false;
            label1.Text = kumelerim.AltKume(eSayisi).ToString();
            label2.Text = kumelerim.İkiElemanli(eSayisi).ToString();
            label3.Text = kumelerim.UcElemanli(eSayisi).ToString();
            label4.Text = kumelerim.DortElemanli(eSayisi).ToString();
            label5.Text = kumelerim.BesElemanli(eSayisi).ToString();
            label6.Text = kumelerim.AltiElemanli(eSayisi).ToString();
            label7.Text = kumelerim.EnFazlaIkiElemanli(eSayisi).ToString();
            label8.Text = kumelerim.EnAzİkiElemanli(eSayisi).ToString();
            if (int.TryParse(AltKumeSayisiVerilirse, out sonuc))
            {
                c = true;
            }            
            label9.Text = kumelerim.UcElemanliAltKumeSayisiVerilirse(c,sonuc).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
