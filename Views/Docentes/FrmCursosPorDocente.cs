using CursosLibres.Controllers;
using CursosLibres.Models;
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
    public partial class FrmCursosPorDocente : Form
    {
        private readonly DocentesController docentesController;
        private readonly CursosController cursosController;

        public FrmCursosPorDocente()
        {
            InitializeComponent();
            docentesController = new DocentesController();
            cursosController = new CursosController();
        }

        private void FrmCursosPorDocente_Load(object sender, EventArgs e)
        {
            cmbBoxFiltroDocente.DataSource = docentesController.ObtenerTodos();
            cmbBoxFiltroDocente.DisplayMember = "Nombre";
            cmbBoxFiltroDocente.SelectedIndex = -1; 
        }

        private void cmbBoxFiltroDocente_SelectedIndexChanged(object sender, EventArgs e)
        {         
            FiltrarDocente();
        }

        private void FiltrarDocente()
        {
            pnlResultados.Controls.Clear();

            if (cmbBoxFiltroDocente.SelectedItem is not Docente docenteSeleccionado)
            {
                return; 
            }

            var cursosDelDocente = cursosController.ObtenerPorDocente(docenteSeleccionado.Id);

            if (!cursosDelDocente.Any())
            {
                var lblSinCursos = new Label { Text = "El docente no tiene cursos asignados.", AutoSize = true, Location = new Point(10, 10) };
                pnlResultados.Controls.Add(lblSinCursos);
                return;
            }

            int yPosition = 10;
            foreach (var curso in cursosDelDocente)
            {
                var lblTituloCurso = new Label
                {
                    Text = curso.Titulo,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, yPosition)
                };
                pnlResultados.Controls.Add(lblTituloCurso);
                yPosition += 30;
                var pnlSesiones = new FlowLayoutPanel
                {
                    Location = new Point(10, yPosition),
                    Size = new Size(pnlResultados.Width - 30, 150),
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle
                };

                foreach (var sesion in curso.Sesiones)
                {
                    var lblSesion = new Label
                    {
                        Text = $"Sesión: {sesion.Inicio:g}\nDuración: {sesion.Duracion.TotalMinutes} min",
                        Size = new Size(150, 50),
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(5)
                    };
                    pnlSesiones.Controls.Add(lblSesion);
                }

                pnlResultados.Controls.Add(pnlSesiones);
                yPosition += pnlSesiones.Height + 20;
            }
        }
    }
}