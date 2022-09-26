using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_mundial
{
    public class CouchModel
    {
        public int id;
        public string name;
        public string surname;
        public int age;
        public int working_time;
        public int id_country;

        public CouchModel(int id, string name, string surname, int age, int working_time, int id_country)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.working_time = working_time;
            this.id_country = id_country;
        }

        public CouchModel(string name, string surname, int age, int working_time, int id_country)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.working_time = working_time;
            this.id_country = id_country;
        }
    }
}
