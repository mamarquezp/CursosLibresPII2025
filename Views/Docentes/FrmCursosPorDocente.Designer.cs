namespace CursosLibres.Views.Docentes
{
    partial class FrmCursosPorDocente
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
            cmbBoxFiltroDocente = new ComboBox();
            pnlResultados = new Panel();
            SuspendLayout();
            // 
            // cmbBoxFiltroDocente
            // 
            cmbBoxFiltroDocente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxFiltroDocente.FormattingEnabled = true;
            cmbBoxFiltroDocente.Location = new Point(69, 12);
            cmbBoxFiltroDocente.Name = "cmbBoxFiltroDocente";
            cmbBoxFiltroDocente.Size = new Size(300, 28);
            cmbBoxFiltroDocente.TabIndex = 0;
            cmbBoxFiltroDocente.SelectedIndexChanged += cmbBoxFiltroDocente_SelectedIndexChanged;
            // 
            // pnlResultados
            // 
            pnlResultados.AutoScroll = true;
            pnlResultados.Location = new Point(12, 46);
            pnlResultados.Name = "pnlResultados";
            pnlResultados.Size = new Size(415, 454);
            pnlResultados.TabIndex = 1;
            // 
            // FrmCursosPorDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 512);
            Controls.Add(pnlResultados);
            Controls.Add(cmbBoxFiltroDocente);
            Name = "FrmCursosPorDocente";
            Text = "Cursos Por Docente";
            Load += FrmCursosPorDocente_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbBoxFiltroDocente;
        private Panel pnlResultados;
    }
}