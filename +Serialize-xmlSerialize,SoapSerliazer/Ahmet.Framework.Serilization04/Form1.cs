using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmet.Framework.Serilization04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DOSYA YAZMA BUTONU
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci temp = new Ogrenci()
            {
                Adi = "Hasan",
                DogumTarihi = DateTime.Now.AddYears(-8),
                Numara = 190,
                Soyadi = "Soysal"
            };

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("dosyacik", FileMode.OpenOrCreate);
            bf.Serialize(fs, temp);

        }

        //DOSYA OKUMA BUTONU
        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("dosyacik", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Ogrenci okunan =(Ogrenci) bf.Deserialize(fs);
            MessageBox.Show($" Adı ={okunan.Adi}, Soyadi= {okunan.Soyadi} , Num = {okunan.Numara},  DT = {okunan.DogumTarihi}");
        }
    }
}
