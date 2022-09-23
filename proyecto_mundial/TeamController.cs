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

        public SqlConnection conn;
        public TeamController()
        {
            this.conn = DatabaseController.getConnection();
        }
        public void insertTeam(TeamModel team)
        {
            this.conn.Open();
            String query = "insert into dbo.Pais(nombre, cant_jugadores) values('" + team.name + "', '" + team.cant + "')";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }


        public List<TeamModel> getTeams()
        {
            this.conn.Open();
            String query = "select * from dbo.Pais";
            SqlCommand cursor = new SqlCommand(query, this.conn);
            SqlDataReader reader = cursor.ExecuteReader();
            List<TeamModel> arr_teams = new List<TeamModel>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int cant = reader.GetInt32(2);
                TeamModel tm = new TeamModel(id, name, cant);
                arr_teams.Add(tm);
            }
            this.conn.Close();
            return arr_teams;
        }
    }
}
