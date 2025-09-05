
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
            SuspendLayout();
            // 
            // flowPanelTodoList
            // 
            flowPanelTodoList.Location = new Point(12, 45);
            flowPanelTodoList.Name = "flowPanelTodoList";
            flowPanelTodoList.Size = new Size(908, 480);
            flowPanelTodoList.TabIndex = 0;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(12, 12);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Nombre del curso que desea buscar";
            txtBoxBuscar.Size = new Size(787, 27);
            txtBoxBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(805, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmCursosActuales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 537);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(flowPanelTodoList);
            Name = "FrmCursosActuales";
            Text = "Cursos Disponibles";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private FlowLayoutPanel flowPanelTodoList;
        private TextBox txtBoxBuscar;
        private Button btnBuscar;
    }
}