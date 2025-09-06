namespace CursosLibres.Views.Cursos
{
    partial class FrmCursoNuevo
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
            lblTitulo = new Label();
            txtBoxTitulo = new TextBox();
            lblCategoria = new Label();
            txtBoxCupo = new TextBox();
            lblCupo = new Label();
            txtBoxCosto = new TextBox();
            lblCosto = new Label();
            lblDocente = new Label();
            cmbBoxDocente = new ComboBox();
            txtBoxCampus = new TextBox();
            lblCampus = new Label();
            txtBoxSalon = new TextBox();
            lblSalon = new Label();
            txtBoxEnlace = new TextBox();
            lblEnlace = new Label();
            txtBoxPlataforma = new TextBox();
            lblPlataforma = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            cmbBoxCategoria = new ComboBox();
            lblSesiones = new Label();
            dtpFechaSesion = new DateTimePicker();
            lblFecha = new Label();
            nupDuracion = new NumericUpDown();
            lblDuracion = new Label();
            dgvSesiones = new DataGridView();
            btnAgregaSesion = new Button();
            panel1 = new Panel();
            pnlPresencial = new Panel();
            pnlVirtual = new Panel();
            ((System.ComponentModel.ISupportInitialize)nupDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).BeginInit();
            panel1.SuspendLayout();
            pnlPresencial.SuspendLayout();
            pnlVirtual.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(116, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título del Curso:";
            // 
            // txtBoxTitulo
            // 
            txtBoxTitulo.Location = new Point(204, 12);
            txtBoxTitulo.Name = "txtBoxTitulo";
            txtBoxTitulo.PlaceholderText = "Ingrese el nombre del curso";
            txtBoxTitulo.Size = new Size(480, 27);
            txtBoxTitulo.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 48);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría:";
            // 
            // txtBoxCupo
            // 
            txtBoxCupo.Location = new Point(204, 78);
            txtBoxCupo.Name = "txtBoxCupo";
            txtBoxCupo.PlaceholderText = "Ingrese el cupo máximo del curso";
            txtBoxCupo.Size = new Size(480, 27);
            txtBoxCupo.TabIndex = 5;
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(12, 81);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(105, 20);
            lblCupo.TabIndex = 4;
            lblCupo.Text = "Cupo Máximo:";
            // 
            // txtBoxCosto
            // 
            txtBoxCosto.Location = new Point(204, 111);
            txtBoxCosto.Name = "txtBoxCosto";
            txtBoxCosto.PlaceholderText = "Ingrese el costo del curso";
            txtBoxCosto.Size = new Size(480, 27);
            txtBoxCosto.TabIndex = 7;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(12, 114);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(116, 20);
            lblCosto.TabIndex = 6;
            lblCosto.Text = "Costo del Curso:";
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.Location = new Point(12, 147);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(134, 20);
            lblDocente.TabIndex = 8;
            lblDocente.Text = "Docente del Curso:";
            // 
            // cmbBoxDocente
            // 
            cmbBoxDocente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxDocente.FormattingEnabled = true;
            cmbBoxDocente.Location = new Point(204, 144);
            cmbBoxDocente.Name = "cmbBoxDocente";
            cmbBoxDocente.Size = new Size(480, 28);
            cmbBoxDocente.TabIndex = 9;
            // 
            // txtBoxCampus
            // 
            txtBoxCampus.Location = new Point(196, 7);
            txtBoxCampus.Name = "txtBoxCampus";
            txtBoxCampus.PlaceholderText = "Ingrese el campus donde se imparte el curso";
            txtBoxCampus.Size = new Size(480, 27);
            txtBoxCampus.TabIndex = 13;
            // 
            // lblCampus
            // 
            lblCampus.AutoSize = true;
            lblCampus.Location = new Point(4, 10);
            lblCampus.Name = "lblCampus";
            lblCampus.Size = new Size(65, 20);
            lblCampus.TabIndex = 12;
            lblCampus.Text = "Campus:";
            // 
            // txtBoxSalon
            // 
            txtBoxSalon.Location = new Point(196, 40);
            txtBoxSalon.Name = "txtBoxSalon";
            txtBoxSalon.PlaceholderText = "Ingrese el salón donde se imparte el curso";
            txtBoxSalon.Size = new Size(480, 27);
            txtBoxSalon.TabIndex = 15;
            // 
            // lblSalon
            // 
            lblSalon.AutoSize = true;
            lblSalon.Location = new Point(4, 43);
            lblSalon.Name = "lblSalon";
            lblSalon.Size = new Size(49, 20);
            lblSalon.TabIndex = 14;
            lblSalon.Text = "Salón:";
            // 
            // txtBoxEnlace
            // 
            txtBoxEnlace.Location = new Point(197, 3);
            txtBoxEnlace.Name = "txtBoxEnlace";
            txtBoxEnlace.PlaceholderText = "Ingrese el enlace del curso";
            txtBoxEnlace.Size = new Size(480, 27);
            txtBoxEnlace.TabIndex = 17;
            // 
            // lblEnlace
            // 
            lblEnlace.AutoSize = true;
            lblEnlace.Location = new Point(5, 6);
            lblEnlace.Name = "lblEnlace";
            lblEnlace.Size = new Size(96, 20);
            lblEnlace.TabIndex = 16;
            lblEnlace.Text = "Enlace Curso:";
            lblEnlace.UseMnemonic = false;
            // 
            // txtBoxPlataforma
            // 
            txtBoxPlataforma.Location = new Point(197, 36);
            txtBoxPlataforma.Name = "txtBoxPlataforma";
            txtBoxPlataforma.PlaceholderText = "Ingrese la plataforma donde se imparte el curso";
            txtBoxPlataforma.Size = new Size(480, 27);
            txtBoxPlataforma.TabIndex = 19;
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Location = new Point(5, 39);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(85, 20);
            lblPlataforma.TabIndex = 18;
            lblPlataforma.Text = "Plataforma:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(543, 661);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(132, 29);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(405, 661);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 29);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbBoxCategoria
            // 
            cmbBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCategoria.FormattingEnabled = true;
            cmbBoxCategoria.Location = new Point(204, 45);
            cmbBoxCategoria.Name = "cmbBoxCategoria";
            cmbBoxCategoria.Size = new Size(480, 28);
            cmbBoxCategoria.TabIndex = 22;
            cmbBoxCategoria.SelectedIndexChanged += cmbBoxCategoria_SelectedIndexChanged;
            // 
            // lblSesiones
            // 
            lblSesiones.AutoSize = true;
            lblSesiones.Location = new Point(1, 1);
            lblSesiones.Name = "lblSesiones";
            lblSesiones.Size = new Size(69, 20);
            lblSesiones.TabIndex = 10;
            lblSesiones.Text = "Sesiones:";
            // 
            // dtpFechaSesion
            // 
            dtpFechaSesion.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaSesion.Format = DateTimePickerFormat.Custom;
            dtpFechaSesion.Location = new Point(193, 34);
            dtpFechaSesion.MinDate = new DateTime(2025, 9, 1, 0, 0, 0, 0);
            dtpFechaSesion.Name = "dtpFechaSesion";
            dtpFechaSesion.ShowUpDown = true;
            dtpFechaSesion.Size = new Size(150, 27);
            dtpFechaSesion.TabIndex = 23;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1, 39);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 24;
            lblFecha.Text = "Fecha:";
            // 
            // nupDuracion
            // 
            nupDuracion.Location = new Point(193, 67);
            nupDuracion.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nupDuracion.Name = "nupDuracion";
            nupDuracion.Size = new Size(150, 27);
            nupDuracion.TabIndex = 25;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(0, 69);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(139, 20);
            lblDuracion.TabIndex = 26;
            lblDuracion.Text = "Duración (Minutos):";
            // 
            // dgvSesiones
            // 
            dgvSesiones.AllowUserToOrderColumns = true;
            dgvSesiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesiones.Location = new Point(192, 100);
            dgvSesiones.Name = "dgvSesiones";
            dgvSesiones.RowHeadersWidth = 51;
            dgvSesiones.Size = new Size(333, 219);
            dgvSesiones.TabIndex = 27;
            // 
            // btnAgregaSesion
            // 
            btnAgregaSesion.Location = new Point(349, 34);
            btnAgregaSesion.Name = "btnAgregaSesion";
            btnAgregaSesion.Size = new Size(176, 60);
            btnAgregaSesion.TabIndex = 28;
            btnAgregaSesion.Text = "Añadir Sesión";
            btnAgregaSesion.UseVisualStyleBackColor = true;
            btnAgregaSesion.Click += btnAgregaSesion_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAgregaSesion);
            panel1.Controls.Add(dgvSesiones);
            panel1.Controls.Add(lblDuracion);
            panel1.Controls.Add(nupDuracion);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(dtpFechaSesion);
            panel1.Controls.Add(lblSesiones);
            panel1.Location = new Point(12, 310);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 332);
            panel1.TabIndex = 24;
            // 
            // pnlPresencial
            // 
            pnlPresencial.Controls.Add(txtBoxCampus);
            pnlPresencial.Controls.Add(lblCampus);
            pnlPresencial.Controls.Add(lblSalon);
            pnlPresencial.Controls.Add(txtBoxSalon);
            pnlPresencial.Location = new Point(8, 172);
            pnlPresencial.Name = "pnlPresencial";
            pnlPresencial.Size = new Size(676, 72);
            pnlPresencial.TabIndex = 25;
            // 
            // pnlVirtual
            // 
            pnlVirtual.Controls.Add(txtBoxEnlace);
            pnlVirtual.Controls.Add(lblEnlace);
            pnlVirtual.Controls.Add(lblPlataforma);
            pnlVirtual.Controls.Add(txtBoxPlataforma);
            pnlVirtual.Location = new Point(8, 245);
            pnlVirtual.Name = "pnlVirtual";
            pnlVirtual.Size = new Size(676, 60);
            pnlVirtual.TabIndex = 26;
            // 
            // FrmCursoNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 702);
            Controls.Add(pnlVirtual);
            Controls.Add(pnlPresencial);
            Controls.Add(panel1);
            Controls.Add(cmbBoxCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbBoxDocente);
            Controls.Add(lblDocente);
            Controls.Add(txtBoxCosto);
            Controls.Add(lblCosto);
            Controls.Add(txtBoxCupo);
            Controls.Add(lblCupo);
            Controls.Add(lblCategoria);
            Controls.Add(txtBoxTitulo);
            Controls.Add(lblTitulo);
            Name = "FrmCursoNuevo";
            Text = "Crear Nuevo Curso";
            ((System.ComponentModel.ISupportInitialize)nupDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlPresencial.ResumeLayout(false);
            pnlPresencial.PerformLayout();
            pnlVirtual.ResumeLayout(false);
            pnlVirtual.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtBoxTitulo;
        private Label lblCategoria;
        private TextBox txtBoxCupo;
        private Label lblCupo;
        private TextBox txtBoxCosto;
        private Label lblCosto;
        private Label lblDocente;
        private ComboBox cmbBoxDocente;
        private TextBox txtBoxCampus;
        private Label lblCampus;
        private TextBox txtBoxSalon;
        private Label lblSalon;
        private TextBox txtBoxEnlace;
        private Label lblEnlace;
        private TextBox txtBoxPlataforma;
        private Label lblPlataforma;
        private Button btnLimpiar;
        private Button btnGuardar;
        private ComboBox cmbBoxCategoria;
        private Label lblSesiones;
        private DateTimePicker dtpFechaSesion;
        private Label lblFecha;
        private NumericUpDown nupDuracion;
        private Label lblDuracion;
        private DataGridView dgvSesiones;
        private Button btnAgregaSesion;
        private Panel panel1;
        private Panel pnlPresencial;
        private Panel pnlVirtual;
    }
}