using LongDrinkSys_Local.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LongDrinkSys_Local.View
{
    public partial class frmRecuperarCredenciales : Form
    {
        public frmRecuperarCredenciales()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool BuscarUsuario = Buscar(txtUsuario.Text, txtDNI.Text);
            if (BuscarUsuario)
            {
                btnBuscar.Enabled = false;
                txtDNI.Enabled = false;
                txtUsuario.Enabled = false;
                txtNC1.Enabled = true;
                txtNC2.Enabled = true;
                btnCambiarC.Enabled = true;
                MessageBox.Show("Usuario encontrado, puede proceder a cambiar su contraseña!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado, vuelva a ingresar sus datos o contacte con administración.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCambiarC_Click(object sender, EventArgs e)
        {
            string C1 = txtNC1.Text;
            string C2 = txtNC2.Text;
            if (C1 == C2)
            {
                if (C1.Length > 0 && C1.Length <= 20)
                {
                    bool ActualizarCredenciales = Actualizar(txtUsuario.Text, txtNC1.Text);
                    if (ActualizarCredenciales)
                    {
                        MessageBox.Show("Sus credenciales fueron cambiadas con exito, puede volver a iniciar sesión.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("ERROR! Sus credenciales no pudieron ser actualizadas. Por favor, contacte con administración", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ADVERTENCIA! Los dos campos deben estar llenos y su longitud máxima es de 20 caracteres.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNC1.Clear();
                    txtNC2.Clear();
                }
            }
            else
            {
                MessageBox.Show("ADVERTENCIA! Las dos contraseñas deben ser iguales.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNC1.Clear();
                txtNC2.Clear();
            }
        }

        private void frmRecuperarCredenciales_Load(object sender, EventArgs e)
        {
            txtNC1.Enabled = false;
            txtNC2.Enabled = false;
            btnCambiarC.Enabled = false;
            txtDNI.MaxLength = 8;
            txtUsuario.MaxLength = 20;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Cons = MessageBox.Show("¿Está seguro que desea salir?", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Cons == DialogResult.Yes) { Application.Restart(); }

        }

        public bool Buscar(string usuario, string dni)
        {
            bool r = false;
            using (LongDrinkEntities db = new LongDrinkEntities())
            {
                var sqlUsuario = db.Usuario.FirstOrDefault(i => i.nombre_usuario.Equals(usuario));
                var sqlDNI = db.Profesor.FirstOrDefault(i => i.dni.Equals(dni));
                if (sqlUsuario != null && sqlDNI != null)
                {
                    r = true;
                }
                else { r = false; }
            }
            return r;
        }

        public bool Actualizar(string usuario, string nContra)
        {
            bool r = false;
            try
            {
                using (LongDrinkEntities db = new LongDrinkEntities())
                {
                    var sql = (from i in db.Usuario where i.nombre_usuario.Equals(usuario) select i);
                    foreach (Usuario u in sql)
                    {
                        u.contrasena = nContra;
                    }
                    db.SaveChanges();
                }
                r = true;
            }
            catch (Exception) { return r; }
            return r;
        }


    }
}
