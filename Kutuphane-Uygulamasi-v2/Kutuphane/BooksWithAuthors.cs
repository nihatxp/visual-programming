using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Kutuphane
{
    public partial class BooksWithAuthors : Form
    {
        readonly MainScreen mainScreen;
        public BooksWithAuthors(MainScreen prm)
        {
            mainScreen = prm;
            InitializeComponent();
            if (mainScreen.yazarIsimleri.Count > 0)
            {
                comboBAuthors.Text = (string)mainScreen.yazarIsimleri[0];
            }

            for (int i = 0; i < mainScreen.yazarIsimleri.Count; i++)
            {
                comboBAuthors.Items.Add(mainScreen.yazarIsimleri[i]);
            }
        }

        private void Authors_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBBooksWithAuthors.Items.Clear();
            if (comboBAuthors.SelectedIndex >= 0)
            {
                string selectedItem = (string)comboBAuthors.SelectedItem;
                foreach (var item in mainScreen.kitap)
                {
                    if (item.Author == selectedItem)
                    {
                        listBBooksWithAuthors.Items.Add(item.Name);
                    }
                }
            }
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            comboBAuthors.Text = "Lütfen Seçin";
            if(mainScreen.isdark == true)
            {
                this.BackColor = Color.FromArgb(255, 64, 64, 64);
                panel1.BackColor = Color.FromArgb(255, 30, 30, 30);
                label1.ForeColor = Color.FromArgb(255, 240, 240, 240);
                label2.ForeColor = Color.FromArgb(255, 240, 240, 240);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 240, 240, 240);
                panel1.BackColor = Color.FromArgb(255, 200, 200, 200);
                label1.ForeColor = Color.FromArgb(255, 30, 30, 30);
                label2.ForeColor = Color.FromArgb(255, 30, 30, 30);
            }
        }

        
    }

}
