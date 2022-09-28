using System.Windows.Forms;

namespace Kütüphane
{
    partial class frmbooklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbooklist));
            this.cmbsahib = new System.Windows.Forms.ComboBox();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyladevdataset = new Kütüphane.kyladevdataset();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.txtTür = new System.Windows.Forms.TextBox();
            this.txtYayınevi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgridbooklist = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayıneviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahibiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgridodunclist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayıneviDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnemanetet = new System.Windows.Forms.Button();
            this.txtEmanetad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKime = new System.Windows.Forms.TextBox();
            this.txtEmanetyazar = new System.Windows.Forms.TextBox();
            this.txtEmanettarih = new System.Windows.Forms.TextBox();
            this.txtEmanetyayın = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtemtur = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbKimden = new System.Windows.Forms.ComboBox();
            this.btniade = new System.Windows.Forms.Button();
            this.txtoduncadsoyad = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtiadekonum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kitapTableAdapter = new Kütüphane.kyladevdatasetTableAdapters.KitapTableAdapter();
            this.emanetTableAdapter = new Kütüphane.kyladevdatasetTableAdapters.EmanetTableAdapter();
            this.kullaniciTableAdapter = new Kütüphane.kyladevdatasetTableAdapters.KullaniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyladevdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridbooklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridodunclist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbsahib
            // 
            this.cmbsahib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbsahib.DataSource = this.kullaniciBindingSource;
            this.cmbsahib.DisplayMember = "AdSoyad";
            this.cmbsahib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsahib.FormattingEnabled = true;
            this.cmbsahib.Location = new System.Drawing.Point(81, 169);
            this.cmbsahib.Name = "cmbsahib";
            this.cmbsahib.Size = new System.Drawing.Size(242, 29);
            this.cmbsahib.TabIndex = 6;
            this.cmbsahib.ValueMember = "TC";
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.kyladevdataset;
            // 
            // kyladevdataset
            // 
            this.kyladevdataset.DataSetName = "kyladevdataset";
            this.kyladevdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(174, 240);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 39);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(9, 240);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(150, 39);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtKonum
            // 
            this.txtKonum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKonum.Location = new System.Drawing.Point(81, 205);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(242, 29);
            this.txtKonum.TabIndex = 7;
            // 
            // txtTür
            // 
            this.txtTür.Location = new System.Drawing.Point(81, 133);
            this.txtTür.Name = "txtTür";
            this.txtTür.Size = new System.Drawing.Size(242, 29);
            this.txtTür.TabIndex = 5;
            // 
            // txtYayınevi
            // 
            this.txtYayınevi.Location = new System.Drawing.Point(81, 97);
            this.txtYayınevi.Name = "txtYayınevi";
            this.txtYayınevi.Size = new System.Drawing.Size(242, 29);
            this.txtYayınevi.TabIndex = 4;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(81, 61);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(242, 29);
            this.txtYazar.TabIndex = 3;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(81, 25);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(242, 29);
            this.txtKitapAd.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Konum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sahibi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tür:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yayınevi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // dgridbooklist
            // 
            this.dgridbooklist.AllowUserToAddRows = false;
            this.dgridbooklist.AllowUserToDeleteRows = false;
            this.dgridbooklist.AutoGenerateColumns = false;
            this.dgridbooklist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgridbooklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridbooklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.yayıneviDataGridViewTextBoxColumn,
            this.türDataGridViewTextBoxColumn,
            this.sahibiDataGridViewTextBoxColumn,
            this.konumDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dgridbooklist.DataSource = this.kitapBindingSource;
            this.dgridbooklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridbooklist.Location = new System.Drawing.Point(3, 25);
            this.dgridbooklist.Name = "dgridbooklist";
            this.dgridbooklist.ReadOnly = true;
            this.dgridbooklist.Size = new System.Drawing.Size(1529, 561);
            this.dgridbooklist.TabIndex = 23;
            this.dgridbooklist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yayıneviDataGridViewTextBoxColumn
            // 
            this.yayıneviDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yayıneviDataGridViewTextBoxColumn.DataPropertyName = "Yayınevi";
            this.yayıneviDataGridViewTextBoxColumn.HeaderText = "Yayınevi";
            this.yayıneviDataGridViewTextBoxColumn.Name = "yayıneviDataGridViewTextBoxColumn";
            this.yayıneviDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // türDataGridViewTextBoxColumn
            // 
            this.türDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.türDataGridViewTextBoxColumn.DataPropertyName = "Tür";
            this.türDataGridViewTextBoxColumn.HeaderText = "Tür";
            this.türDataGridViewTextBoxColumn.Name = "türDataGridViewTextBoxColumn";
            this.türDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sahibiDataGridViewTextBoxColumn
            // 
            this.sahibiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sahibiDataGridViewTextBoxColumn.DataPropertyName = "Sahibi";
            this.sahibiDataGridViewTextBoxColumn.HeaderText = "Sahibi";
            this.sahibiDataGridViewTextBoxColumn.Name = "sahibiDataGridViewTextBoxColumn";
            this.sahibiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // konumDataGridViewTextBoxColumn
            // 
            this.konumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.konumDataGridViewTextBoxColumn.DataPropertyName = "Konum";
            this.konumDataGridViewTextBoxColumn.HeaderText = "Konum";
            this.konumDataGridViewTextBoxColumn.Name = "konumDataGridViewTextBoxColumn";
            this.konumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kyladevdataset;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(5, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 84);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ara (Ad, Yazar, Yayınevi, Tür)";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(10, 36);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(314, 29);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // dgridodunclist
            // 
            this.dgridodunclist.AllowUserToAddRows = false;
            this.dgridodunclist.AllowUserToDeleteRows = false;
            this.dgridodunclist.AutoGenerateColumns = false;
            this.dgridodunclist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgridodunclist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridodunclist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.adDataGridViewTextBoxColumn1,
            this.yazarDataGridViewTextBoxColumn1,
            this.yayıneviDataGridViewTextBoxColumn1,
            this.türDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.tarihDataGridViewTextBoxColumn1});
            this.dgridodunclist.DataSource = this.emanetBindingSource;
            this.dgridodunclist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridodunclist.Location = new System.Drawing.Point(3, 25);
            this.dgridodunclist.Name = "dgridodunclist";
            this.dgridodunclist.ReadOnly = true;
            this.dgridodunclist.Size = new System.Drawing.Size(1525, 376);
            this.dgridodunclist.TabIndex = 25;
            this.dgridodunclist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // adDataGridViewTextBoxColumn1
            // 
            this.adDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adDataGridViewTextBoxColumn1.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn1.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn1.Name = "adDataGridViewTextBoxColumn1";
            this.adDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yazarDataGridViewTextBoxColumn1
            // 
            this.yazarDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yazarDataGridViewTextBoxColumn1.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn1.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn1.Name = "yazarDataGridViewTextBoxColumn1";
            this.yazarDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yayıneviDataGridViewTextBoxColumn1
            // 
            this.yayıneviDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yayıneviDataGridViewTextBoxColumn1.DataPropertyName = "Yayınevi";
            this.yayıneviDataGridViewTextBoxColumn1.HeaderText = "Yayınevi";
            this.yayıneviDataGridViewTextBoxColumn1.Name = "yayıneviDataGridViewTextBoxColumn1";
            this.yayıneviDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // türDataGridViewTextBoxColumn1
            // 
            this.türDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.türDataGridViewTextBoxColumn1.DataPropertyName = "Tür";
            this.türDataGridViewTextBoxColumn1.HeaderText = "Tür";
            this.türDataGridViewTextBoxColumn1.Name = "türDataGridViewTextBoxColumn1";
            this.türDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kimden";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kimden";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn1
            // 
            this.tarihDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarihDataGridViewTextBoxColumn1.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.Name = "tarihDataGridViewTextBoxColumn1";
            this.tarihDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emanetBindingSource
            // 
            this.emanetBindingSource.DataMember = "Emanet";
            this.emanetBindingSource.DataSource = this.kyladevdataset;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgridbooklist);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(347, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1535, 589);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mevcut Kitaplar";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dgridodunclist);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(347, 596);
            this.groupBox3.MaximumSize = new System.Drawing.Size(1546, 485);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1531, 404);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödünç Verilmiş Kitaplar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtKitapAd);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmbsahib);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnGüncelle);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtKonum);
            this.groupBox4.Controls.Add(this.txtYazar);
            this.groupBox4.Controls.Add(this.txtTür);
            this.groupBox4.Controls.Add(this.txtYayınevi);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(5, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 300);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seçili Kitap";
            // 
            // btnemanetet
            // 
            this.btnemanetet.Location = new System.Drawing.Point(2, 60);
            this.btnemanetet.Name = "btnemanetet";
            this.btnemanetet.Size = new System.Drawing.Size(327, 39);
            this.btnemanetet.TabIndex = 11;
            this.btnemanetet.Text = "Ödünc Ver";
            this.btnemanetet.UseVisualStyleBackColor = true;
            this.btnemanetet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmanetad
            // 
            this.txtEmanetad.Enabled = false;
            this.txtEmanetad.Location = new System.Drawing.Point(83, 28);
            this.txtEmanetad.Name = "txtEmanetad";
            this.txtEmanetad.Size = new System.Drawing.Size(242, 29);
            this.txtEmanetad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Yazar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Yayınevi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Kimden:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 21);
            this.label11.TabIndex = 37;
            this.label11.Text = "Tarih:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "Kime:";
            // 
            // txtKime
            // 
            this.txtKime.Enabled = false;
            this.txtKime.Location = new System.Drawing.Point(83, 203);
            this.txtKime.Name = "txtKime";
            this.txtKime.Size = new System.Drawing.Size(242, 29);
            this.txtKime.TabIndex = 17;
            // 
            // txtEmanetyazar
            // 
            this.txtEmanetyazar.Enabled = false;
            this.txtEmanetyazar.Location = new System.Drawing.Point(83, 64);
            this.txtEmanetyazar.Name = "txtEmanetyazar";
            this.txtEmanetyazar.Size = new System.Drawing.Size(242, 29);
            this.txtEmanetyazar.TabIndex = 13;
            // 
            // txtEmanettarih
            // 
            this.txtEmanettarih.Enabled = false;
            this.txtEmanettarih.Location = new System.Drawing.Point(83, 242);
            this.txtEmanettarih.Name = "txtEmanettarih";
            this.txtEmanettarih.Size = new System.Drawing.Size(242, 29);
            this.txtEmanettarih.TabIndex = 18;
            // 
            // txtEmanetyayın
            // 
            this.txtEmanetyayın.Enabled = false;
            this.txtEmanetyayın.Location = new System.Drawing.Point(83, 100);
            this.txtEmanetyayın.Name = "txtEmanetyayın";
            this.txtEmanetyayın.Size = new System.Drawing.Size(242, 29);
            this.txtEmanetyayın.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.txtemtur);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.cmbKimden);
            this.groupBox5.Controls.Add(this.txtEmanetad);
            this.groupBox5.Controls.Add(this.txtEmanetyayın);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtEmanettarih);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtEmanetyazar);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtKime);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(5, 596);
            this.groupBox5.MaximumSize = new System.Drawing.Size(335, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 299);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Seçili Ödünç Kitap";
            // 
            // txtemtur
            // 
            this.txtemtur.Enabled = false;
            this.txtemtur.Location = new System.Drawing.Point(83, 133);
            this.txtemtur.Name = "txtemtur";
            this.txtemtur.Size = new System.Drawing.Size(242, 29);
            this.txtemtur.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 21);
            this.label15.TabIndex = 43;
            this.label15.Text = "Tür:";
            // 
            // cmbKimden
            // 
            this.cmbKimden.Enabled = false;
            this.cmbKimden.FormattingEnabled = true;
            this.cmbKimden.Location = new System.Drawing.Point(83, 166);
            this.cmbKimden.Name = "cmbKimden";
            this.cmbKimden.Size = new System.Drawing.Size(242, 29);
            this.cmbKimden.TabIndex = 16;
            // 
            // btniade
            // 
            this.btniade.Location = new System.Drawing.Point(10, 55);
            this.btniade.Name = "btniade";
            this.btniade.Size = new System.Drawing.Size(309, 34);
            this.btniade.TabIndex = 20;
            this.btniade.Text = "İade Al";
            this.btniade.UseVisualStyleBackColor = true;
            this.btniade.Click += new System.EventHandler(this.btniade_Click);
            // 
            // txtoduncadsoyad
            // 
            this.txtoduncadsoyad.Location = new System.Drawing.Point(100, 28);
            this.txtoduncadsoyad.Name = "txtoduncadsoyad";
            this.txtoduncadsoyad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtoduncadsoyad.Size = new System.Drawing.Size(229, 29);
            this.txtoduncadsoyad.TabIndex = 10;
            this.txtoduncadsoyad.Text = "Kime ?";
            this.txtoduncadsoyad.Enter += new System.EventHandler(this.txtoduncadsoyad_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.btnemanetet);
            this.groupBox6.Controls.Add(this.txtoduncadsoyad);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(5, 470);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 127);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Seçili Kitabı Ödünç Ver";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 21);
            this.label13.TabIndex = 43;
            this.label13.Text = "Ad Soyad:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txtiadekonum);
            this.groupBox7.Controls.Add(this.btniade);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(5, 899);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(333, 101);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "İade Al";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 21);
            this.label14.TabIndex = 43;
            this.label14.Text = "Konum:";
            // 
            // txtiadekonum
            // 
            this.txtiadekonum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtiadekonum.Location = new System.Drawing.Point(83, 20);
            this.txtiadekonum.Name = "txtiadekonum";
            this.txtiadekonum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtiadekonum.Size = new System.Drawing.Size(236, 29);
            this.txtiadekonum.TabIndex = 19;
            this.txtiadekonum.Text = "YENI KONUM GIRINIZ.";
            this.txtiadekonum.Enter += new System.EventHandler(this.txtiadekonum_Enter);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 65);
            this.button1.TabIndex = 45;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // emanetTableAdapter
            // 
            this.emanetTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // frmbooklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1894, 1012);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1910, 1038);
            this.Name = "frmbooklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmbooklist_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmbooklist_FormClosed);
            this.Load += new System.EventHandler(this.booklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyladevdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridbooklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridodunclist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbsahib;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.TextBox txtTür;
        private System.Windows.Forms.TextBox txtYayınevi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataGridView dgridbooklist;
        private GroupBox groupBox1;
        private TextBox txtAra;
        private DataGridView dgridodunclist;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnemanetet;
        private TextBox txtEmanetad;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtKime;
        private TextBox txtEmanetyazar;
        private TextBox txtEmanettarih;
        private TextBox txtEmanetyayın;
        private GroupBox groupBox5;
        private ComboBox cmbKimden;
        private Button btniade;
        private TextBox txtemtur;
        private Label label15;
        private TextBox txtoduncadsoyad;
        private GroupBox groupBox6;
        private Label label13;
        private GroupBox groupBox7;
        private Label label14;
        private TextBox txtiadekonum;
        private Button button1;
        private kyladevdataset kyladevdataset;
        private BindingSource kitapBindingSource;
        private kyladevdatasetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private BindingSource emanetBindingSource;
        private kyladevdatasetTableAdapters.EmanetTableAdapter emanetTableAdapter;
        private BindingSource kullaniciBindingSource;
        private kyladevdatasetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yayıneviDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn türDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sahibiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn konumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yayıneviDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn türDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn1;
    }
}