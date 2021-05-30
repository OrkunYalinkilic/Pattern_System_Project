using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelMüsteriSistem
{
    public class LoginTuruDisplay : ILoginTuru
    {
        public void LogIn(Musteri musteri)
        {
            musteri.LogIn(musteri);
        }

        public void LogIn(Yonetici kullanici)
        {
            Admin frm = new Admin();
            frm.ShowDialog();
        }
    }
}
