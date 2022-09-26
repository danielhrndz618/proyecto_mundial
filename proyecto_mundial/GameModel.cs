using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_mundial
{
    public class GameModel
    {
        public int id;
        public int id_local;
        public int id_vis;
        public int vis_goals;
        public int local_goals;
        public int vis_shots;
        public int local_shots;
        public int local_desv_shots;
        public int vis_desv_shots;
        public int yellow_cards_l;
        public int yellow_cards_v;
        public int red_cards_v;
        public int red_cards_l;

        public GameModel(int id, int id_local, int id_vis, int vis_goals, int local_goals, int vis_shots, int local_shots, int local_desv_shots, int vis_desv_shots, int yellow_cards_l, int yellow_cards_v, int red_cards_v, int red_cards_l) : this(id, id_local, id_vis, vis_goals, local_goals, vis_shots, local_shots, local_desv_shots, vis_desv_shots, yellow_cards_l, yellow_cards_v, red_cards_v)
        {
            this.red_cards_l = red_cards_l;
        }

        public GameModel(int id_local, int id_vis, int local_goals, int vis_goals, int vis_shots, int local_shots, int local_desv_shots, int vis_desv_shots, int yellow_cards_l, int yellow_cards_v, int red_cards_v, int red_cards_l)
        {
            this.id_local = id_local;
            this.id_vis = id_vis;
            this.vis_goals = vis_goals;
            this.local_goals = local_goals;
            this.vis_shots = vis_shots;
            this.local_shots = local_shots;
            this.local_desv_shots = local_desv_shots;
            this.vis_desv_shots = vis_desv_shots;
            this.yellow_cards_l = yellow_cards_l;
            this.yellow_cards_v = yellow_cards_v;
            this.red_cards_v = red_cards_v;
            this.red_cards_l = red_cards_l;
        }

        public GameModel(int id, int id_l,int id_v, int g_v, int g_l)
        {
            this.id = id;
            this.id_vis = id_v;
            this.id_local = id_l;
            this.local_goals = g_l;
            this.vis_goals = g_v;
        }


    }
}
