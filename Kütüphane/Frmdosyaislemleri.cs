using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Kütüphane
{
    public partial class Frmdosyaislemleri : Form
    {
        public Frmdosyaislemleri()
        {
            InitializeComponent();
        }


        private void Frmdosyaislemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kyladevdataset.Kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter.Fill(this.kyladevdataset.Kitap);
        }

        private void Frmdosyaislemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa frm = new frmAnasayfa
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            frm.Show();
        }

        private void BtnMetinsil_Click(object sender, EventArgs e)
        {
            richtxtNot.Text = "";
            label1.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (richtxtNot.Text != "" & richtxtNot.Text != "Metin Giriniz.")
            {
                saveFileDialog1.Filter = "Metin Dosyalar|*.txt";
                saveFileDialog1.Title = "Metin Belgesi Kayıt";
                if (label1.Text !="")
                {
                    saveFileDialog1.FileName = label1.Text;
                }         
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.WriteLine(richtxtNot.Text);
                    sw.Close();
                    MessageBox.Show("Kayıt oluşturuldu");
                    label1.Text ="";
                    richtxtNot.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen metin giriniz.");
            }
            
        }

        private void BtnNotgetir_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                label1.Text = file;
                try
                {
                    richtxtNot.Text = File.ReadAllText(file);
                }
                catch (IOException) { }
                
            }
        }

        private void BtnExcelaktar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                OverwritePrompt = false,
                Title = "Excel Dosyaları",
                DefaultExt = "xlsx",
                Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 1; i < dgridKitaplar.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgridKitaplar.Columns[i - 1].HeaderText;
                    app.Cells[1, i].Font.Bold = true;
                    app.Cells[1, i].Font.Size = 14;
                }
                for (int i = 0; i <= dgridKitaplar.Rows.Count - 1 ; i++)
                {
                    for (int j = 0; j < dgridKitaplar.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgridKitaplar.Rows[i].Cells[j].Value.ToString();
                    }
                }

                worksheet.Columns.AutoFit();
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();   
                
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                    app = null;
                }
                catch (Exception ex)
                {
                    app = null;
                    MessageBox.Show("Hata " + ex.ToString());
                }
                finally
                {
                    GC.Collect();
                }

                MessageBox.Show("Excel dosyayı oluşturuldu.");

            }
        }
        
    }
}
