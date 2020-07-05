using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogicLayer
{
    public class Service : DbEntity
    {
        string serviceID;
        string empID;
        int installationHours;
        double intallationCost;
        double montlyCost;
        bool installationPaid;

        public Service(string serviceID, string empID, int installationHours, double intallationCost, double montlyCost, bool installationPaid)
        {
            this.serviceID = serviceID;
            this.empID = empID;
            this.installationHours = installationHours;
            this.intallationCost = intallationCost;
            this.montlyCost = montlyCost;
            this.installationPaid = installationPaid;
        }

        public string ServiceID { get => serviceID; set => serviceID = value; }
        public string EmpID { get => empID; set => empID = value; }
        public int InstallationHours { get => installationHours; set => installationHours = value; }
        public double IntallationCost { get => intallationCost; set => intallationCost = value; }
        public double MontlyCost { get => montlyCost; set => montlyCost = value; }
        public bool InstallationPaid { get => installationPaid; set => installationPaid = value; }
    }
}
