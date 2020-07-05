using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatAccessLayer;
using System.Data;


namespace BusLogicLayer
{
    public class DataGridViewManager
    {
        private CRUDcontext dataHandler = new CRUDcontext();

        public List<DbEntity> executeQuery(string table, string whereClause, string operation)
        {

            List<DbEntity> entityList = new List<DbEntity>();
            DataSet dbList =  dataHandler.executeQuery(table, whereClause, operation);
            switch (table)
            {
                case "tblUser":
                    
                    foreach (DataTable tableInstance in dbList.Tables)
                    {
                        foreach (DataRow item in tableInstance.Rows)
                        {
                            entityList.Add(new User(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(), item.ItemArray[2].ToString(), item.ItemArray[3].ToString(), int.Parse(item.ItemArray[4].ToString()), item.ItemArray[5].ToString(),item.ItemArray[6].ToString(), item.ItemArray[8].ToString()));
                        }
                    }
                    break;
                case "tblTechnician":
                    foreach (DataTable tableInstance in dbList.Tables)
                    {
                        foreach (DataRow item in tableInstance.Rows)
                        {
                            entityList.Add(new Technician(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(), item.ItemArray[2].ToString(),double.Parse(item.ItemArray[3].ToString()),int.Parse(item.ItemArray[4].ToString()), item.ItemArray[5].ToString()));
                        }
                    }
                    break;
                case "tblProduct":
                    foreach (DataTable tableInstance in dbList.Tables)
                    {
                        foreach (DataRow item in tableInstance.Rows)
                        {
                            entityList.Add(new Product(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(),double.Parse(item.ItemArray[2].ToString())));
                        }
                    }
                    break;
                case "tblService":
                    foreach (DataTable tableInstance in dbList.Tables)
                    {
                        foreach (DataRow item in tableInstance.Rows)
                        {
                            entityList.Add(new Service(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(),int.Parse(item.ItemArray[2].ToString()),double.Parse(item.ItemArray[3].ToString()),double.Parse(item.ItemArray[4].ToString()),bool.Parse(item.ItemArray[5].ToString())));
                        }
                    }
                    break;
                case "tblContract":
                    foreach (DataTable tableInstance in dbList.Tables)
                    {
                        foreach (DataRow item in tableInstance.Rows)
                        {
                            entityList.Add(new Contract(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(),double.Parse(item.ItemArray[2].ToString()),bool.Parse(item.ItemArray[3].ToString())));
                        }
                    }
                    break;
                case "tblClient":
                    foreach (DataTable tableInstance in dbList.Tables)
                    {
                        foreach (DataRow item in tableInstance.Rows)
                        {
                            entityList.Add(new Client(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(), item.ItemArray[2].ToString(), item.ItemArray[3].ToString(),int.Parse(item.ItemArray[4].ToString()),item.ItemArray[5].ToString()));
                        }
                    }
                    break;
                case "tblBillingHistory":
                    foreach (DataTable tableInstance in dbList.Tables)
                    {
                        foreach (DataRow item in tableInstance.Rows)
                        {
                            entityList.Add(new BillingHistory(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(), double.Parse(item.ItemArray[2].ToString()), DateTime.Parse(item.ItemArray[3].ToString()), bool.Parse(item.ItemArray[4].ToString())));
                        }
                    }
                    break;
            }
            return entityList;
        }
        public void formatDataView(string entity, DataGridView dataGridView)
        {
            switch (entity)
            {
                case "User":
                    //Formatting for User Datagridview
                    break;
                case "Bill":
                    //Formatting for Billing History Datagridview
                    break;
                case "Contract":
                    //Formatting for Contract Datagridview
                    break;
                case "Service":
                    //Formatting for Service Datagridview
                    break;
                case "Client":
                    //Formatting for Client Datagridview
                    break;
                case "Technician":
                    //Formatting for Technician Datagridview
                    break;
                case "Product":
                    //Formatting for Product Datagridview
                    break;
                default:
                    break;
            }
        }
    }
}
