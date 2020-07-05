using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusLogicLayer;

namespace SEN381_PA1_Hagen_Johann.CustomControls
{
    public partial class TechnicianForm : UserControl
    {
        DataGridViewManager dgvm = new DataGridViewManager();
        List<Technician> technician = new List<Technician>();
        private List<DbEntity> technicians = new List<DbEntity>();
        BindingSource bs = new BindingSource();

        public void refresh()
        {
            technician.Clear();
            foreach (DbEntity item in technicians)
            {
                if (item is Technician) 
                    technician.Add((Technician)item);
            }
        }
        public TechnicianForm()
        {
            InitializeComponent();
            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            technicians  = dgvm.executeQuery("tblTechnician",null, "Read");
            refresh();
            bs.DataSource = technician;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            technicians =  dgvm.executeQuery("tblTechnician", String.Format("'{0}';'{1}'",cboxFilter.SelectedItem.ToString(),txtFilter.Text), "Read");
            refresh();
            bs.DataSource = technician;
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            technicians  = dgvm.executeQuery("tblTechnician", txtDelID.Text, "Delete");
            refresh();
            bs.DataSource = technician;
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            technicians = dgvm.executeQuery("tblTechnician", String.Format("'{0}';'{1}';'{2}'",txtUpID.Text,txtUpPhone.Text,txtUpRate.Text), "Update");
            refresh();
            bs.DataSource = technician;
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           technicians =  dgvm.executeQuery("tblTechnician", String.Format("'{0}';'{1}';'{2}';'{3}';'{4}'",txtInAge.Text,txtInFname.Text,txtInLname.Text,txtInNumber.Text,txtInRate.Text), "Insert");
            refresh();
            bs.DataSource = technician;
            dataGridView1.DataSource = bs;
        }

        public void TechnicianForm_Load(object sender, EventArgs e)
        {
            technicians = dgvm.executeQuery("tblTechnician", null, "Read");
            refresh();
            bs.DataSource = technician;
            dataGridView1.DataSource = bs;
        }
    }
}
