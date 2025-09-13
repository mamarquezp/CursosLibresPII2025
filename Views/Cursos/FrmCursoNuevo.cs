using CursosLibres.Controllers;
using CursosLibres.Data;
using CursosLibres.Enums;
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

namespace CursosLibres.Views.Cursos
{
    public partial class FrmCursoNuevo : Form
    {
        private readonly CursosController cursosController;
        private List<Sesion> sesionesTemporales = new List<Sesion>();
        public FrmCursoNuevo()
        {
            InitializeComponent();
            cursosController = new CursosController();
            cmbBoxCategoria.DataSource = Enum.GetValues(typeof(CursosLibres.Enums.CategoriaCurso));
            cmbBoxDocente.DataSource = CursosLibres.Data.InMemoryDb.Alumnos;
            cmbBoxDocente.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxTitulo.Text) ||
            cmbBoxCategoria.SelectedItem is null ||
            string.IsNullOrWhiteSpace(txtBoxCupo.Text) ||
            string.IsNullOrWhiteSpace(txtBoxCosto.Text) ||
            cmbBoxDocente.SelectedItem is null)
            {
                MessageBox.Show("Por favor complete todos los campos generales", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBoxCupo.Text, out int cupo) || cupo < 0)
            {
                MessageBox.Show("El cupo máximo debe ser un número entero positivo", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtBoxCosto.Text, out decimal costo) || costo < 0)
            {
                MessageBox.Show("El costo debe ser un número mayor o igual a 0", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!sesionesTemporales.Any())
            {
                MessageBox.Show("Debe agregar al menos una sesión al curso", "Sesiones Requeridas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var titulo = txtBoxTitulo.Text;
            var categoria = cmbBoxCategoria.SelectedItem.ToString();
            var docente = (Docente)cmbBoxDocente.SelectedItem;

            try
            {
                switch ((CategoriaCurso)cmbBoxCategoria.SelectedItem)
                {
                    case CategoriaCurso.Presencial:
                        if (string.IsNullOrWhiteSpace(txtBoxCampus.Text) || string.IsNullOrWhiteSpace(txtBoxSalon.Text))
                        {
                            MessageBox.Show("Para un curso presencial el campus y el salón son requeridos", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cursosController.CrearPresencial(titulo, categoria, cupo, costo, docente, txtBoxCampus.Text, txtBoxSalon.Text);
                        break;

                    case CategoriaCurso.Virtual:
                        if (string.IsNullOrWhiteSpace(txtBoxPlataforma.Text) || string.IsNullOrWhiteSpace(txtBoxEnlace.Text))
                        {
                            MessageBox.Show("Para un curso virtual la plataforma y el enlace son requeridos", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cursosController.CrearVirtual(titulo, categoria, cupo, costo, docente, txtBoxPlataforma.Text, txtBoxEnlace.Text);
                        break;

                    case CategoriaCurso.Hibrido:
                        if (string.IsNullOrWhiteSpace(txtBoxCampus.Text) || string.IsNullOrWhiteSpace(txtBoxSalon.Text) || string.IsNullOrWhiteSpace(txtBoxPlataforma.Text) || string.IsNullOrWhiteSpace(txtBoxEnlace.Text))
                        {
                            MessageBox.Show("Para un curso híbrido todos los campos son requeridos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cursosController.CrearHibrido(titulo, categoria, cupo, costo, docente, txtBoxCampus.Text, txtBoxSalon.Text, txtBoxEnlace.Text);
                        break;
                }

                var cursoRecienCreado = InMemoryDb.Cursos.Last();
                foreach (var sesion in sesionesTemporales)
                {
                    cursosController.AgregarSesion(cursoRecienCreado, sesion.Inicio, sesion.Duracion);
                }

                MessageBox.Show("¡Curso guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (UriFormatException)
            {
                MessageBox.Show("El formato del enlace del curso no es válido. Asegúrese de que sea una URL completa (http://ejemplo.com)", "URL Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtBoxTitulo.Clear();
            txtBoxCupo.Clear();
            txtBoxCosto.Clear();
            txtBoxCampus.Clear();
            txtBoxSalon.Clear();
            txtBoxEnlace.Clear();
            txtBoxPlataforma.Clear();
            cmbBoxCategoria.SelectedIndex = 0;
            cmbBoxDocente.SelectedIndex = 0;
            dtpFechaSesion.Value = DateTime.Now;
            nupDuracion.Value = 30;
            dgvSesiones.DataSource = null;
            sesionesTemporales.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnAgregaSesion_Click(object sender, EventArgs e)
        {
            DateTime fechaHoraInicio = dtpFechaSesion.Value;
            double duracionMinutos = (double)nupDuracion.Value;
            TimeSpan duracion = TimeSpan.FromMinutes(duracionMinutos);

            var nuevaSesion = new Sesion(fechaHoraInicio, duracion);

            sesionesTemporales.Add(nuevaSesion);
            RefrescarGridSesiones();
        }

        private void RefrescarGridSesiones()
        {
            dgvSesiones.DataSource = null;
            dgvSesiones.DataSource = sesionesTemporales;

            if (dgvSesiones.Columns.Contains("Inicio"))
            {
                dgvSesiones.Columns["Inicio"].HeaderText = "Fecha y Hora de Inicio";
            }

            if (dgvSesiones.Columns.Contains("Duracion"))
            {
                dgvSesiones.Columns["Duracion"].HeaderText = "Duración (hh:mm)";
            }
        }

        private void cmbBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxCategoria.SelectedItem is CategoriaCurso categoriaSeleccionada)
            {
                switch (categoriaSeleccionada)
                {
                    case CategoriaCurso.Presencial:
                        pnlPresencial.Visible = true;
                        pnlVirtual.Visible = false;
                        break;

                    case CategoriaCurso.Virtual:
                        pnlPresencial.Visible = false;
                        pnlVirtual.Visible = true;
                        break;

                    case CategoriaCurso.Hibrido:
                        pnlPresencial.Visible = true;
                        pnlVirtual.Visible = true;
                        break;

                    default:
                        pnlPresencial.Visible = false;
                        pnlVirtual.Visible = false;
                        break;
                }
            }
        }

        
    }
}

