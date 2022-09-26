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
    public partial class addCouch : Form
    {
        private List<TeamModel> teams;
        public addCouch()
        {
            InitializeComponent();
            this.teams = new List<TeamModel>();
            this.fillTeams();
        }

        public void clearComponents()
        {
            txt_age.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_time.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clearComponents();
        }


        public void fillTeams()
        {
            TeamController tc = new TeamController();
             teams = tc.getTeams();
            foreach(TeamModel team in teams)
            {
                this.cmb_country.Items.Add(team.name);
            }
        }

        public int getId(String name)
        {
            foreach(TeamModel team in this.teams)
            {
                Console.WriteLine(team.name+ " and " + name);
                if (team.name.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("Es Esta!");
                    return team.id;
                }
            }
            return -1;
        }

        public bool isEmpty()
        {
            return txt_nombre.Text == "" || txt_apellido.Text == "" || txt_time.Text == "" || txt_age.Text == "";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Debe rellenar todos los campos anteriores :(");
            }
            else
            {
                CouchController couchController = new CouchController();
                String name_pais = this.cmb_country.GetItemText(this.cmb_country.SelectedItem);
                int id_pais = this.getId(name_pais);
                CouchModel couch = new CouchModel(txt_nombre.Text, txt_apellido.Text, Convert.ToInt32(txt_age.Text), Convert.ToInt32(txt_time.Text), id_pais);
                couchController.insertCouch(couch);
                this.clearComponents();
                MessageBox.Show("Entrenador Guardado :D");
            }
        }
    }
}
