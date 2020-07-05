using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SEN381_PA1_Hagen_Johann.Business_Logic_Layer.CRUD_Strategy
{
    class CRUDcontext // Context class for the CRUD strategy
    {
        private CRUD crud;
        private SqlConnection connection = new SqlConnection("Insert String Here");

        public CRUDcontext()
        {

        }
        public DataSet executeQuery<T>(string table, string whereClause, string operation)
        {
            switch (operation)
            {
                case "Insert":
                    crud = new Inserter(connection);
                    crud.executeProcedure(table, whereClause);
                    return crud.returnEntityList(table);

                case "Delete":
                    crud = new Deleter(connection);
                    crud.executeProcedure(table, whereClause);
                    return crud.returnEntityList(table);
                   
                case "Update":
                    crud = new Updater(connection);
                    crud.executeProcedure(table, whereClause);
                    return crud.returnEntityList(table);
                    
                case "Read":
                    crud = new Updater(connection);
                    if (whereClause.Equals("None", StringComparison.CurrentCultureIgnoreCase))
                    {
                        return crud.returnEntityList(table);
                    }
                    return crud.returnFilteredList(table, whereClause);
                default:
                    return null;
            }
        }
    }
}
