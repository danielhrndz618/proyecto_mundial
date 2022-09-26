using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_mundial
{
    public class HelperGame
    {
        public Random random_generator;
        public HelperGame()
        {
            this.random_generator = new Random();
        }

        public int getRandPos(int size)
        {
            return random_generator.Next(0, size);
        }


        public List<TeamModel> getGameTeams(List<TeamModel> teams)
        {
            int x = this.getRandPos(teams.Count);
            List<TeamModel> game_teams = new List<TeamModel>();
            game_teams.Add(teams[x]);
            teams.Remove(teams[x]);
            int y = this.getRandPos(teams.Count);
            game_teams.Add(teams[y]);
            return game_teams;
        }


        public List<TeamModel> removeById(int id, List<TeamModel> teams)
        {
            foreach(TeamModel team in teams)
            {
                if(team.id == id)
                {
                    teams.Remove(team);
                }
            }
            return teams;
        }

        public List<TeamModel> getFilteredTeams(List<TeamModel> teams)
        {
            GameController gc = new GameController();
            List<GameModel> arr = gc.getGames();
            int pos = 0;
            foreach(GameModel game in arr)
            {
                teams = removeById(game.id_vis, teams);
                teams = removeById(game.id_local, teams);
            }
            return teams;
        }



        






    }
}
