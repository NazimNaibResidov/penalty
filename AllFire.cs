using Paractika.Win.UI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paractika.Win.UI
{
    public partial class AllFire : Form
    {
        public AllFire()
        {
            InitializeComponent();
        }
        Main context = new Main();
        private void AllFire_Load(object sender, EventArgs e)
        {


            var x = from persn in context.People
                    join identy in context.Identities
                    on persn.IdentityID equals identy.ID
                    join drv in context.Drives on persn.DriveID equals drv.ID
                    join drt in context.Fires on persn.Id equals drt.PersonID
                    select new
                    {
                        ID=persn.Id,
                        Name = persn.Name,
                        Surname = persn.Surname,
                        BithyDay = persn.BithyDay,
                        Moeny = drt.Money,
                        Bal = drt.Bal,
                        Identity = identy.IdentityNumber,
                        Drive = drv.DriveNumber,
                        Depricate=persn.Depricate
                      
                    };
            dataGridView1.DataSource = x.ToList();

    }
    }
}
