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

        public void createGame(TeamModel t1, TeamModel t2, HelperGame hg)
        {
            int x = hg.getRandomGoal();
            int y = hg.getRandomGoal();
            lbl_g.Text = x.ToString();
            lbl_g2.Text = y.ToString();
            PlayerController pc = new PlayerController();
            pc.setGoals(x, t1.id);
            pc.setGoals(y, t2.id);
            controller.insertGame(new GameModel(t1.id, t2.id, x, y, 2, 2, 2, 2, 2, 2, 2, 2, 2));
        }


        public void winner(TeamModel winner_team) {
            lbl_title.Visible = true;
            team_1.Visible = false;
            team_2.Visible = false;
            img_1.Visible = false;
            img_2.Visible = false;
            pic_winner.Visible = true;
            lbl_g.Visible = false;
            lbl_g2.Visible = false;
            this.ponerImagen(pic_winner, winner_team.name.ToLower());
        }

        public void fillData()
        {
            TeamController tc = new TeamController();
            var teams = tc.getTeams();
            HelperGame hg = new HelperGame();
            List<TeamModel> game_teams = hg.getFilteredTeams(teams);
            //List<TeamModel> game_teams = tc.getTeams();
            if(game_teams.Count == 2)
            {
                MessageBox.Show("Estamos jugando las finales");
                team_1.Text = game_teams[0].name;
                team_2.Text = game_teams[1].name;
                this.ponerImagen(img_1, team_1.Text.ToLower());
                this.ponerImagen(img_2, team_2.Text.ToLower());
                this.createGame(game_teams[0], game_teams[1], hg);
                return;
            }
            if(game_teams.Count < 2)
            {
                this.winner(game_teams[0]);
                return;
            }
            game_teams = hg.getGameTeams(teams);
            team_1.Text = game_teams[0].name;
            team_2.Text = game_teams[1].name;
            this.ponerImagen(img_1, team_1.Text.ToLower());
            this.ponerImagen(img_2, team_2.Text.ToLower());
            this.createGame(game_teams[0], game_teams[1], hg);
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
