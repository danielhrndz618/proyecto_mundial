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


        public List<TeamModel> getTeams(SqlConnection conn)
        {
            String query = "select * from dbo.Pais";
            SqlCommand cursor = new SqlCommand(query, conn);
            SqlDataReader reader = cursor.ExecuteReader();
            List<TeamModel> arr_teams = new List<TeamModel>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int cant = reader.GetInt32(2);
                TeamModel tm = new TeamModel(name, cant);
                arr_teams.Add(tm);
            }
            return arr_teams;
        }
    }
}
