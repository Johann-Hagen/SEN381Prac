using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogicLayer
{
    public class Contract : DbEntity
    {
        string contractID;
        string clientID;
        double cost;
        bool active;

        public Contract(string contractID, string clientID, double cost, bool active)
        {
            this.contractID = contractID;
            this.clientID = clientID;
            this.cost = cost;
            this.active = active;
        }

        public string ContractID { get => contractID; set => contractID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public double Cost { get => cost; set => cost = value; }
        public bool Active { get => active; set => active = value; }
    }
}
