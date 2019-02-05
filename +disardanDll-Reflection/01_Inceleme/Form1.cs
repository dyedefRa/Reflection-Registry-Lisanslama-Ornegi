using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Inceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //C:\Users\Asus\source\repos\UdemyLib\bin\Debug\netstandard2.0


            //DLL I  BU YOLLA PROJEYE  AKTARDIK.
            //BURDAAA LIBRARYDEN DLL DOSTASI ALDIK
            Assembly Library = Assembly.LoadFile(@"C:\Users\Asus\source\repos\UdemyLib\bin\Debug\netstandard2.0\UdemyLib.dll");




            //TYPELERI ALDIK BURDAN SADECE 'MUSTERI' TYPE GELDI 
            Type[] TP=  Library.GetTypes();
            
          

            foreach (Type item in TP)
            {
                ////BIRTANE MUSTERI TYPENI FOREARCH ILE DONDERDIK. VE CONSTRUCTORLARINI ALDIK
                //ConstructorInfo[] CTORS= item.GetConstructors();
              
                //for (int i = 0; i < CTORS.Length; i++)
                //{
                //    MessageBox.Show(CTORS[i].ToString());

                //}




                //// BURDADA PROPRETYLERINI ALALIMM.
                //PropertyInfo [] PRP =item.GetProperties();

                //for (int i = 0; i < PRP.Length; i++)
                //{
                //    MessageBox.Show($"INameSpace={item.Namespace} - Isim ={PRP[i].Name} -  Public = {item.IsPublic}  - Tam Adi= {item.FullName}");
                //}


                //METOD ALALIM

               MethodInfo [] MTI=  item.GetMethods();

                for (int i = 0; i < MTI.Length; i++)
                {
                    MessageBox.Show($"Method Adi = {MTI[i].Name}");
                }

            }




        }
    }
}
