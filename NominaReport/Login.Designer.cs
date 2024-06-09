namespace NominaReport
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(78)))), ((int)(((byte)(64)))));
            this.pnlLogo.Controls.Add(this.logo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(300, 350);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // logo
            // 
            this.logo.Enabled = false;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(42, 69);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(212, 208);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtbUsuario.Location = new System.Drawing.Point(402, 117);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(314, 29);
            this.txtbUsuario.TabIndex = 1;
            this.txtbUsuario.Text = "Usuario";
            this.txtbUsuario.Enter += new System.EventHandler(this.txtbUsuario_Enter);
            this.txtbUsuario.Leave += new System.EventHandler(this.txtbUsuario_Leave);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogin.Location = new System.Drawing.Point(455, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(207, 45);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Iniciar Sesión";
            // 
            // txtbPassword
            // 
            this.txtbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtbPassword.Location = new System.Drawing.Point(402, 174);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(314, 29);
            this.txtbPassword.TabIndex = 2;
            this.txtbPassword.Text = "Contraseña";
            this.txtbPassword.Enter += new System.EventHandler(this.txtbPassword_Enter);
            this.txtbPassword.Leave += new System.EventHandler(this.txtbPassword_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.LightGreen;
            this.btnAcceder.Location = new System.Drawing.Point(402, 263);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(314, 40);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::NominaReport.Properties.Resources.Close2x;
            this.btnClose.Location = new System.Drawing.Point(767, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMsg.Image")));
            this.lblErrorMsg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMsg.Location = new System.Drawing.Point(400, 215);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(141, 19);
            this.lblErrorMsg.TabIndex = 5;
            this.lblErrorMsg.Text = "     Error Message";
            this.lblErrorMsg.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.pnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.PictureBox btnClose;
    }
}