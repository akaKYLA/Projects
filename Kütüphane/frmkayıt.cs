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
    public partial class frmkayıt : Form
    {
        sqlbaglanti bgl = new sqlbaglanti();
        public frmkayıt()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (mskTc.Text.Length == 11 && mskTc.Text != "" && txtAdsoyad.Text != "" && txtYas.Text != "" && cmbCinsiyet2.Text != "" && txtMail.Text != "")
            {
                SqlCommand ekle = new SqlCommand("insert into Kullanici(TC,AdSoyad,Yaş,Cinsiyet,Mail) values(@TC,@AdSoyad,@Yaş,@Cinsiyet,@Mail) ", bgl.baglanti());
                ekle.Parameters.AddWithValue("@TC", mskTc.Text);
                ekle.Parameters.AddWithValue("@AdSoyad", txtAdsoyad.Text);
                ekle.Parameters.AddWithValue("@Yaş", txtYas.Text);
                ekle.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet2.Text);
                ekle.Parameters.AddWithValue("@Mail", txtMail.Text);
                ekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurunuz.");
            }
            
            
        }

        private void frmkayıt_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mskTc_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mskTc.Select(0, 0);
            });
        }
    }
}
