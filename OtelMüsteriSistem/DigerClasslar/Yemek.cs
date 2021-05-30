using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelMüsteriSistem
{
    public class Yemek
    {
        public int yemekID { get; set; }
        public string ogun { get; set; }
        public string tarih { get; set; }
        public string cesit1 { get; set; }
        public string cesit2 { get; set; }
        public string cesit3 { get; set; }

        public Yemek()
        {
        }

        public Yemek(string ogun, string tarih, string cesit1, string cesit2, string cesit3)
        {
            this.ogun = ogun;
            this.tarih = tarih;
            this.cesit1 = cesit1;
            this.cesit2 = cesit2;
            this.cesit3 = cesit3;
        }

        public Yemek(int yemekID, string ogun, string tarih, string cesit1, string cesit2,string cesit3)
        {
            this.yemekID = yemekID;
            this.ogun = ogun;
            this.tarih = tarih;
            this.cesit1 = cesit1;
            this.cesit2 = cesit2;
            this.cesit3 = cesit3;
        }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(ogun) == true ||
                string.IsNullOrEmpty(tarih) == true||
                string.IsNullOrEmpty(cesit1) == true||
                string.IsNullOrEmpty(cesit2) == true||
                string.IsNullOrEmpty(cesit3) == true)
            {
                return false;
            }
            return true;
        }
    }
}
