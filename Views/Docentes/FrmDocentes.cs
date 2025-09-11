using CursosLibres.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursosLibres.Views.Docentes
{
    public partial class FrmDocentes : Form
    {
        private readonly DocentesController controller;
        public FrmDocentes()
        {
            InitializeComponent();
            controller = new DocentesController();
        }

        private void btnGuardadDocente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxNombreDocente.Text) || string.IsNullOrWhiteSpace(txtBoxEspecialidadDocente.Text))
            {
                MessageBox.Show("Ambos campos son requeridos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controller.Crear(txtBoxNombreDocente.Text, txtBoxEspecialidadDocente.Text);
            MessageBox.Show("Docente guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelarDocente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
