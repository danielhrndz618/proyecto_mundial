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
    public partial class addTeam : Form
    {
        public addTeam()
        {
            InitializeComponent();
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

        private void btn_bandera_Click(object sender, EventArgs e)
        {
            /*String dir = Environment.CurrentDirectory;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccione la bandera";
            ofd.InitialDirectory = dir;
            ofd.RestoreDirectory = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = System.IO.Path.GetFullPath(ofd.FileName);
            }
            */
        }

        public void ponerImagen(String pais)
        {
            if(pais == "")
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                return;
            }
            if (fileExist("./Banderas", pais + ".png"))
            {
                pictureBox1.ImageLocation = "./Banderas/" + pais + ".png";
            } 
        }


        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            this.ponerImagen(txt_nombre.Text.ToLower());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void clearComponents()
        {
            txt_nombre.Text = "";
            txt_cant.Text = "";
            pictureBox1.Dispose();
            pictureBox1.Image = null;
        }

        public bool componentIsEmpty()
        {
            return txt_nombre.Text == "" && txt_cant.Text == "";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (this.componentIsEmpty())
            {
                MessageBox.Show("Debe completar los campos");
                return;
            }

            TeamModel team = new TeamModel(txt_nombre.Text, Convert.ToInt32(txt_cant.Text));
            DatabaseController db = new DatabaseController();
            TeamController teamc = new TeamController();
            teamc.insertTeam(team);
            MessageBox.Show("Equipo insertado :D");
            this.clearComponents();
        }
    }
}
