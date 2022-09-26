using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto_mundial
{
    public class PlayerController
    {
        public SqlConnection conn;
        public PlayerController()
        {
            this.conn = DatabaseController.getConnection();
        }
        public void insertPlayer(playerModel player)
        {
            this.conn.Open();
            String query = "insert into dbo.Jugador(nombre, apellido, edad, posicion, goles, asistencias, minutos, id_pais) ";
            query += "values('"+player.name+"', '"+player.surname+"','"+player.edad+"', '"+player.position+"'";
            query += ", '" + player.gol + "', '" + player.assist + "', '" + player.minutos + "', '" + player.id_pais + "');";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }

        public List<playerModel> getPlayers(int id)
        { 
            this.conn.Open();
            String query = "select id, goles,asistencias, posicion, minutos from dbo.Jugador where id_pais='"+id+"'";
            SqlCommand cursor = new SqlCommand(query, this.conn);
            SqlDataReader reader = cursor.ExecuteReader();
            List<playerModel> arr_player = new List<playerModel>();
            while (reader.Read())
            {
                int id_p = reader.GetInt32(0);
                int g = reader.GetInt32(1);
                int a = reader.GetInt32(2);
                String pos = reader.GetString(3);
                int min = reader.GetInt32(4);
                arr_player.Add(new playerModel(id_p, g, a, pos, min));
            }
            this.conn.Close();
            return arr_player;
        }
        

        public List<playerModel> getPlayersWithPais()
        { 
            this.conn.Open();
            String query = "select nombre,goles,asistencias, minutos, id_pais from dbo.Jugador";
            SqlCommand cursor = new SqlCommand(query, this.conn);
            SqlDataReader reader = cursor.ExecuteReader();
            List<playerModel> arr_player = new List<playerModel>();
            while (reader.Read())
            {
                String nombre = reader.GetString(0);
                int g = reader.GetInt32(1);
                int a = reader.GetInt32(2);
                int min = reader.GetInt32(3);
                int id_pais = reader.GetInt32(4);
                arr_player.Add(new playerModel(nombre, g, a, min, id_pais));
            }
            this.conn.Close();
            return arr_player;
        }
        
        public void updatePlayerGoal(int g, int id)
        {
            this.conn.Open();
            String query = "update dbo.Jugador set goles='"+g+"' where id='"+id+"' ";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }
        public void updatePlayerAsist(int a, int id)
        {
            this.conn.Open();
            String query = "update dbo.Jugador set asistencias='"+a+"' where id='"+id+"' ";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }
        public void updatePlayerMin(int m, int id)
        {
            this.conn.Open();
            String query = "update dbo.Jugador set minutos='"+m+"' where id='"+id+"' ";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }

        public void setGoals(int g, int id)
        {
            List<playerModel> arr = this.getPlayers(id);
            for(int i = 0; i < arr.Count; i++)
            {
                int min = arr[i].minutos + 90;
                this.updatePlayerMin(min, arr[i].id);

                if (arr[i].position == "Delantero")
                {
                    int gl = arr[i].gol + g;
                    this.updatePlayerGoal(g, arr[i].id);
                }
                else
                {
                    int ass = arr[i].assist+ g;
                    this.updatePlayerAsist(ass, arr[i].id);
                }
            } 
        }

    }
}
