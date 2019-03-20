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
    public partial class Ekle : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-V5FHF02\\SQLEXPRESS;Initial Catalog=Araba;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
       
        public Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Marka, Model, Km, Renk,Tarih,GirisTarih;
    //      
            Marka = comboBox1.Text;
            Model = comboBox2.Text;
            Km = textBox3.Text;
            Renk = textBox4.Text;
            Tarih = dateTimePicker1.Text;
            GirisTarih = dateTimePicker2.Text;
            if(Marka!=""&&Model!=""&&Km!=""&&Renk!=""&&Tarih!=""&&GirisTarih!="")
            {
                baglan.Open();
              komut.CommandText = "INSERT INTO EkleAraba(Marka, Model, Km, Renk,Tarih,GirisTarih) VALUES(@Marka,@Model,@Km,@Renk,@Tarih,@GirisTarih)";
                komut.Connection = baglan;
                komut.Parameters.AddWithValue("@Marka",comboBox1.Text);
                komut.Parameters.AddWithValue("@Model",Convert.ToString(comboBox2.Text));
                komut.Parameters.AddWithValue("@Km",Convert.ToString(textBox3.Text));
                komut.Parameters.AddWithValue("@Renk",textBox4.Text);
                komut.Parameters.AddWithValue("@Tarih",dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@GirisTarih",dateTimePicker2.Value);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Arac sisteme kaydedilmiştir...");

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");

            }
            comboBox1.ResetText();
            comboBox2.ResetText();
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa ac = new AnaSayfa();

            ac.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
            {
                comboBox1.DataSource = ekleArabaBindingSource.DataMember;
            }
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'arabaDataSet.EkleAraba' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ekleArabaTableAdapter.Fill(this.arabaDataSet.EkleAraba);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.Text != "")
            {
                comboBox2.Text.ToString();
            }
            else
            {
                comboBox2.DataSource = ekleArabaBindingSource.DataMember;
            }
        }
    }
}
