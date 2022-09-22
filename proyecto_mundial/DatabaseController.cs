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
        public string connectionString;
        public SqlConnection connection;

        public DatabaseController()
        {
            this.connectionString = "Data Source=localhost; Initial Catalog=mundial; User ID=sa; Password=daniela11";
            this.connection = new SqlConnection(connectionString);
        }

        public bool isConnected()
        {
            return this.connection != null;
        }
    }
}
