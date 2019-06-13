using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paractika.Win.UI.Data
{
   public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BithyDay { get; set; }
        public Identity Identity { get; set; }
        public int IdentityID { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }
        public Drive Drive { get; set; }
        public int DriveID { get; set; }
        public bool? Depricate { get; set; }
        public ICollection<Fire> Fires { get; set; }
    }
}
