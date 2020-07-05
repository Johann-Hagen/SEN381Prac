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
    public partial class ClientForm : UserControl
    {
        DataGridViewManager dgvm = new DataGridViewManager();
        BindingSource bs = new BindingSource();
        List<DbEntity> clients = new List<DbEntity>();
        List<Client> c = new List<Client>();
        public void refresh()
        {
            c.Clear();
            foreach (Client item in clients)
            {
                if (item is Client)
                {
                    c.Add((Client)item);
                }
            }
        }
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           clients =  dgvm.executeQuery("tblClient",null, "Read");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           clients =  dgvm.executeQuery("tblClient", String.Format("'{0}';'{1}'",cbFilter.SelectedItem.ToString(),txtFIlter.Text), "Read");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          clients=  dgvm.executeQuery("tblClient", txtDelID.Text, "Delete");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          clients=  dgvm.executeQuery("tblClient",String.Format("'{0}';'{1}';'{2}';'{3}'",txtUpAddress.Text,txtUpAge.Text,txtUpID.Text,txtUpmail.Text),"Update");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           clients= dgvm.executeQuery("tblClient", String.Format("'{0}';'{1}';'{2}';'{3}';'{4}'",txtInAddress.Text,txtInAge.Text,txtInFname.Text,txtInLname.Text,txtInmail.Text), "Insert");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }

        public void ClientForm_Load(object sender, EventArgs e)
        {
            clients = dgvm.executeQuery("tblClient", null, "Read");
            refresh();
            bs.DataSource = c;
            dataGridView1.DataSource = bs;
        }
    }
}
