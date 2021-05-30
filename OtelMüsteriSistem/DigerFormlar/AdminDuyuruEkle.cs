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
    public partial class AdminDuyuruEkle : Form
    {
        public AdminDuyuruEkle()
        {
            InitializeComponent();
        }
        private void AdminDuyuruEkle_Load(object sender, EventArgs e)
        {
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");

        private void btnDuyuruEkle_Click(object sender, EventArgs e)
        {
            Duyuru duyuru = new Duyuru();

            duyuru.duyuruBaslik = TxtDuyuruBaslik.Text;
            duyuru.duyuruIcerik = txtDuyuruIcerik.Text;

            if (duyuru.boslukKontrol() == true)
            {
                if (YardimciSinif.stringKontrol(duyuru.duyuruBaslik, duyuru.duyuruIcerik) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    SQLiteCommand komutKaydet = new SQLiteCommand("insert into Duyuru(Baslik,Icerik) values(@p1,@p2)", con);
                    komutKaydet.Parameters.AddWithValue("@p1", duyuru.duyuruBaslik);
                    komutKaydet.Parameters.AddWithValue("@p2", duyuru.duyuruIcerik);

                    komutKaydet.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Duyuru Ekleme islemi gerceklestirildi..", "Duyuru Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
