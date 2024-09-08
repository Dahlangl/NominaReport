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
using Dominio;

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
        private async Task CargarDatosAsync()
        {
            ObjectsModel objectsModel = new ObjectsModel();

            // Suponemos que la barra de progreso tiene 100 unidades, repartimos el progreso entre las tareas
            int step = 25;  // Cada conjunto de datos representa un 25% del progreso

            // Cargar empleados
            await Task.Run(() =>
            {
                objectsModel.cargarEmpleados();
            });
            progBarWelcome.Value += step;
            await Task.Delay(500); // Agregar un retraso de 500 ms

            // Cargar razón social
            await Task.Run(() =>
            {
                objectsModel.cargarRazonSocial();
            });
            progBarWelcome.Value += step;
            await Task.Delay(500); // Agregar un retraso de 500 ms

            // Cargar tipos de nómina
            await Task.Run(() =>
            {
                objectsModel.cargarNominaTipos();
            });
            progBarWelcome.Value += step;
            await Task.Delay(500); // Agregar un retraso de 500 ms

            // Cargar conceptos de nómina
            await Task.Run(() =>
            {
                objectsModel.cargarNominaConceptos();
            });
            progBarWelcome.Value += step;
            await Task.Delay(500); // Agregar un retraso de 500 ms

            // Todos los datos se cargaron, la barra de progreso debería estar en 100
            fadeIn.Stop();
            fadeOut.Start();
        }

        private async void welcmForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserCache.userNombre + " " + UserCache.userApellidoPat;
            this.Opacity = 0.0;
            progBarWelcome.Value = 0; 
            fadeIn.Start();

            await CargarDatosAsync();
        }
    }
}
