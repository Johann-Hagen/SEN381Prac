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
  
    public partial class ServiceForm : UserControl
    {
        private DataGridViewManager dgvm = new DataGridViewManager();
        private List<Service> service = new List<Service>();
        public List<DbEntity> services = new List<DbEntity>();
        BindingSource bs = new BindingSource();
        public void refresh()
        {
            service.Clear();
            foreach (DbEntity item in services)
            {
                if (item is Service)
                {
                    service.Add((Service)item);
                }
            }
        }
        public ServiceForm()
        {
            InitializeComponent();
            refresh();
        }

        public void ServiceForm_Load(object sender, EventArgs e)
        {
            services = dgvm.executeQuery("tblService",null,"Read");
            refresh();
            bs.DataSource = service;
            dataGridView1.DataSource = bs;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            services = dgvm.executeQuery("tblService", null, "Read");
            refresh();
            bs.DataSource = service;
            dataGridView1.DataSource = bs;

        }

        private void button1_Click(object sender, EventArgs e)
        {

           services =  dgvm.executeQuery("tblService", String.Format("Where '{0}' = '{1}'", cboxFilter.SelectedItem.ToString(), txtFilter.Text), "Read");
            refresh();
            bs.DataSource = service;
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            services = dgvm.executeQuery("tblService", txtDelID.Text, "Delete");
            refresh();
            bs.DataSource = service;
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            services = dgvm.executeQuery("tblService", String.Format("'{0}';'{1}';'{2}';'{3}'",txtUpID.Text, chboxPaid.Checked,txtUpMonCost.Text,txtUpInstallHour.Text), "Update");
            refresh();
            bs.DataSource = service;
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            services = dgvm.executeQuery("tblService",String.Format("'{0}';'{1}';'{2}'",txtInID.Text,txtInMonCost.Text,txtInInstHour.Text),"Insert");
            refresh();
            bs.DataSource = service;
            dataGridView1.DataSource = bs;
        }
    }
}
