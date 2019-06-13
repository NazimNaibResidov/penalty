using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paractika.Win.UI.Data
{
   public class Drive
    {
        public int ID { get; set; }
        public string DriveNumber { get; set; }
        public DateTime StatDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Depricate { get; set; }
       
        public ICollection<Person> People { get; set; }
    }
}
