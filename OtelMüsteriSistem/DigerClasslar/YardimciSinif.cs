using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelMüsteriSistem
{
    public static class YardimciSinif
    {
        public static bool stringKontrol(params string[] strings)
        {
            bool sonuc = true;

            for (int i = 0; i < strings.Length; i++)
            {
                foreach (char item in strings[i])
                {
                    if (Char.IsNumber(item) == true)
                    {
                        sonuc = false;
                        break;
                    }
                }
            }

            return sonuc;
        }

        public static bool sayiKontrol(params string[] sayilar)
        {
            bool sonuc = true;

            for (int i = 0; i < sayilar.Length; i++)
            {
                foreach (char item in sayilar[i])
                {
                    if (Char.IsNumber(item) == false)
                    {
                        sonuc = false;
                        break;
                    }
                }
            }

            return sonuc;
        }

        public static string boslukKaldir(string veri)
        {
            List<char> dizi = veri.ToList();

            for (int i = 0; i < dizi.Count; i++)
            {
                if (dizi[i] == ' ')
                {
                    dizi.Remove(dizi[i]);
                }
            }

            return dizi.ToString();
        }

        public static void LogOut()
        {
             Application.Exit();
        }

    }
}
