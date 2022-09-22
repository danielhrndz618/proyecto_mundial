using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_mundial
{
    public class TeamController
    {
        public void insertTeam(SqlConnection conn, TeamModel team)
        {
            String query = "insert into dbo.Pais(nombre, cant_jugadores) values('" + team.name + "', '" + team.cant + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
