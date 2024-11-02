using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet17.Mesaj' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mesajTableAdapter.Fill(this.otelOtomasyonuDataSet17.Mesaj);
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet16.OdaRezervasyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odaRezervasyonTableAdapter.Fill(this.otelOtomasyonuDataSet16.OdaRezervasyon);
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet15.Odalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odalarTableAdapter.Fill(this.otelOtomasyonuDataSet15.Odalar);
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet14.MÜŞTERİ_KAYIT_1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mÜŞTERİ_KAYIT_1TableAdapter.Fill(this.otelOtomasyonuDataSet14.MÜŞTERİ_KAYIT_1);

        }
    }
}
