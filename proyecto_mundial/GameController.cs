using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_mundial
{
    public class GameController
    {
        public SqlConnection conn;
        public GameController()
        {
            this.conn = DatabaseController.getConnection();
        }
        public void insertGame(GameModel game)
        {
            this.conn.Open();
            String query = "insert into dbo.Partido(id_local, " +
                "id_visitante, " +
                "goles_local," +
                "goles_visitante," +
                "tiros_marco_visitante," +
                "tiros_marco_local," +
                "tiros_desviados_local," +
                "tiros_desviados_visitante," +
                "amarillas_v," +
                "amarillas_l," +
                "rojas_v," +
                "rojas_l) values(";
            query += "'" + game.id_local + "', '" + game.id_vis + "', '" + game.local_goals + "', '" + game.vis_goals + "', ";
            query += "'" + game.vis_shots + "', '" + game.local_shots + "', '" + game.local_desv_shots + "', '" + game.vis_desv_shots + "',";
            query += "'"+game.yellow_cards_v+"', '"+game.red_cards_l+"', '"+game.red_cards_v+"', '"+game.red_cards_l+"')"; 
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }
        public List<GameModel> getGames()
        {
            this.conn.Open();
            String query = "select * from dbo.Partido";
            SqlCommand cursor = new SqlCommand(query, this.conn);
            SqlDataReader reader = cursor.ExecuteReader();
            List<GameModel> arr_games = new List<GameModel>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int id_l = reader.GetInt32(1);
                int id_v = reader.GetInt32(2);
                int g_l = reader.GetInt32(3);
                int g_v = reader.GetInt32(4);
                GameModel tm = new GameModel(id, id_l, id_v, g_v, g_l);
                arr_games.Add(tm);
            }
            this.conn.Close();
            return arr_games;
        }

    }
}
