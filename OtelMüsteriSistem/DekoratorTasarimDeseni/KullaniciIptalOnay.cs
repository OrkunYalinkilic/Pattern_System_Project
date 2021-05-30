using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelMüsteriSistem
{
    public class KullaniciIptalOnay : Musteri
    {
        public Musteri musteri;

        public void IptalOnayMesajBildir()
        {
            MessageBox.Show("Kullanıcı hesabınız kapanmıştır.\n.",
                "Hesap İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public KullaniciIptalOnay()
        {
        }

        public KullaniciIptalOnay(Musteri _musteri)
        {
            this.musteri = _musteri;
            KullanıcıHesapIptalEdildi();
        }

        public void KullanıcıHesapIptalEdildi()
        {
            Debug.WriteLine("Kullanıcı Hesabı İptal Edildi");
        }

    }
}
