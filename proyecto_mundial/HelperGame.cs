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





    }
}
