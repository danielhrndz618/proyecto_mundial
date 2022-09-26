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

    }
}
