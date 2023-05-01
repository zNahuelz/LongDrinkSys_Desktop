using LongDrinkSys_Local.Model;
using LongDrinkSys_Local.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LongDrinkSys_Local.View
{
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        public List<string> ListaEstados = new List<string>()
        {
            "VIGENTE","INACTIVO"
        };
        public List<string> ListaTurnos = new List<string>()
        {
            "MAÑANA (9:30AM -> 12:30AM)","TARDE (1:00PM -> 5:00PM)","NOCHE (8:00PM -> 9:00PM)"
        };

        public List<FrontCursos> Listar()
        {
            try
            {
                using (LongDrinkEntities db = new LongDrinkEntities())
                {
                    var sql = (from i in db.Curso
                               select new FrontCursos
                               {
                                   id_curso = i.id_curso,
                                   nombre = i.nombre,
                                   descripcion = i.descripcion,
                                   costo = i.costo,
                                   duracion = i.duracion,
                                   estado = (bool)i.Estado

                               }).ToList();
                    foreach (var i in sql)
                    {
                        if (i.estado)
                        {
                            i.frontEstado = "VIGENTE";
                        }
                        else { i.frontEstado = "INACTIVO"; }
                    }
                    return sql;
                }

            }
            catch { return null; }
        }

        public void GridDesign()
        {
            dgvCursos.Columns[0].HeaderText = "ID";
            dgvCursos.Columns[1].HeaderText = "NOMBRE CURSO";
            dgvCursos.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgvCursos.Columns[3].HeaderText = "COSTO";
            dgvCursos.Columns[4].HeaderText = "DURACIÓN";
            dgvCursos.Columns[6].HeaderText = "ESTADO";
            dgvCursos.Columns[5].Visible = false;
            dgvCursos.Columns[2].Width = 250;
            dgvCursos.ReadOnly = true;
            dgvCursos.AutoSize = true;
        }

        private void frmCursos_Load(object sender, System.EventArgs e)
        {

            dgvCursos.DataSource = Listar();
            cbEstado.DataSource = ListaEstados;
            cbEstado.SelectedIndex = 0;
            cbTurno.DataSource = ListaTurnos;
            cbTurno.SelectedIndex = 0;
            GridDesign();
            cbEstadoL.DataSource = ListaEstados;
            cbEstadoL.SelectedIndex = 0;
            txtDescL.ReadOnly = true;
            cbEstadoL.Enabled = false;
            nudCostoL.Enabled = false;
            nudDuracionL.Enabled = false;
            btnGuardarC.Enabled = false;
            btnCancelar.Enabled = false;
            txtIDL.ReadOnly = true;
        }

        private void tabPage2_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            dgvCursos.DataSource = Listar();
        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, System.EventArgs e)
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            cbTurno.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            nudCosto.Value = 100;
            nudDuracion.Value = 1;
        }

        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            float c = (float)nudCosto.Value;
            int d = (int)nudDuracion.Value;

            if (nombre.Length > 0 && descripcion.Length > 0)
            {
                if (c > 0 && c <= 1000 && d > 0 && d <= 12)
                {
                    string valorTurno = "";
                    Curso curso = new Curso();
                    curso.nombre = nombre;
                    curso.descripcion = descripcion;
                    curso.costo = c;
                    curso.duracion = (byte)d;
                    if (cbEstado.SelectedIndex == 0) { curso.Estado = true; }
                    else { curso.Estado = false; }
                    if (cbTurno.SelectedIndex == 0) { valorTurno = "M"; }
                    else if (cbTurno.SelectedIndex == 1) { valorTurno = "T"; }
                    else { valorTurno = "N"; }
                    RegistrarCurso(curso, valorTurno);
                    MessageBox.Show("Curso registrado con exito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El costo debe ser mayor a 0 e inferior a 1000. La duración debe ser menor a 12 meses!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos de nombre y descripción deben estar llenos!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void RegistrarCurso(Curso c, string t)
        {
            try
            {
                using (LongDrinkEntities db = new LongDrinkEntities())
                {
                    db.Curso.Add(c);
                    db.SaveChanges();
                    Turnos turno = new Turnos();
                    turno.Curso = c;
                    turno.id_curso = c.id_curso;
                    if (t == "M")
                    {
                        turno.nombre = "MAÑANA";
                        turno.hora_inicio = new TimeSpan(9, 00, 00);
                        turno.hora_final = new TimeSpan(12, 30, 00);
                    }
                    else if (t == "T")
                    {
                        turno.nombre = "TARDE";
                        turno.hora_inicio = new TimeSpan(13, 30, 00);
                        turno.hora_final = new TimeSpan(17, 00, 00);
                    }
                    else
                    {
                        turno.nombre = "NOCHE";
                        turno.hora_inicio = new TimeSpan(19, 00, 00);
                        turno.hora_final = new TimeSpan(21, 30, 00);
                    }
                    db.Turnos.Add(turno);
                    db.SaveChanges();

                }
            }
            catch { throw; }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbEditar.Checked = false;
            foreach (Control c in gbPrincipal.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            nudCostoL.Value = 100;
            nudDuracionL.Value = 1;
            cbEstadoL.SelectedIndex = 0;
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvCursos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCursos.CurrentRow.Selected = true;
                txtDescL.Text = dgvCursos.Rows[e.RowIndex].Cells["descripcion"].FormattedValue.ToString();
                string costo = dgvCursos.Rows[e.RowIndex].Cells["costo"].FormattedValue.ToString();
                nudCostoL.Value = decimal.Parse(costo);
                string duracion = dgvCursos.Rows[e.RowIndex].Cells["duracion"].FormattedValue.ToString();
                nudDuracionL.Value = decimal.Parse(duracion);
                txtIDL.Text = dgvCursos.Rows[e.RowIndex].Cells["id_curso"].FormattedValue.ToString();
            }
        }

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditar.Checked)
            {
                btnGuardarC.Enabled = true;
                btnCancelar.Enabled = true;
                nudDuracionL.Enabled = true;
                nudCostoL.Enabled = true;
                cbEstadoL.Enabled = true;
                txtDescL.ReadOnly = false;
                txtIDL.ReadOnly = true;

            }
            else
            {
                btnGuardarC.Enabled = false;
                btnCancelar.Enabled = false;
                nudDuracionL.Enabled = false;
                nudCostoL.Enabled = false;
                cbEstadoL.Enabled = false;
                txtDescL.ReadOnly = true;
                txtIDL.ReadOnly = true;
            }
        }

        public void EditarCurso(Curso c)
        {
            try
            {
                using (LongDrinkEntities db = new LongDrinkEntities())
                {
                    var sql = from i in db.Curso where i.id_curso == c.id_curso select i;
                    foreach (Curso mod in sql)
                    {
                        mod.descripcion = c.descripcion;
                        mod.costo = c.costo;
                        mod.duracion = c.duracion;
                        mod.Estado = c.Estado;
                    }
                    db.SaveChanges();
                }
            }
            catch { throw; }
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            Curso c = new Curso();
            c.id_curso = int.Parse(txtIDL.Text);
            c.descripcion = txtDescL.Text;
            c.costo = (double)nudCostoL.Value;
            c.duracion = (byte)nudDuracionL.Value;
            if(cbEstadoL.SelectedIndex == 0)
            {
                c.Estado = true;
            }
            else { c.Estado = false; }
            if(txtDescL.Text.Length >0 && txtDescL.Text.Length <= 255)
            {
                EditarCurso(c);
                dgvCursos.DataSource = Listar();
                GridDesign();
                MessageBox.Show("Curso modificado con exito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbEditar.Checked = false;
            }
            else { MessageBox.Show("Debe llenar el campo descripcíón!","ADVERTENCIA",MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        public void EliminarCurso(Curso c)
        {
            try
            {
                using (LongDrinkEntities db = new LongDrinkEntities())
                {
                    var sql = from i in db.Curso where i.id_curso == c.id_curso select i;
                    foreach(Curso e in sql)
                    {
                        e.Estado = false;
                    }
                    db.SaveChanges();
                }
            }
            catch { throw; }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Curso c = new Curso();
            c.id_curso = int.Parse(txtIDL.Text);
            DialogResult consulta = MessageBox.Show("¿Está seguro de eliminar el siguiente curso?" + Environment.NewLine + "ID: " + txtIDL.Text + Environment.NewLine + "DESCRIPCIÓN: " + txtDescL.Text, "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(consulta == DialogResult.Yes)
            {
                EliminarCurso(c);
                dgvCursos.DataSource = Listar();
                GridDesign();
                MessageBox.Show("Curso eliminado con exito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbEditar.Checked = false;
            }

        }
    }
}
