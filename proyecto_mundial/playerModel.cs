using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_mundial
{
    public class playerModel
    {
        public int id;
        public string name;
        public string surname;
        public int edad;
        public string position;
        public int assist;
        public int minutos;
        public int id_pais;
        public int gol;

        public playerModel(int id, string name, string surname, int edad, string position, int assist, int minutos, int id_pais, int gol)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.edad = edad;
            this.position = position;
            this.assist = assist;
            this.minutos = minutos;
            this.id_pais = id_pais;
            this.gol = gol;
        }

        public playerModel(string name, string surname, int edad, string position, int assist, int minutos, int id_pais, int gol)
        {
            this.name = name;
            this.surname = surname;
            this.edad = edad;
            this.position = position;
            this.assist = assist;
            this.minutos = minutos;
            this.id_pais = id_pais;
            this.gol = gol;
        }

        public playerModel(int id, int g, int a, String pos, int min)
        {
            this.id = id;
            this.gol = g;
            this.assist = a;
            this.position = pos;
            this.minutos = min;
        }

        public playerModel(String nombre, int gol, int minutos, int assist, int id_pais)
        {
            this.name = nombre;
            this.assist = assist;
            this.minutos = minutos;
            this.id_pais = id_pais;
            this.gol = gol;
        }
    }
}
