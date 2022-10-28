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

namespace Kutuphane
{
    public partial class MainScreen : Form
    {
        public ArrayList yazarIsimleri = new ArrayList();
        public List<Book> kitap = new List<Book>();

        public MainScreen()
        {
            InitializeComponent();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnDeselect.Enabled = false;
            menuStrip1.ForeColor = Color.FromArgb(255, 30, 30, 30);
            menuStrip1.Font = new Font("Arial", 10, FontStyle.Regular);
            menuStrip1.BackColor = Color.FromArgb(255, 240, 240, 240);
        }

        public void addBook(Book book)
        {
            listBEntitys.Items.Add(book);
        }

        public int selectedIndex;

        public void updateBook(Book book)
        {
            listBEntitys.Items[listBEntitys.SelectedIndex] = book;
        }

        public void yazarEkle(string prm)
        {
            yazarIsimleri.Add(prm);
        }

        public void yazarSil(int prm)
        {
            try
            {
                yazarIsimleri.RemoveAt(prm);
            }
            catch
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBEntitys.SelectedIndex == -1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnDeselect.Enabled = false;
            }
            else
            {
                selectedIndex = listBEntitys.SelectedIndex;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnDeselect.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İlgili kitabı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                kitap.RemoveAt(listBEntitys.SelectedIndex);
                listBEntitys.Items.RemoveAt(listBEntitys.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBookScreen abs = new AddBookScreen(this, (Book)listBEntitys.Items[listBEntitys.SelectedIndex]);
            this.Hide();
            abs.Show();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookScreen abs = new AddBookScreen(this);
            this.Hide();
            abs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBEntitys.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tümünü Silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                listBEntitys.Items.Clear();
                kitap.Clear();
            }
        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor(this);
            addAuthor.Show();
            this.Hide();
        }
        
        private void filtreleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BooksWithAuthors authors = new BooksWithAuthors(this);
            authors.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public bool isdark;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                isdark = true;
                this.BackColor = Color.FromArgb(255, 64, 64, 64);
                panel1.BackColor = Color.FromArgb(255, 30, 30, 30);
                checkBox1.ForeColor = Color.Gray;
                menuStrip1.ForeColor = Color.FromArgb(255, 140, 140, 140);
                menuStrip1.BackColor = Color.FromArgb(255, 64, 64, 64);
            }
            else
            {
                isdark = false;
                this.BackColor = Color.FromArgb(255, 240, 240, 240);
                panel1.BackColor = Color.FromArgb(255, 200, 200, 200);
                checkBox1.ForeColor = Color.Black;
                menuStrip1.ForeColor = Color.FromArgb(255, 30, 30, 30);
                menuStrip1.BackColor = Color.FromArgb(255, 240, 240, 240);
            }
        }
    }
}
