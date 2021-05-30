using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelMüsteriSistem
{
    public partial class Admin : Form
    {
        string zaman;
        public Admin()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDuyuruEkle_Click(object sender, EventArgs e)
        {
            AdminDuyuruEkle frm = new AdminDuyuruEkle();
            frm.ShowDialog();
        }

        private void btnMenuYemekEkle_Click(object sender, EventArgs e)
        {
            AdminYemekEkle frm = new AdminYemekEkle();
            frm.ShowDialog();
        }

        private void btnMusterilerAyrinti_Click(object sender, EventArgs e)
        {
            AdminMusteriler frm = new AdminMusteriler();
            frm.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

            string ay = DateTime.Now.Month.ToString();
            string yil = DateTime.Now.Year.ToString();
            zaman = ay + "-" + yil;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            timer.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
