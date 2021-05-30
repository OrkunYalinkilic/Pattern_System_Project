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
    public partial class Duyurular : Form
    {
        Musteri aktifMusteri;
        List<Duyuru> duyurular = new List<Duyuru>();
        Label labelDuyuru;

        public Duyuru gelenDuyuru = new Duyuru();

        public Duyurular(Musteri _aktifMusteri)
        {
            aktifMusteri = _aktifMusteri;
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");

        private void Duyurular_Load(object sender, EventArgs e)
        {
            con.Open();

            SQLiteCommand komut = new SQLiteCommand("select * from Duyuru", con);
            SQLiteDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                Duyuru yeniGelenDuyuru = gelenDuyuru.getClone(); //Prototip Desen kullandığım alandır. 

                yeniGelenDuyuru.duyuruBaslik = oku[1].ToString();
                yeniGelenDuyuru.duyuruIcerik = oku[2].ToString();

                duyurular.Add(yeniGelenDuyuru);
            }

            con.Close();

            for (int i = 0; i < duyurular.Count; i++)
            {
                labelDuyuru = new Label();

                labelDuyuru.AutoSize = true;
                labelDuyuru.BackColor = System.Drawing.SystemColors.Info;
                labelDuyuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                labelDuyuru.Location = new System.Drawing.Point(55, 50);
                labelDuyuru.Name = "label";
                labelDuyuru.Size = new System.Drawing.Size(192, 24);
                labelDuyuru.TabIndex = 0;
                labelDuyuru.Padding = new System.Windows.Forms.Padding(10);
                labelDuyuru.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);

                labelDuyuru.Text = "Duyuru Başlığı: " + duyurular[i].duyuruBaslik + "\n\n" +
                 "Duyuru İçeriği: " + duyurular[i].duyuruIcerik + "\n";

                flowLayoutDuyurular.Controls.Add(labelDuyuru);
            }
        }
    }
}
