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
    public partial class UserForm : UserControl
    {
        private List<DbEntity> users = new List<DbEntity>();
        public string dept = "0";
        private List<User> user = new List<User>();
        private DataGridViewManager dgvm = new DataGridViewManager();
        private BindingSource bs = new BindingSource();
        public void refresh()
        {
            user.Clear();
            foreach (DbEntity item in users)
            {
                if (item is User)
                {
                    User u = (User)item;
                    if (u.DeptID == dept)
                    {
                        user.Add((User)item);
                    }
                    
                }
            }
        }
        public UserForm()
        {
            InitializeComponent();
            
            }

        public void UserForm_Load(object sender, EventArgs e)
        {
            users = dgvm.executeQuery("tblUser", null, "Read");
            refresh();
            bs.DataSource = user;
            dgvUsergfef.DataSource = bs;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
          users =   dgvm.executeQuery("tblUser", String.Format("'{0}';'{1}'", cboxFilter.SelectedItem.ToString(), txtFilter.Text), "Read");
            refresh();
            bs.DataSource = user;
            dgvUsergfef.DataSource = bs;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          users =   dgvm.executeQuery("tblUser", txtDelID.Text, "Delete");
            refresh();
            bs.DataSource = user;
            dgvUsergfef.DataSource = bs;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          users =   dgvm.executeQuery("tblUser", String.Format("'{0}';'{1}';'{2}';'{3}'", cboxRank.SelectedItem.ToString(), txtUpUsername.Text, txtUpPassword.Text, txtUpID.Text), "Update");
            refresh();
            bs.DataSource = user;
            dgvUsergfef.DataSource = bs;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
          users =    dgvm.executeQuery("tblUser", String.Format("{0};{1};{2};{3};{4};{5}",txtInFname.Text, txtInLname.Text, txtInAge.Text, txtInUserName.Text, txtInPassword.Text, cboxInRank.SelectedIndex.ToString()), "Insert");
            refresh();
            bs.DataSource = user;
            dgvUsergfef.DataSource = bs;
        }

        private void btnDispAll_Click(object sender, EventArgs e)
        {
           users =  dgvm.executeQuery("tblUser", null, "Read");
            refresh();
            bs.DataSource = user;
            dgvUsergfef.DataSource = bs;

        }

       
    }
}
