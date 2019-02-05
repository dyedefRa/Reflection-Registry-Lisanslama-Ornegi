using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionUygulamasi
{
    public  class Musteri
    {

        public Guid ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public int CariNumarasi { get; set; }

        public Musteri()
        {

        }

        public Musteri(Guid id, int carinumarasi)
        {
            this.ID = id;
            this.CariNumarasi = carinumarasi;
        }

        public Musteri(Guid id, int carinumarasi, string isim, string soyisim)
        {
            this.ID = id;
            this.CariNumarasi = carinumarasi;
            this.Adi = isim;
            this.Soyadi = soyisim;
        }

        public void EkranaYaz()
        {
            Console.WriteLine($"{ID.ToString()}   - Cari Numarasi={CariNumarasi.ToString()} - Isim SoyIsim = {Adi + " " + Soyadi}");
        }

        public void CariNoGuncelle(int yenicari)
        {
            this.CariNumarasi = yenicari;
        }
    }
}
