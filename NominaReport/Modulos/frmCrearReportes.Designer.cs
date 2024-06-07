namespace NominaReport.Modulos
{
    partial class frmCrearReportes
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.pnlCrear = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cboxRznSocial = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSelConcepto = new System.Windows.Forms.Label();
            this.cboxConceptos = new System.Windows.Forms.ComboBox();
            this.btnAggConcepto = new System.Windows.Forms.Button();
            this.detalleNomina = new System.Windows.Forms.DataGridView();
            this.nominaConceptoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominaConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporteNomDetalleCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboxNomina = new System.Windows.Forms.ComboBox();
            this.lblEmp = new System.Windows.Forms.Label();
            this.cboxColaborador = new System.Windows.Forms.ComboBox();
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.historialNomina = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlCont.SuspendLayout();
            this.pnlCrear.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleNomina)).BeginInit();
            this.pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(830, 66);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Reporte Nomina";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrear.Location = new System.Drawing.Point(39, 14);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(129, 40);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pnlCont
            // 
            this.pnlCont.Controls.Add(this.pnlCrear);
            this.pnlCont.Controls.Add(this.pnlFooter);
            this.pnlCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCont.Location = new System.Drawing.Point(0, 66);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(830, 503);
            this.pnlCont.TabIndex = 2;
            // 
            // pnlCrear
            // 
            this.pnlCrear.Controls.Add(this.panel1);
            this.pnlCrear.Controls.Add(this.pnlRegistro);
            this.pnlCrear.Controls.Add(this.pnlHistorial);
            this.pnlCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCrear.Location = new System.Drawing.Point(0, 0);
            this.pnlCrear.Name = "pnlCrear";
            this.pnlCrear.Size = new System.Drawing.Size(830, 423);
            this.pnlCrear.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(235, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 69);
            this.panel1.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(437, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(242, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 40);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegistro.Controls.Add(this.lblSucursal);
            this.pnlRegistro.Controls.Add(this.cboxRznSocial);
            this.pnlRegistro.Controls.Add(this.txtCantidad);
            this.pnlRegistro.Controls.Add(this.lblCantidad);
            this.pnlRegistro.Controls.Add(this.lblSelConcepto);
            this.pnlRegistro.Controls.Add(this.cboxConceptos);
            this.pnlRegistro.Controls.Add(this.btnAggConcepto);
            this.pnlRegistro.Controls.Add(this.detalleNomina);
            this.pnlRegistro.Controls.Add(this.lblTipo);
            this.pnlRegistro.Controls.Add(this.cboxNomina);
            this.pnlRegistro.Controls.Add(this.lblEmp);
            this.pnlRegistro.Controls.Add(this.cboxColaborador);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistro.Location = new System.Drawing.Point(235, 0);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(595, 423);
            this.pnlRegistro.TabIndex = 1;
            this.pnlRegistro.Visible = false;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(35, 101);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(121, 13);
            this.lblSucursal.TabIndex = 17;
            this.lblSucursal.Text = "Selecciona la sucursal:";
            // 
            // cboxRznSocial
            // 
            this.cboxRznSocial.FormattingEnabled = true;
            this.cboxRznSocial.Location = new System.Drawing.Point(38, 118);
            this.cboxRznSocial.Name = "cboxRznSocial";
            this.cboxRznSocial.Size = new System.Drawing.Size(139, 21);
            this.cboxRznSocial.TabIndex = 16;
            this.cboxRznSocial.SelectedIndexChanged += new System.EventHandler(this.cboxRznSocial_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(38, 270);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(139, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(35, 245);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(108, 13);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Ingresa la cantidad:";
            // 
            // lblSelConcepto
            // 
            this.lblSelConcepto.AutoSize = true;
            this.lblSelConcepto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelConcepto.Location = new System.Drawing.Point(35, 183);
            this.lblSelConcepto.Name = "lblSelConcepto";
            this.lblSelConcepto.Size = new System.Drawing.Size(124, 13);
            this.lblSelConcepto.TabIndex = 13;
            this.lblSelConcepto.Text = "Selecciona el concepto";
            // 
            // cboxConceptos
            // 
            this.cboxConceptos.FormattingEnabled = true;
            this.cboxConceptos.Location = new System.Drawing.Point(38, 209);
            this.cboxConceptos.Name = "cboxConceptos";
            this.cboxConceptos.Size = new System.Drawing.Size(139, 21);
            this.cboxConceptos.TabIndex = 12;
            // 
            // btnAggConcepto
            // 
            this.btnAggConcepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAggConcepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAggConcepto.FlatAppearance.BorderSize = 0;
            this.btnAggConcepto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAggConcepto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAggConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggConcepto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggConcepto.ForeColor = System.Drawing.Color.LightGray;
            this.btnAggConcepto.Location = new System.Drawing.Point(38, 311);
            this.btnAggConcepto.Name = "btnAggConcepto";
            this.btnAggConcepto.Size = new System.Drawing.Size(139, 32);
            this.btnAggConcepto.TabIndex = 5;
            this.btnAggConcepto.Text = "Agregar";
            this.btnAggConcepto.UseVisualStyleBackColor = false;
            // 
            // detalleNomina
            // 
            this.detalleNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nominaConceptoId,
            this.nominaConcepto,
            this.reporteNomDetalleCantidad});
            this.detalleNomina.Location = new System.Drawing.Point(231, 183);
            this.detalleNomina.Name = "detalleNomina";
            this.detalleNomina.Size = new System.Drawing.Size(244, 160);
            this.detalleNomina.TabIndex = 11;
            // 
            // nominaConceptoId
            // 
            this.nominaConceptoId.HeaderText = "ID Concepto";
            this.nominaConceptoId.Name = "nominaConceptoId";
            this.nominaConceptoId.Visible = false;
            // 
            // nominaConcepto
            // 
            this.nominaConcepto.HeaderText = "Concepto";
            this.nominaConcepto.Name = "nominaConcepto";
            // 
            // reporteNomDetalleCantidad
            // 
            this.reporteNomDetalleCantidad.HeaderText = "Cantidad";
            this.reporteNomDetalleCantidad.Name = "reporteNomDetalleCantidad";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(228, 101);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(159, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Selecciona el tipo de nómina:";
            // 
            // cboxNomina
            // 
            this.cboxNomina.FormattingEnabled = true;
            this.cboxNomina.Location = new System.Drawing.Point(231, 118);
            this.cboxNomina.Name = "cboxNomina";
            this.cboxNomina.Size = new System.Drawing.Size(139, 21);
            this.cboxNomina.TabIndex = 9;
            this.cboxNomina.SelectedIndexChanged += new System.EventHandler(this.cboxNomina_SelectedIndexChanged);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(423, 101);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(142, 13);
            this.lblEmp.TabIndex = 6;
            this.lblEmp.Text = "Selecciona al colaborador:";
            // 
            // cboxColaborador
            // 
            this.cboxColaborador.FormattingEnabled = true;
            this.cboxColaborador.Location = new System.Drawing.Point(426, 118);
            this.cboxColaborador.Name = "cboxColaborador";
            this.cboxColaborador.Size = new System.Drawing.Size(139, 21);
            this.cboxColaborador.TabIndex = 5;
            this.cboxColaborador.SelectedIndexChanged += new System.EventHandler(this.cboxColaborador_SelectedIndexChanged);
            // 
            // pnlHistorial
            // 
            this.pnlHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistorial.Controls.Add(this.label1);
            this.pnlHistorial.Controls.Add(this.historialNomina);
            this.pnlHistorial.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHistorial.Location = new System.Drawing.Point(0, 0);
            this.pnlHistorial.Name = "pnlHistorial";
            this.pnlHistorial.Size = new System.Drawing.Size(235, 423);
            this.pnlHistorial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Últimos reportes:";
            // 
            // historialNomina
            // 
            this.historialNomina.AllowUserToAddRows = false;
            this.historialNomina.AllowUserToDeleteRows = false;
            this.historialNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialNomina.Location = new System.Drawing.Point(15, 44);
            this.historialNomina.Name = "historialNomina";
            this.historialNomina.ReadOnly = true;
            this.historialNomina.Size = new System.Drawing.Size(202, 365);
            this.historialNomina.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 423);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(830, 80);
            this.pnlFooter.TabIndex = 5;
            // 
            // frmCrearReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 569);
            this.Controls.Add(this.pnlCont);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearReportes";
            this.Text = "frmCrearReportes";
            this.Load += new System.EventHandler(this.frmCrearReportes_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCont.ResumeLayout(false);
            this.pnlCrear.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleNomina)).EndInit();
            this.pnlHistorial.ResumeLayout(false);
            this.pnlHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialNomina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.ComboBox cboxColaborador;
        private System.Windows.Forms.Panel pnlCrear;
        private System.Windows.Forms.Panel pnlHistorial;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView historialNomina;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboxNomina;
        private System.Windows.Forms.DataGridView detalleNomina;
        private System.Windows.Forms.Button btnAggConcepto;
        private System.Windows.Forms.Label lblSelConcepto;
        private System.Windows.Forms.ComboBox cboxConceptos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cboxRznSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominaConceptoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominaConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporteNomDetalleCantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}