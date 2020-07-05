using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace SEN381_PA1_Hagen_Johann.Business_Logic_Layer
{
    interface CRUD // Abstract class to give concrete classes functionality
    {

        
        
        DataSet returnEntityList(string table);
        DataSet returnFilteredList(string table, string whereClause);
        void executeProcedure(string table, string whereClause);
    }
}
