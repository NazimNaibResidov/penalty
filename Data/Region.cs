using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paractika.Win.UI.Data
{
   public class Region
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Person> People { get; set; }
    }
}
