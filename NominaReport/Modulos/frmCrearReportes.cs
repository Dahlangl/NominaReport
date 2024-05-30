using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace NominaReport.Modulos
{
    public partial class frmCrearReportes : Form
    {
        ObjectsModel objectsDao = new ObjectsModel();
        public frmCrearReportes()
        {
            InitializeComponent();
        }

        private void frmCrearReportes_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            cboxColaborador.DataSource = objectsDao.cargarEmpleados();
            cboxColaborador.DisplayMember = "nomColab";
            cboxColaborador.ValueMember = "colabId";
            cboxRazonSocial.DataSource 
        }

        private void cboxColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
