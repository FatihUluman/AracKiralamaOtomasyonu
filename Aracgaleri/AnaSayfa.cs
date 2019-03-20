using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aracgaleri
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle ac = new Ekle();
            ac.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kirala ac = new Kirala();
            ac.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullaniciEkle ac = new KullaniciEkle();
            ac.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string veri;
            veri = Giris.Kullanıci.Kad;
            label1.Text = "Sisteme Giriş Yapan Kullanıcı"+"  "+veri;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string zaman;
            zaman = DateTime.Now.ToString();
            label2.Text ="Sisteme Giriş Zamanı"+"  "+ zaman;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AraçBilgileri ac = new AraçBilgileri();
            ac.Show();
            this.Hide();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
