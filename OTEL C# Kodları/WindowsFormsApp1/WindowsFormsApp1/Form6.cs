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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OB0D2CD\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
        SqlDataAdapter da;
        int customer_id = -1;

        void MusteriGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-OB0D2CD\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM MÜŞTERİ_KAYIT_1", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = richTextBox1.Text;
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Mesaj (MÜŞTERİİD,Mesaj) values (@c_id,@msg)", baglanti);
            komut1.Parameters.AddWithValue("@c_id", customer_id);
            komut1.Parameters.AddWithValue("@msg", message);
            komut1.ExecuteNonQuery();
            MessageBox.Show("EKLENDİ!");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customer_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }
    }
}
