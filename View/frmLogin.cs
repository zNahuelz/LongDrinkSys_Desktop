using LongDrinkSys_Local.Model;
using LongDrinkSys_Local.Utils;
using LongDrinkSys_Local.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LongDrinkSys_Local
{
    public partial class frmLogin : Form
    {
        private frmRecuperarCredenciales fRecuperar;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            fRecuperar = new frmRecuperarCredenciales();
            this.Hide();
            fRecuperar.ShowDialog();

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
                    this.Hide();
                    frmPrincipal fP = new frmPrincipal();
                    Usuario usr = ObtenerDatos(txtUsuario.Text);
                    fP.NombreUsuario = usr.nombre_usuario;
                    fP.PermisosUsuario = usr.permisos;
                    fP.ShowDialog();
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

        public Usuario ObtenerDatos(string usuario)
        {
            try
            {
                using (LongDrinkEntities db = new LongDrinkEntities())
                {
                    var sql = db.Usuario.FirstOrDefault(e => e.nombre_usuario.Equals(usuario));
                    if (sql != null)
                    {
                        return sql;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception) { return null; }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.Next(txtContrasena, e);
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { btnIniciar_Click(sender, e); }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 20;
            txtContrasena.MaxLength = 20;
        }
    }
}
