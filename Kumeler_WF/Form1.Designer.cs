namespace Kumeler_WF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbKume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbElemanSayisi = new System.Windows.Forms.TextBox();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.cmbIslem2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKumeKombinasyon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbKume
            // 
            this.txbKume.Location = new System.Drawing.Point(9, 40);
            this.txbKume.Name = "txbKume";
            this.txbKume.Size = new System.Drawing.Size(180, 20);
            this.txbKume.TabIndex = 1;
            this.txbKume.TextChanged += new System.EventHandler(this.txbKume_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Alt Küme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbElemanSayisi
            // 
            this.txbElemanSayisi.Location = new System.Drawing.Point(9, 231);
            this.txbElemanSayisi.Name = "txbElemanSayisi";
            this.txbElemanSayisi.Size = new System.Drawing.Size(66, 20);
            this.txbElemanSayisi.TabIndex = 19;
            // 
            // cmbIslem
            // 
            this.cmbIslem.AutoCompleteCustomSource.AddRange(new string[] {
            "Alt Küme Sayısı",
            "Öz Alt Küme Sayısı",
            "İki Elemanlı Alt Kümelerinin Sayısı",
            "Üç Elemanlı Alt Kümelerinin Sayısı",
            "Dört Elemanlı Alt Kümelerinin Sayısı",
            "Beş Elemanlı Alt Kümelerinin Sayısı",
            "Altı Elemanlı Alt Kümelerinin Sayısı",
            "Yedi Elemanlı Alt Kümelerinin Sayısı",
            "En Az İki Elemanlı Alt Kümelerinin Sayısı",
            "En Az Üç Elemanlı Alt Kümelerinin Sayısı",
            "En Az Dört Elemanlı Alt Kümelerinin Sayısı",
            "En Az Beş Elemanlı Alt Kümelerinin Sayısı",
            "En Az Altı Elemanlı Alt Kümelerinin Sayısı"});
            this.cmbIslem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbIslem.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.cmbIslem, "Aşağıdaki listeden, belirtiğiniz küme ile ilgili yapmak istediğiniz işlemi seçip " +
        "butona tıklayanız.");
            this.cmbIslem.Items.AddRange(new object[] {
            "Alt Küme Sayısı",
            "Öz Alt Küme Sayısı",
            "İki Elemanlı Alt Kümelerinin Sayısı",
            "Üç Elemanlı Alt Kümelerinin Sayısı",
            "Dört Elemanlı Alt Kümelerinin Sayısı",
            "Beş Elemanlı Alt Kümelerinin Sayısı",
            "Altı Elemanlı Alt Kümelerinin Sayısı",
            "Yedi Elemanlı Alt Kümelerinin Sayısı",
            "En Az İki Elemanlı Alt Kümelerinin Sayısı",
            "En Az Üç Elemanlı Alt Kümelerinin Sayısı",
            "En Az Dört Elemanlı Alt Kümelerinin Sayısı",
            "En Az Beş Elemanlı Alt Kümelerinin Sayısı",
            "En Az Altı Elemanlı Alt Kümelerinin Sayısı"});
            this.cmbIslem.Location = new System.Drawing.Point(9, 128);
            this.cmbIslem.Name = "cmbIslem";
            this.helpProvider1.SetShowHelp(this.cmbIslem, true);
            this.cmbIslem.Size = new System.Drawing.Size(244, 21);
            this.cmbIslem.TabIndex = 22;
            this.cmbIslem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbIslem2
            // 
            this.cmbIslem2.FormattingEnabled = true;
            this.cmbIslem2.Items.AddRange(new object[] {
            "En Çok İki Elemanlı Alt Kümelerinin Sayısı",
            "En Çok Üç Elemanlı Alt Kümelerinin Sayısı"});
            this.cmbIslem2.Location = new System.Drawing.Point(9, 296);
            this.cmbIslem2.Name = "cmbIslem2";
            this.cmbIslem2.Size = new System.Drawing.Size(244, 21);
            this.cmbIslem2.TabIndex = 23;
            this.cmbIslem2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Sonuc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(214, 96);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txbElemanSayisi);
            this.groupBox1.Controls.Add(this.cmbIslem2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbIslem);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txbKume);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 375);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnKumeKombinasyon
            // 
            this.btnKumeKombinasyon.Location = new System.Drawing.Point(145, 171);
            this.btnKumeKombinasyon.Name = "btnKumeKombinasyon";
            this.btnKumeKombinasyon.Size = new System.Drawing.Size(75, 23);
            this.btnKumeKombinasyon.TabIndex = 27;
            this.btnKumeKombinasyon.Text = "Göster";
            this.btnKumeKombinasyon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnKumeKombinasyon);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(536, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 212);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label1, "a");
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.MaximumSize = new System.Drawing.Size(440, 50);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(283, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Küme Elemanlarını aralarına virgül koyarak yazınız.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label2, "a");
            this.label2.Location = new System.Drawing.Point(195, 39);
            this.label2.MaximumSize = new System.Drawing.Size(240, 50);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Örn: 12,a,Elma,Kristal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label3, "a");
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.MaximumSize = new System.Drawing.Size(440, 50);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(194, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lütfen yapmak istediğiniz işlemi seçini.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label4, "a");
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.MaximumSize = new System.Drawing.Size(200, 50);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.label4, true);
            this.label4.Size = new System.Drawing.Size(192, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "Yanda girilen küme elemanlarının tüm alt küme varyasyonlarını gösterir.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label6, "a");
            this.label6.Location = new System.Drawing.Point(6, 207);
            this.label6.MaximumSize = new System.Drawing.Size(440, 50);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.label6, true);
            this.label6.Size = new System.Drawing.Size(190, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Lütfen verilen alt küme sayısını giriniz.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label7, "a");
            this.label7.Location = new System.Drawing.Point(81, 230);
            this.label7.MaximumSize = new System.Drawing.Size(240, 50);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.label7, true);
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Örn: 29";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label8, "a");
            this.label8.Location = new System.Drawing.Point(9, 272);
            this.label8.MaximumSize = new System.Drawing.Size(440, 50);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.label8, true);
            this.label8.Size = new System.Drawing.Size(194, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Lütfen yapmak istediğiniz işlemi seçini.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 389);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbKume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbElemanSayisi;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.ComboBox cmbIslem2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKumeKombinasyon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

