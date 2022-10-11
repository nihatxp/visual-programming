using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Microsoft.VisualBasic;
using System.Drawing.Imaging;

namespace VizeFinalNotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly WindowsMediaPlayer wplayer = new WindowsMediaPlayer();//wplayer arkaplan muzigi icin olusturuldu
        readonly WindowsMediaPlayer notfPlayer = new WindowsMediaPlayer();
        readonly string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
        double ortalama, vizeOrani, finalOrani;
        sbyte vize, final;
        bool gecmeDurumu;

        private void ArkaplanMuzigi()
        {
            wplayer.URL = string.Format("{0}Kaynak\\music.mp3", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            wplayer.settings.setMode("loop", true);
            wplayer.controls.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblort_dgr.Text = "";
            //ArkaplanMuzigi();
            lblinfo.Text = "";
            num1.Select();
            vizeOrani = 0.4;
            finalOrani = 0.6;
            lblvize_oran.Text = "V 40%";
            lblfinal_oran.Text = "F 60%";
            TrackBar1.Maximum = 4;
        }
        
        private void Nothesapla(object sender, EventArgs e)
        {
            try
            {
                if (!(num1.Value == 0 && num2.Value == 0))
                {
                    vize = Convert.ToSByte(num1.Value);
                    final = Convert.ToSByte(num2.Value);
                    if (CheckVize.Checked == true)
                    {
                        ortalama = final;
                    }
                    else
                    {
                        ortalama = vize * vizeOrani + final * finalOrani;
                    }
                    if (final < 50)
                    {
                        lblinfo.Text = "Final Notu 50'den az";
                        lblinfo.Font = new Font("Cascadia Code", 8);
                    }
                    else if (ortalama < 50 && CheckVize.Checked == false)
                    {
                        lblinfo.Text = "Ortalama 50'den az";
                        lblinfo.Font = new Font("Cascadia Code", 9);
                    }
                    else
                    {
                        lblinfo.Text = "";
                    }
                    lblort_dgr.Text = ortalama.ToString();
                    lblharf_dgr.Text = HarfNotuKac(ortalama).ToString();
                    if (ortalama >= 50 && final >= 50)
                    {
                        notfPlayer.URL = string.Format("{0}Kaynak\\win.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                        notfPlayer.controls.play();
                        lbldurum_dgr.Text = "Geçti";
                        gecmeDurumu = true;
                        lbldurum_dgr.ForeColor = Color.Green;
                    }
                    else
                    {
                        notfPlayer.URL = string.Format("{0}Kaynak\\alert.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                        notfPlayer.controls.play();
                        lbldurum_dgr.Text = "Kaldı";
                        gecmeDurumu = false;
                        lbldurum_dgr.ForeColor = Color.Red;
                    }
                }
            }
            catch
            {
                //Kullanici Deneyimi Acisindan Hata Vermesine Gerek Yok.
            }
        }

        private void KeyUpNum(object sender, KeyEventArgs e)
        {
            num1.Focus(); //her tusa basilip birakildiginda yenilensin
            num1.Select(num1.Value.ToString().Length, 0); //focus oldugunda cursor sagda kalmasin diye sona tasiyorum
        }

        private void KeyUpNum_2(object sender, KeyEventArgs e)
        {
            num2.Focus();
            num2.Select(num2.Value.ToString().Length, 0);
        }

        private string HarfNotuKac(double ort)
        {
            if (ort > 0 && ort <= 39)
            {
                return "FF";
            }
            else if (ort > 39 && ort <= 49)
            {
                return "FD";
            }
            else if (ort > 49 && ort <= 56)
            {
                return "DD";
            }
            else if (ort > 56 && ort <= 63)
            {
                return "DC";
            }
            else if (ort > 63 && ort <= 70)
            {
                return "CC";
            }
            else if (ort > 71 && ort <= 77)
            {
                return "CB";
            }
            else if (ort > 77 && ort <= 84)
            {
                return "BB";
            }
            else if (ort > 84 && ort <= 91)
            {
                return "BA";
            }
            else if (ort > 91 && ort <= 100)
            {
                return "AA";
            }
            else
            {
                return "Hata";
            }
        }

        string eskiDeger;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckVize.Checked == true)
            {
                eskiDeger = lblfinal_oran.Text;
                num1.Visible = false;
                lblvize.Visible = false;
                label12.Visible = false;
                lblvize_oran.Visible = false;
                lblfinal_oran.Text = "F 100%";
                TrackBar1.Visible = false;
            }
            else
            {
                num1.Visible = true;
                lblvize.Visible = true;
                lblvize_oran.Visible = true;
                lblfinal_oran.Text = eskiDeger;
                label12.Visible = true;
                TrackBar1.Visible = true;
            }
        }

        string belgeYolu, belgeAdi;
        private void button2_Click(object sender, EventArgs e)
        {
            string isim = Interaction.InputBox("İsminiz", "İsim Alanı", "<yok>", 555, 305);
            string soyad = Interaction.InputBox("Soyadınız", "Soyadı Alanı", "<yok>", 555, 305);
            string ogrno = Interaction.InputBox("Öğrenci Numaranız", "OGRNO", "<yok>", 555, 305);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeYolu = folderBrowserDialog1.SelectedPath;
                belgeAdi = "download.txt";
                StreamWriter swTuret = File.CreateText(belgeYolu + "\\" + belgeAdi);
                swTuret.WriteLine("***********************************************");
                swTuret.WriteLine("Isim : " + isim);
                swTuret.WriteLine("Soyad : " + soyad);
                swTuret.WriteLine("OgrNo : " + ogrno);
                swTuret.WriteLine("***********************************************");
                if (CheckVize.Checked == false)
                {
                    swTuret.WriteLine("Vize Notu : " + vize);
                    swTuret.WriteLine("Vize Oranı : " + vizeOrani * 100 + "%");
                }
                else
                {
                    swTuret.WriteLine("Vize Mevcut Değil");
                }
                swTuret.WriteLine("Final Notu : " + final);
                swTuret.WriteLine("Final Oranı : " + finalOrani * 100 + "%");
                swTuret.WriteLine("Ortalama : " + ortalama);
                swTuret.WriteLine("Harf Notu : " + HarfNotuKac((int)ortalama).ToString());
                if (gecmeDurumu)
                {
                    swTuret.WriteLine("Durum : Geçti");
                }
                else
                {
                    swTuret.WriteLine("Durum : Kaldı");
                }
                swTuret.Close();
                MessageBox.Show("Belge Başarıyla oluşturuldu", "Bilgi", MessageBoxButtons.OK);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            num1.Value = 0;
            num2.Value = 0;
            num1.ResetText();
            num2.ResetText();
            lblort_dgr.Text = "";
            lblharf_dgr.Text = "-";
            lbldurum_dgr.Text = "-";
            lbldurum_dgr.ForeColor = Color.FromArgb(153, 180, 209);
            lblinfo.Text = "";
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            switch (TrackBar1.Value)
            {
                case 0:
                    vizeOrani = 0.1;
                    finalOrani = 0.9;
                    lblbilgi.Text = "Ortalama Hesaplanması,\nVize % 10, Final % 90 Olarak\nHesaplanır";
                    lblvize_oran.Text = "V 10%";
                    lblfinal_oran.Text = "F 90%";
                    break;
                case 1:
                    vizeOrani = 0.2;
                    finalOrani = 0.8;
                    lblbilgi.Text = "Ortalama Hesaplanması,\nVize % 20, Final % 80 Olarak\nHesaplanır";
                    lblvize_oran.Text = "V 20%";
                    lblfinal_oran.Text = "F 80%";
                    break;
                case 2:
                    vizeOrani = 0.3;
                    finalOrani = 0.7;
                    lblbilgi.Text = "Ortalama Hesaplanması,\nVize % 30, Final % 70 Olarak\nHesaplanır";
                    lblvize_oran.Text = "V 30%";
                    lblfinal_oran.Text = "F 70%";
                    break;
                case 3:
                    vizeOrani = 0.4;
                    finalOrani = 0.6;
                    lblbilgi.Text = "Ortalama Hesaplanması,\nVize % 40, Final % 60 Olarak\nHesaplanır";
                    lblvize_oran.Text = "V 40%";
                    lblfinal_oran.Text = "F 60%";
                    break;
                case 4:
                    vizeOrani = 0.5;
                    finalOrani = 0.5;
                    lblbilgi.Text = "Ortalama Hesaplanması,\nVize % 50, Final % 50 Olarak\nHesaplanır";
                    lblvize_oran.Text = "V 50%";
                    lblfinal_oran.Text = "F 50%";
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}