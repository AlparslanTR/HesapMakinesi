using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }
        int sayı1, sayı2 = 0;
        double islem = 0;
        
        public void sifirla()
        {
            TxtYazdır.Text = "";
        }

        private void BtnBir_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "1";
        }

        private void Btniki_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "2";
        }

        private void BtnUc_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "3";
        }

        private void BtnDort_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "4";
        }

        private void BtnBes_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "5";
        }

        private void BtnAltı_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "6";
        }

        private void BtnYedi_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "7";
        }

        private void BtnSekiz_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "8";
        }

        private void BtnDokuz_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtYazdır.Text = "0";
        }

        private void Btnartı_Click(object sender, EventArgs e)
        {
            islem = 1;
            sayı1 = (int)double.Parse(TxtYazdır.Text);
            sifirla();
        }

        private void BtnEksi_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayı1 = (int)double.Parse(TxtYazdır.Text);
            sifirla();
        }

        private void BtnCarpı_Click(object sender, EventArgs e)
        {
            islem = 3;
            sayı1 = (int)double.Parse(TxtYazdır.Text);
            sifirla();
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            islem = 4;
            sayı1 = (int)double.Parse(TxtYazdır.Text);
            sifirla();
        }

        private void BtnEsitle_Click(object sender, EventArgs e)
        {
            sayı2 = (int)double.Parse(TxtYazdır.Text);
            TxtYazdır.Text = hesapla().ToString("#,#.0");
        }

        public double hesapla()
        {
            double sonuc = 0;

            if (islem == 1)
                sonuc = sayı1 + sayı2;
            else if (islem == 2)
                sonuc = sayı1 - sayı2;
            else if (islem == 3)
                sonuc = sayı1 * sayı2;
            else if (islem == 4)
                sonuc = sayı1 / sayı2;
            else
                sonuc = 0;

            return sonuc;

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = "";
        }

        private void BtnSıfır_Click(object sender, EventArgs e)
        {
            TxtYazdır.Text = TxtYazdır.Text + "0";
        }
    }
}
