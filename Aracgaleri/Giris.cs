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
    public partial class Giris : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-V5FHF02\\SQLEXPRESS;Initial Catalog=Araba;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataReader oku;
        
        public Giris()
        {
            InitializeComponent();
        }
        public class Kullanıci
        { 
            public static string Kad;
          
            public static string GirisTarih;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Kullanıci.Kad = textBox1.Text.ToString();
            string Sifre = textBox2.Text.ToString();
                if (Kullanıci.Kad != "" && Sifre != "")
                {
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "SELECT*FROM KullaniciAdmin WHERE Kad='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'";
                    oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        AnaSayfa ac = new AnaSayfa();
                        ac.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı ve Şifre yanlış girildi!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı ve Şifre boş bırakılamaz");

                }
                textBox1.Text = "";
                textBox2.Text = "";

                baglan.Close();
            
         
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
