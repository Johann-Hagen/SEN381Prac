using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DatAccessLayer
{
    class Deleter : CRUD // Class that will execute DELETE procedure
    {

        SqlConnection conn;
        public Deleter(SqlConnection connection)
        {
            this.Conn = connection;
        }

        public SqlConnection Conn { get => conn; set => conn = value; }

        public void executeProcedure(string table, string whereClause)
        {
            using (SqlConnection conn = new SqlConnection(Conn.ToString()))
            {
                switch (table)
                {
                    case "tblUser":
                        conn.Open();
                        SqlCommand command = new SqlCommand("DeleteUser", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", whereClause);
                        command.ExecuteNonQuery();
                        break;
                    case "tblTechnician":
                        conn.Open();
                        SqlCommand command2 = new SqlCommand("DeleteTech", conn);
                        command2.CommandType = CommandType.StoredProcedure;
                        command2.Parameters.AddWithValue("@ID", whereClause);
                        command2.ExecuteNonQuery();
                        break;
                    case "tblProduct":
                        conn.Open();
                        SqlCommand command3 = new SqlCommand("DeleteProduct", conn);
                        command3.CommandType = CommandType.StoredProcedure;
                        command3.Parameters.AddWithValue("@ID", whereClause);
                        command3.ExecuteNonQuery();
                        break;
                    case "tblService":
                        conn.Open();
                        SqlCommand command4 = new SqlCommand("DeleteService", conn);
                        command4.CommandType = CommandType.StoredProcedure;
                        command4.Parameters.AddWithValue("@ID", whereClause);
                        command4.ExecuteNonQuery();
                        break;
                    case "tblContract":
                        conn.Open();
                        SqlCommand command5 = new SqlCommand("DeleteContract", conn);
                        command5.CommandType = CommandType.StoredProcedure;
                        command5.Parameters.AddWithValue("@ID", whereClause);
                        command5.ExecuteNonQuery();
                        break;
                    case "tblClient":
                        conn.Open();
                        SqlCommand command6 = new SqlCommand("DeleteClient", conn);
                        command6.CommandType = CommandType.StoredProcedure;
                        command6.Parameters.AddWithValue("@ID", whereClause);
                        command6.ExecuteNonQuery();
                        break;
                    case "tblBillingHistory":
                        conn.Open();
                        SqlCommand command7 = new SqlCommand("DeleteBillingHistory", conn);
                        command7.CommandType = CommandType.StoredProcedure;
                        command7.Parameters.AddWithValue("@ID", whereClause);
                        command7.ExecuteNonQuery();
                        break;
                }
            }
        }
               
        public  DataSet returnEntityList(string table)
        {
                DataSet dt = new DataSet();
                
                using (SqlConnection conn = new SqlConnection(Conn.ToString()))
                {
                    string qry = string.Format("SELECT * FROM {0}", table);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.FillSchema(dt, SchemaType.Source, table);
                    adapter.Fill(dt, table);
                }
            return dt;
        }
               
        public  DataSet returnFilteredList(string table, string whereClause)
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
    }
}
