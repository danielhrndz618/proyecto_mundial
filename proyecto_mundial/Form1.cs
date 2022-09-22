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
    public partial class Form1 : Form
    {

        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            this.activeForm = null;
        }

        private void add_team_Click(object sender, EventArgs e)
        {
            this.openForm(new addTeam());
        }

        private void add_player_Click(object sender, EventArgs e)
        {
            this.openForm(new addPlayer());
        }

        private void add_couch_Click(object sender, EventArgs e)
        {

            this.openForm(new addCouch());
        }

        private void btn_game_Click(object sender, EventArgs e)
        {

            this.openForm(new Partido());
        }

        public void openForm(Form child)
        {
            if(this.activeForm != null)
            {
                this.activeForm.Close();
            }
            this.activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            this.container_center.Controls.Add(child);
            this.container_center.Tag = child;
            child.BringToFront();
            child.Show();
        }
    }
}
