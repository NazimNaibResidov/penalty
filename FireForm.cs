using Paractika.Win.UI.Data;
using Paractika.Win.UI.Exseption;
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
    public partial class FireForm : Form
    {
        public FireForm()
        {
            InitializeComponent();
        }
                 Main context = new Main();
        private void FireError()
        {
            if (textBox1.Text == string.Empty)
            {
                throw new DataEmptyExeption("Text Box Not be empty");
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
                  Fire fire = new Fire();
               try
            {
               

                Person person = Tools.GetPerson(context, textBox1.Text);
                bool   data   = Tools.FireIfExists(context, person);
                    if(data)
                {

         Fire a = Tools.GetFire(context, person);
         if (a.Bal == 10)
         person.Depricate = true;
         a.Bal            += Tools.constraintBal(a.Bal, comboBox1.SelectedItem);
         a.Money          += Tools.CountMoney(a.Bal,a.Money);
                  
                    
         a.AddedTime       = DateTime.Now;
                    context.Fires.Add(a);
                }
                  
                
                else
                {
                fire.PersonID  = person.Id;
                fire.AddedTime = DateTime.Now;
                fire.Bal      += Tools.constraintBal(fire.Bal, comboBox1.SelectedItem );
                fire.Money    += Tools.CountMoney(fire.Bal,fire.Money);
              
                context.Fires.Add(fire);
                }
               
                context.SaveChanges();
                AllFire allFire = new AllFire();
                allFire.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllFire fire = new AllFire();
            fire.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDrive drive = new AddDrive();
            drive.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddIdentity identity = new AddIdentity();
            identity.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
        }

        private void FireForm_Load(object sender, EventArgs e)
        {

        }
    }
}
