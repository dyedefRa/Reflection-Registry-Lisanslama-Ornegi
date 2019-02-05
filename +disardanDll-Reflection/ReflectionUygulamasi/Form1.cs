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

namespace ReflectionUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text)) 
            {
                textBox1.BackColor = Color.White;
                Type T = Type.GetType(textBox1.Text);
                if(T!=null)
                {
                    Temizle();
                    CTORS(T);
                    PropGetir(T);
                    METH(T);
                }
                else

                {
                    MessageBox.Show($"'{textBox1.Text}' adli sinif bulunamadı...", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgi almak istediğiniz sınıfın tam adını giriniz","Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Information );
                textBox1.BackColor = Color.Yellow;
            }
        }

        private void METH(Type T)
        {
             MethodInfo[] MTI= T.GetMethods();

            for (int i = 0; i < MTI.Length; i++)
            {
                listBox3.Items.Add($"{MTI[i].ReturnType.Name} - {MTI[i].Name}");
            }
        }

        private void CTORS(Type T)
        {

            ConstructorInfo [] RV= T.GetConstructors();


            foreach (var item in RV)
            {
                listBox1.Items.Add(item.ToString());
            }
          }
        private void PropGetir(Type T)
        {

            PropertyInfo [] Prop= T.GetProperties();
            foreach (var item in Prop)
            {
                listBox2.Items.Add(item.Name);
            }
        }

        private void Temizle()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
    }
}
