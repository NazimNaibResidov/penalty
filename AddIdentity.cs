using Paractika.Win.UI.Data;
using Paractika.Win.UI.Exseption;
using System;
using System.Windows.Forms;

namespace Paractika.Win.UI
{
    public partial class AddIdentity : Form
    {
        public AddIdentity()
        {
            InitializeComponent();
        }
             Main context = new Main();
        private void AddIdentityError()
        {
            if (textBox1.Text == string.Empty)
            {
                throw new DataEmptyExeption("Text Box Not be empty");
            }
            else if(dateTimePicker1.Value==null)
            {
                throw new DateTimePicareEmty("DateTimePicre value Not be null");
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Identity identity = new Identity();

            try
            {
                identity.IdentityNumber = textBox1.Text;
                identity.StartDate = DateTime.Now;
                identity.EndData = dateTimePicker1.Value;
                context.Identities.Add(identity);
                context.SaveChanges();
                
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
