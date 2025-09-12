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
    public partial class FrmDocentesActuales : Form
    {
        List<Docente> curso = InMemoryDb.Docentes;
        List<Docente> docenteFiltrado = new List<Docente>();
        private int paginaActual = 1;
        private int registrosPorPagina = 6; // por si se quisiera cambiar más adelante o hacer dinámico

        public FrmDocentesActuales()
        {
            InitializeComponent();
        }

        public void renderizarCursos(List<Docente> listaCursos)
        {
            flowPanelDocenteActual.Controls.Clear();
            foreach (Docente docente in listaCursos)
            {
                Panel tarjeta = crearTarjetaDocente(docente);
                flowPanelDocenteActual.Controls.Add(tarjeta);
            }
        }


        public Panel crearTarjetaDocente(Docente docente)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(200, 100);
            tarjeta.Padding = new Padding(5);
            tarjeta.Margin = new Padding(5);
            tarjeta.BackColor = Color.White;
            tarjeta.Tag = docente;

            Label nombreDocente = new Label();
            nombreDocente.AutoSize = true;
            nombreDocente.Text = $"{docente.Nombre}";
            nombreDocente.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            nombreDocente.Dock = DockStyle.Top;
            nombreDocente.Margin = new Padding(3, 3, 3, 3);

            Label categoria = new Label();
            categoria.AutoSize = true;
            categoria.Text = docente.Especialidad;
            categoria.Font = new Font("Segoe UI", 9);
            categoria.Dock = DockStyle.Top;
            categoria.Margin = new Padding(3, 50, 3, 3);

            tarjeta.Controls.Add(categoria);
            tarjeta.Controls.Add(nombreDocente);

            return tarjeta;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBoxBuscarDocente.Text.ToLower();
            docenteFiltrado = curso.Where(filtro => filtro.Nombre.ToLower().Contains(busqueda) ||
            filtro.Especialidad.ToLower().Contains(busqueda)).ToList();
            paginaActual = 1;
            CargarDocentes();
        }

        private void CargarDocentes()
        {
            var listaFuente = docenteFiltrado.Any() || !string.IsNullOrWhiteSpace(txtBoxBuscarDocente.Text) ? docenteFiltrado : curso;

            var docentePaginados = listaFuente
                .Skip((paginaActual - 1) * registrosPorPagina)
                .Take(registrosPorPagina)
                .ToList();

            renderizarCursos(docentePaginados);

            btnAnteriorDocentesActuales.Enabled = paginaActual > 1;

            int totalRegistros = listaFuente.Count();
            int totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            btnSiguienteDocentesActuales.Enabled = paginaActual < totalPaginas;
        }

        private void FrmDocentesActuales_Load(object sender, EventArgs e)
        {
            CargarDocentes();
        }

        private void btnAnteriorDocentesActuales_Click(object sender, EventArgs e)
        {
            paginaActual--;
            CargarDocentes();
        }

        private void btnSiguienteDocentesActuales_Click(object sender, EventArgs e)
        {
            paginaActual++;
            CargarDocentes();
        }
    }
}
