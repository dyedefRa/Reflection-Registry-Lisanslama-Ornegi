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

namespace UDEMY.CSV__VIRGULLE_AYRILMIS_XMLLER_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Musteri> musterilerim = new List<Musteri>();

            for (int i = 0; i < 50; i++)
            {
                Musteri temp = new Musteri();
                temp.ID = i;
                temp.Adi = FakeData.NameData.GetFirstName();
                temp.Soyadi = FakeData.NameData.GetSurname();
                temp.Email = $"{temp.Adi}.{temp.Soyadi}@{FakeData.NetworkData.GetDomain()}";

                temp.Tel = FakeData.PhoneNumberData.GetPhoneNumber();
                musterilerim.Add(temp);
            
            }


            if (!Directory.Exists("D:\\CSV\\Dosyam"))
            {
                Directory.CreateDirectory("D:\\CSV\\Dosyam");
            }
            StreamWriter sw = new StreamWriter("D:\\CSV\\Dosyam\\yeni",true);
           
            CsvHelper.CsvWriter writer = new CsvHelper.CsvWriter(sw);
            writer.WriteHeader(typeof(Musteri));

            foreach (Musteri item in musterilerim)
            {
                writer.WriteRecord(item);
            }
            sw.Close();

            MessageBox.Show("Tamamlandı");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
