using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusLogicLayer;

namespace SEN381_PA1_Hagen_Johann.GUI
{
    public partial class Technical_Department_Form : Form
    {
        
             
   
        
        public Technical_Department_Form()
        {
            InitializeComponent();
            userForm1.dept = "1";
        }

        private void Technical_Department_Form_Load(object sender, EventArgs e)
        {
            serviceForm1.Show();
            productForm1.Hide();
            technicianForm1.Hide();
            userForm1.Hide();
            selectionpanel.Top = button1.Top;
            selectionpanel.Height = button1.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serviceForm1.Show();
            productForm1.Hide();
            technicianForm1.Hide();
            userForm1.Hide();
            selectionpanel.Top = button1.Top;
            selectionpanel.Height = button1.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serviceForm1.Hide();
            productForm1.Show();
            technicianForm1.Hide();
            userForm1.Hide();
            selectionpanel.Top = button2.Top;
            selectionpanel.Height = button2.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serviceForm1.Hide();
            productForm1.Hide();
            technicianForm1.Show();
            userForm1.Hide();
            selectionpanel.Top = button3.Top;
            selectionpanel.Height = button3.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serviceForm1.Hide();
            productForm1.Hide();
            technicianForm1.Hide();
            userForm1.Show();
            selectionpanel.Top = button4.Top;
            selectionpanel.Height = button4.Height;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
           
        }

        private void userForm1_Load(object sender, EventArgs e)
        {
            userForm1.UserForm_Load(sender, e);
                      
        }

        private void technicianForm1_Load(object sender, EventArgs e)
        {
            technicianForm1.TechnicianForm_Load(sender, e);
        }

        private void productForm1_Load(object sender, EventArgs e)
        {
            productForm1.ProductForm_Load(sender, e);
        }

        private void serviceForm1_Load(object sender, EventArgs e)
        {
            serviceForm1.ServiceForm_Load(sender, e);
        }
    }
}
