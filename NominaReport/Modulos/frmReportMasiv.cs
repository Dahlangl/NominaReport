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
    }
}
