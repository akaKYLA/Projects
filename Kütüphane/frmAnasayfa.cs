using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmkayıt fr = new frmkayıt ();
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmuserislemleri fr = new frmuserislemleri ();
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmkitapekle fr = new frmkitapekle();
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbooklist fr = new frmbooklist ();
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
            this.Hide();
        }

        private void frmAnasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frmdosyaislemleri frm = new Frmdosyaislemleri();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }
    }
}
