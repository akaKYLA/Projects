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
    public partial class frmkitapekle : Form
    {
        public frmkitapekle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void frmkitapekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kyladevdataset.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.kyladevdataset.Kullanici);
            SqlCommand cmd = new SqlCommand("Select * from Kullanici", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            cmbsahib.DataSource = ds.Tables[0];
            cmbsahib.DisplayMember = "AdSoyad";
            cmbsahib.ValueMember = "TC";
        }

        readonly DateTime bugün = DateTime.Now;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKitapAd.Text != "" && txtKonum.Text != "" && txtTür.Text != "" && txtYayınevi.Text != "" && txtYazar.Text != "" && cmbsahib.Text!= "")
            {
                SqlCommand ekle = new SqlCommand("insert into Kitap(Ad,Yazar,Yayınevi,Tür,Sahibi,Konum,Tarih) values(@Ad,@Yazar,@Yayınevi,@Tür,@Sahibi,@Konum,@Tarih) ", bgl.baglanti());
                ekle.Parameters.AddWithValue("@Ad", txtKitapAd.Text);
                ekle.Parameters.AddWithValue("@Yazar", txtYazar.Text);
                ekle.Parameters.AddWithValue("@Yayınevi", txtYayınevi.Text);
                ekle.Parameters.AddWithValue("@Tür", txtTür.Text);
                ekle.Parameters.AddWithValue("@Sahibi", cmbsahib.Text);
                ekle.Parameters.AddWithValue("@Konum", txtKonum.Text);
                ekle.Parameters.AddWithValue("@Tarih", bugün);
                ekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt işlemi başarı ile tamamlandı.");
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen eklenecek kitabın tüm bilgilerini giriniz.");
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
