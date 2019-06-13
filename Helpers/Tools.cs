using Paractika.Win.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paractika.Win.UI.Helpers
{
   public class Tools
    {
       
       
     public static Person   GetPerson(Main context,string text)
        {
            int id = context.Identities.FirstOrDefault(x => x.IdentityNumber == text).ID;
            return context.People.FirstOrDefault(x => x.IdentityID == id);
        }
     public static Identity GetIdentity(Main context,Person person)
        {
           return context.Identities.FirstOrDefault(x => x.ID == person.IdentityID);
        }
     public static Drive    GetDrive(Main context,Person person)
        {
          return  context.Drives.FirstOrDefault(x => x.ID == person.Id);
        }
     public static Drive    GetDriveInPerson(Main context, Person person)
        {
           return context.Drives.FirstOrDefault(x => x.ID == person.DriveID);
        }
     public static Fire     FireOrderByDesc(Main context, Person person)
        {
            return context.Fires.Where(x => x.PersonID == person.Id).OrderByDescending(x => x.ID).First();

        }
     public static Fire     GetFire(Main context, Person person)
        {
            return context.Fires.FirstOrDefault(x => x.PersonID == person.Id);
        }
     public static int      PersonIdentity(Main context, string text)
        {
            return context.Identities.FirstOrDefault(x => x.IdentityNumber == text).ID;
        }
     public static byte     constraintBal(byte Bal, object value)
        {
            byte resultes = 0;
            if (Bal == 0)
            {
                resultes = Convert.ToByte(value);
            }
            else if (11 > Bal + Convert.ToByte(value))
            {
                resultes = Bal;
            }
            else if (11 < Bal + Convert.ToByte(value))
            {
                int bals = Convert.ToByte(value);
                byte result = Convert.ToByte((Bal + bals) - 10);
                resultes = Convert.ToByte(Convert.ToByte(value) - result);

            }
            else
            {
                resultes = 0;
            }
            return resultes;



        }
     public static bool     FireIfExists(Main context,Person person)
        {
           return context.Fires.Where(x => x.PersonID == person.Id).Any();
        }
     public static void     DepricateAndVisible(int bal,Person person,Button button)
        {
            if (bal == 10)
            {
                person.Depricate = true;
                button.Visible = false;
            }
        }
     public static decimal  CountMoney(int Bal,decimal money)
        {
           
            if (money==200)
            {
                return 0;
            }
            return Bal * 20;

           



        }
    


    }
}
