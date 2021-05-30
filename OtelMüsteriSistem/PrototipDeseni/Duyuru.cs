using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelMüsteriSistem
{
    public class Duyuru : IDuyuru
    {
        public int duyuruID { get; set; }
        public string duyuruBaslik { get; set; }
        public string duyuruIcerik { get; set; }

        public Duyuru()
        {
        }

        public Duyuru(int duyuruID, string duyuruBaslik, string duyuruIcerik)
        {
            this.duyuruID = duyuruID;
            this.duyuruBaslik = duyuruBaslik;
            this.duyuruIcerik = duyuruIcerik;
        }
        public Duyuru(string duyuruBaslik, string duyuruIcerik)
        {
            this.duyuruBaslik = duyuruBaslik;
            this.duyuruIcerik = duyuruIcerik;
        }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(duyuruBaslik) == true ||
                string.IsNullOrEmpty(duyuruIcerik) == true)
            {
                return false;
            }
            return true;
        }

        IDuyuru IDuyuru.getClone()
        {
            return new Duyuru(duyuruBaslik, duyuruIcerik);
        }

        internal Duyuru getClone()
        {
            return new Duyuru();
        }
    }
}
