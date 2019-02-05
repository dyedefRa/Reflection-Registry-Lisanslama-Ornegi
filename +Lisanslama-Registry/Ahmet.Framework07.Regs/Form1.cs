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
using Microsoft.Win32;

namespace Ahmet.Framework07.Regs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
         {
            RegistryKey dosyam = Registry.CurrentUser.OpenSubKey("Software\\Ornek1\\sonSurum");
            if (dosyam == null)
            {
                MessageBox.Show("Ürünün lisans anahtari gerekli.");
                Lisanslama f2 = new Lisanslama();
                this.Hide();
                f2.Show();
            }
            else
            {
              string lisans= (string) dosyam.GetValue("versiyon");
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                
                StreamWriter sw = new StreamWriter(ms);
                sw.Write(lisans);
                ms.Position = 0;
                Lisans lis = (Lisans)bf.Deserialize(ms);
                if (lis!=null)
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lisans Blok Edildi");
                }
            }

        }
    }
}
