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
    public partial class KullaniciEkle : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-V5FHF02\\SQLEXPRESS;Initial Catalog=Araba;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
       
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                 string Kad = textBox1.Text;
                 string Sifre = textBox2.Text.ToString();
                komut.Connection = baglan;
                komut.CommandText = "INSERT INTO KullaniciAdmin(Kad,Sifre) VALUES ('"+ textBox1.Text + "','"+textBox1.Text+"')";             
                komut.Parameters.AddWithValue("@Kad",textBox1.Text);
                komut.Parameters.AddWithValue("@Sifre",textBox2.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
            baglan.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa ac = new AnaSayfa();
            ac.Show();
            this.Hide();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'arabaKullaniciDataSet1.KullaniciAdmin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullaniciAdminTableAdapter.Fill(this.arabaKullaniciDataSet1.KullaniciAdmin);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Kullanıcıyı silmek istiyor musunuz?","Hayır",MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count > -1)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                }
                else
                {
                    MessageBox.Show("Lütfen silinecek satırı seçiniz!!!");
                }
            }
        }
    }
}
