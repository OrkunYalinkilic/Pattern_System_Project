using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelMüsteriSistem
{
    public interface ILoginTuru
    {
        void LogIn(Musteri musteri);
        void LogIn(Yonetici kullanici);
    }
}
