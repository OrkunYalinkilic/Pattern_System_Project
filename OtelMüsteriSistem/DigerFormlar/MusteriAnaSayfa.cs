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
    public partial class MusteriAnaSayfa : Form
    {
        string zaman;
        Timer timer1 = new Timer();
        public Musteri aktifMusteri= new Musteri();
        public MusteriAnaSayfa(Musteri _aktifMusteri)
        {
            aktifMusteri = _aktifMusteri;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string ay = DateTime.Now.Month.ToString();
            string yil = DateTime.Now.Year.ToString();
            zaman = ay + "-" + yil;
        }

        private void btnYemekhaneTakvim_Click(object sender, EventArgs e)
        {
            Yemekhane frm = new Yemekhane();
            frm.ShowDialog();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            Duyurular frm = new Duyurular(aktifMusteri);
            frm.ShowDialog();
        }

        private void btnKullaniciBilgilerim_Click(object sender, EventArgs e)
        {
            KullaniciBilgilerim frm = new KullaniciBilgilerim(aktifMusteri);
            frm.ShowDialog();
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

            string ay = DateTime.Now.Month.ToString();
            string yil = DateTime.Now.Year.ToString();
            zaman = ay + "-" + yil;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MusteriAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
