using Microsoft.Win32;
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

namespace Ahmet.Framework07.Regs
{
    public partial class Lisanslama : Form
    {
        public Lisanslama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k1 = 0, k2 = 0, k3 = 0, k4 = 0;
            k1 = Convert.ToInt32(textBox1.Text);
            k2=Convert.ToInt32(textBox2.Text);
            k3=Convert.ToInt32(textBox3.Text);
            k4=Convert.ToInt32(textBox4.Text);

            if (k1==k3&&k2==k4)
            {
                Lisans liss = new Lisans();
                liss.K1 = k1;
                liss.K2 = k2;
                liss.K3 = k3;
                liss.K4 = k4;
                liss.KullaniciAdi = txt_KADI.Text;
                liss.Olusturma = DateTime.Now;
MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, liss);

                RegistryKey soft = Registry.CurrentUser.OpenSubKey("Software", true);
              RegistryKey orn1=  soft.OpenSubKey("Ornek1",true);
                if (orn1==null)
                {
                 orn1=   soft.CreateSubKey("Ornek1");
                }
                RegistryKey surum = orn1.CreateSubKey("sonSurum");
                ms.Position = 0;
                
                //StreamReader ILE DEGIL  ms.Read ile OLMASI GEREK HATA VAR
                StreamReader reader = new StreamReader(ms);
                string deger = reader.ReadToEnd();
                surum.SetValue("versiyon", deger);

                DialogResult = DialogResult.OK;
                
                
            }
        }
    }
}
