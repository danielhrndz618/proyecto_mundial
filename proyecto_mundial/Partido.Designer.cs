namespace proyecto_mundial
{
    partial class Partido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.team_1 = new System.Windows.Forms.Label();
            this.team_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_1 = new System.Windows.Forms.PictureBox();
            this.img_2 = new System.Windows.Forms.PictureBox();
            this.lbl_g = new System.Windows.Forms.Label();
            this.lbl_g2 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pic_winner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_winner)).BeginInit();
            this.SuspendLayout();
            // 
            // team_1
            // 
            this.team_1.AutoSize = true;
            this.team_1.Font = new System.Drawing.Font("Qatar2022 Arabic Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team_1.Location = new System.Drawing.Point(66, 48);
            this.team_1.Name = "team_1";
            this.team_1.Size = new System.Drawing.Size(190, 53);
            this.team_1.TabIndex = 0;
            this.team_1.Text = "Argentina";
            // 
            // team_2
            // 
            this.team_2.AutoSize = true;
            this.team_2.Font = new System.Drawing.Font("Qatar2022 Arabic Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team_2.Location = new System.Drawing.Point(533, 48);
            this.team_2.Name = "team_2";
            this.team_2.Size = new System.Drawing.Size(180, 53);
            this.team_2.TabIndex = 1;
            this.team_2.Text = "Alemania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Qatar2022 Arabic Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "vs";
            // 
            // img_1
            // 
            this.img_1.Location = new System.Drawing.Point(75, 121);
            this.img_1.Name = "img_1";
            this.img_1.Size = new System.Drawing.Size(241, 253);
            this.img_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_1.TabIndex = 3;
            this.img_1.TabStop = false;
            // 
            // img_2
            // 
            this.img_2.Location = new System.Drawing.Point(472, 121);
            this.img_2.Name = "img_2";
            this.img_2.Size = new System.Drawing.Size(241, 253);
            this.img_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_2.TabIndex = 4;
            this.img_2.TabStop = false;
            // 
            // lbl_g
            // 
            this.lbl_g.AutoSize = true;
            this.lbl_g.Font = new System.Drawing.Font("Qatar2022 Arabic Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_g.Location = new System.Drawing.Point(205, 389);
            this.lbl_g.Name = "lbl_g";
            this.lbl_g.Size = new System.Drawing.Size(42, 18);
            this.lbl_g.TabIndex = 5;
            this.lbl_g.Text = "label2";
            // 
            // lbl_g2
            // 
            this.lbl_g2.AutoSize = true;
            this.lbl_g2.Font = new System.Drawing.Font("Qatar2022 Arabic Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_g2.Location = new System.Drawing.Point(584, 389);
            this.lbl_g2.Name = "lbl_g2";
            this.lbl_g2.Size = new System.Drawing.Size(42, 18);
            this.lbl_g2.TabIndex = 6;
            this.lbl_g2.Text = "label2";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Qatar2022 Arabic Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(305, 48);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(227, 72);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Ganador";
            this.lbl_title.Visible = false;
            // 
            // pic_winner
            // 
            this.pic_winner.Location = new System.Drawing.Point(291, 121);
            this.pic_winner.Name = "pic_winner";
            this.pic_winner.Size = new System.Drawing.Size(241, 253);
            this.pic_winner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_winner.TabIndex = 8;
            this.pic_winner.TabStop = false;
            this.pic_winner.Visible = false;
            // 
            // Partido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 428);
            this.Controls.Add(this.pic_winner);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_g2);
            this.Controls.Add(this.lbl_g);
            this.Controls.Add(this.img_2);
            this.Controls.Add(this.img_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.team_2);
            this.Controls.Add(this.team_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Partido";
            this.Text = "Partido";
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_winner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label team_1;
        private System.Windows.Forms.Label team_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_1;
        private System.Windows.Forms.PictureBox img_2;
        private System.Windows.Forms.Label lbl_g;
        private System.Windows.Forms.Label lbl_g2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pic_winner;
    }
}