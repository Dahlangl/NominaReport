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
            //ComboBox de Empleados
            cboxColaborador.DataSource = objectsDao.cargarEmpleados();
            cboxColaborador.DisplayMember = "colabNombre";
            cboxColaborador.ValueMember = "colabRazonSocialID";
            cboxConceptos.SelectedValue = null;
            //ComboBox de Sucursales
            cboxRznSocial.DataSource  = objectsDao.cargarRazonSocial();
            cboxRznSocial.DisplayMember = "raznSocialDescripcion";
            cboxRznSocial.ValueMember = "raznSocialId";
            //ComboBox de Tipos de Nomina
            cboxNomina.DataSource = objectsDao.cargarNominaTipos();
            cboxNomina.DisplayMember = "nominaTipoDescripcion";
            cboxNomina.ValueMember = "nominaTipoId";
            //ComboBox de Conceptos
            cboxConceptos.DataSource = objectsDao.cargarNominaConceptos();
            cboxConceptos.DisplayMember = "nomConceptoDes";
            cboxConceptos.ValueMember = "nomConceptoId";
        }

        private void cboxColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            pnlRegistro.Visible = true;
        }

        private void cboxRznSocial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxNomina.SelectedValue != null) 
            {
                int selectedNominaConceptoTipo;
                if (int.TryParse(cboxNomina.SelectedValue.ToString(), out selectedNominaConceptoTipo))
                {
                    // Filtrar los conceptos basados en el nominaTipoId
                    FiltrarConceptos(selectedNominaConceptoTipo);
                }
                else
                {
                    // Manejar el error si la conversión falla
                    //MessageBox.Show("La conversión del valor seleccionado a 'int' no es válida.");
                }
            }

        }

        private void FiltrarConceptos(int nominaConceptoTipo)
        {
            DataTable allConceptos = objectsDao.cargarNominaConceptos();

            DataView dv = new DataView(allConceptos);
            dv.RowFilter = $"nomConceptoTipo = {nominaConceptoTipo}";

            cboxConceptos.DataSource = dv;
            cboxConceptos.DisplayMember = "nomConceptoDes";
            cboxConceptos.ValueMember = "nomConceptoId";
        }
    }
}
