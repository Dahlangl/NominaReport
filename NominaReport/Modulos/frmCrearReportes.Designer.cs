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
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.cboxRazonSocial = new System.Windows.Forms.ComboBox();
            this.lblEmp = new System.Windows.Forms.Label();
            this.cboxColaborador = new System.Windows.Forms.ComboBox();
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlHeader.SuspendLayout();
            this.pnlCont.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnCrear);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(830, 66);
            this.pnlHeader.TabIndex = 1;
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
            this.btnCrear.Location = new System.Drawing.Point(689, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(129, 40);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
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
            // pnlCont
            // 
            this.pnlCont.Controls.Add(this.panel2);
            this.pnlCont.Controls.Add(this.pnlFooter);
            this.pnlCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCont.Location = new System.Drawing.Point(0, 66);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(830, 503);
            this.pnlCont.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlRegistro);
            this.panel2.Controls.Add(this.pnlHistorial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 423);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.lblTipo);
            this.pnlRegistro.Controls.Add(this.comboBox1);
            this.pnlRegistro.Controls.Add(this.lblRazonSocial);
            this.pnlRegistro.Controls.Add(this.cboxRazonSocial);
            this.pnlRegistro.Controls.Add(this.lblEmp);
            this.pnlRegistro.Controls.Add(this.cboxColaborador);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistro.Location = new System.Drawing.Point(235, 0);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(595, 423);
            this.pnlRegistro.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(21, 18);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(72, 13);
            this.lblRazonSocial.TabIndex = 8;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // cboxRazonSocial
            // 
            this.cboxRazonSocial.FormattingEnabled = true;
            this.cboxRazonSocial.Location = new System.Drawing.Point(24, 35);
            this.cboxRazonSocial.Name = "cboxRazonSocial";
            this.cboxRazonSocial.Size = new System.Drawing.Size(139, 21);
            this.cboxRazonSocial.TabIndex = 7;
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(216, 18);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(142, 13);
            this.lblEmp.TabIndex = 6;
            this.lblEmp.Text = "Selecciona al colaborador:";
            // 
            // cboxColaborador
            // 
            this.cboxColaborador.FormattingEnabled = true;
            this.cboxColaborador.Location = new System.Drawing.Point(219, 35);
            this.cboxColaborador.Name = "cboxColaborador";
            this.cboxColaborador.Size = new System.Drawing.Size(139, 21);
            this.cboxColaborador.TabIndex = 5;
            this.cboxColaborador.SelectedIndexChanged += new System.EventHandler(this.cboxColaborador_SelectedIndexChanged);
            // 
            // pnlHistorial
            // 
            this.pnlHistorial.Controls.Add(this.label1);
            this.pnlHistorial.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(202, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 423);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(830, 80);
            this.pnlFooter.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(409, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(159, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Selecciona el tipo de nómina:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(412, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 9;
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
            this.panel2.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlHistorial.ResumeLayout(false);
            this.pnlHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHistorial;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.ComboBox cboxRazonSocial;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}