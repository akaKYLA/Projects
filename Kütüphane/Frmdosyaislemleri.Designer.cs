namespace Kütüphane
{
    partial class Frmdosyaislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdosyaislemleri));
            this.dgridKitaplar = new System.Windows.Forms.DataGridView();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyladevdataset = new Kütüphane.kyladevdataset();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcelaktar = new System.Windows.Forms.Button();
            this.btnNotgetir = new System.Windows.Forms.Button();
            this.richtxtNot = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnMetinsil = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitapTableAdapter = new Kütüphane.kyladevdatasetTableAdapters.KitapTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayıneviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahibiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyladevdataset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgridKitaplar
            // 
            this.dgridKitaplar.AllowUserToAddRows = false;
            this.dgridKitaplar.AllowUserToDeleteRows = false;
            this.dgridKitaplar.AutoGenerateColumns = false;
            this.dgridKitaplar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgridKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.yayıneviDataGridViewTextBoxColumn,
            this.türDataGridViewTextBoxColumn,
            this.sahibiDataGridViewTextBoxColumn,
            this.konumDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dgridKitaplar.DataSource = this.kitapBindingSource;
            this.dgridKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridKitaplar.Location = new System.Drawing.Point(3, 25);
            this.dgridKitaplar.Name = "dgridKitaplar";
            this.dgridKitaplar.ReadOnly = true;
            this.dgridKitaplar.Size = new System.Drawing.Size(764, 585);
            this.dgridKitaplar.TabIndex = 0;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kyladevdataset;
            // 
            // kyladevdataset
            // 
            this.kyladevdataset.DataSetName = "kyladevdataset";
            this.kyladevdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgridKitaplar);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 613);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mevcut Kitaplar";
            // 
            // btnExcelaktar
            // 
            this.btnExcelaktar.Location = new System.Drawing.Point(12, 18);
            this.btnExcelaktar.Name = "btnExcelaktar";
            this.btnExcelaktar.Size = new System.Drawing.Size(210, 35);
            this.btnExcelaktar.TabIndex = 2;
            this.btnExcelaktar.Text = "Kitapları Excel\'e Aktar";
            this.btnExcelaktar.UseVisualStyleBackColor = true;
            this.btnExcelaktar.Click += new System.EventHandler(this.BtnExcelaktar_Click);
            // 
            // btnNotgetir
            // 
            this.btnNotgetir.Location = new System.Drawing.Point(356, 18);
            this.btnNotgetir.Name = "btnNotgetir";
            this.btnNotgetir.Size = new System.Drawing.Size(210, 35);
            this.btnNotgetir.TabIndex = 4;
            this.btnNotgetir.Text = "Kayıtlı Notu Aç";
            this.btnNotgetir.UseVisualStyleBackColor = true;
            this.btnNotgetir.Click += new System.EventHandler(this.BtnNotgetir_Click);
            // 
            // richtxtNot
            // 
            this.richtxtNot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxtNot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richtxtNot.Location = new System.Drawing.Point(3, 25);
            this.richtxtNot.Name = "richtxtNot";
            this.richtxtNot.Size = new System.Drawing.Size(434, 588);
            this.richtxtNot.TabIndex = 8;
            this.richtxtNot.Text = "Metin Giriniz.";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(572, 18);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(210, 35);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Notu Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnMetinsil
            // 
            this.btnMetinsil.Location = new System.Drawing.Point(788, 634);
            this.btnMetinsil.Name = "btnMetinsil";
            this.btnMetinsil.Size = new System.Drawing.Size(440, 35);
            this.btnMetinsil.TabIndex = 10;
            this.btnMetinsil.Text = "Metni Temizle";
            this.btnMetinsil.UseVisualStyleBackColor = true;
            this.btnMetinsil.Click += new System.EventHandler(this.BtnMetinsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 11;
            this.label1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richtxtNot);
            this.groupBox2.Location = new System.Drawing.Point(788, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 616);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Oluştur";
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            this.ıDDataGridViewTextBoxColumn.Width = 51;
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
            // Frmdosyaislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1240, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNotgetir);
            this.Controls.Add(this.btnMetinsil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnExcelaktar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frmdosyaislemleri";
            this.Text = "Dosya İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmdosyaislemleri_FormClosed);
            this.Load += new System.EventHandler(this.Frmdosyaislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyladevdataset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridKitaplar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcelaktar;
        private System.Windows.Forms.Button btnNotgetir;
        private System.Windows.Forms.RichTextBox richtxtNot;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnMetinsil;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private kyladevdataset kyladevdataset;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private kyladevdatasetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayıneviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn türDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahibiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}