using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NominaReport.Modulos
{
    public partial class frmReportMasiv : Form
    {
        public frmReportMasiv()
        {
            InitializeComponent();
        }

        private void frmReportMasiv_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void btnElegirArchivo_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtbRuta.Text = opn.FileName;
            }
        }

        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            string path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtbRuta.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";";
            OleDbConnection conn = new OleDbConnection(path);
            OleDbDataAdapter adptr = new OleDbDataAdapter("SELECT * FROM [Hoja1$]", conn);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            dtgbPrevia.DataSource = dt;
        }
    }
}
