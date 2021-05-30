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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            MüsteriKayit frm = new MüsteriKayit();
            frm.ShowDialog();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.kullaniciAdi = txtKullaniciAd.Text;
            musteri.sifre = txtParola.Text;   

            LoginTuruDisplay loginTur = new LoginTuruDisplay();
            // Bu nesneyi ziyaretçi tasarım desenini kullanmak için ILoginTuru interfacesini implement ettiğim
            // LoginTuruDisplay class'ından oluşturdum. Kullanıcı türüne göre farklı bir giriş yapılmış olacak.

            if (string.IsNullOrEmpty(txtKullaniciAd.Text) || string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Lutfen bilgileriniz EKSİKSİZ giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtKullaniciAd.Text == "admin" && txtParola.Text == "admin")
            {
                Yonetici admin = new Yonetici();
                admin.kullaniciAdi = txtKullaniciAd.Text;
                admin.sifre = txtParola.Text;

                loginTur.LogIn(admin); // parametre olarak admin gönderildiği için Admin sayfası açılacak.
            }

            else if (musteri.LogIn(musteri) == false)
            {
                MessageBox.Show("Hatalı Giriş Yapıldı.\n\nLütfen Geçerli Kullanıcı Adı ve Parola Giriniz!\n\nKayıtlı Değilseniz Kayıt Olunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAd.Focus();
            }
            else
            {
                loginTur.LogIn(musteri); // parametre olarak kullanici gönderildiği için Admin sayfası açılacak.
            }

            txtKullaniciAd.Text = string.Empty;
            txtParola.Text = string.Empty;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
