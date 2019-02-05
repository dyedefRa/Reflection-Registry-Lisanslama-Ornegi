using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace LateBindingIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assembly Exec = Assembly.GetExecutingAssembly();
            Type T = Exec.GetType("LateBindingIslemleri.Musteri");

            object MusteriInstance = Activator.CreateInstance(T);
            MethodInfo MI = T.GetMethod("MusteriIsimGetir");


            string[] Parametrelerim = new string[2];
            Parametrelerim[0] = "Cengiz";
            Parametrelerim[1] = "Atilla";
             string GelenDeger=(string) MI.Invoke(MusteriInstance, Parametrelerim);
            MessageBox.Show(GelenDeger);
        }
    }
}
