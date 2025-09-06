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
        private List<Sesion> sesionesTemporales = new List<Sesion>();
        public FrmCursoNuevo()
        {
            InitializeComponent();
            cmbBoxCategoria.DataSource = Enum.GetValues(typeof(CursosLibres.Enums.CategoriaCurso));
            cmbBoxDocente.DataSource = CursosLibres.Data.InMemoryDb.Docentes;
            cmbBoxDocente.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

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


    }
}

