namespace proyecto_mundial
{
    partial class EstJugador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_players = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_players)).BeginInit();
            this.SuspendLayout();
            // 
            // data_players
            // 
            this.data_players.AllowUserToAddRows = false;
            this.data_players.AllowUserToDeleteRows = false;
            this.data_players.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.data_players.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Qatar2022 Arabic Bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_players.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_players.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Jugador,
            this.Goles,
            this.Asistencias,
            this.Minutos,
            this.Seleccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_players.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_players.EnableHeadersVisualStyles = false;
            this.data_players.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(121)))));
            this.data_players.Location = new System.Drawing.Point(81, 43);
            this.data_players.Margin = new System.Windows.Forms.Padding(2);
            this.data_players.Name = "data_players";
            this.data_players.ReadOnly = true;
            this.data_players.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Qatar2022 Arabic Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(118)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.data_players.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_players.RowTemplate.Height = 24;
            this.data_players.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_players.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_players.Size = new System.Drawing.Size(607, 342);
            this.data_players.TabIndex = 29;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Jugador
            // 
            this.Jugador.HeaderText = "Jugador";
            this.Jugador.Name = "Jugador";
            this.Jugador.ReadOnly = true;
            // 
            // Goles
            // 
            this.Goles.HeaderText = "Goles";
            this.Goles.Name = "Goles";
            this.Goles.ReadOnly = true;
            // 
            // Asistencias
            // 
            this.Asistencias.HeaderText = "Asistencias";
            this.Asistencias.Name = "Asistencias";
            this.Asistencias.ReadOnly = true;
            // 
            // Minutos
            // 
            this.Minutos.HeaderText = "Minutos";
            this.Minutos.Name = "Minutos";
            this.Minutos.ReadOnly = true;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.ReadOnly = true;
            // 
            // EstJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 428);
            this.Controls.Add(this.data_players);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstJugador";
            this.Text = "EstJugador";
            ((System.ComponentModel.ISupportInitialize)(this.data_players)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_players;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccion;
    }
}