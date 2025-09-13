namespace CursosLibres.Views.Alumnos
{
	partial class FrmNuevoAlumno
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
            lblNombreAlumno = new Label();
            txtBoxNombreAlumno = new TextBox();
            txtBoxCorreoAlumno = new TextBox();
            lblCorreoAlumno = new Label();
            btnGuardarAlumno = new Button();
            btnCancelarAlumno = new Button();
            SuspendLayout();
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Location = new Point(12, 9);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(152, 20);
            lblNombreAlumno.TabIndex = 0;
            lblNombreAlumno.Text = "Nombre del Alumno:";
            // 
            // txtBoxNombreAlumno
            // 
            txtBoxNombreAlumno.Location = new Point(149, 32);
            txtBoxNombreAlumno.Name = "txtBoxNombreAlumno";
            txtBoxNombreAlumno.PlaceholderText = "Ingrese el nombre del alumno";
            txtBoxNombreAlumno.Size = new Size(305, 27);
            txtBoxNombreAlumno.TabIndex = 0;
            // 
            // txtBoxCorreoAlumno
            // 
            txtBoxCorreoAlumno.Location = new Point(149, 88);
            txtBoxCorreoAlumno.Name = "txtBoxCorreoAlumno";
            txtBoxCorreoAlumno.PlaceholderText = "Ingrese la correo del alumno";
            txtBoxCorreoAlumno.Size = new Size(305, 27);
            txtBoxCorreoAlumno.TabIndex = 1;
            // 
            // lblEspecialidadDocente
            // 
            lblCorreoAlumno.AutoSize = true;
            lblCorreoAlumno.Location = new Point(12, 65);
            lblCorreoAlumno.Name = "lblCorreoAlumno";
            lblCorreoAlumno.Size = new Size(181, 20);
            lblCorreoAlumno.TabIndex = 2;
            lblCorreoAlumno.Text = "Correo del Alumno:";
            // 
            // btnGuardadDocente
            // 
            btnGuardarAlumno.Location = new Point(192, 134);
            btnGuardarAlumno.Name = "btnGuardadDocente";
            btnGuardarAlumno.Size = new Size(128, 43);
            btnGuardarAlumno.TabIndex = 2;
            btnGuardarAlumno.Text = "Guardar";
            btnGuardarAlumno.UseVisualStyleBackColor = true;
            btnGuardarAlumno.Click += btnGuardadAlumno_Click;
            // 
            // btnCancelarDocente
            // 
            btnCancelarAlumno.Location = new Point(326, 134);
            btnCancelarAlumno.Name = "btnCancelarDocente";
            btnCancelarAlumno.Size = new Size(128, 43);
            btnCancelarAlumno.TabIndex = 3;
            btnCancelarAlumno.Text = "Cancelar";
            btnCancelarAlumno.UseVisualStyleBackColor = true;
            btnCancelarAlumno.Click += btnCancelarAlumno_Click;
            // 
            // FrmDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 194);
            Controls.Add(btnCancelarAlumno);
            Controls.Add(btnGuardarAlumno);
            Controls.Add(txtBoxCorreoAlumno);
            Controls.Add(lblCorreoAlumno);
            Controls.Add(txtBoxNombreAlumno);
            Controls.Add(lblNombreAlumno);
            Name = "FrmNuevoAlumno";
            Text = "Ingreso de Nuevos Alumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreAlumno;
        private TextBox txtBoxNombreAlumno;
        private TextBox txtBoxCorreoAlumno;
        private Label lblCorreoAlumno;
        private Button btnGuardarAlumno;
        private Button btnCancelarAlumno;
    }
}