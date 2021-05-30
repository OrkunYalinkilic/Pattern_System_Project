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
    public partial class AdminYemekEkle : Form
    {
        public AdminYemekEkle()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            Yemek yemek = new Yemek();
            yemek.ogun = TxtYemekOgunu.Text;
            yemek.tarih = TxtTarih.Text;
            yemek.cesit1 = txtYemekCesit1.Text;
            yemek.cesit2 = txtYemekCesit2.Text;
            yemek.cesit3 = txtYemekCesit3.Text;

            if (yemek.boslukKontrol() == true)
            {
                if (YardimciSinif.stringKontrol(yemek.ogun, yemek.cesit1,yemek.cesit2,yemek.cesit3) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    SQLiteCommand komutKaydet = new SQLiteCommand("insert into Yemek(Ogun,Tarih,Cesit1,Cesit2,Cesit3) VALUES(@p1,@p2,@p3,@p4,@p5)", con);
                    komutKaydet.Parameters.AddWithValue("@p1", yemek.ogun);
                    komutKaydet.Parameters.AddWithValue("@p2", yemek.tarih);
                    komutKaydet.Parameters.AddWithValue("@p3", yemek.cesit1);
                    komutKaydet.Parameters.AddWithValue("@p4", yemek.cesit2);
                    komutKaydet.Parameters.AddWithValue("@p5", yemek.cesit3);

                    komutKaydet.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Yemek Ekleme islemi gerceklestirildi..", "Duyuru Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminYemekEkle_Load(object sender, EventArgs e)
        {
        }
    }
}
