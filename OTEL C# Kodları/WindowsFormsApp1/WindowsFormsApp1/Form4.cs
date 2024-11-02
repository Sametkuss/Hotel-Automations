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
using static WindowsFormsApp1.Form3;


namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OB0D2CD\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
        SqlDataAdapter da;

        

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
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
           
            }

            void UygunOdalariGetir()
        {
            SqlCommand komut1 = new SqlCommand("SELECT * FROM Odalar WHERE OdaNo NOT IN (SELECT OdaID FROM OdaRezervasyon WHERE CikisYapildimi = 0)", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["OdaNo"]);
            }
            baglanti.Close();
        }


        private void Form4_Load(object sender, EventArgs e)
            {
                MusteriGetir();
            UygunOdalariGetir();





        }


            private void button3_Click(object sender, EventArgs e)
            {
              
            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {


            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                int customer_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DateTime enterance_date = dateTimePicker1.Value;
                DateTime exit_date = dateTimePicker2.Value;
                bool dinner_check = checkBox1.Checked;

        

                TimeSpan kalacakGunSayisi = exit_date - enterance_date;
                int kalacakGunler = 0;
                if (enterance_date.ToString() != exit_date.ToString())
                    kalacakGunler = ((int)kalacakGunSayisi.TotalDays) + 1;


                double toplamFiyat = kalacakGunler * 1000; // Her gün için 1000 TL


                if (dinner_check)
                {
                    toplamFiyat += kalacakGunler * 250; // Her gün için 250 TL ek
                }

                if (toplamFiyat > 0)
                {
                 baglanti.Open();
                 SqlCommand komut1 = new SqlCommand("insert into OdaRezervasyon (MusteriID,GirisTarihi,CikisTarihi,YemekDahil,ToplamUcret,OdaID, CikisYapildimi) values (@c_id,@en_date,@ex_date,@c_dinner,@cost,@oda_ıd, 0)", baglanti);
                 komut1.Parameters.AddWithValue("@c_id", customer_id);
                 komut1.Parameters.AddWithValue("@en_date", enterance_date);
                 komut1.Parameters.AddWithValue("@ex_date", exit_date);
                 komut1.Parameters.AddWithValue("@c_dinner", dinner_check);
                 komut1.Parameters.AddWithValue("@cost", toplamFiyat);
                 komut1.Parameters.AddWithValue("@oda_ıd", comboBox1.SelectedItem.ToString());
                 komut1.ExecuteNonQuery();
                 MessageBox.Show("EKLENDİ!");
                 baglanti.Close();
                comboBox1.Items.Clear();
                UygunOdalariGetir();
                }


            }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
    
        
    



