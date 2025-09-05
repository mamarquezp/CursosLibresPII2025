using CursosLibres.Views;

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
    }
}
