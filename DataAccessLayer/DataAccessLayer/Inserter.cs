using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace SEN381_PA1_Hagen_Johann.Business_Logic_Layer.CRUD_Strategy
{
    class Inserter : CRUD // Class that will execute INSERT procedure
    {

        private SqlConnection conn;
        
        public Inserter(SqlConnection conn)
        {
            this.Conn = conn;
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
                        SqlCommand command = new SqlCommand("InsertUser", conn);
                        string[] values = whereClause.Split(';');
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserRank", values[0]);
                        command.Parameters.AddWithValue("@FirsName", values[1]);
                        command.Parameters.AddWithValue("@LastName", values[2]);
                        command.Parameters.AddWithValue("@Age", values[3]);
                        command.Parameters.AddWithValue("@Username", values[4]);
                        command.Parameters.AddWithValue("@Password", values[5]);
                        command.Parameters.AddWithValue("@DeptID", values[6]);
                        command.ExecuteNonQuery();
                        break;
                    case "tblTechnician":
                        conn.Open();
                        SqlCommand command1 = new SqlCommand("InsertTechnician", conn);
                        string[] values1 = whereClause.Split(';');
                        command1.CommandType = CommandType.StoredProcedure;
                        command1.Parameters.AddWithValue("@FistName", values1[0]);
                        command1.Parameters.AddWithValue("@LastName", values1[1]);
                        command1.Parameters.AddWithValue("@Rate", values1[2]);
                        command1.Parameters.AddWithValue("@Age", values1[3]);
                        command1.Parameters.AddWithValue("@PhoneNum", values1[4]);
                        command1.ExecuteNonQuery();
                        break;
                    case "tblProduct":
                        conn.Open();
                        SqlCommand command2 = new SqlCommand("InsertProduct", conn);
                        string[] values2 = whereClause.Split(';');
                        command2.CommandType = CommandType.StoredProcedure;
                        command2.Parameters.AddWithValue("@Name", values2[0]);
                        command2.Parameters.AddWithValue("@Cost", values2[1]);
                        command2.ExecuteNonQuery();
                        break;
                    case "tblService":
                        conn.Open();
                        SqlCommand command3 = new SqlCommand("InsertService", conn);
                        string[] values3 = whereClause.Split(';');
                        command3.CommandType = CommandType.StoredProcedure;
                        command3.Parameters.AddWithValue("@InstallHours", values3[0]);
                        command3.Parameters.AddWithValue("@InstallCost", values3[1]);
                        command3.Parameters.AddWithValue("@EmpID", values3[2]);
                        command3.Parameters.AddWithValue("@MonthlyCost", values3[3]);
                        command3.Parameters.AddWithValue("@Pais", values3[4]);
                        command3.ExecuteNonQuery();
                        break;
                    case "tblContract":
                        conn.Open();
                        SqlCommand command4 = new SqlCommand("InsertContract", conn);
                        string[] values4 = whereClause.Split(';');
                        command4.CommandType = CommandType.StoredProcedure;
                        command4.Parameters.AddWithValue("@Cost", values4[0]);
                        command4.Parameters.AddWithValue("@Active", values4[1]);
                        command4.ExecuteNonQuery();
                        break;
                    case "tblClient":
                        conn.Open();
                        SqlCommand command5 = new SqlCommand("InsertClient", conn);
                        string[] values5 = whereClause.Split(';');
                        command5.CommandType = CommandType.StoredProcedure;
                        command5.Parameters.AddWithValue("@Name", values5[0]);
                        command5.Parameters.AddWithValue("@LName", values5[1]);
                        command5.Parameters.AddWithValue("@Age", values5[2]);
                        command5.Parameters.AddWithValue("@Email", values5[3]);
                        command5.Parameters.AddWithValue("@Address", values5[4]);
                        command5.ExecuteNonQuery();
                        break;
                    case "tblBillingHistory":
                        conn.Open();
                        SqlCommand command6 = new SqlCommand("InsertClient", conn);
                        string[] values6 = whereClause.Split(';');
                        command6.CommandType = CommandType.StoredProcedure;
                        command6.Parameters.AddWithValue("@Cost", values6[0]);
                        command6.Parameters.AddWithValue("@InvoiceDate", values6[1]);
                        command6.Parameters.AddWithValue("@Paid", values6[2]);
                        command6.ExecuteNonQuery();
                        break;
                }
            }
        }

        public DataSet returnEntityList(string table)
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
    }
}
