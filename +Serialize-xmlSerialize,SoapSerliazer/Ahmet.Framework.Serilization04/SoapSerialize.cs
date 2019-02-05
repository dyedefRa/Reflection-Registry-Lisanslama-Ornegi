using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ahmet.Framework.Serilization04
{
    public partial class SoapSerialize : Form
    {
        public SoapSerialize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemurForSoap mf = new MemurForSoap { Adi = "HASAN", Soyadi = "SABBAH", KamuNo = 124, DogumTarihi = DateTime.Now.AddYears(-7) };
       

            SoapFormatter sf = new SoapFormatter();
            FileStream fs = new FileStream("goodByMF.asmx", FileMode.OpenOrCreate);
            sf.Serialize(fs, mf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoapFormatter sf = new SoapFormatter();
            FileStream fs = new FileStream("goodByMF.asmx", FileMode.Open);
            MemurForSoap gelen=(MemurForSoap)sf.Deserialize(fs);
        }
    }
}
