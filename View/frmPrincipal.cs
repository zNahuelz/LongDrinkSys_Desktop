using System;
using System.Drawing;
using System.Windows.Forms;

namespace LongDrinkSys_Local.View
{
    public partial class frmPrincipal : Form
    {
        public string NombreUsuario { get; set; }
        public bool PermisosUsuario { get; set; }

        private frmCursos fCursos;
        private frmProfesores fProfesores;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsBSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tReloj.Enabled = true;

            foreach (Control c in this.Controls)
            {
                MdiClient mdi = c as MdiClient;
                if (!(mdi == null))
                {
                    c.BackColor = Color.White; break;
                }
            }
        }

        private void tReloj_Tick(object sender, EventArgs e)
        {
            lblDatos.Text = "USUARIO: " + NombreUsuario.ToUpper() + Environment.NewLine + "HORA: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void tsBCursos_Click(object sender, EventArgs e)
        {
            if (fCursos == null)
            {
                fCursos = new frmCursos();
                fCursos.MdiParent = this;
                fCursos.FormClosed += new FormClosedEventHandler(CerrarCursos);
                fCursos.Show();
            }
            else { fCursos.Focus(); }
        }
        void CerrarCursos(object sender, FormClosedEventArgs e) { fCursos = null; }

        private void tsBCerrarS_Click(object sender, EventArgs e)
        {
            DialogResult cons = MessageBox.Show("¿Desea cerrar sesión?","CONSULTA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cons == DialogResult.Yes) { Application.Restart(); }
        }

        private void tsBDocentes_Click(object sender, EventArgs e)
        {
            if(fProfesores == null)
            {
                fProfesores= new frmProfesores();
                fProfesores.MdiParent = this;
                fProfesores.FormClosed += new FormClosedEventHandler(CerrarProfesores);
                fProfesores.Show();
            }
        }
        void CerrarProfesores(object sender, FormClosedEventArgs e) { fProfesores = null; }
    }
}
