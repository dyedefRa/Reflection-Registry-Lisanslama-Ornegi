using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kitap.REGISTRY_BOLUMU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RegistryKey appEvents = Registry.CurrentUser.OpenSubKey("AppEvents",true);
            //RegistryKey girili = appEvents.CreateSubKey("yenidosya", true);
            //girili.SetValue("Abowıcerıgı", "1");
            //appEvents.Close();




            //string[] gelenelr = Registry.CurrentUser.GetSubKeyNames();

            //foreach (string item in gelenelr)
            //{
            //    MessageBox.Show(item);
            //}



            RegistryKey AppEventIcerigi = Registry.CurrentUser.OpenSubKey("AppEvents");

            if (AppEventIcerigi.OpenSubKey("yenidosya") != null)
            {

                RegistryKey gelen = AppEventIcerigi.OpenSubKey("yenidosya",true);
              
                gelen.SetValue("Abowıcerıgı", Convert.ToInt32(gelen.GetValue("Abowıcerıgı")) + 1);
                
            }
            else
            {
                RegistryKey icerdeyiz = AppEventIcerigi.CreateSubKey("yenidosya", true);
                icerdeyiz.SetValue("Abowıcerıgı", 1);
            }





        }
    }
}
