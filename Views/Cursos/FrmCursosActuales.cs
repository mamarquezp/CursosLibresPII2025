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
    public partial class FrmCursosActuales : Form
    {
        List<Curso> curso = InMemoryDb.Cursos;
        List<Curso> cursoFiltrado = new List<Curso>();
        private int paginaActual = 1;
        private int registrosPorPagina = 6; // por si se quisiera cambiar más adelante o hacer dinámico

        public FrmCursosActuales()
        {
            InitializeComponent();
        }

        public void renderizarCursos(List<Curso> listaCursos)
        {
            flowPanelTodoList.Controls.Clear();
            foreach (Curso curso in listaCursos)
            {
                Panel tarjeta = crearTarjeta(curso);
                flowPanelTodoList.Controls.Add(tarjeta);
            }
        }


        public Panel crearTarjeta(Curso curso)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(200, 100);
            tarjeta.Padding = new Padding(5);
            tarjeta.Margin = new Padding(5);
            tarjeta.BackColor = Color.White;
            tarjeta.Tag = curso;

            Label nombreCurso = new Label();
            nombreCurso.AutoSize = true;
            nombreCurso.Text = $"{curso.Titulo}";
            nombreCurso.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            nombreCurso.Dock = DockStyle.Top;
            nombreCurso.Margin = new Padding(3, 3, 3, 3);

            Label categoria = new Label();
            categoria.AutoSize = true;
            categoria.Text = curso.Categoria;
            categoria.Font = new Font("Segoe UI", 9);
            categoria.Dock = DockStyle.Top;
            categoria.Margin = new Padding(3, 50, 3, 3);

            Label precio = new Label();
            precio.AutoSize = true;
            precio.Text = $"$ {curso.Costo.ToString()}";
            precio.Font = new Font("Segoe UI", 9);
            precio.Dock = DockStyle.Top;
            precio.Margin = new Padding(3, 103, 3, 3);

            tarjeta.Controls.Add(precio);
            tarjeta.Controls.Add(categoria);
            tarjeta.Controls.Add(nombreCurso);

            return tarjeta;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBoxBuscar.Text.ToLower();
            cursoFiltrado = curso.Where(filtro => filtro.Titulo.ToLower().Contains(busqueda) ||
            filtro.Categoria.ToLower().Contains(busqueda)).ToList();
            paginaActual = 1;
            CargarCursos();
        }

        private void CargarCursos()
        {
            var listaFuente = cursoFiltrado.Any() || !string.IsNullOrWhiteSpace(txtBoxBuscar.Text) ? cursoFiltrado : curso;

            var cursosPaginados = listaFuente
                .Skip((paginaActual - 1) * registrosPorPagina)
                .Take(registrosPorPagina)
                .ToList();

            renderizarCursos(cursosPaginados);

            btnAnteriorCursosActuales.Enabled = paginaActual > 1;

            int totalRegistros = listaFuente.Count();
            int totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            btnSiguienteCursosActuales.Enabled = paginaActual < totalPaginas;
        }

        private void FrmCursosActuales_Load(object sender, EventArgs e)
        {
            CargarCursos();
        }

        private void btnAnteriorCursosActuales_Click(object sender, EventArgs e)
        {
            paginaActual--;
            CargarCursos();
        }

        private void btnSiguienteCursosActuales_Click(object sender, EventArgs e)
        {
            paginaActual++;
            CargarCursos();
        }
    }
}
