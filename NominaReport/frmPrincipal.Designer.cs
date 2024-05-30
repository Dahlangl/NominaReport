namespace NominaReport
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.programNameTop = new System.Windows.Forms.Label();
            this.btnNavBar = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.navBarL = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuNominas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuNominas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCrearReporte = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCrearMasivo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.menuDatosMaestros = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenuDatosMaestros = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnConceptos = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuNominasTransition = new System.Windows.Forms.Timer(this.components);
            this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.menuDatMtroTransition = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.navBarL.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuNominas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.menuDatosMaestros.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.programNameTop);
            this.pnlTop.Controls.Add(this.btnNavBar);
            this.pnlTop.Controls.Add(this.nightControlBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 31);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // programNameTop
            // 
            this.programNameTop.AutoSize = true;
            this.programNameTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameTop.Location = new System.Drawing.Point(43, 6);
            this.programNameTop.Name = "programNameTop";
            this.programNameTop.Size = new System.Drawing.Size(183, 17);
            this.programNameTop.TabIndex = 8;
            this.programNameTop.Text = "Meretti | Reportes de Nómina";
            // 
            // btnNavBar
            // 
            this.btnNavBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBar.Image = ((System.Drawing.Image)(resources.GetObject("btnNavBar.Image")));
            this.btnNavBar.Location = new System.Drawing.Point(7, 0);
            this.btnNavBar.Name = "btnNavBar";
            this.btnNavBar.Size = new System.Drawing.Size(35, 31);
            this.btnNavBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNavBar.TabIndex = 7;
            this.btnNavBar.TabStop = false;
            this.btnNavBar.Click += new System.EventHandler(this.btnNavBar_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(861, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Size = new System.Drawing.Size(170, 40);
            this.panel2.TabIndex = 4;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-4, -16);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(185, 70);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "            Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // navBarL
            // 
            this.navBarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.navBarL.Controls.Add(this.pnlUsuario);
            this.navBarL.Controls.Add(this.panel2);
            this.navBarL.Controls.Add(this.menuNominas);
            this.navBarL.Controls.Add(this.menuDatosMaestros);
            this.navBarL.Controls.Add(this.pnlCerrarSesion);
            this.navBarL.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarL.Location = new System.Drawing.Point(0, 31);
            this.navBarL.Margin = new System.Windows.Forms.Padding(0);
            this.navBarL.Name = "navBarL";
            this.navBarL.Size = new System.Drawing.Size(170, 569);
            this.navBarL.TabIndex = 5;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnlUsuario.Controls.Add(this.lblEmail);
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.pnlUsuario.Controls.Add(this.lblRol);
            this.pnlUsuario.Controls.Add(this.pictureBox2);
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(170, 100);
            this.pnlUsuario.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(9, 68);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(1);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(54, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRol.Location = new System.Drawing.Point(54, 17);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(83, 15);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Rol de Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NominaReport.Properties.Resources.ContactsUser;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // menuNominas
            // 
            this.menuNominas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuNominas.Controls.Add(this.panel1);
            this.menuNominas.Controls.Add(this.panel5);
            this.menuNominas.Controls.Add(this.panel6);
            this.menuNominas.Controls.Add(this.panel7);
            this.menuNominas.Location = new System.Drawing.Point(0, 140);
            this.menuNominas.Margin = new System.Windows.Forms.Padding(0);
            this.menuNominas.Name = "menuNominas";
            this.menuNominas.Size = new System.Drawing.Size(170, 40);
            this.menuNominas.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.btnMenuNominas);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(170, 40);
            this.panel1.TabIndex = 7;
            // 
            // btnMenuNominas
            // 
            this.btnMenuNominas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnMenuNominas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuNominas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuNominas.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuNominas.Image")));
            this.btnMenuNominas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuNominas.Location = new System.Drawing.Point(-4, -16);
            this.btnMenuNominas.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuNominas.Name = "btnMenuNominas";
            this.btnMenuNominas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuNominas.Size = new System.Drawing.Size(185, 70);
            this.btnMenuNominas.TabIndex = 5;
            this.btnMenuNominas.Text = "            Nominas";
            this.btnMenuNominas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuNominas.UseVisualStyleBackColor = false;
            this.btnMenuNominas.Click += new System.EventHandler(this.btnMenuNominas_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel5.Controls.Add(this.btnCrearReporte);
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 40);
            this.panel5.TabIndex = 10;
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnCrearReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearReporte.Image")));
            this.btnCrearReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearReporte.Location = new System.Drawing.Point(-4, -16);
            this.btnCrearReporte.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCrearReporte.Size = new System.Drawing.Size(185, 70);
            this.btnCrearReporte.TabIndex = 5;
            this.btnCrearReporte.Text = "            Crear Reporte";
            this.btnCrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearReporte.UseVisualStyleBackColor = false;
            this.btnCrearReporte.Click += new System.EventHandler(this.btnCrearReporte_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel6.Controls.Add(this.btnCrearMasivo);
            this.panel6.Location = new System.Drawing.Point(0, 80);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 40);
            this.panel6.TabIndex = 11;
            // 
            // btnCrearMasivo
            // 
            this.btnCrearMasivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnCrearMasivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearMasivo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearMasivo.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearMasivo.Image")));
            this.btnCrearMasivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearMasivo.Location = new System.Drawing.Point(-4, -16);
            this.btnCrearMasivo.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearMasivo.Name = "btnCrearMasivo";
            this.btnCrearMasivo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCrearMasivo.Size = new System.Drawing.Size(185, 70);
            this.btnCrearMasivo.TabIndex = 5;
            this.btnCrearMasivo.Text = "            Crear Masivo";
            this.btnCrearMasivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearMasivo.UseVisualStyleBackColor = false;
            this.btnCrearMasivo.Click += new System.EventHandler(this.btnCrearMasivo_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel7.Controls.Add(this.btnVerReportes);
            this.panel7.Location = new System.Drawing.Point(0, 120);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel7.Size = new System.Drawing.Size(170, 40);
            this.panel7.TabIndex = 12;
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnVerReportes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReportes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnVerReportes.Image")));
            this.btnVerReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerReportes.Location = new System.Drawing.Point(-4, -16);
            this.btnVerReportes.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVerReportes.Size = new System.Drawing.Size(185, 70);
            this.btnVerReportes.TabIndex = 5;
            this.btnVerReportes.Text = "            Ver Reportes";
            this.btnVerReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerReportes.UseVisualStyleBackColor = false;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // menuDatosMaestros
            // 
            this.menuDatosMaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuDatosMaestros.Controls.Add(this.panel4);
            this.menuDatosMaestros.Controls.Add(this.panel8);
            this.menuDatosMaestros.Controls.Add(this.panel9);
            this.menuDatosMaestros.Location = new System.Drawing.Point(0, 180);
            this.menuDatosMaestros.Margin = new System.Windows.Forms.Padding(0);
            this.menuDatosMaestros.Name = "menuDatosMaestros";
            this.menuDatosMaestros.Size = new System.Drawing.Size(170, 40);
            this.menuDatosMaestros.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel4.Controls.Add(this.btnMenuDatosMaestros);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel4.Size = new System.Drawing.Size(170, 40);
            this.panel4.TabIndex = 9;
            // 
            // btnMenuDatosMaestros
            // 
            this.btnMenuDatosMaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnMenuDatosMaestros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDatosMaestros.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuDatosMaestros.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuDatosMaestros.Image")));
            this.btnMenuDatosMaestros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDatosMaestros.Location = new System.Drawing.Point(-4, -16);
            this.btnMenuDatosMaestros.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuDatosMaestros.Name = "btnMenuDatosMaestros";
            this.btnMenuDatosMaestros.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuDatosMaestros.Size = new System.Drawing.Size(185, 70);
            this.btnMenuDatosMaestros.TabIndex = 5;
            this.btnMenuDatosMaestros.Text = "            Datos Maestros";
            this.btnMenuDatosMaestros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDatosMaestros.UseVisualStyleBackColor = false;
            this.btnMenuDatosMaestros.Click += new System.EventHandler(this.btnMenuDatosMaestros_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel8.Controls.Add(this.btnConceptos);
            this.panel8.Location = new System.Drawing.Point(0, 40);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel8.Size = new System.Drawing.Size(170, 40);
            this.panel8.TabIndex = 13;
            // 
            // btnConceptos
            // 
            this.btnConceptos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnConceptos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConceptos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConceptos.Image = ((System.Drawing.Image)(resources.GetObject("btnConceptos.Image")));
            this.btnConceptos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConceptos.Location = new System.Drawing.Point(-4, -16);
            this.btnConceptos.Margin = new System.Windows.Forms.Padding(0);
            this.btnConceptos.Name = "btnConceptos";
            this.btnConceptos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConceptos.Size = new System.Drawing.Size(185, 70);
            this.btnConceptos.TabIndex = 5;
            this.btnConceptos.Text = "            Conceptos";
            this.btnConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConceptos.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel9.Controls.Add(this.btnAgregarEmpleado);
            this.panel9.Location = new System.Drawing.Point(0, 80);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel9.Size = new System.Drawing.Size(170, 40);
            this.panel9.TabIndex = 14;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEmpleado.Image")));
            this.btnAgregarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(-4, -16);
            this.btnAgregarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(185, 70);
            this.btnAgregarEmpleado.TabIndex = 5;
            this.btnAgregarEmpleado.Text = "            Agregar Empleado";
            this.btnAgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnlCerrarSesion.Controls.Add(this.btnLogout);
            this.pnlCerrarSesion.Location = new System.Drawing.Point(0, 220);
            this.pnlCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlCerrarSesion.Size = new System.Drawing.Size(170, 40);
            this.pnlCerrarSesion.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-4, -16);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(185, 70);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "            Cerrar Sesión";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuNominasTransition
            // 
            this.menuNominasTransition.Interval = 10;
            this.menuNominasTransition.Tick += new System.EventHandler(this.menuNominasTransition_Tick);
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 10;
            this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
            // 
            // menuDatMtroTransition
            // 
            this.menuDatMtroTransition.Interval = 10;
            this.menuDatMtroTransition.Tick += new System.EventHandler(this.menuDatMtroTransition_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.navBarL);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.navBarL.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuNominas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.menuDatosMaestros.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnlCerrarSesion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.FlowLayoutPanel navBarL;
        private System.Windows.Forms.Label programNameTop;
        private System.Windows.Forms.PictureBox btnNavBar;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuNominas;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMenuDatosMaestros;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCrearReporte;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCrearMasivo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnConceptos;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.FlowLayoutPanel menuNominas;
        private System.Windows.Forms.FlowLayoutPanel menuDatosMaestros;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer menuNominasTransition;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Timer sideBarTransition;
        private System.Windows.Forms.Timer menuDatMtroTransition;
    }
}

