using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN381_PA1_Hagen_Johann.Business_Logic_Layer.CRUD_Strategy;

namespace SEN381_PA1_Hagen_Johann.Business_Logic_Layer
{
    class DataGridViewManager
    {
        private CRUDcontext dataHandler = new CRUDcontext();

        public List<T> executeQuery<T>(string table, string whereClause, string operation)
        {
           return dataHandler.executeQuery<T>(table, whereClause, operation);
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
