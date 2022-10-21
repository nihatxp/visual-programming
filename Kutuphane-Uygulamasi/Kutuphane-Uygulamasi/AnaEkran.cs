using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KutuphaneUygulamasi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private SyncListBoxes _SyncListBoxes = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.Gray;
            menuStrip1.Font = new Font("Arial", 10, FontStyle.Regular);
            this.menuStrip1.BackColor = Color.FromArgb(255, 64, 64, 64);
            this._SyncListBoxes = new SyncListBoxes(this.listBYazarAdi, this.listBKitapAdi); //2 listbox'i senkronize ettim
        }

        /*-------EKLE DÜZENLE---------*/
        public void kitapEkle(string kitapAdi)
        {
            listBKitapAdi.Items.Add(kitapAdi);
        }
        public void yazarEkle(string yazarAdi)
        {
            listBYazarAdi.Items.Add(yazarAdi);
        }
        public void kitapDuzenle(string duzenlenmisKitapAdi)
        {
            listBKitapAdi.Items[listBKitapAdi.SelectedIndex] = duzenlenmisKitapAdi;
        }
        public void yazarDuzenle(string duzenlenmisYazarAdi)
        {
            listBYazarAdi.Items[listBYazarAdi.SelectedIndex] = duzenlenmisYazarAdi;
        }

        // Ekle
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
            //this.Hide();
        }

        //DÜZENLE
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBKitapAdi.SelectedIndex < 0 && listBYazarAdi.SelectedIndex < 0) return;
            DuzenlemeEkrani duzenlemeEkrani = new DuzenlemeEkrani(this);
            duzenlemeEkrani.Show();
            string yazarAdi = listBKitapAdi.Items[listBKitapAdi.SelectedIndex].ToString();
            string kitapAdi = listBYazarAdi.Items[listBKitapAdi.SelectedIndex].ToString();

            duzenlemeEkrani.yazardzn(yazarAdi);
            duzenlemeEkrani.kitapdzn(kitapAdi);
        }

        //Listbox
        private void listBKitapAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBKitapAdi.SelectedIndex = listBYazarAdi.SelectedIndex;
            btnItemDuzenle.Focus();
            if (listBKitapAdi.SelectedIndex >= 0 || listBYazarAdi.SelectedIndex >= 0)
            {
                btnItemDuzenle.Enabled = true;
                btnItemSil.Enabled = true;
                btnSecimKaldir.Enabled = true;
            }
            else
            {
                btnItemDuzenle.Enabled = false;
                btnItemSil.Enabled = false;
                btnSecimKaldir.Enabled = false;
            }
        }

        private void listBYazarAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBYazarAdi.SelectedIndex = listBKitapAdi.SelectedIndex;
        }

        //Tümünü Sil
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tümünü Silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                listBYazarAdi.Items.Clear();
                listBKitapAdi.Items.Clear();
            }
        }

        //Secim Kaldir
        private void btnSecimKaldir_Click(object sender, EventArgs e)
        {
            listBYazarAdi.SelectedIndex = -1;
        }

        //Sil
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBKitapAdi.SelectedIndex >= 0 || listBYazarAdi.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int index = listBYazarAdi.SelectedIndex;
                    listBYazarAdi.Items.RemoveAt(index);
                    listBKitapAdi.Items.RemoveAt(index);
                }
            }
        }
    }
}