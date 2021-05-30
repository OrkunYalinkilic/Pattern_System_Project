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
    public partial class Yemekhane : Form
    {
        List<Yemek> yemekler = new List<Yemek>();
        Label labelYemek;
        public Yemekhane()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=OtelSistemDb.db");

        private void Yemekhane_Load(object sender, EventArgs e)
        {
            con.Open();

            SQLiteCommand komut = new SQLiteCommand("select * from Yemek", con);
            SQLiteDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                Yemek yeniGelenYemek = new Yemek();
                yeniGelenYemek.ogun = oku[1].ToString();
                yeniGelenYemek.tarih = oku[2].ToString();
                yeniGelenYemek.cesit1 = oku[3].ToString();
                yeniGelenYemek.cesit2 = oku[4].ToString();
                yeniGelenYemek.cesit3 = oku[5].ToString();

                yemekler.Add(yeniGelenYemek);
            }

            con.Close();

            for (int i = 0; i < yemekler.Count; i++)
            {
                labelYemek = new Label();

                labelYemek.AutoSize = true;
                labelYemek.BackColor = System.Drawing.SystemColors.Info;
                labelYemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                labelYemek.Location = new System.Drawing.Point(55, 50);
                labelYemek.Name = "label";
                labelYemek.Size = new System.Drawing.Size(192, 24);
                labelYemek.TabIndex = 0;
                labelYemek.Padding = new System.Windows.Forms.Padding(10);
                labelYemek.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);

                labelYemek.Text = yemekler[i].ogun.ToUpper() + "\n" +
                    yemekler[i].tarih + "\n" +
                    yemekler[i].cesit1 + "\n" +
                    yemekler[i].cesit2 + "\n" +
                    yemekler[i].cesit3 + "\n";

                flowLayoutYemekhane.Controls.Add(labelYemek);
            }
        }
    }
}
