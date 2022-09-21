namespace proyecto_mundial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.container = new System.Windows.Forms.Panel();
            this.container_top = new System.Windows.Forms.Panel();
            this.container_left = new System.Windows.Forms.Panel();
            this.container_center = new System.Windows.Forms.Panel();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.container_center);
            this.container.Controls.Add(this.container_left);
            this.container.Controls.Add(this.container_top);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1005, 493);
            this.container.TabIndex = 0;
            // 
            // container_top
            // 
            this.container_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(121)))));
            this.container_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.container_top.Location = new System.Drawing.Point(0, 0);
            this.container_top.Name = "container_top";
            this.container_top.Size = new System.Drawing.Size(1005, 26);
            this.container_top.TabIndex = 0;
            // 
            // container_left
            // 
            this.container_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.container_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.container_left.Location = new System.Drawing.Point(0, 26);
            this.container_left.Name = "container_left";
            this.container_left.Size = new System.Drawing.Size(213, 467);
            this.container_left.TabIndex = 1;
            // 
            // container_center
            // 
            this.container_center.BackColor = System.Drawing.Color.Black;
            this.container_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_center.Location = new System.Drawing.Point(213, 26);
            this.container_center.Name = "container_center";
            this.container_center.Size = new System.Drawing.Size(792, 467);
            this.container_center.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 493);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel container_center;
        private System.Windows.Forms.Panel container_left;
        private System.Windows.Forms.Panel container_top;
    }
}

