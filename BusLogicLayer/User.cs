using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogicLayer
{
    public class User : DbEntity
    {
        private string userID;
        private string userRank;
        private string firstName;
        private string lastName;
        private int age;
        private string userName;
        private string pword;
        private string deptID;


        public string DeptID { get => deptID; set => deptID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string UserRank { get => userRank; set => userRank = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Pword { get => pword; set => pword = value; }

        public User(string userID, string userRank, string firstName, string lastName, int age, string userName, string pword, string deptID) : base()
        {
            this.userID = userID;
            this.userRank = userRank;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.userName = userName;
            this.pword = pword;
            this.deptID = deptID;
        }
    }
}
