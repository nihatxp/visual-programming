using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi
{
    public partial class DuzenlemeEkrani : Form
    {
        AnaEkran anaEkran;
        public DuzenlemeEkrani(AnaEkran param)
        {
            InitializeComponent();
            anaEkran = param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.kitapDuzenle(textBox2.Text);
            anaEkran.yazarDuzenle(textBox1.Text);
            this.Close();
        }
        public void kitapdzn(string prm)
        {
            textBox1.Text = prm;
        }
        public void yazardzn(string prm)
        {
            textBox2.Text = prm;
            textBox2.Focus();
            textBox2.Select(textBox2.Text.ToString().Length, 0);
            textBox2.Text = prm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
