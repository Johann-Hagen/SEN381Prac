using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN381_PA1_Hagen_Johann.Database_Entities;

namespace SEN381_PA1_Hagen_Johann.Business_Logic_Layer.Privelage_Factory
{
    class PrivilageFactory //Factory class that will be used to assign privelages to users
    {
        private User user;
        private Department department;

        public User User { get => user; set => user = value; }
        public Department Department { get => department; set => department = value; }

        public PrivilageFactory(User user)
        {
            this.user = user;
            switch (user.DeptID)
            {
                case "TechnicalID":
                    this.Department = new TechnicalDept();
                    break;
                case "ContractID":
                    this.Department = new ContractDept();
                    break;
                case "ClientID":
                    this.Department = new ClientDept();
                    break;
            }
        }
        public string setFileAccess()
        {
            return department.returnPrivilage();
        }
    }
}
