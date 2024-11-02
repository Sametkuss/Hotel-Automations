using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OB0D2CD\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
        SqlDataAdapter da;

        void RezervasyonGetir()
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM OdaRezervasyon WHERE CikisYapildimi = 0", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            RezervasyonGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("UPDATE OdaRezervasyon SET CikisYapildimi = 1 WHERE RezervasyonID = @r_id", baglanti);
                 komut1.Parameters.AddWithValue("@r_id", r_id);
                 komut1.ExecuteNonQuery();
                 
                 baglanti.Close();
            RezervasyonGetir();
        }
    }
}
       


