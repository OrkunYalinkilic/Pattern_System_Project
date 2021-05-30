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
    public partial class MusteriBilgiGuncelleme : Form
    {
        Musteri aktifMusteri;
        public MusteriBilgiGuncelleme(Musteri _aktifMusteri)
        {
            aktifMusteri = _aktifMusteri;
            InitializeComponent();
        }
        private void MusteriBilgiGuncelleme_Load(object sender, EventArgs e)
        {
            TxtAdGuncel.Text = aktifMusteri.adi;
            txtKullaniciAdiGuncel.Text = aktifMusteri.kullaniciAdi;
            TxtSoyadGuncel.Text = aktifMusteri.soyadi;
            MskKullaniciTcGuncel.Text = aktifMusteri.tcKimlikNo;
            MskKullaniciTelefonGuncel.Text = aktifMusteri.cepTelefonNumara;
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");

        private void BtnBilgiGuncelleme_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.adi = TxtAdGuncel.Text;
            musteri.soyadi = TxtSoyadGuncel.Text;
            musteri.tcKimlikNo = MskKullaniciTcGuncel.Text;
            musteri.cepTelefonNumara = MskKullaniciTelefonGuncel.Text;
            musteri.kullaniciAdi = txtKullaniciAdiGuncel.Text;

            if (!String.IsNullOrEmpty(musteri.adi) && !String.IsNullOrEmpty(musteri.soyadi) && !String.IsNullOrEmpty(MskKullaniciTcGuncel.Text)
            && !String.IsNullOrEmpty(MskKullaniciTelefonGuncel.Text) && !String.IsNullOrEmpty(txtKullaniciAdiGuncel.Text))
            {
                if (YardimciSinif.stringKontrol(musteri.adi, musteri.soyadi) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    SQLiteCommand komut = new SQLiteCommand("update Kullanici set Adi=@p1, Soyadi=@p2, TcKimlikNumarasi=@p3, CepNumarasi=@p4, KullaniciAdi=@p5  where KullaniciID=@p6", con);
                    komut.Parameters.AddWithValue("@p1", TxtAdGuncel.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSoyadGuncel.Text);
                    komut.Parameters.AddWithValue("@p3", MskKullaniciTcGuncel.Text);
                    komut.Parameters.AddWithValue("@p4", MskKullaniciTelefonGuncel.Text);
                    komut.Parameters.AddWithValue("@p5", txtKullaniciAdiGuncel.Text);
                    komut.Parameters.AddWithValue("@p6", aktifMusteri.kullaniciID);

                    komut.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        RemoteControl remoteControl = new RemoteControl();
        // Komut Tasarım desenini kullandığım alandır.  Debug kısmında yazılacakları her onay durumunda 
        // kontrol etmek için global olarak oluşturdum. Butonların click eventlerinin son kısımlarında
        // ise remoteControl fonksiyonlarını kullandım.

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Hesabınız kalıcı olarak kapatılsın mı?", "Hesap Kapatma Onay", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                con.Open();
                SQLiteCommand komutBilet = new SQLiteCommand("DELETE FROM Kullanici WHERE KullaniciID=@p1", con);
                komutBilet.Parameters.AddWithValue("@p1", aktifMusteri.kullaniciID.ToString());
                komutBilet.ExecuteNonQuery();
                con.Close();

                KullaniciIptalOnay redKullaniciOnay = (KullaniciIptalOnay)new Musteri();  // Dekoratör Desen kullandığım alandır. 
                redKullaniciOnay.IptalOnayMesajBildir();  // Dekoratör Desen kullandığım alandır. 

                remoteControl.remoteExecute();  // Komut tasarim Deseni kullanığım alandır.
                remoteControl.setDebugMessageOnay(new KullaniciIptalOnay()); // Komut tasarim Deseni kullanığım alandır.

            }
            else
            {
                KullaniciIptalRed redKullaniciIptal = (KullaniciIptalRed)new Musteri();  // Dekoratör Desen kullandığım alandır. 
                redKullaniciIptal.IptalRedMesajBildir(); // Dekoratör Desen kullandığım alandır. 

                remoteControl.remoteExecute(); // Komut tasarim Deseni kullanığım alandır.
                remoteControl.setDebugMessageRed(new KullaniciIptalRed()); // Komut tasarim Deseni kullanığım alandır.
            }
        }
    }
}