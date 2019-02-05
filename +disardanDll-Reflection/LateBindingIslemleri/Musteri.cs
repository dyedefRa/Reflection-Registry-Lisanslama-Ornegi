using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingIslemleri
{
    public class Musteri
    {
        public string MusteriIsimGetir(string isim ,string soyisim)
        {
            return $"{isim}{soyisim}";
        }
    }
}
