using System;
using System.Drawing;
using System.Windows.Forms;

namespace LongDrinkSys_Local.View
{
    public partial class frmPrincipal : Form
    {
        public string NombreUsuario { get; set; }
        public bool PermisosUsuario { get; set; }

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
    }
}
