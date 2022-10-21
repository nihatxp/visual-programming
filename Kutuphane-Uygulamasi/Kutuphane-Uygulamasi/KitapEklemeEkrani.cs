using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi
{
    public partial class KitapEklemeEkrani : Form
    {
        AnaEkran anaEkran;
        public KitapEklemeEkrani(AnaEkran param)
        {
            InitializeComponent();
            anaEkran = param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                anaEkran.yazarEkle("<Mevcut Degil>");
            }
            else
            {
                anaEkran.yazarEkle(textBox1.Text);
            }
            
            if (textBox2.Text == "")
            {
                anaEkran.kitapEkle("<Mevcut Degil>");
            }
            else
            {
                anaEkran.kitapEkle(textBox2.Text);
            }
            anaEkran.Show();
            this.Close();
        }

        private void KitapEklemeEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
