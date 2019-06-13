using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paractika.Win.UI.Data
{
   public class Identity
    {
        public int ID { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndData { get; set; }
        public bool Depricate { get; set; }
        public ICollection<Person> People { get; set; }
       
    }
}
