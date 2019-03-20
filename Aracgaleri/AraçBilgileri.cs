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
    public partial class AraçBilgileri : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-V5FHF02\\SQLEXPRESS;Initial Catalog=Araba;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
       

        public AraçBilgileri()
        {
            InitializeComponent();
        }

        private void arabaDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa ac = new AnaSayfa();
            ac.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string bul = textBox1.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper().Replace(" ", "").Equals(bul))
                            {
                                cell.Style.BackColor = Color.Orange;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>-1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekle ac = new Ekle();
            ac.Show();
            this.Hide();
        }

        private void AraçBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'arabaDataSet1.EkleAraba' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ekleArabaTableAdapter.Fill(this.arabaDataSet1.EkleAraba);

        }

        private void arabaDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
