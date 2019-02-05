using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmet.Framework.Serilization04
{
    [Serializable]
   public class MemurForSoap
    {
        public string Adi { get; set; }
        public int KamuNo { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
