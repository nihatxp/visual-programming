namespace Kutuphane
{
    partial class BooksWithAuthors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksWithAuthors));
            this.comboBAuthors = new System.Windows.Forms.ComboBox();
            this.listBBooksWithAuthors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBAuthors
            // 
            this.comboBAuthors.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.comboBAuthors.FormattingEnabled = true;
            this.comboBAuthors.Location = new System.Drawing.Point(13, 73);
            this.comboBAuthors.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBAuthors.Name = "comboBAuthors";
            this.comboBAuthors.Size = new System.Drawing.Size(232, 30);
            this.comboBAuthors.TabIndex = 0;
            this.comboBAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBBooksWithAuthors
            // 
            this.listBBooksWithAuthors.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.listBBooksWithAuthors.FormattingEnabled = true;
            this.listBBooksWithAuthors.ItemHeight = 26;
            this.listBBooksWithAuthors.Location = new System.Drawing.Point(249, 32);
            this.listBBooksWithAuthors.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBBooksWithAuthors.Name = "listBBooksWithAuthors";
            this.listBBooksWithAuthors.Size = new System.Drawing.Size(296, 342);
            this.listBBooksWithAuthors.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yazarlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(296, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seçili Yazarın Kitapları";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.comboBAuthors);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBBooksWithAuthors);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 377);
            this.panel1.TabIndex = 4;
            // 
            // BooksWithAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(577, 401);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(595, 448);
            this.MinimumSize = new System.Drawing.Size(595, 448);
            this.Name = "BooksWithAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane - Filtrele";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authors_FormClosed);
            this.Load += new System.EventHandler(this.Authors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBAuthors;
        private System.Windows.Forms.ListBox listBBooksWithAuthors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}