namespace VizeFinalNotHesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblvize = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.lblort_dgr = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.lblharf_dgr = new System.Windows.Forms.Label();
            this.lblort = new System.Windows.Forms.Label();
            this.lblharf = new System.Windows.Forms.Label();
            this.lbldurum = new System.Windows.Forms.Label();
            this.lbldurum_dgr = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxBilgi = new System.Windows.Forms.GroupBox();
            this.lblfinal_oran = new System.Windows.Forms.Label();
            this.lblvize_oran = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.lblbilgi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxUyari = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.CheckVize = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.BtnSifirla = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxUyari.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblvize
            // 
            this.lblvize.AutoSize = true;
            this.lblvize.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblvize.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblvize.Location = new System.Drawing.Point(15, 69);
            this.lblvize.Name = "lblvize";
            this.lblvize.Size = new System.Drawing.Size(60, 27);
            this.lblvize.TabIndex = 3;
            this.lblvize.Text = "vize";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblfinal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblfinal.Location = new System.Drawing.Point(15, 115);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(72, 27);
            this.lblfinal.TabIndex = 5;
            this.lblfinal.Text = "final";
            // 
            // lblort_dgr
            // 
            this.lblort_dgr.AutoSize = true;
            this.lblort_dgr.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblort_dgr.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblort_dgr.Location = new System.Drawing.Point(132, 20);
            this.lblort_dgr.Name = "lblort_dgr";
            this.lblort_dgr.Size = new System.Drawing.Size(24, 27);
            this.lblort_dgr.TabIndex = 8;
            this.lblort_dgr.Text = "0";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num1.Location = new System.Drawing.Point(102, 66);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(228, 30);
            this.num1.TabIndex = 1;
            this.num1.ValueChanged += new System.EventHandler(this.Nothesapla);
            this.num1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpNum);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num2.Location = new System.Drawing.Point(102, 112);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(228, 30);
            this.num2.TabIndex = 2;
            this.num2.ValueChanged += new System.EventHandler(this.Nothesapla);
            this.num2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpNum_2);
            // 
            // lblharf_dgr
            // 
            this.lblharf_dgr.AutoSize = true;
            this.lblharf_dgr.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblharf_dgr.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblharf_dgr.Location = new System.Drawing.Point(144, 62);
            this.lblharf_dgr.Name = "lblharf_dgr";
            this.lblharf_dgr.Size = new System.Drawing.Size(24, 27);
            this.lblharf_dgr.TabIndex = 10;
            this.lblharf_dgr.Text = "-";
            // 
            // lblort
            // 
            this.lblort.AutoSize = true;
            this.lblort.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblort.Location = new System.Drawing.Point(6, 20);
            this.lblort.Name = "lblort";
            this.lblort.Size = new System.Drawing.Size(120, 27);
            this.lblort.TabIndex = 7;
            this.lblort.Text = "Ortalama:";
            // 
            // lblharf
            // 
            this.lblharf.AutoSize = true;
            this.lblharf.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblharf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblharf.Location = new System.Drawing.Point(6, 62);
            this.lblharf.Name = "lblharf";
            this.lblharf.Size = new System.Drawing.Size(132, 27);
            this.lblharf.TabIndex = 9;
            this.lblharf.Text = "Harf Notu:";
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lbldurum.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldurum.Location = new System.Drawing.Point(6, 100);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(96, 27);
            this.lbldurum.TabIndex = 11;
            this.lbldurum.Text = "Durum: ";
            // 
            // lbldurum_dgr
            // 
            this.lbldurum_dgr.AutoSize = true;
            this.lbldurum_dgr.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lbldurum_dgr.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldurum_dgr.Location = new System.Drawing.Point(102, 100);
            this.lbldurum_dgr.Name = "lbldurum_dgr";
            this.lbldurum_dgr.Size = new System.Drawing.Size(24, 27);
            this.lbldurum_dgr.TabIndex = 12;
            this.lbldurum_dgr.Text = "-";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblinfo.Location = new System.Drawing.Point(6, 30);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(84, 27);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "Info :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.groupBoxBilgi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(662, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 359);
            this.panel1.TabIndex = 15;
            // 
            // groupBoxBilgi
            // 
            this.groupBoxBilgi.Controls.Add(this.lblfinal_oran);
            this.groupBoxBilgi.Controls.Add(this.lblvize_oran);
            this.groupBoxBilgi.Controls.Add(this.label12);
            this.groupBoxBilgi.Controls.Add(this.TrackBar1);
            this.groupBoxBilgi.Controls.Add(this.lblbilgi);
            this.groupBoxBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxBilgi.Location = new System.Drawing.Point(6, 18);
            this.groupBoxBilgi.Name = "groupBoxBilgi";
            this.groupBoxBilgi.Size = new System.Drawing.Size(191, 329);
            this.groupBoxBilgi.TabIndex = 0;
            this.groupBoxBilgi.TabStop = false;
            this.groupBoxBilgi.Text = "Bilgilendirme";
            // 
            // lblfinal_oran
            // 
            this.lblfinal_oran.AutoSize = true;
            this.lblfinal_oran.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinal_oran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblfinal_oran.Location = new System.Drawing.Point(104, 237);
            this.lblfinal_oran.Name = "lblfinal_oran";
            this.lblfinal_oran.Size = new System.Drawing.Size(72, 27);
            this.lblfinal_oran.TabIndex = 15;
            this.lblfinal_oran.Text = "F --%";
            // 
            // lblvize_oran
            // 
            this.lblvize_oran.AutoSize = true;
            this.lblvize_oran.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblvize_oran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblvize_oran.Location = new System.Drawing.Point(6, 237);
            this.lblvize_oran.Name = "lblvize_oran";
            this.lblvize_oran.Size = new System.Drawing.Size(72, 27);
            this.lblvize_oran.TabIndex = 14;
            this.lblvize_oran.Text = "V --%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Oranları Değiştir";
            // 
            // TrackBar1
            // 
            this.TrackBar1.Location = new System.Drawing.Point(45, 160);
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(104, 56);
            this.TrackBar1.TabIndex = 6;
            this.TrackBar1.Value = 3;
            this.TrackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.TrackBar1.ValueChanged += new System.EventHandler(this.Nothesapla);
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.Location = new System.Drawing.Point(4, 30);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(172, 48);
            this.lblbilgi.TabIndex = 0;
            this.lblbilgi.Text = "Ortalama Hesaplanması,\r\n Vize %40, Final %60 Olarak\r\n Hesaplanır\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.groupBoxUyari);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 359);
            this.panel2.TabIndex = 16;
            // 
            // groupBoxUyari
            // 
            this.groupBoxUyari.Controls.Add(this.lblinfo);
            this.groupBoxUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBoxUyari.Location = new System.Drawing.Point(6, 18);
            this.groupBoxUyari.Name = "groupBoxUyari";
            this.groupBoxUyari.Size = new System.Drawing.Size(191, 329);
            this.groupBoxUyari.TabIndex = 16;
            this.groupBoxUyari.TabStop = false;
            this.groupBoxUyari.Text = "Uyarı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.BtnKaydet);
            this.panel3.Controls.Add(this.CheckVize);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.lblBaslik);
            this.panel3.Controls.Add(this.num1);
            this.panel3.Controls.Add(this.num2);
            this.panel3.Controls.Add(this.lblvize);
            this.panel3.Controls.Add(this.lblfinal);
            this.panel3.Controls.Add(this.BtnSifirla);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 359);
            this.panel3.TabIndex = 17;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKaydet.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnKaydet.Location = new System.Drawing.Point(271, 236);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(182, 35);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckVize
            // 
            this.CheckVize.AutoSize = true;
            this.CheckVize.ForeColor = System.Drawing.Color.LightCoral;
            this.CheckVize.Location = new System.Drawing.Point(371, 66);
            this.CheckVize.Name = "CheckVize";
            this.CheckVize.Size = new System.Drawing.Size(82, 20);
            this.CheckVize.TabIndex = 3;
            this.CheckVize.Text = "Vize Yok";
            this.CheckVize.UseVisualStyleBackColor = true;
            this.CheckVize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.CheckVize.Click += new System.EventHandler(this.Nothesapla);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblort);
            this.groupBox1.Controls.Add(this.lblort_dgr);
            this.groupBox1.Controls.Add(this.lblharf);
            this.groupBox1.Controls.Add(this.lblharf_dgr);
            this.groupBox1.Controls.Add(this.lbldurum);
            this.groupBox1.Controls.Add(this.lbldurum_dgr);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code", 7F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(11, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Durum";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBaslik.Location = new System.Drawing.Point(83, 18);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(300, 27);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Vize Final Not Hesaplama";
            // 
            // BtnSifirla
            // 
            this.BtnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSifirla.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSifirla.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnSifirla.Location = new System.Drawing.Point(271, 287);
            this.BtnSifirla.Name = "BtnSifirla";
            this.BtnSifirla.Size = new System.Drawing.Size(182, 35);
            this.BtnSifirla.TabIndex = 5;
            this.BtnSifirla.Text = "Sıfırla";
            this.BtnSifirla.UseVisualStyleBackColor = true;
            this.BtnSifirla.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 359);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxBilgi.ResumeLayout(false);
            this.groupBoxBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxUyari.ResumeLayout(false);
            this.groupBoxUyari.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblvize;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Label lblort_dgr;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Label lblharf_dgr;
        private System.Windows.Forms.Label lblort;
        private System.Windows.Forms.Label lblharf;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.Label lbldurum_dgr;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button BtnSifirla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxBilgi;
        private System.Windows.Forms.TrackBar TrackBar1;
        private System.Windows.Forms.Label lblbilgi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblfinal_oran;
        private System.Windows.Forms.Label lblvize_oran;
        private System.Windows.Forms.CheckBox CheckVize;
        private System.Windows.Forms.GroupBox groupBoxUyari;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

