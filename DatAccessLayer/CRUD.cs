using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DatAccessLayer
{
    interface CRUD // Abstract class to give concrete classes functionality
    {
        void executeProcedure(string table, string whereClause);
    }
}
