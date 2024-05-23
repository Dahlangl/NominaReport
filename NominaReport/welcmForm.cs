using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace NominaReport
{
    public partial class welcmForm : Form
    {
        public welcmForm()
        {
            InitializeComponent();
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <1) this .Opacity += 0.05;
            progBarWelcome.Value += 1;
            if (progBarWelcome.Value == 100) 
            {
                fadeIn.Stop();
                fadeOut.Start();
            }
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0 )
            {
                fadeOut.Stop();
                this.Close();
            }
        }

        private void welcmForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserCache.userNombre + " " + UserCache.userApellidoPat;
            this.Opacity = 0.0;
            progBarWelcome.Value = 0; 
            fadeIn.Start();
        }
    }
}
