using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_PA1_Hagen_Johann.GUI
{
    public partial class Client_Department_Form : Form
    {
        public Client_Department_Form()
        {
            InitializeComponent();
            userForm1.dept = "3";
        }

        private void Client_Department_Form_Load(object sender, EventArgs e)
        {
            userForm1.Hide();
            contractForm1.Hide();
            billingHistoryForm1.Hide();
            selectionpanel.Top = button1.Top;
            selectionpanel.Height = button1.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientForm1.Show();
            userForm1.Hide();
            contractForm1.Hide();
            billingHistoryForm1.Hide();
            selectionpanel.Top = button1.Top;
            selectionpanel.Height = button1.Height;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientForm1.Hide();
            userForm1.Hide();
            contractForm1.Show();
            billingHistoryForm1.Hide();
            selectionpanel.Top = button2.Top;
            selectionpanel.Height = button2.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientForm1.Hide();
            userForm1.Hide();
            contractForm1.Hide();
            billingHistoryForm1.Show();
            selectionpanel.Top = button3.Top;
            selectionpanel.Height = button3.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientForm1.Hide();
            userForm1.Show();
            contractForm1.Hide();
            billingHistoryForm1.Hide();
            selectionpanel.Top = button3.Top;
            selectionpanel.Height = button3.Height;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void contractForm1_Load(object sender, EventArgs e)
        {
            contractForm1.ContractForm_Load(sender, e);
        }

        private void billingHistoryForm1_Load(object sender, EventArgs e)
        {
            billingHistoryForm1.BillingHistoryForm_Load(sender, e);
        }

        private void userForm1_Load(object sender, EventArgs e)
        {
            userForm1.UserForm_Load(sender, e);
        }

        private void clientForm1_Load(object sender, EventArgs e)
        {
            clientForm1.ClientForm_Load(sender, e);
        }
    }
}
