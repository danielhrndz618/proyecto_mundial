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

        public int getRandomGoal()
        {
            return random_generator.Next(0, 5);
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
            int pos = 0;
            foreach(TeamModel team in teams)
            {
                if(team.id == id)
                {
                    break;
                }
                pos++;
            }
            teams.RemoveAt(pos);
            return teams;
        }

        public List<TeamModel> getFilteredTeams(List<TeamModel> teams)
        {
            GameController gc = new GameController();
            List<GameModel> arr = gc.getGames();
            List<TeamModel> arr_c = teams; 
            foreach(GameModel game in arr)
            {
                Console.WriteLine("Local: " + game.local_goals);
                Console.WriteLine("Visitante: " + game.vis_goals);
                if(game.local_goals > game.vis_goals)
                {
                    arr_c = removeById(game.id_vis, teams);
                }
                if(game.vis_goals > game.local_goals)
                {
                    arr_c = removeById(game.id_local, teams);
                }
            }
            return arr_c;
        }



        






    }
}
