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
            txtBoxCategoria = new TextBox();
            lblCategoria = new Label();
            txtBoxCupo = new TextBox();
            lblCupo = new Label();
            txtBoxCosto = new TextBox();
            lblCosto = new Label();
            lblDocente = new Label();
            cmbBoxDocente = new ComboBox();
            lblSesiones = new Label();
            cmbBoxSesion = new ComboBox();
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
            // txtBoxCategoria
            // 
            txtBoxCategoria.Location = new Point(204, 45);
            txtBoxCategoria.Name = "txtBoxCategoria";
            txtBoxCategoria.PlaceholderText = "Ingrese la categoría del curso";
            txtBoxCategoria.Size = new Size(480, 27);
            txtBoxCategoria.TabIndex = 3;
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
            // lblSesiones
            // 
            lblSesiones.AutoSize = true;
            lblSesiones.Location = new Point(12, 181);
            lblSesiones.Name = "lblSesiones";
            lblSesiones.Size = new Size(69, 20);
            lblSesiones.TabIndex = 10;
            lblSesiones.Text = "Sesiones:";
            // 
            // cmbBoxSesion
            // 
            cmbBoxSesion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSesion.FormattingEnabled = true;
            cmbBoxSesion.Location = new Point(204, 178);
            cmbBoxSesion.Name = "cmbBoxSesion";
            cmbBoxSesion.Size = new Size(480, 28);
            cmbBoxSesion.TabIndex = 11;
            // 
            // txtBoxCampus
            // 
            txtBoxCampus.Location = new Point(204, 212);
            txtBoxCampus.Name = "txtBoxCampus";
            txtBoxCampus.PlaceholderText = "Ingrese el campus donde se imparte el curso";
            txtBoxCampus.Size = new Size(480, 27);
            txtBoxCampus.TabIndex = 13;
            // 
            // lblCampus
            // 
            lblCampus.AutoSize = true;
            lblCampus.Location = new Point(12, 215);
            lblCampus.Name = "lblCampus";
            lblCampus.Size = new Size(65, 20);
            lblCampus.TabIndex = 12;
            lblCampus.Text = "Campus:";
            // 
            // txtBoxSalon
            // 
            txtBoxSalon.Location = new Point(204, 245);
            txtBoxSalon.Name = "txtBoxSalon";
            txtBoxSalon.PlaceholderText = "Ingrese el salón donde se imparte el curso";
            txtBoxSalon.Size = new Size(480, 27);
            txtBoxSalon.TabIndex = 15;
            // 
            // lblSalon
            // 
            lblSalon.AutoSize = true;
            lblSalon.Location = new Point(12, 248);
            lblSalon.Name = "lblSalon";
            lblSalon.Size = new Size(49, 20);
            lblSalon.TabIndex = 14;
            lblSalon.Text = "Salón:";
            // 
            // txtBoxEnlace
            // 
            txtBoxEnlace.Location = new Point(204, 278);
            txtBoxEnlace.Name = "txtBoxEnlace";
            txtBoxEnlace.PlaceholderText = "Ingrese el enlace del curso";
            txtBoxEnlace.Size = new Size(480, 27);
            txtBoxEnlace.TabIndex = 17;
            // 
            // lblEnlace
            // 
            lblEnlace.AutoSize = true;
            lblEnlace.Location = new Point(12, 281);
            lblEnlace.Name = "lblEnlace";
            lblEnlace.Size = new Size(96, 20);
            lblEnlace.TabIndex = 16;
            lblEnlace.Text = "Enlace Curso:";
            lblEnlace.UseMnemonic = false;
            // 
            // txtBoxPlataforma
            // 
            txtBoxPlataforma.Location = new Point(204, 311);
            txtBoxPlataforma.Name = "txtBoxPlataforma";
            txtBoxPlataforma.PlaceholderText = "Ingrese la plataforma donde se imparte el curso";
            txtBoxPlataforma.Size = new Size(480, 27);
            txtBoxPlataforma.TabIndex = 19;
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Location = new Point(12, 314);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(85, 20);
            lblPlataforma.TabIndex = 18;
            lblPlataforma.Text = "Plataforma:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(543, 397);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(132, 29);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(405, 397);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 29);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmCursoNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtBoxPlataforma);
            Controls.Add(lblPlataforma);
            Controls.Add(txtBoxEnlace);
            Controls.Add(lblEnlace);
            Controls.Add(txtBoxSalon);
            Controls.Add(lblSalon);
            Controls.Add(txtBoxCampus);
            Controls.Add(lblCampus);
            Controls.Add(cmbBoxSesion);
            Controls.Add(lblSesiones);
            Controls.Add(cmbBoxDocente);
            Controls.Add(lblDocente);
            Controls.Add(txtBoxCosto);
            Controls.Add(lblCosto);
            Controls.Add(txtBoxCupo);
            Controls.Add(lblCupo);
            Controls.Add(txtBoxCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtBoxTitulo);
            Controls.Add(lblTitulo);
            Name = "FrmCursoNuevo";
            Text = "Crear Nuevo Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtBoxTitulo;
        private TextBox txtBoxCategoria;
        private Label lblCategoria;
        private TextBox txtBoxCupo;
        private Label lblCupo;
        private TextBox txtBoxCosto;
        private Label lblCosto;
        private Label lblDocente;
        private ComboBox cmbBoxDocente;
        private Label lblSesiones;
        private ComboBox cmbBoxSesion;
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
    }
}