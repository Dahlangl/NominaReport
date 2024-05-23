using Common.Cache;
using NominaReport.Clases;
using NominaReport.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaReport
{
    public partial class frmPrincipal : Form
    {
        frmDashboard dashboard;
        frmAggEmpleado aggEmpleado;
        frmConceptos conceptos;
        frmCrearReportes crearReportes;
        frmReportMasiv reporteMasivo;
        frmReportVwr reportVwr;
        frmUser userPanel;
        public frmPrincipal()
        {
            InitializeComponent();
            mdiProp();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Realmente desea cerrar sesión?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        bool menuNominasExpand = false;
        bool navBarExpand = true;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void menuNominasTransition_Tick(object sender, EventArgs e)
        {
            if (menuNominasExpand == false)
            {
                menuNominas.Height += 10;
                if(menuNominas.Height >= 160)
                {
                    menuNominasTransition.Stop();
                    menuNominasExpand = true;
                }
            }
            else
            {
                menuNominas.Height -= 10;
                if(menuNominas.Height <= 40)
                {
                    menuNominasTransition.Stop();
                    menuNominasExpand = false;
                }
            }
        }
        private void btnMenuNominas_Click(object sender, EventArgs e)
        {
            menuNominasTransition.Start();
        }
        private void LoadUserData()
        {
            lblNombre.Text = UserCache.userNombre;
            lblRol.Text = UserCache.userRol.ToString();
            lblEmail.Text = UserCache.userEmail;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            
        }
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (navBarExpand == false)
            {
                navBarL.Width += 10;
                if (navBarL.Width == 170)
                {
                    sideBarTransition.Stop();
                    navBarExpand = true;
                }
            }
            else
            {
                navBarL.Width -= 10;
                if (navBarL.Width <= 50)
                {
                    sideBarTransition.Stop();
                    navBarExpand = false;
                }
            }
        }
        private void btnNavBar_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new frmDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }
        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            if (crearReportes == null)
            {
                crearReportes = new frmCrearReportes();
                crearReportes.FormClosed += CrearReportes_FormClosed;
                crearReportes.MdiParent = this;
                crearReportes.Dock = DockStyle.Fill;
                crearReportes.Show();
            }
            else
            {
                crearReportes.Activate();
            }
        }
        private void CrearReportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            crearReportes = null;
        }

        private void btnMenuDatosMaestros_Click(object sender, EventArgs e)
        {
            menuDatMtroTransition.Start();
        }
        bool menuDatMtro = false;
        private void menuDatMtroTransition_Tick(object sender, EventArgs e)
        {
            if (menuDatMtro == false)
            {
                menuDatosMaestros.Height += 10;
                if (menuDatosMaestros.Height >= 120)
                {
                    menuDatMtroTransition.Stop();
                    menuDatMtro = true;
                }
            }
            else
            {
                menuDatosMaestros.Height -= 10;
                if (menuDatosMaestros.Height <= 40)
                {
                    menuDatMtroTransition.Stop();
                    menuDatMtro = false;
                }
            }
        }

        private void btnCrearMasivo_Click(object sender, EventArgs e)
        {
            if (reporteMasivo == null)
            {
                reporteMasivo = new frmReportMasiv();
                reporteMasivo.FormClosed += CrearMasivo_FormClosed;
                reporteMasivo.MdiParent = this;
                reporteMasivo.Dock = DockStyle.Fill;
                reporteMasivo.Show();
            }
            else
            {
                reporteMasivo.Activate();
            }
        }

        private void CrearMasivo_FormClosed(object sender, FormClosedEventArgs e)
        {
            reporteMasivo = null;
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            if (reportVwr == null)
            {
                reportVwr = new frmReportVwr();
                reportVwr.FormClosed += VerReportes_FormClosed;
                reportVwr.MdiParent = this;
                reportVwr.Dock = DockStyle.Fill;
                reportVwr.Show();
            }
            else
            {
                reportVwr.Activate();
            }
        }

        private void VerReportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportVwr = null;
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
