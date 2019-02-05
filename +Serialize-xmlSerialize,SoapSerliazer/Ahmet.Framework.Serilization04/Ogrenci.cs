using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ahmet.Framework.Serilization04
{
    [Serializable]
 public   class Ogrenci
    {
        public Ogrenci()
        {
            Dersler = new List<Ders>();
        }
        [XmlElement("TCNO")]
        public int Numara { get; set; }
        [XmlElement(ElementName ="LANBUDAYENI adi")]
        public string Adi { get; set; }
       
        [XmlAttribute("merhaba")]
        public string Soyadi { get; set; }
     
        public DateTime DogumTarihi { get; set; }
        public List<Ders> Dersler { get; set; }
    }

    public class Ders
    {
        public Ders()
        {
            Puanlar = new List<Puan>();
        }
        public string Adi { get; set; }
        public int Kredi { get; set; }
        public List<Puan> Puanlar { get; set; }



    }

    public class Puan
    {
        [XmlAttribute("SinavAdi")]
        public string PuanAdi { get; set; }
        [XmlAttribute("AlinanPuan")]
        public double Puani { get; set; }
    }
}
