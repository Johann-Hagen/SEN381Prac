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
    
    public partial class ContractForm : UserControl
    {
        DataGridViewManager dgvm = new DataGridViewManager();
        List<DbEntity> contracts = new List<DbEntity>();
        List<Contract> c = new List<Contract>();
        BindingSource bs = new BindingSource();
        public void refresh()
        {
            c.Clear();
            foreach(DbEntity item in contracts)
            {
                if (item is Contract)
                {
                    c.Add((Contract)item);
                }
            }
        }
        public ContractForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           contracts =  dgvm.executeQuery("tblContract", null, "Read");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           contracts =  dgvm.executeQuery("tblContract", String.Format("'{0}';'{1}'",cbFilter.SelectedItem.ToString(),txtFilter.Text), "Read");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           contracts = dgvm.executeQuery("tblContract", txtDelID.Text, "Delete");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          contracts =   dgvm.executeQuery("tblContract", String.Format("'{0}';'{1}'",txtUpID.Text,cbUpPaid.Checked), "Update");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          contracts=  dgvm.executeQuery("tblContract", String.Format("'{0}';'{1}'",txtInCLientID.Text,txtInServID.Text), "Insert");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        public void ContractForm_Load(object sender, EventArgs e)
        {
            contracts = dgvm.executeQuery("tblContract", null, "Read");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }
    }
}
