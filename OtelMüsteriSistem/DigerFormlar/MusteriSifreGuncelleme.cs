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
    public partial class MusteriSifreGuncelleme : Form
    {
        Musteri aktifMusteri;
        public MusteriSifreGuncelleme(Musteri _aktifMusteri)
        {
            aktifMusteri = _aktifMusteri;
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");

        private void btnSifreYenile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifreYeni.Text) == true || string.IsNullOrEmpty(txtSifreEski.Text) == true || string.IsNullOrEmpty(txtSifreYeniTekrar.Text) == true)
            {
                MessageBox.Show("Değerler boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSifreEski.Text != aktifMusteri.sifre)
                {
                    MessageBox.Show("Girdiğiniz eski şifre YANLIŞ", "Hatalı Şifre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifreEski.Text = string.Empty;
                    txtSifreYeni.Text = string.Empty;
                    txtSifreYeniTekrar.Text = string.Empty;
                }

                else if (txtSifreYeni.Text.Length <= 5)
                {
                    MessageBox.Show("Yeni Şifre 5 karakterden fazla olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!txtSifreYeni.Text.Equals(txtSifreYeniTekrar.Text))
                {
                    MessageBox.Show("Yeni Şifre ve Tekrarı aynı olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    con.Open();
                    SQLiteCommand cmdDegistir = new SQLiteCommand("update Kullanici set Sifre=@p1 where KullaniciID=@p2", con);
                    cmdDegistir.Parameters.AddWithValue("@p1", txtSifreYeni.Text);
                    cmdDegistir.Parameters.AddWithValue("@p2", aktifMusteri.kullaniciID);
                    cmdDegistir.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Şifre değiştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void MusteriSifreGuncelleme_Load(object sender, EventArgs e)
        {
        }
    }
}
