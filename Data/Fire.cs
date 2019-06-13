using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paractika.Win.UI.Data
{
   public class Fire
    {
        public int ID { get; set; }
        public Person Person { get; set; }
        public int PersonID { get; set; }
        public byte Bal { get; set; }
        public DateTime AddedTime { get; set; }
        public decimal Money { get; set; }
    }
}
