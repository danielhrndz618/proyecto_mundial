using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        private void container_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
