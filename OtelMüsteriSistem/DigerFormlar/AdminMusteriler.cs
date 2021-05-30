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
    public partial class AdminMusteriler : Form
    {
        List<Musteri> musteriler = new List<Musteri>();
        Label labelMusteri;
        public AdminMusteriler()
        {
            InitializeComponent();
        }

        private void flowLayoutMusteriler_Paint(object sender, PaintEventArgs e)
        {
        }
        SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");

        private void AdminMusteriler_Load(object sender, EventArgs e)
        {
            con.Open();

            SQLiteCommand komut = new SQLiteCommand("select * from Kullanici", con);
            SQLiteDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                // Klonlama işlemini fiili olarak burada kullandım.
                //Prototip Desen kullandığım alandır. Açıklama kısmında açıkladım.

                Musteri yeniGelenMusteri = new Musteri();

                yeniGelenMusteri.adi = oku[1].ToString();
                yeniGelenMusteri.soyadi = oku[2].ToString();
                yeniGelenMusteri.tcKimlikNo = oku[3].ToString();
                yeniGelenMusteri.cepTelefonNumara = oku[4].ToString();
                yeniGelenMusteri.kullaniciAdi = oku[5].ToString();

                musteriler.Add(yeniGelenMusteri);
            }

            con.Close();

            for (int i = 0; i < musteriler.Count; i++)
            {
                labelMusteri = new Label();

                labelMusteri.AutoSize = true;
                labelMusteri.BackColor = System.Drawing.SystemColors.Info;
                labelMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                labelMusteri.Location = new System.Drawing.Point(55, 50);
                labelMusteri.Name = "label";
                labelMusteri.Size = new System.Drawing.Size(192, 24);
                labelMusteri.TabIndex = 0;
                labelMusteri.Padding = new System.Windows.Forms.Padding(10);
                labelMusteri.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);

                labelMusteri.Text =
                    "Adı: " + musteriler[i].adi + "\n" +
                 "Soyadı: " + musteriler[i].soyadi + "\n" +
                "TC Kimlik Numarası: " + musteriler[i].tcKimlikNo + "\n" +
                "Cep Telefon Numarası: " + musteriler[i].cepTelefonNumara + "\n" +
                "Kullanıcı Adı: " + musteriler[i].kullaniciAdi + "\n";

                flowLayoutMusteriler.Controls.Add(labelMusteri);
            }
        }
    }
}
