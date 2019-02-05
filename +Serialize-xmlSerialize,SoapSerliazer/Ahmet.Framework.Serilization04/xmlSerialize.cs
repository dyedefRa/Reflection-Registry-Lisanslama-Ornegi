using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ahmet.Framework.Serilization04
{
    public partial class xmlSerialize : Form
    {
        public xmlSerialize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci()
            {
                Adi = "Harun",
                Numara = 190,
                Soyadi = "WUHU",
                DogumTarihi = DateTime.Now.AddYears(-20)

            };
            
            string[] dersler = { "Matematik", "Fizik", "Biyoloji", "Türkçe", "SQL", "C#", "JAVA", "MVC" };
            string[] puanAdlari = { "Vize1", "Vize2", "Final" };
            Random rand = new Random();
            for (int i = 0; i < dersler.Length; i++)
            {
                Ders d = new Ders();
                d.Adi = dersler[i];
                d.Kredi = rand.Next(1, 6);
                for (int j = 0; j < puanAdlari.Length; j++)
                {

                    Puan p = new Puan();
                    p.PuanAdi = puanAdlari[j];
                    p.Puani = rand.Next(10, 101);
                    d.Puanlar.Add(p);
                }

                ogr.Dersler.Add(d);
            }


            //OLAYI BURADAAAAA

            XmlSerializer xml = new XmlSerializer(ogr.GetType());
            FileStream fs = new FileStream("sonnn.xml", FileMode.OpenOrCreate);
            xml.Serialize(fs, ogr);
            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // FileStream fs = new FileStream("ogrenci.xml", FileMode.Open);
           // XmlSerializer seri = new XmlSerializer(typeof(List<Ogrenci>));
           //List<Ogrenci> ogrenciler=(List<Ogrenci>)   seri.Deserialize(fs);
        }
    }
}
