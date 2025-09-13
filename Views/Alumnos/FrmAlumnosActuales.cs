using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursosLibres.Models;
using CursosLibres.Data;

namespace CursosLibres.Views

{
    public partial class FrmAlumnosActuales : Form
    {
        List<Alumno> alumno = InMemoryDb.Alumnos;
        List<Alumno> alumnoFiltrado = new List<Alumno>();
        private int paginaActualAlumno = 1;
        private int registrosPorPaginaAlumno = 6; // por si se quisiera cambiar más adelante o hacer dinámico

        public FrmAlumnosActuales()
        {
            InitializeComponent();
        }

        public void renderizarAlumnos(List<Alumno> listaAlumnos)
        {
            flowPanelAlumnosActuales.Controls.Clear();
            foreach (Alumno alumno in listaAlumnos)
            {
                Panel tarjeta = crearTarjetaAlumno(alumno);
                flowPanelAlumnosActuales.Controls.Add(tarjeta);
            }
        }


        public Panel crearTarjetaAlumno(Alumno alumno)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(200, 100);
            tarjeta.Padding = new Padding(5);
            tarjeta.Margin = new Padding(5);
            tarjeta.BackColor = Color.White;
            tarjeta.Tag = alumno;

            Label nombreAlumno = new Label();
            nombreAlumno.AutoSize = true;
            nombreAlumno.Text = $"{alumno.Nombre}";
            nombreAlumno.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            nombreAlumno.Dock = DockStyle.Top;
            nombreAlumno.Margin = new Padding(3, 3, 3, 3);

            Label correo = new Label();
            correo.AutoSize = true;
            correo.Text = alumno.Email;
            correo.Font = new Font("Segoe UI", 9);
            correo.Dock = DockStyle.Top;
            correo.Margin = new Padding(3, 50, 3, 3);

            tarjeta.Controls.Add(correo);
            tarjeta.Controls.Add(nombreAlumno);

            return tarjeta;
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string busqueda = txtBoxBuscarAlumnos.Text.ToLower();
            alumnoFiltrado = alumno.Where(filtro => filtro.Nombre.ToLower().Contains(busqueda) ||
            filtro.Email.ToLower().Contains(busqueda)).ToList();
            paginaActualAlumno = 1;
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            var listaFuente = alumnoFiltrado.Any() || !string.IsNullOrWhiteSpace(txtBoxBuscarAlumnos.Text) ? alumnoFiltrado : alumno;

            var alumnosPaginados = listaFuente
                .Skip((paginaActualAlumno - 1) * registrosPorPaginaAlumno)
                .Take(registrosPorPaginaAlumno)
                .ToList();

            renderizarAlumnos(alumnosPaginados);

            btnAnteriorAlumnosActuales.Enabled = paginaActualAlumno > 1;

            int totalRegistros = listaFuente.Count();
            int totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPaginaAlumno);
            btnSiguienteAlumnosActuales.Enabled = paginaActualAlumno < totalPaginas;
        }

        private void FrmAlumnosActuales_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnAnteriorAlumnosActuales_Click(object sender, EventArgs e)
        {
            paginaActualAlumno--;
            CargarAlumnos();
        }

        private void btnSiguienAlumnosActuales_Click(object sender, EventArgs e)
        {
            paginaActualAlumno++;
            CargarAlumnos();
        }
    }
}
