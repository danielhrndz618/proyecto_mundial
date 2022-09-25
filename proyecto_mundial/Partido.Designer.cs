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
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).BeginInit();
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
            // Partido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 428);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label team_1;
        private System.Windows.Forms.Label team_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_1;
        private System.Windows.Forms.PictureBox img_2;
    }
}