namespace Kütüphane
{
    partial class frmkitapekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkitapekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtYayınevi = new System.Windows.Forms.TextBox();
            this.txtTür = new System.Windows.Forms.TextBox();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.cmbsahib = new System.Windows.Forms.ComboBox();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyladevdataset = new Kütüphane.kyladevdataset();
            this.kullaniciTableAdapter = new Kütüphane.kyladevdatasetTableAdapters.KullaniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyladevdataset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayınevi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sahibi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Konum:";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(84, 27);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(242, 26);
            this.txtKitapAd.TabIndex = 1;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(84, 63);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(242, 26);
            this.txtYazar.TabIndex = 2;
            // 
            // txtYayınevi
            // 
            this.txtYayınevi.Location = new System.Drawing.Point(84, 99);
            this.txtYayınevi.Name = "txtYayınevi";
            this.txtYayınevi.Size = new System.Drawing.Size(242, 26);
            this.txtYayınevi.TabIndex = 3;
            // 
            // txtTür
            // 
            this.txtTür.Location = new System.Drawing.Point(84, 135);
            this.txtTür.Name = "txtTür";
            this.txtTür.Size = new System.Drawing.Size(242, 26);
            this.txtTür.TabIndex = 4;
            // 
            // txtKonum
            // 
            this.txtKonum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKonum.Location = new System.Drawing.Point(84, 207);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(242, 26);
            this.txtKonum.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(84, 239);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(108, 39);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(218, 239);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(108, 39);
            this.btnİptal.TabIndex = 8;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // cmbsahib
            // 
            this.cmbsahib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbsahib.DataSource = this.kullaniciBindingSource;
            this.cmbsahib.DisplayMember = "AdSoyad";
            this.cmbsahib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsahib.FormattingEnabled = true;
            this.cmbsahib.Location = new System.Drawing.Point(85, 171);
            this.cmbsahib.Name = "cmbsahib";
            this.cmbsahib.Size = new System.Drawing.Size(241, 27);
            this.cmbsahib.TabIndex = 5;
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
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // frmkitapekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 328);
            this.Controls.Add(this.cmbsahib);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKonum);
            this.Controls.Add(this.txtTür);
            this.Controls.Add(this.txtYayınevi);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmkitapekle";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.frmkitapekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyladevdataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtYayınevi;
        private System.Windows.Forms.TextBox txtTür;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.ComboBox cmbsahib;
        private kyladevdataset kyladevdataset;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private kyladevdatasetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
    }
}