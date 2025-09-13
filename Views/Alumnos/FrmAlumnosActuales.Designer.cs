
namespace CursosLibres.Views
{
	partial class FrmAlumnosActuales
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
            flowPanelAlumnosActuales = new FlowLayoutPanel();
            txtBoxBuscarAlumnos = new TextBox();
            btnBuscarAlumnos = new Button();
            btnAnteriorAlumnosActuales = new Button();
            btnSiguienteAlumnosActuales = new Button();
            SuspendLayout();
            // 
            // flowPanelAlumnosActuales
            // 
            flowPanelAlumnosActuales.Location = new Point(12, 45);
            flowPanelAlumnosActuales.Name = "flowPanelAlumnosActuales";
            flowPanelAlumnosActuales.Size = new Size(427, 343);
            flowPanelAlumnosActuales.TabIndex = 0;
            // 
            // txtBoxBuscarAlumnos
            // 
            txtBoxBuscarAlumnos.Location = new Point(12, 12);
            txtBoxBuscarAlumnos.Name = "txtBoxBuscarAlumnos";
            txtBoxBuscarAlumnos.PlaceholderText = "Nombre del alumno que desea buscar";
            txtBoxBuscarAlumnos.Size = new Size(306, 27);
            txtBoxBuscarAlumnos.TabIndex = 0;
            // 
            // btnBuscarAlumnos
            // 
            btnBuscarAlumnos.Location = new Point(324, 12);
            btnBuscarAlumnos.Name = "btnBuscarAlumnos";
            btnBuscarAlumnos.Size = new Size(115, 29);
            btnBuscarAlumnos.TabIndex = 1;
            btnBuscarAlumnos.Text = "Buscar";
            btnBuscarAlumnos.UseVisualStyleBackColor = true;
            btnBuscarAlumnos.Click += btnBuscarAlumno_Click;
            // 
            // btnAnteriorDocentesActuales
            // 
            btnAnteriorAlumnosActuales.Location = new Point(11, 392);
            btnAnteriorAlumnosActuales.Name = "btnAnteriorAlumnosActuales";
            btnAnteriorAlumnosActuales.Size = new Size(139, 42);
            btnAnteriorAlumnosActuales.TabIndex = 3;
            btnAnteriorAlumnosActuales.Text = "Anterior";
            btnAnteriorAlumnosActuales.UseVisualStyleBackColor = true;
            btnAnteriorAlumnosActuales.Click += btnAnteriorAlumnosActuales_Click;
            // 
            // btnSiguienteAlumnosActuales
            // 
            btnSiguienteAlumnosActuales.Location = new Point(300, 394);
            btnSiguienteAlumnosActuales.Name = "btnSiguienteAlumnosActuales";
            btnSiguienteAlumnosActuales.Size = new Size(139, 42);
            btnSiguienteAlumnosActuales.TabIndex = 2;
            btnSiguienteAlumnosActuales.Text = "Siguiente";
            btnSiguienteAlumnosActuales.UseVisualStyleBackColor = true;
            btnSiguienteAlumnosActuales.Click += btnSiguienAlumnosActuales_Click;
            // 
            // FrmDocentesActuales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 445);
            Controls.Add(btnSiguienteAlumnosActuales);
            Controls.Add(btnAnteriorAlumnosActuales);
            Controls.Add(btnBuscarAlumnos);
            Controls.Add(txtBoxBuscarAlumnos);
            Controls.Add(flowPanelAlumnosActuales);
            Name = "FrmAlumnosActuales";
            Text = "Alumnos Actuales";
            Load += FrmAlumnosActuales_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private FlowLayoutPanel flowPanelAlumnosActuales;
        private TextBox txtBoxBuscarAlumnos;
        private Button btnBuscarAlumnos;
        private Button btnAnteriorAlumnosActuales;
        private Button btnSiguienteAlumnosActuales;
    }
}