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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }
        Main context = new Main();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person();
                Identity identity = new Identity();
                Drive drive = new Drive();

                identity.IdentityNumber = txtIdentity.Text.ToString();
                identity.StartDate = DateTime.Now;
                identity.EndData = DateTime.Now;

                context.Identities.Add(identity);
                context.SaveChanges();

                drive.DriveNumber = identity.IdentityNumber.ToString();
                drive.StatDate = DateTime.Now;
                drive.EndDate = DateTime.Now;
                context.Drives.Add(drive);
                context.SaveChanges();

                person.Name = txtName.Text;
                person.Surname = txtSurname.Text;
                person.RegionId = Convert.ToInt32(comboBox1.SelectedIndex);
                person.BithyDay = dateTimePicker1.Value;
                person.Depricate = false;
                person.IdentityID = identity.ID;
                person.DriveID = drive.ID;
                context.People.Add(person);
                
                context.SaveChanges();
                txtName.Text = string.Empty;
                txtSurname.Text = string.Empty;
                txtIdentity.Text = string.Empty;
                txtDrive.Text = string.Empty;
                comboBox1.SelectedItem = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void Insert_Load(object sender, EventArgs e)
        {
            foreach (var item in context.Regions.ToList())
            {
                comboBox1.Items.Add(item.Name);
            }
        }
    }
}
