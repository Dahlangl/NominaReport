using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaReport.Modulos
{
    public partial class frmReportVwr : Form
    {
        public frmReportVwr()
        {
            InitializeComponent();
        }

        private void frmReportVwr_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
