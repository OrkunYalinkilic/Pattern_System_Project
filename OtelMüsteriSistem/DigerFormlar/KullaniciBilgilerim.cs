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
    public partial class KullaniciBilgilerim : Form
    {
        Musteri aktifMusteri;
        public KullaniciBilgilerim(Musteri _aktifMusteri)
        {
            aktifMusteri = _aktifMusteri;
            InitializeComponent();
        }

        private void KullaniciBilgilerim_Load(object sender, EventArgs e)
        {
            labelAdiniz.Text = aktifMusteri.adi;
            labelSoyadiniz.Text = aktifMusteri.soyadi;
            labelCepNo.Text = aktifMusteri.cepTelefonNumara;
            labelTckimlik.Text = aktifMusteri.tcKimlikNo;
            labelKullaniciAdiniz.Text = aktifMusteri.kullaniciAdi;
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            MusteriBilgiGuncelleme frm = new MusteriBilgiGuncelleme(aktifMusteri);
            frm.ShowDialog();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            MusteriSifreGuncelleme frm = new MusteriSifreGuncelleme(aktifMusteri);
            frm.ShowDialog();
        }
    }
}
