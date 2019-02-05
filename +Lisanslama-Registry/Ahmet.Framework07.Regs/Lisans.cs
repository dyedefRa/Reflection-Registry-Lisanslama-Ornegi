using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmet.Framework07.Regs
{
    [Serializable]
    class Lisans
    {
        public int K1 { get; set; }
        public int K2 { get; set; }
        public int K3 { get; set; }
        public int K4 { get; set; }
        public DateTime Olusturma { get; set; }
        public string KullaniciAdi { get; set; }

    }
}
