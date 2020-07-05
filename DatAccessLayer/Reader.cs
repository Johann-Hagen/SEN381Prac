using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DatAccessLayer
{
    class Reader : CRUD
    {
        private SqlConnection conn;
        public Reader(SqlConnection connection)
        {
            this.Conn = connection;
        }

        public SqlConnection Conn { get => conn; set => conn = value; }



        public DataSet returnEntityList(string table)
        {
            DataSet dt = new DataSet();

            using (SqlConnection conn = new SqlConnection(Conn.ConnectionString))
            {
                string qry = String.Format("SELECT * FROM {0}", table);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(dt, SchemaType.Source, table);
                adapter.Fill(dt, table);
            }
            return dt;

        }
        public DataSet returnContractDetails(string invoiceID)
        {
            DataSet dt = new DataSet();

            using (SqlConnection conn = new SqlConnection(Conn.ToString()))
            {
                string qry = string.Format(@"SELECT CON.contractID, CON.Cost, S.ServiceID, T.TechName, T.TechLName, P.ProdName, C.Email
                                             RANK () OVER (ORDER BY CON.Cost DSEC) Cost_Rank
                                             FROM tblContract as CON INNER JOIN tbl Client as C Where CON.ClientID = C.ClientID
                                             INNER JOIN tblContractServices Where CON.ContractID = tblContractServices.ContractID
                                             INNER JOIN tblService as S Where S.ServiceID = tblContractServices.ServiceID
                                             INNER JOIN tblTechnician as T Where T.TechID = S.TechID
                                             INNER JOIN tblServiceProducts Where tblServiceProducts.ServiceID = S.ServiceID
                                             INNER JOIN tblProducts as P Where P.ProductID = tblServiceProducts.ProductID"
                                              );
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(dt, SchemaType.Source, "tblContract");
                adapter.Fill(dt, "tblContract");
            }
            return dt;
        }
        public DataSet returnFilteredList(string table, string whereClause)
        {
            DataSet dt = new DataSet();

            using (SqlConnection conn = new SqlConnection(Conn.ToString()))
            {
                string qry = string.Format("SELECT * FROM {0} WHERE {1}", table, whereClause);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(dt, SchemaType.Source, table);
                adapter.Fill(dt, table);
            }
            return dt;
        }


        public void executeProcedure(string table, string whereClause)
        {

        }

    }
}

