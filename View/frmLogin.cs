using LongDrinkSys_Local.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LongDrinkSys_Local
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Está seguro que desea salir?", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes) { Application.Exit(); }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0 && txtContrasena.Text.Length > 0)
            {
                bool Login = IniciarSesion(txtUsuario.Text, txtContrasena.Text);
                if (Login)
                {
                    MessageBox.Show("Login correcto!");
                    //TO-DO: Permisos, form principal...
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar ambos campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool IniciarSesion(string usr, string pass)
        {
            bool r = false;
            try
            {
                using (LongDrinkEntities db = new LongDrinkEntities())
                {
                    var sql = db.Usuario.FirstOrDefault(e => e.nombre_usuario == usr && e.contrasena == pass);
                    if (sql != null)
                    {
                        r = true;
                    }
                    else { r = false; }
                }
            }
            catch (Exception)
            {
                r = false;
            }
            return r;
        }
    }
}
