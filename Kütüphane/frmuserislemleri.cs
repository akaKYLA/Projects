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

namespace Kütüphane
{
    public partial class frmuserislemleri : Form
    {
        public frmuserislemleri()
        {
            InitializeComponent();
        }
       //
        private void temizle()
        {
            cmbCinsiyet.Text = "Seçiniz.";
            txtAdsoyad.Text = "";
            txtMail.Text = "";
            txtYas.Text = "";
            mskTc.Text = "";
        }

        private Boolean bosluksorgula()
        {
            if (cmbCinsiyet.Text != "" && txtAdsoyad.Text != "" && txtMail.Text != "" && txtYas.Text != "" && mskTc.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        string tcsecilen;
        sqlbaglanti bgl = new sqlbaglanti();
        
        //
        private void frmuserlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kyladevdataset.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.kyladevdataset.Kullanici);

        }

        private void dgridKullanici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgridKullanici.SelectedCells[0].RowIndex;

            mskTc.Text = dgridKullanici.Rows[secilen].Cells[0].Value.ToString();
            txtAdsoyad.Text = dgridKullanici.Rows[secilen].Cells[1].Value.ToString();
            txtYas.Text = dgridKullanici.Rows[secilen].Cells[2].Value.ToString();
            cmbCinsiyet.Text = dgridKullanici.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dgridKullanici.Rows[secilen].Cells[4].Value.ToString();
            tcsecilen = mskTc.Text;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (bosluksorgula() == true)
            {
                SqlCommand güncelle = new SqlCommand("Update Kullanici Set TC=@TC,Adsoyad=@Adsoyad,Yaş=@Yaş,Cinsiyet=@Cinsiyet,Mail=@Mail where TC=@sectc", bgl.baglanti());
                güncelle.Parameters.AddWithValue("@sectc", tcsecilen);
                güncelle.Parameters.AddWithValue("@TC", mskTc.Text);
                güncelle.Parameters.AddWithValue("@Adsoyad", txtAdsoyad.Text);
                güncelle.Parameters.AddWithValue("@Yaş", txtYas.Text);
                güncelle.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.Text);
                güncelle.Parameters.AddWithValue("@Mail", txtMail.Text);
                güncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellenmiştir.");
                this.kullaniciTableAdapter.Fill(this.kyladevdataset.Kullanici);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olunuz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (bosluksorgula() == true)
            {
                if (MessageBox.Show("Seçili Kullanıcıyı Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete From Kullanici Where TC=@p1", bgl.baglanti());
                    sil.Parameters.AddWithValue("@p1", tcsecilen);
                    sil.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt silindi.");
                    this.kullaniciTableAdapter.Fill(this.kyladevdataset.Kullanici);
                    temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçiniz.");
            }
           
        }

        private void frmuserislemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa frm = new frmAnasayfa();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmkayıt frrm = new frmkayıt();
            frrm.StartPosition = FormStartPosition.CenterScreen;
            frrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.kullaniciTableAdapter.Fill(this.kyladevdataset.Kullanici);
        }

        private void frmuserislemleri_Activated(object sender, EventArgs e)
        {
            this.kullaniciTableAdapter.Fill(this.kyladevdataset.Kullanici);
        }
    }
}
