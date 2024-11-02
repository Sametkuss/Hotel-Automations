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
using static WindowsFormsApp1.Form4;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OB0D2CD\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True;TrustServerCertificate=True");

        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        SqlCommand komut2 = new SqlCommand();
        SqlDataAdapter da;

        private void button5_Click(object sender, EventArgs e)
        {
            verilerigöster("SELECT * FROM MÜŞTERİ_KAYIT_1");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM cinsiyet", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CİNSİYET"]);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into MÜŞTERİ_KAYIT_1 (MÜŞTERİ_TC_KİMLİK_NO,MÜŞTERİ_AD,MÜŞTERİ_SOYAD,MÜŞTERİ_CİNSİYET,MÜŞTERİ_YAŞ,MÜŞTERİ_TELEFON_NO,MÜŞTERİ_ADRES) values (@tc,@ad,@soyad,@cinsiyet,@yaş,@telefon,@adres)", baglanti);
            komut1.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            komut1.Parameters.AddWithValue("@ad", maskedTextBox2.Text);
            komut1.Parameters.AddWithValue("@soyad", maskedTextBox3.Text);
            komut1.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            komut1.Parameters.AddWithValue("@yaş", maskedTextBox4.Text);
            komut1.Parameters.AddWithValue("@telefon", maskedTextBox5.Text);
            komut1.Parameters.AddWithValue("@adres", richTextBox1.Text);
            komut1.ExecuteNonQuery();
            MessageBox.Show("MÜŞTERİ EKLENDİ");
            verilerigöster("SELECT * FROM MÜŞTERİ_KAYIT_1");
            baglanti.Close();

            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            richTextBox1.Clear();
            maskedTextBox1.Focus();



        }
        public void veriyisil(int id)
        {
            string sil = "delete from MÜŞTERİ_KAYIT_1 where MÜŞTERİ_TC_KİMLİK_NO = @tc";
            SqlCommand komut1 = new SqlCommand(sil, baglanti);
            komut1.Parameters.AddWithValue("@tc", Convert.ToInt32(maskedTextBox1.Text));
            baglanti.Open();
            komut1.ExecuteNonQuery();
            baglanti.Close();

            MusteriGetir();

        }
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

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("delete from MÜŞTERİ_KAYIT_1 where MÜŞTERİ_TC_KİMLİK_NO=@tc", baglanti);
            komut2.Parameters.AddWithValue("@tc", dataGridView1.Rows[i].Cells[0].Value);
            komut1.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            komut1.ExecuteNonQuery();
            verilerigöster("SELECT * FROM MÜŞTERİ_KAYIT_1");
            MessageBox.Show("MÜŞTERİ SİLİNDİ");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        int i = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE MÜŞTERİ_KAYIT_1 SET MÜŞTERİ_TC_KİMLİK_NO=@tc,MÜŞTERİ_AD=@ad,MÜŞTERİ_SOYAD=@soyad,MÜŞTERİ_CİNSİYET=@cinsiyet,MÜŞTERİ_YAŞ=@yaş,MÜŞTERİ_TELEFON_NO=@telefon,MÜŞTERİ_ADRES=@adres WHERE MÜŞTERİİD=@id";
            komut2 = new SqlCommand(sorgu, baglanti);
            komut2.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
            komut2.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            komut2.Parameters.AddWithValue("@ad", maskedTextBox2.Text);
            komut2.Parameters.AddWithValue("@soyad", maskedTextBox3.Text);
            komut2.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            komut2.Parameters.AddWithValue("@yaş", maskedTextBox4.Text);
            komut2.Parameters.AddWithValue("@telefon", maskedTextBox5.Text);
            komut2.Parameters.AddWithValue("@adres", richTextBox1.Text);
            baglanti.Open();
            komut2.ExecuteNonQuery();
            MessageBox.Show("MÜŞTERİ GÜNCELLENDİ");
            baglanti.Close();
            MusteriGetir();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
       
}

