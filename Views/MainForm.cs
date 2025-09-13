using CursosLibres.Views;
using CursosLibres.Views.Alumnos;
using CursosLibres.Views.Docentes;

namespace CursosLibres
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nuevoCursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Views.Cursos.FrmCursoNuevo { MdiParent = this }.Show();
        }

        private void nuevoCursoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new FrmCursosActuales { MdiParent = this }.Show();
        }

        private void nuevoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDocentes { MdiParent = this }.Show();
        }

        private void docentesActualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDocentesActuales { MdiParent = this }.Show();
        }

        private void cursosPorDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCursosPorDocente { MdiParent = this }.Show();
        }

        private void alumnosActualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAlumnosActuales { MdiParent = this }.Show();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoAlumno { MdiParent = this }.Show();
        }

        private void inscribirseAAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInscripciones { MdiParent = this }.Show();
        }
    }
}
