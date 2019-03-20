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
    public partial class Kirala : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-V5FHF02\\SQLEXPRESS;Initial Catalog=Araba;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        public Kirala()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa ac = new AnaSayfa();
            ac.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kirala_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'arabaKiralananlarDataSet1.Kiralananlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kiralananlarTableAdapter.Fill(this.arabaKiralananlarDataSet1.Kiralananlar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            string TcKimlik, Telefon, Adi, Soyadi, Adres, AlısTarihi, TeslimTarihi, Fiyat, AracPlakasi;
            TcKimlik = textBox1.Text;
            Adi = textBox2.Text;
            Soyadi = textBox3.Text;
            Telefon = textBox4.Text.ToString();
            Adres = textBox5.Text;
            AlısTarihi = dateTimePicker1.Text;
            TeslimTarihi = dateTimePicker2.Text;
            Fiyat = textBox6.Text;
            AracPlakasi = textBox7.Text;
            
            

            if (TcKimlik != "" && Adi != "" && Soyadi != "" && Adres != "" && Telefon != "" && Fiyat != ""&&AracPlakasi!="")
            {
              
                baglan.Open();
                komut.CommandText = "INSERT INTO Kiralananlar(TcKimlik,Adi, Soyadi,Telefon,Adres, AlisTarihi, TeslimTarihi, Fiyat,AracPlaka) VALUES(@TcKimlik,@Adi, @Soyadi,@Telefon,@Adres, @AlisTarihi, @TeslimTarihi, @Fiyat,@AracPlakasi)";
                komut.Connection = baglan;
                komut.Parameters.AddWithValue("@TcKimlik", textBox1.Text);
                komut.Parameters.AddWithValue("@Adi", textBox2.Text);
                komut.Parameters.AddWithValue("@Soyadi", textBox3.Text);
                komut.Parameters.AddWithValue("@Telefon",long.Parse(textBox4.Text));
                komut.Parameters.AddWithValue("@Adres",textBox5.Text);
                komut.Parameters.AddWithValue("@AlisTarihi",dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@TeslimTarihi",dateTimePicker2.Text);
                komut.Parameters.AddWithValue("@Fiyat",int.Parse(textBox6.Text));
                komut.Parameters.AddWithValue("@AracPlakasi",textBox7.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Araç kiralama işi kaydedilmiştir...");

            }
           else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!!!");

            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          int TeslimTarihi, AlisTarihi, Para,Sonuc;
            AlisTarihi =(int) dateTimePicker1.Value.ToOADate();
            TeslimTarihi = (int)dateTimePicker2.Value.ToOADate();

            if(AlisTarihi>TeslimTarihi)
            {
                MessageBox.Show("Lütfen tarihleri kontrol ediniz");
            }
            else
            {
                Para = (int)(dateTimePicker2.Value.ToOADate() - dateTimePicker1.Value.ToOADate());              
                Sonuc = Para * 100;
                
            textBox6.Text = Sonuc.ToString();
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
     
            
        }
    }
}
