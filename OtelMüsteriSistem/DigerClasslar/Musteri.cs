using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelMüsteriSistem
{

    public class Musteri
    {
        public int kullaniciID { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string cepTelefonNumara { get; set; }
        public string tcKimlikNo { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        public Musteri()
        {
        }

        public Musteri(string adi, string soyadi, string cepTelefonNumara, string tcKimlikNo, string kullaniciAdi, string sifre)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.cepTelefonNumara = cepTelefonNumara;
            this.tcKimlikNo = tcKimlikNo;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
        }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(adi) == true ||
                string.IsNullOrEmpty(soyadi) == true ||
                string.IsNullOrEmpty(cepTelefonNumara) == true ||
                string.IsNullOrEmpty(tcKimlikNo) == true ||
                string.IsNullOrEmpty(kullaniciAdi) == true ||
                string.IsNullOrEmpty(sifre) == true)
            {
                return false;
            }

            return true;
        }


        public bool LogIn(Musteri aktifMusteri)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");
            con.Open();
            SQLiteCommand komut = new SQLiteCommand("select *from Kullanici where KullaniciAdi=@p1 and Sifre=@p2", con);
            komut.Parameters.AddWithValue("@p1", this.kullaniciAdi);
            komut.Parameters.AddWithValue("@p2", this.sifre);
            SQLiteDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                Musteri aktifKul = new Musteri();
                aktifKul.kullaniciID = int.Parse(oku[0].ToString());
                aktifKul.adi = oku[1].ToString();
                aktifKul.soyadi = oku[2].ToString();
                aktifKul.tcKimlikNo = oku[3].ToString();
                aktifKul.cepTelefonNumara = oku[4].ToString();
                aktifKul.kullaniciAdi = oku[5].ToString();
                aktifKul.sifre = oku[6].ToString();

                MusteriAnaSayfa frm = new MusteriAnaSayfa(aktifKul);
                frm.ShowDialog();

                return true;
            }
            con.Close();
            return false;

        }

        public void LogOut()
        {
            Application.Exit();
        }
    }

}
