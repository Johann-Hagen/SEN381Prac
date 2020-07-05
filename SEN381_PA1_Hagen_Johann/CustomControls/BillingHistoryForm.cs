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
    
    public partial class BillingHistoryForm : UserControl
    {
        private List<DbEntity> bills = new List<DbEntity>();
        List<BillingHistory> b = new List<BillingHistory>();
        BindingSource bs = new BindingSource();
        DataGridViewManager dgvm = new DataGridViewManager();
        public void refresh()
        {
            b.Clear();
            foreach (DbEntity item in bills)
            {
                if (item is BillingHistory)
                {
                    b.Add((BillingHistory)item);
                }
            }
        }
        public BillingHistoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           bills= dgvm.executeQuery("tblBillingHistory",String.Format("'{0}';'{1}'",cboxFilter.SelectedItem.ToString(),txtFilter.Text), "Read");
            refresh();
            bs.DataSource = b;
            dataGridView1.DataSource = bs;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           bills =  dgvm.executeQuery("tblBillingHistory",null , "Read");
            refresh();
            bs.DataSource = b;
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           bills = dgvm.executeQuery("tblBillingHistory", txtDelID.Text, "Delete");
            refresh();
            bs.DataSource = b;
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           bills =  dgvm.executeQuery("tblBillingHistory", String.Format("'{0}';'{1}';'{2}'",txtUpID.Text, cboxUpPaid.Checked,dtUpDate.Value.ToString()), "Update");
            refresh();
            bs.DataSource = b;
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           bills =  dgvm.executeQuery("tblBillingHistory", String.Format("'{0}';'{1}'",txtInID.Text,dtInDate.Value.ToString()), "Insert");
            refresh();
            bs.DataSource = b;
            dataGridView1.DataSource = bs;
        }

        public void BillingHistoryForm_Load(object sender, EventArgs e)
        {
            bills = dgvm.executeQuery("tblBillingHistory",null,"Read");
            refresh();
            bs.DataSource = b;
            dataGridView1.DataSource = bs;
        }
    }
}
