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
    public partial class dbToXMLser : Form
    {
        public dbToXMLser()
        {
            InitializeComponent();
        }
        CTXDataContext ctx = new CTXDataContext();
        private void button1_Click(object sender, EventArgs e)
        {

            List<Product> urunlerListesi = ctx.Products.ToList();
            XmlSerializer xmlSeri = new XmlSerializer(typeof(List<Product>));
            FileStream fs = new FileStream("urunler.xml", FileMode.OpenOrCreate);
            xmlSeri.Serialize(fs, urunlerListesi);
            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("urunler.xml", FileMode.Open);
            XmlSerializer seri = new XmlSerializer(typeof(List<Product>));
            List<Product> pro = (List<Product>)seri.Deserialize(fs);
        }
    }
}
