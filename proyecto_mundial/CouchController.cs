using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_mundial
{
    public class CouchController
    {
        public SqlConnection conn;
        public CouchController()
        {
            this.conn = DatabaseController.getConnection();
        }
        public void insertCouch(CouchModel couch)
        {
            this.conn.Open();
            String query = "insert into dbo.Entrenador(nombre, apellido, edad, tiempo_trabajo, id_pais)values(";
            query += "'" + couch.name + "', '" + couch.surname + "', '" + couch.age + "', '" + couch.working_time + "', '" + couch.id_country + "')";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }
    }
}
