using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_mundial
{
    public class TeamModel
    {
        public int id;
        public string name;
        public int cant;

        public TeamModel(int id, string name, int cant)
        {
            this.id = id;
            this.name = name;
            this.cant = cant;
        }

        public TeamModel(string name, int cant)
        {
            this.name = name;
            this.cant = cant;
        }
    }
}
