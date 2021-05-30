using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelMüsteriSistem
{
   public class KullaniciIptalRed : Musteri
    {
        public Musteri musteri;

        public void IptalRedMesajBildir()
        {
            MessageBox.Show("Kullanıcı hesabınızın kapatılması iptal edilmiştir.\n.",
                "Hesap Kapanma İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public KullaniciIptalRed()
        {
        }

        public KullaniciIptalRed(Musteri _musteri)
        {
            this.musteri = _musteri;
            KullanıcıHesapIptalEdilmedi();
        }

        public void KullanıcıHesapIptalEdilmedi()
        {
            Debug.WriteLine("Kullanıcı Hesabı İptal Edilmedi");
        }
    }
}
