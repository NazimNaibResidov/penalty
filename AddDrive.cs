using Paractika.Win.UI.Data;
using Paractika.Win.UI.Exseption;
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
    public partial class AddDrive : Form
    {
        Main contnext = new Main();
        public AddDrive()
        {
            InitializeComponent();
        }
           
        private void AddIdentityError()
        {
            if (textBox1.Text == string.Empty)
            {
                throw new DataEmptyExeption("Text Box Not be empty");
            }
            else if (dateTimePicker1.Value == null)
            {
                throw new DateTimePicareEmty("DateTimePicre value Not be null");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Drive drive = new Drive();
            try
            {
                drive.DriveNumber = textBox1.Text;
                drive.StatDate = DateTime.Now;
                drive.EndDate = dateTimePicker1.Value;
                contnext.Drives.Add(drive);
                contnext.SaveChanges();
                
            }
            catch (DataEmptyExeption ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch(DateTimePicareEmty ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = string.Empty;
            

        }
    }
}
