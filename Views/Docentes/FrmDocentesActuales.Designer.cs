
namespace CursosLibres.Views
{
	partial class FrmDocentesActuales
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
            flowPanelDocenteActual = new FlowLayoutPanel();
            txtBoxBuscarDocente = new TextBox();
            btnBuscarDocente = new Button();
            btnAnteriorDocentesActuales = new Button();
            btnSiguienteDocentesActuales = new Button();
            SuspendLayout();
            // 
            // flowPanelDocenteActual
            // 
            flowPanelDocenteActual.Location = new Point(12, 45);
            flowPanelDocenteActual.Name = "flowPanelDocenteActual";
            flowPanelDocenteActual.Size = new Size(427, 343);
            flowPanelDocenteActual.TabIndex = 0;
            // 
            // txtBoxBuscarDocente
            // 
            txtBoxBuscarDocente.Location = new Point(12, 12);
            txtBoxBuscarDocente.Name = "txtBoxBuscarDocente";
            txtBoxBuscarDocente.PlaceholderText = "Nombre del docente que desea buscar";
            txtBoxBuscarDocente.Size = new Size(306, 27);
            txtBoxBuscarDocente.TabIndex = 0;
            // 
            // btnBuscarDocente
            // 
            btnBuscarDocente.Location = new Point(324, 12);
            btnBuscarDocente.Name = "btnBuscarDocente";
            btnBuscarDocente.Size = new Size(115, 29);
            btnBuscarDocente.TabIndex = 1;
            btnBuscarDocente.Text = "Buscar";
            btnBuscarDocente.UseVisualStyleBackColor = true;
            btnBuscarDocente.Click += btnBuscar_Click;
            // 
            // btnAnteriorDocentesActuales
            // 
            btnAnteriorDocentesActuales.Location = new Point(11, 392);
            btnAnteriorDocentesActuales.Name = "btnAnteriorDocentesActuales";
            btnAnteriorDocentesActuales.Size = new Size(139, 42);
            btnAnteriorDocentesActuales.TabIndex = 3;
            btnAnteriorDocentesActuales.Text = "Anterior";
            btnAnteriorDocentesActuales.UseVisualStyleBackColor = true;
            btnAnteriorDocentesActuales.Click += btnAnteriorDocentesActuales_Click;
            // 
            // btnSiguienteDocentesActuales
            // 
            btnSiguienteDocentesActuales.Location = new Point(300, 394);
            btnSiguienteDocentesActuales.Name = "btnSiguienteDocentesActuales";
            btnSiguienteDocentesActuales.Size = new Size(139, 42);
            btnSiguienteDocentesActuales.TabIndex = 2;
            btnSiguienteDocentesActuales.Text = "Siguiente";
            btnSiguienteDocentesActuales.UseVisualStyleBackColor = true;
            btnSiguienteDocentesActuales.Click += btnSiguienteDocentesActuales_Click;
            // 
            // FrmDocentesActuales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 445);
            Controls.Add(btnSiguienteDocentesActuales);
            Controls.Add(btnAnteriorDocentesActuales);
            Controls.Add(btnBuscarDocente);
            Controls.Add(txtBoxBuscarDocente);
            Controls.Add(flowPanelDocenteActual);
            Name = "FrmDocentesActuales";
            Text = "Docentes Actuales";
            Load += FrmDocentesActuales_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private FlowLayoutPanel flowPanelDocenteActual;
        private TextBox txtBoxBuscarDocente;
        private Button btnBuscarDocente;
        private Button btnAnteriorDocentesActuales;
        private Button btnSiguienteDocentesActuales;
    }
}