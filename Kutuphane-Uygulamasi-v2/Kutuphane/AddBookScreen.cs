using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class AddBookScreen : Form
    {
        readonly MainScreen mainScreen;
        readonly bool isEditMode;

        public AddBookScreen(MainScreen ms)
        {
            InitializeComponent();
            mainScreen = ms;
            isEditMode = false;
            btnAdd.Text = "Ekle";

            for (int i = 0; i < mainScreen.yazarIsimleri.Count; i++)
            {
                comboBAuthorName.Items.Add(mainScreen.yazarIsimleri[i]);
            }

            if (comboBAuthorName.Items.Count > 0)
            {
                comboBAuthorName.Text = (string)comboBAuthorName.Items[comboBAuthorName.Items.Count - 1];
            }

        }

        public AddBookScreen(MainScreen ms, Book book)
        {
            InitializeComponent();
            mainScreen = ms;
            isEditMode = true;
            btnAdd.Text = "Düzenle";

            textBISSN.Text = book.ISSN;
            textBNookName.Text = book.Name;
            comboBAuthorName.Text = book.Author;
            for (int i = 0; i < mainScreen.yazarIsimleri.Count; i++)
            {
                comboBAuthorName.Items.Add(mainScreen.yazarIsimleri[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBNookName.Text == "" || comboBAuthorName.Text == "")
            {
                if (MessageBox.Show("Devam Etmek İstediğinize Emin Misiniz?", "Kitap Adı Veya Yazar Adı Girilmedi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }
            Book book = new Book
            {
                ISSN = textBISSN.Text,
                Name = textBNookName.Text,
                Author = comboBAuthorName.Text
            };


            bool yazarDahaOnceEklendiMi = false;
            for (int i = 0; i < mainScreen.yazarIsimleri.Count; i++)
            {
                if ((string)mainScreen.yazarIsimleri[i] == comboBAuthorName.Text)
                {
                    yazarDahaOnceEklendiMi = true;
                }
            }

            if (!yazarDahaOnceEklendiMi && comboBAuthorName.Text != "")
            {
                mainScreen.yazarIsimleri.Add(comboBAuthorName.Text);
            }

            if (isEditMode == false)
            {
                mainScreen.addBook(book);
                addCombo(textBISSN.Text, textBNookName.Text, comboBAuthorName.Text);
            }
            else
            {
                mainScreen.updateBook(book);
                mainScreen.kitap[mainScreen.selectedIndex] = book;

                //mainScreen.kitap.Add(new Book { ISSN = textBox1.Text, Name = textBox2.Text, Author = comboBox1.Text });

            }
            mainScreen.Show();
            this.Close();


        }

        private void AddBookScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void AddBookScreen_Load(object sender, EventArgs e)
        {
            textBISSN.Select();
            if (mainScreen.isdark == true)
            {
                this.BackColor = Color.FromArgb(255, 64, 64, 64);
                groupBox1.BackColor = Color.FromArgb(255, 30, 30, 30);
                groupBox1.ForeColor = Color.FromArgb(255, 240, 240, 240);
                label1.ForeColor = Color.FromArgb(255, 240, 240, 240);
                label2.ForeColor = Color.FromArgb(255, 240, 240, 240);
                label3.ForeColor = Color.FromArgb(255, 240, 240, 240);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 240, 240, 240);
                groupBox1.BackColor = Color.FromArgb(255, 200, 200, 200);
                groupBox1.ForeColor = Color.FromArgb(255, 30, 30, 30);
                label1.ForeColor = Color.FromArgb(255, 30, 30, 30);
                label2.ForeColor = Color.FromArgb(255, 30, 30, 30);
                label3.ForeColor = Color.FromArgb(255, 30, 30, 30);
            }
        }

        public void addCombo(string issn, string name, string author)
        {
            mainScreen.kitap.Add(new Book { ISSN = issn, Name = name, Author = author });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
