using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_mundial
{
    public partial class EstJugador : Form
    {
        public EstJugador()
        {
            InitializeComponent();
            this.fillData();
        }

        public String getPais(int id)
        {
            TeamController tc = new TeamController();
            List<TeamModel> teams = tc.getTeams();
            foreach (TeamModel team in teams)
            {
                if (id == team.id) return team.name;
            }
            return "";
        }

        public void fillData()
        {
            PlayerController pc = new PlayerController();
            List<playerModel> arr = pc.getPlayersWithPais();
            foreach (playerModel player in arr)
            {
                String pais = this.getPais(player.id_pais);
                this.data_players.Rows.Add(player.id, player.name, player.gol, player.assist, player.minutos, pais);
            }
        }
    }
}
