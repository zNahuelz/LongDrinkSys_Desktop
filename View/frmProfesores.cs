using LongDrinkSys_Local.Model;
using LongDrinkSys_Local.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LongDrinkSys_Local.View
{
    public partial class frmProfesores : Form
    {
        public frmProfesores()
        {
            InitializeComponent();
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            dgvProfesores.DataSource = Listar();
            GridDesign();
        }

        public void GridDesign()
        {
            dgvProfesores.Columns[0].HeaderText = "ID";
            dgvProfesores.Columns[1].HeaderText = "NOMBRE";
            dgvProfesores.Columns[2].HeaderText = "AP. PATERNO";
            dgvProfesores.Columns[3].HeaderText = "AP. MATERNO";
            dgvProfesores.Columns[4].HeaderText = "EMAIL";
            dgvProfesores.Columns[5].HeaderText = "DNI";
            dgvProfesores.Columns[4].Width = 250;
            dgvProfesores.ReadOnly = true;
            dgvProfesores.AutoSize = true;
        }

        public List<FrontProfesores> Listar()
        {
            try
            {
                using (LongDrinkEntities db = new LongDrinkEntities())
                {
                    var sql = (from i in db.Profesor
                               select new FrontProfesores
                               {
                                   id_profesor = i.id_profesor,
                                   nombre = i.nombre,
                                   dni = i.dni,
                                   ap_paterno = i.ap_paterno,
                                   ap_materno = i.ap_materno,
                                   email = i.email
                               }).ToList();
                    return sql;
                }
            }
            catch { return null; }
        }
    }
}
