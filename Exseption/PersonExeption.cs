using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paractika.Win.UI.Exseption
{
   public class PersonExeption:ArgumentException
    {
        public PersonExeption(string Erros):base(Erros)
        {

        }
    }
}
