
namespace CursosLibres.Views
{
	partial class FrmCursosActuales
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
            flowPanelTodoList = new FlowLayoutPanel();
            txtBoxBuscar = new TextBox();
            btnBuscar = new Button();
            btnAnteriorCursosActuales = new Button();
            btnSiguienteCursosActuales = new Button();
            SuspendLayout();
            // 
            // flowPanelTodoList
            // 
            flowPanelTodoList.Location = new Point(12, 45);
            flowPanelTodoList.Name = "flowPanelTodoList";
            flowPanelTodoList.Size = new Size(457, 343);
            flowPanelTodoList.TabIndex = 0;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(12, 12);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Nombre del curso que desea buscar";
            txtBoxBuscar.Size = new Size(336, 27);
            txtBoxBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(354, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAnteriorCursosActuales
            // 
            btnAnteriorCursosActuales.Location = new Point(11, 392);
            btnAnteriorCursosActuales.Name = "btnAnteriorCursosActuales";
            btnAnteriorCursosActuales.Size = new Size(139, 42);
            btnAnteriorCursosActuales.TabIndex = 3;
            btnAnteriorCursosActuales.Text = "Anterior";
            btnAnteriorCursosActuales.UseVisualStyleBackColor = true;
            btnAnteriorCursosActuales.Click += btnAnteriorCursosActuales_Click;
            // 
            // btnSiguienteCursosActuales
            // 
            btnSiguienteCursosActuales.Location = new Point(330, 392);
            btnSiguienteCursosActuales.Name = "btnSiguienteCursosActuales";
            btnSiguienteCursosActuales.Size = new Size(139, 42);
            btnSiguienteCursosActuales.TabIndex = 4;
            btnSiguienteCursosActuales.Text = "Siguiente";
            btnSiguienteCursosActuales.UseVisualStyleBackColor = true;
            btnSiguienteCursosActuales.Click += btnSiguienteCursosActuales_Click;
            // 
            // FrmCursosActuales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 445);
            Controls.Add(btnSiguienteCursosActuales);
            Controls.Add(btnAnteriorCursosActuales);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(flowPanelTodoList);
            Name = "FrmCursosActuales";
            Text = "Cursos Disponibles";
            Load += FrmCursosActuales_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private FlowLayoutPanel flowPanelTodoList;
        private TextBox txtBoxBuscar;
        private Button btnBuscar;
        private Button btnAnteriorCursosActuales;
        private Button btnSiguienteCursosActuales;
    }
}