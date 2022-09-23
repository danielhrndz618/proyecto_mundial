using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_mundial
{
    class DatabaseController
    {

        static public SqlConnection getConnection()
        {
            String connectionString = "Data Source=localhost; Initial Catalog=mundial; User ID=sa; Password=daniela11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
