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
                                   nombre= i.nombre,
                                   descripcion= i.descripcion,
                                   costo= i.costo,
                                   duracion= i.duracion,
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
            foreach(Control c in tabPage1.Controls)
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

            if(nombre.Length> 0 && descripcion.Length > 0)
            {
                if (c>0 && c<=1000 && d>0 && d <= 12)
                {
                    string valorTurno = "";
                    Curso curso = new Curso();
                    curso.nombre = nombre;
                    curso.descripcion = descripcion;
                    curso.costo = c;
                    curso.duracion = (byte)d;
                    if(cbEstado.SelectedIndex == 0){ curso.Estado = true; }
                    else{ curso.Estado = false; }
                    if(cbTurno.SelectedIndex == 0) { valorTurno = "M"; }
                    else if (cbTurno.SelectedIndex == 1) { valorTurno = "T"; }
                    else { valorTurno = "N"; }
                    RegistrarCurso(curso, valorTurno);
                    MessageBox.Show("Curso registrado con exito!","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El costo debe ser mayor a 0 e inferior a 1000. La duración debe ser menor a 12 meses!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos de nombre y descripción deben estar llenos!","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        public void RegistrarCurso(Curso c, string t)
        {
            try
            {
                using(LongDrinkEntities db = new LongDrinkEntities())
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
                    else if(t == "T")
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
    }
}
