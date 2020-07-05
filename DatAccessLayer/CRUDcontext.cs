using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatAccessLayer
{
   public class CRUDcontext // Context class for the CRUD strategy
    {
        private CRUD crud;
        private SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-920KE7OJ;Initial Catalog=PA2_SHS_Johann_Hagen;Integrated Security=True");

        public CRUDcontext()
        {
        }
        public DataSet executeQuery(string table, string whereClause, string operation)
        {
            switch (operation)
            {
                case "Insert":
                    crud = new Inserter(connection);
                    crud.executeProcedure(table, whereClause);
                    break;
                case "Delete":
                    crud = new Deleter(connection);
                    crud.executeProcedure(table, whereClause);
                    break;
                case "Update":
                    crud = new Updater(connection);
                    crud.executeProcedure(table, whereClause);
                    break;
            }
            Reader reader = new Reader(connection);
            if (whereClause == null)
            {
                return reader.returnEntityList(table);
            }
            return reader.returnFilteredList(table, whereClause);
        }
    }
}
