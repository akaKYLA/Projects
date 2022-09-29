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
    public partial class frmbooklist : Form
    {
        public frmbooklist()
        {
            InitializeComponent();
        }

        string secilenid;
        string secilenid2;

        sqlbaglanti bgl = new sqlbaglanti();

        private void booklist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kyladevdataset.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.kyladevdataset.Kullanici);
            // TODO: This line of code loads data into the 'kyladevdataset.Emanet' table. You can move, or remove it, as needed.
            this.emanetTableAdapter.Fill(this.kyladevdataset.Emanet);
            // TODO: This line of code loads data into the 'kyladevdataset.Kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter.Fill(this.kyladevdataset.Kitap);
        }

        DateTime bugün = DateTime.Now;

        private void temizle()
        {
            txtAra.Text = "";
            txtKitapAd.Text = "";
            txtYayınevi.Text = "";
            txtYazar.Text = "";
            txtKonum.Text = "";
            txtTür.Text = "";
            cmbsahib.Text = "";
            txtoduncadsoyad.Text = "";
        }

        private Boolean secilikitapsorgu()
        {
            if (txtKitapAd.Text != "" && txtYayınevi.Text != "" && txtYazar.Text != "" && txtKonum.Text != "" && txtTür.Text != "" && cmbsahib.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgridbooklist.SelectedCells[0].RowIndex;
            secilenid = dgridbooklist.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dgridbooklist.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dgridbooklist.Rows[secilen].Cells[2].Value.ToString();
            txtYayınevi.Text = dgridbooklist.Rows[secilen].Cells[3].Value.ToString();
            txtTür.Text = dgridbooklist.Rows[secilen].Cells[4].Value.ToString();
            cmbsahib.Text = dgridbooklist.Rows[secilen].Cells[5].Value.ToString();
            txtKonum.Text = dgridbooklist.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilikitapsorgu() == true)
            {
                if (MessageBox.Show("Seçili Kitabı Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete From Kitap Where ID=@p1", bgl.baglanti());
                    sil.Parameters.AddWithValue("@p1", secilenid);
                    sil.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    this.kitapTableAdapter.Fill(this.kyladevdataset.Kitap);
                    temizle();
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı seçiniz.");
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (secilikitapsorgu() == true)
            {
                SqlCommand güncelle = new SqlCommand("Update Kitap Set Ad=@Ad,Yazar=@Yazar,Yayınevi=@Yayınevi,Tür=@Tür,Sahibi=@Sahibi,Konum=@Konum where ID=@secid", bgl.baglanti());
                güncelle.Parameters.AddWithValue("@secid", secilenid);
                güncelle.Parameters.AddWithValue("@Ad", txtKitapAd.Text);
                güncelle.Parameters.AddWithValue("@Yazar", txtYazar.Text);
                güncelle.Parameters.AddWithValue("@Yayınevi", txtYayınevi.Text);
                güncelle.Parameters.AddWithValue("@Tür", txtTür.Text);
                güncelle.Parameters.AddWithValue("@Sahibi", cmbsahib.Text);
                güncelle.Parameters.AddWithValue("@Konum", txtKonum.Text);
                güncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellenmiştir.");
                this.kitapTableAdapter.Fill(this.kyladevdataset.Kitap);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen kitap seçtiğinizden ve ilgili alanların hepsinin dolu olduğundan emin olunuz.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secilikitapsorgu() == true && txtoduncadsoyad.Text != "" && txtoduncadsoyad.Text != "Kime ?")
            {
                if (MessageBox.Show("Seçili kitabı ödünç vermek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand emanet = new SqlCommand("insert into Emanet(Ad,Yazar,Yayınevi,Kimden,Kime,Tarih,Tür) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7) ", bgl.baglanti());
                    emanet.Parameters.AddWithValue("@p1", txtKitapAd.Text);
                    emanet.Parameters.AddWithValue("@p2", txtYazar.Text);
                    emanet.Parameters.AddWithValue("@p3", txtYayınevi.Text);
                    emanet.Parameters.AddWithValue("@p4", cmbsahib.Text);
                    emanet.Parameters.AddWithValue("@p5", txtoduncadsoyad.Text);
                    emanet.Parameters.AddWithValue("@p6", bugün);
                    emanet.Parameters.AddWithValue("@p7", txtTür.Text);
                    emanet.ExecuteNonQuery();
                    SqlCommand eksilt = new SqlCommand("Delete From Kitap Where ID=@p1", bgl.baglanti());
                    eksilt.Parameters.AddWithValue("@p1", secilenid);
                    eksilt.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Ödünç verme işlemi başarı ile tamamlandı.");
                    txtoduncadsoyad.Text = "";
                    temizle();
                    this.kitapTableAdapter.Fill(this.kyladevdataset.Kitap);
                    this.emanetTableAdapter.Fill(this.kyladevdataset.Emanet);

                }
            }
            else
            {
                MessageBox.Show("Lütfen kitap seçtiğinizden ve ödünç verilecek kişiyi girdiğinizden emin olunuz.");
            }
        }

        private void btniade_Click(object sender, EventArgs e)
        {
            if (txtEmanetad.Text != "" && txtEmanetyazar.Text != "" && txtiadekonum.Text != "" && txtiadekonum.Text != "YENI KONUM GIRINIZ.")
            {
                SqlCommand iade = new SqlCommand("insert into Kitap(Ad,Yazar,Yayınevi,Tür,Sahibi,Konum,Tarih) values(@Ad,@Yazar,@Yayınevi,@Tür,@Sahibi,@Konum,@Tarih) ", bgl.baglanti());
                iade.Parameters.AddWithValue("@Ad", txtEmanetad.Text);
                iade.Parameters.AddWithValue("@Yazar", txtEmanetyazar.Text);
                iade.Parameters.AddWithValue("@Yayınevi", txtEmanetyayın.Text);
                iade.Parameters.AddWithValue("@Tür", txtemtur.Text);
                iade.Parameters.AddWithValue("@Sahibi", cmbKimden.Text);
                iade.Parameters.AddWithValue("@Konum", txtiadekonum.Text);
                iade.Parameters.AddWithValue("@Tarih", bugün);
                iade.ExecuteNonQuery();
                MessageBox.Show("İade işlemi başarı ile tamamlandı.");

                SqlCommand oduncsil = new SqlCommand("Delete From Emanet Where id=@p1", bgl.baglanti());
                oduncsil.Parameters.AddWithValue("@p1", secilenid2);
                oduncsil.ExecuteNonQuery();
                bgl.baglanti().Close();

                this.kitapTableAdapter.Fill(this.kyladevdataset.Kitap);
                this.emanetTableAdapter.Fill(this.kyladevdataset.Emanet);

                txtEmanetad.Text = "";
                txtEmanettarih.Text = "";
                txtEmanetyayın.Text = "";
                txtEmanetyazar.Text = "";
                txtemtur.Text = "";
                txtKime.Text = "";
                cmbKimden.Text = "";
                txtEmanettarih.Text = "";
                txtiadekonum.Text = "YENI KONUM GIRINIZ.";
            }
            else
            {
                MessageBox.Show("Lütfen iade alınacak kitabı seçtiğinizden ve yeni konumu girdiğinizden emin olunuz.");
            }

        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
         {
             int secilen2 = dgridodunclist.SelectedCells[0].RowIndex;
             secilenid2 = dgridodunclist.Rows[secilen2].Cells[0].Value.ToString();
             txtEmanetad.Text = dgridodunclist.Rows[secilen2].Cells[1].Value.ToString();
             txtEmanetyazar.Text = dgridodunclist.Rows[secilen2].Cells[2].Value.ToString();
             txtEmanetyayın.Text = dgridodunclist.Rows[secilen2].Cells[3].Value.ToString();
             txtemtur.Text = dgridodunclist.Rows[secilen2].Cells[4].Value.ToString();
             cmbKimden.Text = dgridodunclist.Rows[secilen2].Cells[5].Value.ToString();
             txtKime.Text = dgridodunclist.Rows[secilen2].Cells[6].Value.ToString();
             txtEmanettarih.Text = dgridodunclist.Rows[secilen2].Cells[7].Value.ToString();
         }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmkitapekle fr = new frmkitapekle();
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
        }

        private void frmbooklist_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa frm = new frmAnasayfa();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void txtoduncadsoyad_Enter(object sender, EventArgs e)
        {
            txtoduncadsoyad.Text = "";
        }

        private void txtiadekonum_Enter(object sender, EventArgs e)
        {
            txtiadekonum.Text = "";
        }
        private void frmbooklist_Activated(object sender, EventArgs e)
        {
            this.emanetTableAdapter.Fill(this.kyladevdataset.Emanet);
            this.kitapTableAdapter.Fill(this.kyladevdataset.Kitap);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            using (SqlCommand komut = new SqlCommand("Select * from Kitap where Ad like '%" + txtAra.Text + "%' or Yazar like '%" + txtAra.Text + "%' ", bgl.baglanti()))
            {
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgridbooklist.DataSource = ds.Tables[0];
            }

            bgl.baglanti().Close();
        }
    }
}
