using CursosLibres.Controllers;
using CursosLibres.Models;
using System;
using System.Windows.Forms;

namespace CursosLibres.Views
{
    public partial class FrmInscripciones : Form
    {
        private readonly InscripcionesController controller;

        public FrmInscripciones()
        {
            InitializeComponent();
            controller = new InscripcionesController();
        }

        private void FrmInscripciones_Load(object sender, EventArgs e)
        {
            cmbBoxAlumnos.DataSource = Data.InMemoryDb.Alumnos;
            cmbBoxAlumnos.DisplayMember = "Nombre";
            cmbBoxAlumnos.SelectedIndex = -1;

            cmbBoxCursos.DataSource = Data.InMemoryDb.Cursos;
            cmbBoxCursos.DisplayMember = "Titulo";
            cmbBoxCursos.SelectedIndex = -1;
        }

        private void cmbBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxCursos.SelectedItem is Curso cursoSeleccionado)
            {
                var inscripciones = controller.ListarPorCurso(cursoSeleccionado);

                var vistaParaGrid = inscripciones.Select(i => new {
                    Alumno = i.Alumno.Nombre,  
                    Curso = i.Curso.Titulo,    
                    Estado = i.Estado,
                    Fecha = i.Fecha
                }).ToList();

                dgvInscritos.DataSource = vistaParaGrid;

                if (dgvInscritos.Columns.Contains("Id"))
                {
                    dgvInscritos.Columns["Id"].Visible = false;
                }
                
                if (dgvInscritos.Columns.Count > 0)
                {
                    dgvInscritos.Columns["Fecha"].DefaultCellStyle.Format = "g";
                    dgvInscritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            else
            {
                dgvInscritos.DataSource = null;
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            if (cmbBoxAlumnos.SelectedItem is not Alumno alumno || cmbBoxCursos.SelectedItem is not Curso curso)
            {
                lblResultado.Text = "Por favor, seleccione un alumno y un curso";
                return;
            }

            var (_, mensaje) = controller.Inscribir(alumno, curso);

            lblResultado.Text = mensaje;

            cmbBoxCursos_SelectedIndexChanged(null, null);
        }
    }
}
