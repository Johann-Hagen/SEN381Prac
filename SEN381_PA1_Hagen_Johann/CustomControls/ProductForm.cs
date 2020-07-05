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
    public partial class ProductForm : UserControl
    {
        private List<DbEntity> products = new List<DbEntity>();
        List<Product> p = new List<Product>();
        BindingSource bs = new BindingSource();
        DataGridViewManager dgvm = new DataGridViewManager();
        public void refresh()
        {
            p.Clear();
            foreach (DbEntity item in products)
            {
                if (item is Product)
                {
                    p.Add((Product)item);
                }         
                                
            }
        }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            products = dgvm.executeQuery("tblProduct",null,"Read");
            refresh();
            bs.DataSource = p;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           products =  dgvm.executeQuery("tblProduct",String.Format("'{0};'{1}'",cboxFilter.SelectedItem.ToString(),txtFilter.Text), "Read");
            refresh();
            bs.DataSource = p;
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           products =  dgvm.executeQuery("tblProduct", txtDelID.Text, "Delete");
            refresh();
            bs.DataSource = p;
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            products = dgvm.executeQuery("tblProduct", String.Format("'{0}';'{1}';'{2}'",txtUpID.Text,txtUpName.Text,txtUpCost.Text), "Update");
            refresh();
            bs.DataSource = p;
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           products =  dgvm.executeQuery("tblProduct", String.Format("'{0}';'{1}'",txtInName.Text, txtInCost.Text), "Insert");
            refresh();
            bs.DataSource = p;
            dataGridView1.DataSource = bs;

        }

        public void ProductForm_Load(object sender, EventArgs e)
        {
            products = dgvm.executeQuery("tblProduct", null, "Read");
            refresh();
            bs.DataSource = p;
            dataGridView1.DataSource = bs;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
