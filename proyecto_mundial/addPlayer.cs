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
    public partial class addPlayer : Form
    {
        private List<TeamModel> teams;
        public addPlayer()
        {
            InitializeComponent();
            this.teams = new List<TeamModel>();
            this.fillTeams();
        }

        public void fillTeams()
        {
            TeamController tc = new TeamController();
             teams = tc.getTeams();
            foreach(TeamModel team in teams)
            {
                this.team_combo.Items.Add(team.name);
            }
        }

        public int getId(String name)
        {
            foreach(TeamModel team in this.teams)
            {
                if(team.name.Equals(name)) return team.id;
            }
            return -1;
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {

            String name_pais = this.team_combo.GetItemText(this.team_combo.SelectedItem);
            int id_pais = this.getId(name_pais);

            playerModel player = new playerModel(txt_nombre.Text
                , txt_apellido.Text,
                date_picker.Text,
                txt_posicion.Text,
                Convert.ToInt32(txt_asistencias.Text),
                Convert.ToInt32(txt_minutos.Text),
                id_pais,
                Convert.ToInt32(txt_gol.Text));

        }
    }
}






