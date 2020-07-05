using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogicLayer
{
    public class BillingHistory : DbEntity
    {
        string invoiceID;
        string contractID;
        double cost;
        DateTime invoiceDate;
        bool paid;

        public BillingHistory(string invoiceID, string contractID, double cost, DateTime invoiceDate, bool paid)
        {
            this.invoiceID = invoiceID;
            this.contractID = contractID;
            this.cost = cost;
            this.invoiceDate = invoiceDate;
            this.paid = paid;
        }

        public string InvoiceID { get => invoiceID; set => invoiceID = value; }
        public string ContractID { get => contractID; set => contractID = value; }
        public double Cost { get => cost; set => cost = value; }
        public DateTime InvoiceDate { get => invoiceDate; set => invoiceDate = value; }
        public bool Paid { get => paid; set => paid = value; }
    }
}
