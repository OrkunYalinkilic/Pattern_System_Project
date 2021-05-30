using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelMüsteriSistem
{
    public partial class MüsteriKayit : Form
    {
        public MüsteriKayit()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();

            musteri.adi = TxtAd.Text;
            musteri.soyadi = TxtSoyad.Text;
            musteri.tcKimlikNo = MskKullaniciTc.Text;
            musteri.cepTelefonNumara = MskKullaniciTelefon.Text;
            musteri.kullaniciAdi = txtKullaniciAdi.Text;
            musteri.sifre = txtSifre.Text;

            if (musteri.boslukKontrol() == true)
            {
                if (YardimciSinif.stringKontrol(musteri.adi, musteri.soyadi) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    SQLiteCommand komutKaydet = new SQLiteCommand("insert into Kullanici (Adi,Soyadi,TcKimlikNumarasi,CepNumarasi,KullaniciAdi,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                    komutKaydet.Parameters.AddWithValue("@p1", musteri.adi);
                    komutKaydet.Parameters.AddWithValue("@p2", musteri.soyadi);
                    komutKaydet.Parameters.AddWithValue("@p3", musteri.tcKimlikNo);
                    komutKaydet.Parameters.AddWithValue("@p4", musteri.cepTelefonNumara);
                    komutKaydet.Parameters.AddWithValue("@p5", musteri.kullaniciAdi);
                    komutKaydet.Parameters.AddWithValue("@p6", musteri.sifre);
                    komutKaydet.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayit islemi gerceklestirildi..", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MüsteriKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
