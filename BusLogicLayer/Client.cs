using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogicLayer
{
    public class Client :DbEntity
    {
        string clientID;
        string clientName;
        string clientLName;
        string email;
        int age;
        string physicalAddress;

        public Client(string clientID, string clientName, string clientLName, string email, int age, string physicalAddress)
        {
            this.clientID = clientID;
            this.clientName = clientName;
            this.clientLName = clientLName;
            this.email = email;
            this.age = age;
            this.physicalAddress = physicalAddress;
        }

        public string ClientID { get => clientID; set => clientID = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientLName { get => clientLName; set => clientLName = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }
        public string PhysicalAddress { get => physicalAddress; set => physicalAddress = value; }
    }
}
