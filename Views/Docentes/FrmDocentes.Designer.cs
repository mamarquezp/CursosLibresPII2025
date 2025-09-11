namespace CursosLibres.Views.Docentes
{
	partial class FrmDocentes
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
            lblNombreDocente = new Label();
            txtBoxNombreDocente = new TextBox();
            txtBoxEspecialidadDocente = new TextBox();
            lblEspecialidadDocente = new Label();
            btnGuardadDocente = new Button();
            btnCancelarDocente = new Button();
            SuspendLayout();
            // 
            // lblNombreDocente
            // 
            lblNombreDocente.AutoSize = true;
            lblNombreDocente.Location = new Point(12, 9);
            lblNombreDocente.Name = "lblNombreDocente";
            lblNombreDocente.Size = new Size(152, 20);
            lblNombreDocente.TabIndex = 0;
            lblNombreDocente.Text = "Nombre del Docente:";
            // 
            // txtBoxNombreDocente
            // 
            txtBoxNombreDocente.Location = new Point(149, 32);
            txtBoxNombreDocente.Name = "txtBoxNombreDocente";
            txtBoxNombreDocente.PlaceholderText = "Ingrese el nombre del docente";
            txtBoxNombreDocente.Size = new Size(305, 27);
            txtBoxNombreDocente.TabIndex = 0;
            // 
            // txtBoxEspecialidadDocente
            // 
            txtBoxEspecialidadDocente.Location = new Point(149, 88);
            txtBoxEspecialidadDocente.Name = "txtBoxEspecialidadDocente";
            txtBoxEspecialidadDocente.PlaceholderText = "Ingrese la especialidad del docente";
            txtBoxEspecialidadDocente.Size = new Size(305, 27);
            txtBoxEspecialidadDocente.TabIndex = 1;
            // 
            // lblEspecialidadDocente
            // 
            lblEspecialidadDocente.AutoSize = true;
            lblEspecialidadDocente.Location = new Point(12, 65);
            lblEspecialidadDocente.Name = "lblEspecialidadDocente";
            lblEspecialidadDocente.Size = new Size(181, 20);
            lblEspecialidadDocente.TabIndex = 2;
            lblEspecialidadDocente.Text = "Especialidad del Docente:";
            // 
            // btnGuardadDocente
            // 
            btnGuardadDocente.Location = new Point(192, 134);
            btnGuardadDocente.Name = "btnGuardadDocente";
            btnGuardadDocente.Size = new Size(128, 43);
            btnGuardadDocente.TabIndex = 2;
            btnGuardadDocente.Text = "Guardar";
            btnGuardadDocente.UseVisualStyleBackColor = true;
            btnGuardadDocente.Click += btnGuardadDocente_Click;
            // 
            // btnCancelarDocente
            // 
            btnCancelarDocente.Location = new Point(326, 134);
            btnCancelarDocente.Name = "btnCancelarDocente";
            btnCancelarDocente.Size = new Size(128, 43);
            btnCancelarDocente.TabIndex = 3;
            btnCancelarDocente.Text = "Cancelar";
            btnCancelarDocente.UseVisualStyleBackColor = true;
            btnCancelarDocente.Click += btnCancelarDocente_Click;
            // 
            // FrmDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 194);
            Controls.Add(btnCancelarDocente);
            Controls.Add(btnGuardadDocente);
            Controls.Add(txtBoxEspecialidadDocente);
            Controls.Add(lblEspecialidadDocente);
            Controls.Add(txtBoxNombreDocente);
            Controls.Add(lblNombreDocente);
            Name = "FrmDocentes";
            Text = "Ingreso de Nuevos Docentes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreDocente;
        private TextBox txtBoxNombreDocente;
        private TextBox txtBoxEspecialidadDocente;
        private Label lblEspecialidadDocente;
        private Button btnGuardadDocente;
        private Button btnCancelarDocente;
    }
}