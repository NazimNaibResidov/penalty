using Paractika.Win.UI.Data;
using Paractika.Win.UI.Helpers;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                   Main context = new Main();
      

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fire fir = new Fire();
            try
            {    Person person =  Tools.GetPerson(context, textBox1.Text);
                 bool   data   =  Tools.FireIfExists(context, person);
                 Drive  drive  =  Tools.GetDriveInPerson(context, person);
              
                if (data)
                {
                    Fire fire      = Tools.FireOrderByDesc(context, person);
                    fir = fire;
                    txtMoeny.Text = fire.Money.ToString();
                    txtBal.Text   = fire.Bal.ToString();
                    if (fire.Bal==10)
                    {
                       Identity identity= Tools.GetIdentity(context, person);
                       Drive drives     = Tools.GetDrive(context, person);
                        identity.Depricate = true;
                        drive.Depricate = true;
                    }
                    Tools.DepricateAndVisible(fire.Bal, person, button2);

                }
                else
                {
                    txtMoeny.Visible = false;
                    txtBal.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                }
                    txtName.Text = person.Name;
                    txtSurname.Text = person.Surname;
                    txtBirthday.Text = person.BithyDay.ToString("mmmm -dd -yyyy");
                    txtIdentity.Text = textBox1.Text;
                    txtDrive.Text = drive.DriveNumber;
                    txtDupricate.Text = person.Depricate.ToString();
                if(person.Depricate==true)
                    MessageBox.Show($"{person.Name} {person.Surname} \n \nYou Drive Licen  \n\n Since { fir.AddedTime.ToString().ToUpper()} -- Blocked");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FireForm fireForm = new FireForm();
            fireForm.Show();
            
        }

       
    }
}
