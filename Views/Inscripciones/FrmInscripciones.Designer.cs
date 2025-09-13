namespace CursosLibres.Views
{
	partial class FrmInscripciones
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
            lblAlumno = new Label();
            cmbBoxAlumnos = new ComboBox();
            cmbBoxCursos = new ComboBox();
            lblCurso = new Label();
            btnInscribir = new Button();
            lblResultado = new Label();
            dgvInscritos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInscritos).BeginInit();
            SuspendLayout();
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(12, 9);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(61, 20);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "Alumno";
            // 
            // cmbBoxAlumnos
            // 
            cmbBoxAlumnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxAlumnos.FormattingEnabled = true;
            cmbBoxAlumnos.Location = new Point(12, 32);
            cmbBoxAlumnos.Name = "cmbBoxAlumnos";
            cmbBoxAlumnos.Size = new Size(246, 28);
            cmbBoxAlumnos.TabIndex = 1;
            // 
            // cmbBoxCursos
            // 
            cmbBoxCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCursos.FormattingEnabled = true;
            cmbBoxCursos.Location = new Point(310, 32);
            cmbBoxCursos.Name = "cmbBoxCursos";
            cmbBoxCursos.Size = new Size(246, 28);
            cmbBoxCursos.TabIndex = 3;
            cmbBoxCursos.SelectedIndexChanged += cmbBoxCursos_SelectedIndexChanged;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(310, 9);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(46, 20);
            lblCurso.TabIndex = 2;
            lblCurso.Text = "Curso";
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(201, 89);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(167, 69);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribirse";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BorderStyle = BorderStyle.Fixed3D;
            lblResultado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(21, 166);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(2, 25);
            lblResultado.TabIndex = 5;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvInscritos
            // 
            dgvInscritos.AllowUserToAddRows = false;
            dgvInscritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInscritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscritos.Location = new Point(12, 207);
            dgvInscritos.Name = "dgvInscritos";
            dgvInscritos.ReadOnly = true;
            dgvInscritos.RowHeadersWidth = 51;
            dgvInscritos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscritos.Size = new Size(533, 215);
            dgvInscritos.TabIndex = 6;
            // 
            // FrmInscripciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 434);
            Controls.Add(dgvInscritos);
            Controls.Add(lblResultado);
            Controls.Add(btnInscribir);
            Controls.Add(cmbBoxCursos);
            Controls.Add(lblCurso);
            Controls.Add(cmbBoxAlumnos);
            Controls.Add(lblAlumno);
            Name = "FrmInscripciones";
            Text = "Inscripciones a Cursos";
            Load += FrmInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscritos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlumno;
        private ComboBox cmbBoxAlumnos;
        private ComboBox cmbBoxCursos;
        private Label lblCurso;
        private Button btnInscribir;
        private Label lblResultado;
        private DataGridView dgvInscritos;
    }
}