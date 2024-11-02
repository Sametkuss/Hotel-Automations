namespace WindowsFormsApp1
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.otelOtomasyonuDataSet14 = new WindowsFormsApp1.OtelOtomasyonuDataSet14();
            this.mÜŞTERİKAYIT1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mÜŞTERİ_KAYIT_1TableAdapter = new WindowsFormsApp1.OtelOtomasyonuDataSet14TableAdapters.MÜŞTERİ_KAYIT_1TableAdapter();
            this.mÜŞTERİİDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİCİNSİYETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİYAŞDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİTELEFONNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİADRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelOtomasyonuDataSet15 = new WindowsFormsApp1.OtelOtomasyonuDataSet15();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odalarTableAdapter = new WindowsFormsApp1.OtelOtomasyonuDataSet15TableAdapters.OdalarTableAdapter();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolulukDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelOtomasyonuDataSet16 = new WindowsFormsApp1.OtelOtomasyonuDataSet16();
            this.odaRezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaRezervasyonTableAdapter = new WindowsFormsApp1.OtelOtomasyonuDataSet16TableAdapters.OdaRezervasyonTableAdapter();
            this.rezervasyonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekDahilDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toplamUcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisYapildimiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.otelOtomasyonuDataSet17 = new WindowsFormsApp1.OtelOtomasyonuDataSet17();
            this.mesajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mesajTableAdapter = new WindowsFormsApp1.OtelOtomasyonuDataSet17TableAdapters.MesajTableAdapter();
            this.mÜŞTERİİDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mÜŞTERİKAYIT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaRezervasyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervasyonIDDataGridViewTextBoxColumn,
            this.musteriIDDataGridViewTextBoxColumn,
            this.girisTarihiDataGridViewTextBoxColumn,
            this.cikisTarihiDataGridViewTextBoxColumn,
            this.yemekDahilDataGridViewCheckBoxColumn,
            this.toplamUcretDataGridViewTextBoxColumn,
            this.odaIDDataGridViewTextBoxColumn,
            this.cikisYapildimiDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.odaRezervasyonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 97);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mÜŞTERİİDDataGridViewTextBoxColumn,
            this.mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn,
            this.mÜŞTERİADDataGridViewTextBoxColumn,
            this.mÜŞTERİSOYADDataGridViewTextBoxColumn,
            this.mÜŞTERİCİNSİYETDataGridViewTextBoxColumn,
            this.mÜŞTERİYAŞDataGridViewTextBoxColumn,
            this.mÜŞTERİTELEFONNODataGridViewTextBoxColumn,
            this.mÜŞTERİADRESDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mÜŞTERİKAYIT1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(2, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(786, 102);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaNoDataGridViewTextBoxColumn,
            this.dolulukDurumuDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.odalarBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(2, 120);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(786, 110);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mÜŞTERİİDDataGridViewTextBoxColumn1,
            this.mesajDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.mesajBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(2, 339);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(786, 87);
            this.dataGridView4.TabIndex = 3;
            // 
            // otelOtomasyonuDataSet14
            // 
            this.otelOtomasyonuDataSet14.DataSetName = "OtelOtomasyonuDataSet14";
            this.otelOtomasyonuDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mÜŞTERİKAYIT1BindingSource
            // 
            this.mÜŞTERİKAYIT1BindingSource.DataMember = "MÜŞTERİ_KAYIT_1";
            this.mÜŞTERİKAYIT1BindingSource.DataSource = this.otelOtomasyonuDataSet14;
            // 
            // mÜŞTERİ_KAYIT_1TableAdapter
            // 
            this.mÜŞTERİ_KAYIT_1TableAdapter.ClearBeforeFill = true;
            // 
            // mÜŞTERİİDDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİİDDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİİD";
            this.mÜŞTERİİDDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİİD";
            this.mÜŞTERİİDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİİDDataGridViewTextBoxColumn.Name = "mÜŞTERİİDDataGridViewTextBoxColumn";
            this.mÜŞTERİİDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mÜŞTERİİDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn
            // 
            this.mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ_TC_KİMLİK_NO";
            this.mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ_TC_KİMLİK_NO";
            this.mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn.Name = "mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn";
            this.mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn.Width = 125;
            // 
            // mÜŞTERİADDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİADDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ_AD";
            this.mÜŞTERİADDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ_AD";
            this.mÜŞTERİADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİADDataGridViewTextBoxColumn.Name = "mÜŞTERİADDataGridViewTextBoxColumn";
            this.mÜŞTERİADDataGridViewTextBoxColumn.Width = 125;
            // 
            // mÜŞTERİSOYADDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİSOYADDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ_SOYAD";
            this.mÜŞTERİSOYADDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ_SOYAD";
            this.mÜŞTERİSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİSOYADDataGridViewTextBoxColumn.Name = "mÜŞTERİSOYADDataGridViewTextBoxColumn";
            this.mÜŞTERİSOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // mÜŞTERİCİNSİYETDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİCİNSİYETDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ_CİNSİYET";
            this.mÜŞTERİCİNSİYETDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ_CİNSİYET";
            this.mÜŞTERİCİNSİYETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİCİNSİYETDataGridViewTextBoxColumn.Name = "mÜŞTERİCİNSİYETDataGridViewTextBoxColumn";
            this.mÜŞTERİCİNSİYETDataGridViewTextBoxColumn.Width = 125;
            // 
            // mÜŞTERİYAŞDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİYAŞDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ_YAŞ";
            this.mÜŞTERİYAŞDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ_YAŞ";
            this.mÜŞTERİYAŞDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİYAŞDataGridViewTextBoxColumn.Name = "mÜŞTERİYAŞDataGridViewTextBoxColumn";
            this.mÜŞTERİYAŞDataGridViewTextBoxColumn.Width = 125;
            // 
            // mÜŞTERİTELEFONNODataGridViewTextBoxColumn
            // 
            this.mÜŞTERİTELEFONNODataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ_TELEFON_NO";
            this.mÜŞTERİTELEFONNODataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ_TELEFON_NO";
            this.mÜŞTERİTELEFONNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİTELEFONNODataGridViewTextBoxColumn.Name = "mÜŞTERİTELEFONNODataGridViewTextBoxColumn";
            this.mÜŞTERİTELEFONNODataGridViewTextBoxColumn.Width = 125;
            // 
            // mÜŞTERİADRESDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİADRESDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ_ADRES";
            this.mÜŞTERİADRESDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ_ADRES";
            this.mÜŞTERİADRESDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİADRESDataGridViewTextBoxColumn.Name = "mÜŞTERİADRESDataGridViewTextBoxColumn";
            this.mÜŞTERİADRESDataGridViewTextBoxColumn.Width = 125;
            // 
            // otelOtomasyonuDataSet15
            // 
            this.otelOtomasyonuDataSet15.DataSetName = "OtelOtomasyonuDataSet15";
            this.otelOtomasyonuDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.otelOtomasyonuDataSet15;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            this.odaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dolulukDurumuDataGridViewTextBoxColumn
            // 
            this.dolulukDurumuDataGridViewTextBoxColumn.DataPropertyName = "DolulukDurumu";
            this.dolulukDurumuDataGridViewTextBoxColumn.HeaderText = "DolulukDurumu";
            this.dolulukDurumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dolulukDurumuDataGridViewTextBoxColumn.Name = "dolulukDurumuDataGridViewTextBoxColumn";
            this.dolulukDurumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // otelOtomasyonuDataSet16
            // 
            this.otelOtomasyonuDataSet16.DataSetName = "OtelOtomasyonuDataSet16";
            this.otelOtomasyonuDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odaRezervasyonBindingSource
            // 
            this.odaRezervasyonBindingSource.DataMember = "OdaRezervasyon";
            this.odaRezervasyonBindingSource.DataSource = this.otelOtomasyonuDataSet16;
            // 
            // odaRezervasyonTableAdapter
            // 
            this.odaRezervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // rezervasyonIDDataGridViewTextBoxColumn
            // 
            this.rezervasyonIDDataGridViewTextBoxColumn.DataPropertyName = "RezervasyonID";
            this.rezervasyonIDDataGridViewTextBoxColumn.HeaderText = "RezervasyonID";
            this.rezervasyonIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezervasyonIDDataGridViewTextBoxColumn.Name = "rezervasyonIDDataGridViewTextBoxColumn";
            this.rezervasyonIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervasyonIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // girisTarihiDataGridViewTextBoxColumn
            // 
            this.girisTarihiDataGridViewTextBoxColumn.DataPropertyName = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.HeaderText = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girisTarihiDataGridViewTextBoxColumn.Name = "girisTarihiDataGridViewTextBoxColumn";
            this.girisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cikisTarihiDataGridViewTextBoxColumn
            // 
            this.cikisTarihiDataGridViewTextBoxColumn.DataPropertyName = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.HeaderText = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cikisTarihiDataGridViewTextBoxColumn.Name = "cikisTarihiDataGridViewTextBoxColumn";
            this.cikisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yemekDahilDataGridViewCheckBoxColumn
            // 
            this.yemekDahilDataGridViewCheckBoxColumn.DataPropertyName = "YemekDahil";
            this.yemekDahilDataGridViewCheckBoxColumn.HeaderText = "YemekDahil";
            this.yemekDahilDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.yemekDahilDataGridViewCheckBoxColumn.Name = "yemekDahilDataGridViewCheckBoxColumn";
            this.yemekDahilDataGridViewCheckBoxColumn.Width = 125;
            // 
            // toplamUcretDataGridViewTextBoxColumn
            // 
            this.toplamUcretDataGridViewTextBoxColumn.DataPropertyName = "ToplamUcret";
            this.toplamUcretDataGridViewTextBoxColumn.HeaderText = "ToplamUcret";
            this.toplamUcretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamUcretDataGridViewTextBoxColumn.Name = "toplamUcretDataGridViewTextBoxColumn";
            this.toplamUcretDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaIDDataGridViewTextBoxColumn
            // 
            this.odaIDDataGridViewTextBoxColumn.DataPropertyName = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.HeaderText = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaIDDataGridViewTextBoxColumn.Name = "odaIDDataGridViewTextBoxColumn";
            this.odaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cikisYapildimiDataGridViewCheckBoxColumn
            // 
            this.cikisYapildimiDataGridViewCheckBoxColumn.DataPropertyName = "CikisYapildimi";
            this.cikisYapildimiDataGridViewCheckBoxColumn.HeaderText = "CikisYapildimi";
            this.cikisYapildimiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.cikisYapildimiDataGridViewCheckBoxColumn.Name = "cikisYapildimiDataGridViewCheckBoxColumn";
            this.cikisYapildimiDataGridViewCheckBoxColumn.Width = 125;
            // 
            // otelOtomasyonuDataSet17
            // 
            this.otelOtomasyonuDataSet17.DataSetName = "OtelOtomasyonuDataSet17";
            this.otelOtomasyonuDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesajBindingSource
            // 
            this.mesajBindingSource.DataMember = "Mesaj";
            this.mesajBindingSource.DataSource = this.otelOtomasyonuDataSet17;
            // 
            // mesajTableAdapter
            // 
            this.mesajTableAdapter.ClearBeforeFill = true;
            // 
            // mÜŞTERİİDDataGridViewTextBoxColumn1
            // 
            this.mÜŞTERİİDDataGridViewTextBoxColumn1.DataPropertyName = "MÜŞTERİİD";
            this.mÜŞTERİİDDataGridViewTextBoxColumn1.HeaderText = "MÜŞTERİİD";
            this.mÜŞTERİİDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mÜŞTERİİDDataGridViewTextBoxColumn1.Name = "mÜŞTERİİDDataGridViewTextBoxColumn1";
            this.mÜŞTERİİDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mesajDataGridViewTextBoxColumn
            // 
            this.mesajDataGridViewTextBoxColumn.DataPropertyName = "Mesaj";
            this.mesajDataGridViewTextBoxColumn.HeaderText = "Mesaj";
            this.mesajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajDataGridViewTextBoxColumn.Name = "mesajDataGridViewTextBoxColumn";
            this.mesajDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mÜŞTERİKAYIT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaRezervasyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private OtelOtomasyonuDataSet14 otelOtomasyonuDataSet14;
        private System.Windows.Forms.BindingSource mÜŞTERİKAYIT1BindingSource;
        private OtelOtomasyonuDataSet14TableAdapters.MÜŞTERİ_KAYIT_1TableAdapter mÜŞTERİ_KAYIT_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİİDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİTCKİMLİKNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİCİNSİYETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİYAŞDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİTELEFONNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİADRESDataGridViewTextBoxColumn;
        private OtelOtomasyonuDataSet15 otelOtomasyonuDataSet15;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private OtelOtomasyonuDataSet15TableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolulukDurumuDataGridViewTextBoxColumn;
        private OtelOtomasyonuDataSet16 otelOtomasyonuDataSet16;
        private System.Windows.Forms.BindingSource odaRezervasyonBindingSource;
        private OtelOtomasyonuDataSet16TableAdapters.OdaRezervasyonTableAdapter odaRezervasyonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn yemekDahilDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamUcretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cikisYapildimiDataGridViewCheckBoxColumn;
        private OtelOtomasyonuDataSet17 otelOtomasyonuDataSet17;
        private System.Windows.Forms.BindingSource mesajBindingSource;
        private OtelOtomasyonuDataSet17TableAdapters.MesajTableAdapter mesajTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİİDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajDataGridViewTextBoxColumn;
    }
}