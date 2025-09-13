using CursosLibres.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursosLibres.Views.Alumnos
{
    public partial class FrmNuevoAlumno : Form
    {
        private readonly AlumnosController controller;

        public FrmNuevoAlumno()
        {
            InitializeComponent();
            controller = new AlumnosController();
        }

        private void btnGuardadAlumno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxNombreAlumno.Text) || string.IsNullOrWhiteSpace(txtBoxCorreoAlumno.Text))
            {
                MessageBox.Show("Ambos campos son requeridos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtBoxCorreoAlumno.Text.Contains("@"))
            {
                MessageBox.Show("El formato del email no es válido.", "Validación");
                return;
            }

            controller.Crear(txtBoxNombreAlumno.Text, txtBoxCorreoAlumno.Text);
            MessageBox.Show("Alumno guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelarAlumno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
