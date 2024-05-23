using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using System.Drawing.Text;
using Microsoft.VisualBasic;
using Common.Cache;

namespace NominaReport
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtbUsuario.Text != "Usuario")
            {
                if (txtbPassword.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtbUsuario.Text, txtbPassword.Text);
                    if( validLogin == true)
                    {
                        this.Hide();
                        welcmForm welcome = new welcmForm();
                        welcome.ShowDialog();
                        //MessageBox.Show(msgBnvd + UserCache.userNombre + " " + UserCache.userApellidoPat + " " + UserCache.userApellidoMat, "Reportes de Nomina", MessageBoxButtons.OK);
                        frmPrincipal mainMenu = new frmPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos.  \n     Intenta de nuevo");
                        txtbPassword.Clear();
                        txtbUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Ingresa la contraseña");
                }
            }
            else
            {
                msgError("Ingresa el nombre de usuario");
            }
        }

        private void msgError(string msg)
        {
            lblErrorMsg.Text = "    " + msg;
            lblErrorMsg.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e) 
        {
            txtbUsuario.Text = "Usuario";
            txtbPassword.Text = "Contraseña";
            txtbPassword.UseSystemPasswordChar = false;
            lblErrorMsg.Visible = false;
            this.Show();
            txtbUsuario.Focus();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtbPassword_Enter(object sender, EventArgs e)
        {
            if (txtbPassword.Text == "Contraseña")
            {
                txtbPassword.Text = "";
                txtbPassword.ForeColor = Color.White;
                txtbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtbPassword_Leave(object sender, EventArgs e)
        {
            if( txtbPassword.Text == "")
            {
                txtbPassword.Text = "Contraseña";
                txtbPassword.ForeColor = Color.DimGray;
                txtbPassword.UseSystemPasswordChar= false;
            }
        }

        private void txtbUsuario_Enter(object sender, EventArgs e)
        {
            if (txtbUsuario.Text == "Usuario")
            {
                txtbUsuario.Text = "";
                txtbUsuario.ForeColor = Color.White;
            }
        }

        private void txtbUsuario_Leave(object sender, EventArgs e)
        {
            if(txtbUsuario.Text == "") 
            { 
                txtbUsuario.Text = "Usuario";
                txtbUsuario.ForeColor = Color.DimGray;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
