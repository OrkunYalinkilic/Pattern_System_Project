using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelMüsteriSistem
{
    public class RemoteControl
    {
        KullaniciIptalOnay iptalOnay;
        KullaniciIptalRed iptalRed;
        public void setDebugMessageOnay(KullaniciIptalOnay iptalOnay)
        {
            this.iptalOnay = iptalOnay;
        }
        public void setDebugMessageRed(KullaniciIptalRed iptalRed)
        {
            this.iptalRed = iptalRed;
        }
        public void remoteExecute()
        {
            Debug.WriteLine("Remote Control Calisti.");
        }
    }
}
