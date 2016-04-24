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
            this.btnAltkume = new System.Windows.Forms.Button();
            this.txbElemanSayisi = new System.Windows.Forms.TextBox();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.cmbIslem2 = new System.Windows.Forms.ComboBox();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbGicikEleman = new System.Windows.Forms.GroupBox();
            this.rdoVeya = new System.Windows.Forms.RadioButton();
            this.rdoVe = new System.Windows.Forms.RadioButton();
            this.txbBulunmayan = new System.Windows.Forms.TextBox();
            this.txbBulunan = new System.Windows.Forms.TextBox();
            this.btnGicik = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBilgi4 = new System.Windows.Forms.Label();
            this.lblBilgi3 = new System.Windows.Forms.Label();
            this.lblBilgi2 = new System.Windows.Forms.Label();
            this.lblKume = new System.Windows.Forms.Label();
            this.lblBilgi1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKumeKombinasyon = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altKümeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümAltKümeleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gıcıkElemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartezyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.grbGicikEleman.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // btnAltkume
            // 
            this.btnAltkume.Location = new System.Drawing.Point(178, 155);
            this.btnAltkume.Name = "btnAltkume";
            this.btnAltkume.Size = new System.Drawing.Size(75, 23);
            this.btnAltkume.TabIndex = 2;
            this.btnAltkume.Text = "Alt Küme";
            this.btnAltkume.UseVisualStyleBackColor = true;
            this.btnAltkume.Click += new System.EventHandler(this.button1_Click);
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
            this.cmbIslem2.Location = new System.Drawing.Point(9, 289);
            this.cmbIslem2.Name = "cmbIslem2";
            this.cmbIslem2.Size = new System.Drawing.Size(244, 21);
            this.cmbIslem2.TabIndex = 23;
            this.cmbIslem2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(178, 316);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 24;
            this.btnSonuc.Text = "Sonuc";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.button2_Click);
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
            this.groupBox1.Controls.Add(this.grbGicikEleman);
            this.groupBox1.Controls.Add(this.lblBilgi4);
            this.groupBox1.Controls.Add(this.lblBilgi3);
            this.groupBox1.Controls.Add(this.lblBilgi2);
            this.groupBox1.Controls.Add(this.btnSonuc);
            this.groupBox1.Controls.Add(this.txbElemanSayisi);
            this.groupBox1.Controls.Add(this.cmbIslem2);
            this.groupBox1.Controls.Add(this.lblKume);
            this.groupBox1.Controls.Add(this.lblBilgi1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBilgi);
            this.groupBox1.Controls.Add(this.cmbIslem);
            this.groupBox1.Controls.Add(this.btnAltkume);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txbKume);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 349);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grbGicikEleman
            // 
            this.grbGicikEleman.Controls.Add(this.rdoVeya);
            this.grbGicikEleman.Controls.Add(this.rdoVe);
            this.grbGicikEleman.Controls.Add(this.txbBulunmayan);
            this.grbGicikEleman.Controls.Add(this.txbBulunan);
            this.grbGicikEleman.Controls.Add(this.btnGicik);
            this.grbGicikEleman.Controls.Add(this.label3);
            this.grbGicikEleman.Controls.Add(this.label1);
            this.grbGicikEleman.Location = new System.Drawing.Point(9, 67);
            this.grbGicikEleman.Name = "grbGicikEleman";
            this.grbGicikEleman.Size = new System.Drawing.Size(244, 162);
            this.grbGicikEleman.TabIndex = 37;
            this.grbGicikEleman.TabStop = false;
            this.grbGicikEleman.Text = "Gıcık Eleman Yöntemi";
            // 
            // rdoVeya
            // 
            this.rdoVeya.AutoSize = true;
            this.rdoVeya.Location = new System.Drawing.Point(162, 49);
            this.rdoVeya.Name = "rdoVeya";
            this.rdoVeya.Size = new System.Drawing.Size(49, 17);
            this.rdoVeya.TabIndex = 38;
            this.rdoVeya.TabStop = true;
            this.rdoVeya.Text = "Veya";
            this.rdoVeya.UseVisualStyleBackColor = true;
            // 
            // rdoVe
            // 
            this.rdoVe.AutoSize = true;
            this.rdoVe.Checked = true;
            this.rdoVe.Location = new System.Drawing.Point(118, 50);
            this.rdoVe.Name = "rdoVe";
            this.rdoVe.Size = new System.Drawing.Size(38, 17);
            this.rdoVe.TabIndex = 37;
            this.rdoVe.TabStop = true;
            this.rdoVe.Text = "Ve";
            this.rdoVe.UseVisualStyleBackColor = true;
            // 
            // txbBulunmayan
            // 
            this.txbBulunmayan.Location = new System.Drawing.Point(118, 73);
            this.txbBulunmayan.Name = "txbBulunmayan";
            this.txbBulunmayan.Size = new System.Drawing.Size(100, 20);
            this.txbBulunmayan.TabIndex = 34;
            // 
            // txbBulunan
            // 
            this.txbBulunan.Location = new System.Drawing.Point(118, 23);
            this.txbBulunan.Name = "txbBulunan";
            this.txbBulunan.Size = new System.Drawing.Size(100, 20);
            this.txbBulunan.TabIndex = 34;
            // 
            // btnGicik
            // 
            this.btnGicik.Location = new System.Drawing.Point(143, 99);
            this.btnGicik.Name = "btnGicik";
            this.btnGicik.Size = new System.Drawing.Size(75, 23);
            this.btnGicik.TabIndex = 36;
            this.btnGicik.Text = "Sonuç";
            this.btnGicik.UseVisualStyleBackColor = true;
            this.btnGicik.Click += new System.EventHandler(this.btnGicik_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Bulunmayan Eleman :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bulunan Eleman :";
            // 
            // lblBilgi4
            // 
            this.lblBilgi4.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.lblBilgi4, "a");
            this.lblBilgi4.Location = new System.Drawing.Point(9, 265);
            this.lblBilgi4.MaximumSize = new System.Drawing.Size(440, 50);
            this.lblBilgi4.Name = "lblBilgi4";
            this.lblBilgi4.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.lblBilgi4, true);
            this.lblBilgi4.Size = new System.Drawing.Size(194, 21);
            this.lblBilgi4.TabIndex = 33;
            this.lblBilgi4.Text = "Lütfen yapmak istediğiniz işlemi seçini.";
            // 
            // lblBilgi3
            // 
            this.lblBilgi3.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.lblBilgi3, "a");
            this.lblBilgi3.Location = new System.Drawing.Point(81, 223);
            this.lblBilgi3.MaximumSize = new System.Drawing.Size(240, 50);
            this.lblBilgi3.Name = "lblBilgi3";
            this.lblBilgi3.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.lblBilgi3, true);
            this.lblBilgi3.Size = new System.Drawing.Size(50, 21);
            this.lblBilgi3.TabIndex = 32;
            this.lblBilgi3.Text = "Örn: 29";
            // 
            // lblBilgi2
            // 
            this.lblBilgi2.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.lblBilgi2, "a");
            this.lblBilgi2.Location = new System.Drawing.Point(6, 200);
            this.lblBilgi2.MaximumSize = new System.Drawing.Size(440, 50);
            this.lblBilgi2.Name = "lblBilgi2";
            this.lblBilgi2.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.lblBilgi2, true);
            this.lblBilgi2.Size = new System.Drawing.Size(190, 21);
            this.lblBilgi2.TabIndex = 31;
            this.lblBilgi2.Text = "Lütfen verilen alt küme sayısını giriniz.";
            // 
            // lblKume
            // 
            this.lblKume.AutoSize = true;
            this.lblKume.Location = new System.Drawing.Point(9, 67);
            this.lblKume.Name = "lblKume";
            this.lblKume.Size = new System.Drawing.Size(0, 13);
            this.lblKume.TabIndex = 30;
            // 
            // lblBilgi1
            // 
            this.lblBilgi1.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.lblBilgi1, "a");
            this.lblBilgi1.Location = new System.Drawing.Point(6, 104);
            this.lblBilgi1.MaximumSize = new System.Drawing.Size(440, 50);
            this.lblBilgi1.Name = "lblBilgi1";
            this.lblBilgi1.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.lblBilgi1, true);
            this.lblBilgi1.Size = new System.Drawing.Size(194, 21);
            this.lblBilgi1.TabIndex = 24;
            this.lblBilgi1.Text = "Lütfen yapmak istediğiniz işlemi seçini.";
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
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.lblBilgi, "a");
            this.lblBilgi.Location = new System.Drawing.Point(6, 16);
            this.lblBilgi.MaximumSize = new System.Drawing.Size(440, 50);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider1.SetShowHelp(this.lblBilgi, true);
            this.lblBilgi.Size = new System.Drawing.Size(283, 21);
            this.lblBilgi.TabIndex = 1;
            this.lblBilgi.Text = "Lütfen Küme Elemanlarını aralarına virgül koyarak yazınız.";
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
            // btnKumeKombinasyon
            // 
            this.btnKumeKombinasyon.Location = new System.Drawing.Point(145, 171);
            this.btnKumeKombinasyon.Name = "btnKumeKombinasyon";
            this.btnKumeKombinasyon.Size = new System.Drawing.Size(75, 23);
            this.btnKumeKombinasyon.TabIndex = 27;
            this.btnKumeKombinasyon.Text = "Göster";
            this.btnKumeKombinasyon.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altKümeİşlemleriToolStripMenuItem,
            this.gıcıkElemToolStripMenuItem,
            this.kartezyenToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // altKümeİşlemleriToolStripMenuItem
            // 
            this.altKümeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümAltKümeleriGösterToolStripMenuItem});
            this.altKümeİşlemleriToolStripMenuItem.Name = "altKümeİşlemleriToolStripMenuItem";
            this.altKümeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.altKümeİşlemleriToolStripMenuItem.Text = "Alt Küme İşlemleri";
            // 
            // tümAltKümeleriGösterToolStripMenuItem
            // 
            this.tümAltKümeleriGösterToolStripMenuItem.Name = "tümAltKümeleriGösterToolStripMenuItem";
            this.tümAltKümeleriGösterToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tümAltKümeleriGösterToolStripMenuItem.Text = "Tüm Alt Kümeleri Göster";
            // 
            // gıcıkElemToolStripMenuItem
            // 
            this.gıcıkElemToolStripMenuItem.Name = "gıcıkElemToolStripMenuItem";
            this.gıcıkElemToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gıcıkElemToolStripMenuItem.Text = "Gıcık Eleman Yöntemi";
            this.gıcıkElemToolStripMenuItem.Click += new System.EventHandler(this.gıcıkElemanToolStripMenuItem_Click);
            // 
            // kartezyenToolStripMenuItem
            // 
            this.kartezyenToolStripMenuItem.Name = "kartezyenToolStripMenuItem";
            this.kartezyenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kartezyenToolStripMenuItem.Text = "Kartezyen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbGicikEleman.ResumeLayout(false);
            this.grbGicikEleman.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbKume;
        private System.Windows.Forms.Button btnAltkume;
        private System.Windows.Forms.TextBox txbElemanSayisi;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.ComboBox cmbIslem2;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKumeKombinasyon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblBilgi1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKume;
        private System.Windows.Forms.Label lblBilgi4;
        private System.Windows.Forms.Label lblBilgi3;
        private System.Windows.Forms.Label lblBilgi2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altKümeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gıcıkElemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümAltKümeleriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartezyenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBulunan;
        private System.Windows.Forms.Button btnGicik;
        private System.Windows.Forms.GroupBox grbGicikEleman;
        private System.Windows.Forms.RadioButton rdoVeya;
        private System.Windows.Forms.RadioButton rdoVe;
        private System.Windows.Forms.TextBox txbBulunmayan;
        private System.Windows.Forms.Label label3;
    }
}

