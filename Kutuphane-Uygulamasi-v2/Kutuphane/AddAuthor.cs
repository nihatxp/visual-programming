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
    public partial class AddAuthor : Form
    {
        readonly MainScreen mainScreen;
        public AddAuthor(MainScreen ms)
        {
            mainScreen = ms;
            InitializeComponent();
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {

            if (mainScreen.isdark == true)
            {
                this.BackColor = Color.FromArgb(255, 64, 64, 64);
                groupBox1.BackColor = Color.FromArgb(255, 30, 30, 30);
                groupBox1.ForeColor = Color.FromArgb(255, 240, 240, 240);
                label1.ForeColor = Color.FromArgb(255, 240, 240, 240);
                label2.ForeColor = Color.FromArgb(255, 240, 240, 240);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 240, 240, 240);
                groupBox1.BackColor = Color.FromArgb(255, 200, 200, 200);
                groupBox1.ForeColor = Color.FromArgb(255, 30, 30, 30);
                label1.ForeColor = Color.FromArgb(255, 30, 30, 30);
                label2.ForeColor = Color.FromArgb(255, 30, 30, 30);
            }


            for (int i = 0; i < mainScreen.yazarIsimleri.Count; i++)
            {
                comboBDeleteAuthor.Items.Add(mainScreen.yazarIsimleri[i]);
            }

            if (comboBDeleteAuthor.Items.Count > 0)
            {
                //comboBox1.Text = (string)comboBox1.Items[comboBox1.Items.Count - 1];

            }

            if (comboBDeleteAuthor.Items.Count < 1)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainScreen.yazarEkle(textBAddAuthor.Text);
            //MessageBox.Show("Yazar Eklendi", "Eklendi!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBDeleteAuthor.Items.Clear();
            for (int i = 0; i < mainScreen.yazarIsimleri.Count; i++)
            {
                comboBDeleteAuthor.Items.Add(mainScreen.yazarIsimleri[i]);
            }
            if (comboBDeleteAuthor.Items.Count > 0)
            {
                comboBDeleteAuthor.Text = (string)comboBDeleteAuthor.Items[comboBDeleteAuthor.Items.Count - 1];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBAddAuthor.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainScreen.yazarSil(comboBDeleteAuthor.SelectedIndex);
            //MessageBox.Show("Yazar Silindi", "Eklendi!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBDeleteAuthor.Items.Clear();

            for (int i = 0; i < mainScreen.yazarIsimleri.Count; i++)
            {
                comboBDeleteAuthor.Items.Add(mainScreen.yazarIsimleri[i]);
            }
            if (comboBDeleteAuthor.Items.Count > 0)
            {
                comboBDeleteAuthor.Text = (string)comboBDeleteAuthor.Items[comboBDeleteAuthor.Items.Count - 1];
            }
        }

        private void AddAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBDeleteAuthor.Items.Count < 1)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }
    }
}
