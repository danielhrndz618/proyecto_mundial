using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyecto_mundial
{
    public partial class Partido : Form
    {
        GameController controller;
        public Partido()
        {
            InitializeComponent();
            controller = new GameController();
            this.fillData();
        }

        public void createGame(TeamModel t1, TeamModel t2)
        {
            controller.insertGame(new GameModel(t1.id, t2.id, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2));
        }

        public void fillData()
        {
            TeamController tc = new TeamController();
            var teams = tc.getTeams();
            HelperGame hg = new HelperGame();
            List<TeamModel> game_teams = hg.getFilteredTeams(teams);
            if(game_teams.Count == 2)
            {
                MessageBox.Show("Estsamos jugando las finales");
            }
            if(game_teams.Count < 2)
            {
                MessageBox.Show("El ganador es: ", game_teams[0].name);
                return;
            }
            game_teams = hg.getGameTeams(teams);
            team_1.Text = game_teams[0].name;
            team_2.Text = game_teams[1].name;
            this.ponerImagen(img_1, team_1.Text.ToLower());
            this.ponerImagen(img_2, team_2.Text.ToLower());
            this.createGame(game_teams[0], game_teams[1]);
        }
        public bool fileExist(string path, string filename)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                if (String.Compare(file.Name, filename) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void ponerImagen(PictureBox pic, String pais)
        {
            if(pais == "")
            {
                pic.Image.Dispose();
                pic.Image = null;
                return;
            }
            if (fileExist("./Banderas", pais + ".png"))
            {
                pic.ImageLocation = "./Banderas/" + pais + ".png";
            }
        }
    }
}
