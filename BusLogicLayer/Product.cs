using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogicLayer
{
    public class Product : DbEntity
    {
        string prodID;
        string prodName;
        double cost;

        public Product(string prodID, string prodName, double cost)
        {
            this.prodID = prodID;
            this.prodName = prodName;
            this.cost = cost;
        }

        public string ProdID { get => prodID; set => prodID = value; }
        public string ProdName { get => prodName; set => prodName = value; }
        public double Cost { get => cost; set => cost = value; }
    }
}
