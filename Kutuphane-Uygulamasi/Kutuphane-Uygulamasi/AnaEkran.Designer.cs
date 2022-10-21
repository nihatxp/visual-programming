namespace KutuphaneUygulamasi
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borçlularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taleplerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTalepleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dergiTalepleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBKitapAdi = new System.Windows.Forms.ListBox();
            this.btnItemDuzenle = new System.Windows.Forms.Button();
            this.btnItemSil = new System.Windows.Forms.Button();
            this.listBYazarAdi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSecimKaldir = new System.Windows.Forms.Button();
            this.btnTumunuSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.üyelerToolStripMenuItem,
            this.taleplerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem});
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // üyelerToolStripMenuItem
            // 
            this.üyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeleToolStripMenuItem,
            this.ekleToolStripMenuItem1,
            this.borçlularToolStripMenuItem});
            this.üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            this.üyelerToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.üyelerToolStripMenuItem.Text = "Üyeler";
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.listeleToolStripMenuItem.Text = "Listele";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            // 
            // borçlularToolStripMenuItem
            // 
            this.borçlularToolStripMenuItem.Name = "borçlularToolStripMenuItem";
            this.borçlularToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.borçlularToolStripMenuItem.Text = "Borçlular";
            // 
            // taleplerToolStripMenuItem
            // 
            this.taleplerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapTalepleriToolStripMenuItem,
            this.dergiTalepleriToolStripMenuItem});
            this.taleplerToolStripMenuItem.Name = "taleplerToolStripMenuItem";
            this.taleplerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.taleplerToolStripMenuItem.Text = "Talepler";
            // 
            // kitapTalepleriToolStripMenuItem
            // 
            this.kitapTalepleriToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kitapTalepleriToolStripMenuItem.Name = "kitapTalepleriToolStripMenuItem";
            this.kitapTalepleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kitapTalepleriToolStripMenuItem.Text = "Kitap Talepleri";
            // 
            // dergiTalepleriToolStripMenuItem
            // 
            this.dergiTalepleriToolStripMenuItem.Name = "dergiTalepleriToolStripMenuItem";
            this.dergiTalepleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dergiTalepleriToolStripMenuItem.Text = "Dergi Talepleri";
            // 
            // listBKitapAdi
            // 
            this.listBKitapAdi.BackColor = System.Drawing.Color.Honeydew;
            this.listBKitapAdi.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.listBKitapAdi.FormattingEnabled = true;
            this.listBKitapAdi.ItemHeight = 26;
            this.listBKitapAdi.Items.AddRange(new object[] {
            "Tutunamayanlar",
            "Şeker Portakalı",
            "Görünmez Kentler",
            "Aşk",
            "Yeraltından Notlar",
            "Erken Kaybedenler",
            "Büyülü Fener",
            "Ölümsüzlük ",
            "Parfümün Dans",
            "Başarının Anatomisi",
            "Yeni Hayat",
            "Git Kendini Çok Sevdirmeden",
            "Bu Köşedeki Adam",
            "Sonsuzluk İçin Yedi Gün",
            "Hep Yarın",
            "Masumiyet Müzesi",
            "Dehanın Gölgesinde"});
            this.listBKitapAdi.Location = new System.Drawing.Point(315, 38);
            this.listBKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.listBKitapAdi.Name = "listBKitapAdi";
            this.listBKitapAdi.Size = new System.Drawing.Size(339, 342);
            this.listBKitapAdi.TabIndex = 1;
            this.listBKitapAdi.SelectedIndexChanged += new System.EventHandler(this.listBYazarAdi_SelectedIndexChanged);
            // 
            // btnItemDuzenle
            // 
            this.btnItemDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnItemDuzenle.Enabled = false;
            this.btnItemDuzenle.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItemDuzenle.ForeColor = System.Drawing.Color.Black;
            this.btnItemDuzenle.Location = new System.Drawing.Point(29, 38);
            this.btnItemDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemDuzenle.Name = "btnItemDuzenle";
            this.btnItemDuzenle.Size = new System.Drawing.Size(117, 35);
            this.btnItemDuzenle.TabIndex = 1;
            this.btnItemDuzenle.Text = "Düzenle";
            this.btnItemDuzenle.UseVisualStyleBackColor = false;
            this.btnItemDuzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnItemSil
            // 
            this.btnItemSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnItemSil.Enabled = false;
            this.btnItemSil.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnItemSil.ForeColor = System.Drawing.Color.Black;
            this.btnItemSil.Location = new System.Drawing.Point(29, 81);
            this.btnItemSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemSil.Name = "btnItemSil";
            this.btnItemSil.Size = new System.Drawing.Size(117, 35);
            this.btnItemSil.TabIndex = 2;
            this.btnItemSil.Text = "Sil";
            this.btnItemSil.UseVisualStyleBackColor = false;
            this.btnItemSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBYazarAdi
            // 
            this.listBYazarAdi.BackColor = System.Drawing.Color.Honeydew;
            this.listBYazarAdi.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.listBYazarAdi.FormattingEnabled = true;
            this.listBYazarAdi.ItemHeight = 26;
            this.listBYazarAdi.Items.AddRange(new object[] {
            "Oğuz Atay",
            "Vasconcelos",
            "Italo Calvino",
            "Elif Şafak",
            "Dostoyevski",
            "Emrah Serbes",
            "Ingmar Bergman",
            "Milan Kundera",
            "Tom Robbins",
            "Jose Mourinho",
            "Orhan Pamuk",
            "Tuna Kiremitçi",
            "Hrant Dink",
            "Marc Levy",
            "Cahit Uçuk",
            "Orhan Pamuk",
            "Maria Publig"});
            this.listBYazarAdi.Location = new System.Drawing.Point(46, 38);
            this.listBYazarAdi.Margin = new System.Windows.Forms.Padding(4);
            this.listBYazarAdi.Name = "listBYazarAdi";
            this.listBYazarAdi.Size = new System.Drawing.Size(261, 342);
            this.listBYazarAdi.TabIndex = 4;
            this.listBYazarAdi.SelectedIndexChanged += new System.EventHandler(this.listBKitapAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yazar Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(438, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBox1.Controls.Add(this.btnSecimKaldir);
            this.groupBox1.Controls.Add(this.btnTumunuSil);
            this.groupBox1.Controls.Add(this.btnItemSil);
            this.groupBox1.Controls.Add(this.btnItemDuzenle);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(692, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 392);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnSecimKaldir
            // 
            this.btnSecimKaldir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSecimKaldir.Enabled = false;
            this.btnSecimKaldir.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecimKaldir.ForeColor = System.Drawing.Color.Black;
            this.btnSecimKaldir.Location = new System.Drawing.Point(29, 124);
            this.btnSecimKaldir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecimKaldir.Name = "btnSecimKaldir";
            this.btnSecimKaldir.Size = new System.Drawing.Size(117, 35);
            this.btnSecimKaldir.TabIndex = 3;
            this.btnSecimKaldir.Text = "Seçimi Kaldır";
            this.btnSecimKaldir.UseVisualStyleBackColor = false;
            this.btnSecimKaldir.Click += new System.EventHandler(this.btnSecimKaldir_Click);
            // 
            // btnTumunuSil
            // 
            this.btnTumunuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTumunuSil.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumunuSil.ForeColor = System.Drawing.Color.Black;
            this.btnTumunuSil.Location = new System.Drawing.Point(29, 345);
            this.btnTumunuSil.Name = "btnTumunuSil";
            this.btnTumunuSil.Size = new System.Drawing.Size(117, 35);
            this.btnTumunuSil.TabIndex = 4;
            this.btnTumunuSil.TabStop = false;
            this.btnTumunuSil.Text = "Tümünü Sil";
            this.btnTumunuSil.UseVisualStyleBackColor = false;
            this.btnTumunuSil.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.listBYazarAdi);
            this.panel1.Controls.Add(this.listBKitapAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 392);
            this.panel1.TabIndex = 8;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(893, 484);
            this.MinimumSize = new System.Drawing.Size(893, 484);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Uygulaması - Ana Sayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borçlularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taleplerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTalepleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dergiTalepleriToolStripMenuItem;
        private System.Windows.Forms.ListBox listBKitapAdi;
        private System.Windows.Forms.Button btnItemDuzenle;
        private System.Windows.Forms.Button btnItemSil;
        private System.Windows.Forms.ListBox listBYazarAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTumunuSil;
        private System.Windows.Forms.Button btnSecimKaldir;
    }
}