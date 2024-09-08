namespace NominaReport.Modulos
{
    partial class frmReportMasiv
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtbRegistros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtbRuta = new System.Windows.Forms.TextBox();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            this.btnElegirArchivo = new System.Windows.Forms.Button();
            this.dtgbPrevia = new System.Windows.Forms.DataGridView();
            this.pnlRevision = new System.Windows.Forms.Panel();
            this.dtgdDesglose = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbPrevia)).BeginInit();
            this.pnlRevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdDesglose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(830, 66);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(275, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Importar Masivo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardar.Location = new System.Drawing.Point(402, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Crear Reportes";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtbRegistros
            // 
            this.txtbRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegistros.Location = new System.Drawing.Point(114, 46);
            this.txtbRegistros.Name = "txtbRegistros";
            this.txtbRegistros.Size = new System.Drawing.Size(150, 23);
            this.txtbRegistros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° de registros";
            // 
            // pnlImport
            // 
            this.pnlImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImport.Controls.Add(this.btnProcesar);
            this.pnlImport.Controls.Add(this.txtbRuta);
            this.pnlImport.Controls.Add(this.lblRutaArchivo);
            this.pnlImport.Controls.Add(this.btnElegirArchivo);
            this.pnlImport.Controls.Add(this.dtgbPrevia);
            this.pnlImport.Controls.Add(this.txtbRegistros);
            this.pnlImport.Controls.Add(this.label1);
            this.pnlImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImport.Location = new System.Drawing.Point(0, 66);
            this.pnlImport.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(280, 503);
            this.pnlImport.TabIndex = 4;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.LightGray;
            this.btnProcesar.Location = new System.Drawing.Point(148, 75);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(117, 40);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click_1);
            // 
            // txtbRuta
            // 
            this.txtbRuta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRuta.Location = new System.Drawing.Point(101, 17);
            this.txtbRuta.Name = "txtbRuta";
            this.txtbRuta.Size = new System.Drawing.Size(163, 23);
            this.txtbRuta.TabIndex = 8;
            // 
            // lblRutaArchivo
            // 
            this.lblRutaArchivo.AutoSize = true;
            this.lblRutaArchivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaArchivo.Location = new System.Drawing.Point(9, 20);
            this.lblRutaArchivo.Name = "lblRutaArchivo";
            this.lblRutaArchivo.Size = new System.Drawing.Size(86, 17);
            this.lblRutaArchivo.TabIndex = 7;
            this.lblRutaArchivo.Text = "Ruta Archivo";
            // 
            // btnElegirArchivo
            // 
            this.btnElegirArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnElegirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirArchivo.FlatAppearance.BorderSize = 0;
            this.btnElegirArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnElegirArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElegirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirArchivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirArchivo.ForeColor = System.Drawing.Color.LightGray;
            this.btnElegirArchivo.Location = new System.Drawing.Point(13, 75);
            this.btnElegirArchivo.Name = "btnElegirArchivo";
            this.btnElegirArchivo.Size = new System.Drawing.Size(117, 40);
            this.btnElegirArchivo.TabIndex = 9;
            this.btnElegirArchivo.Text = "Subir Archivo";
            this.btnElegirArchivo.UseVisualStyleBackColor = false;
            this.btnElegirArchivo.Click += new System.EventHandler(this.btnElegirArchivo_Click_1);
            // 
            // dtgbPrevia
            // 
            this.dtgbPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgbPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbPrevia.Location = new System.Drawing.Point(29, 132);
            this.dtgbPrevia.Name = "dtgbPrevia";
            this.dtgbPrevia.Size = new System.Drawing.Size(220, 347);
            this.dtgbPrevia.TabIndex = 0;
            // 
            // pnlRevision
            // 
            this.pnlRevision.Controls.Add(this.btnGuardar);
            this.pnlRevision.Controls.Add(this.dtgdDesglose);
            this.pnlRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevision.Location = new System.Drawing.Point(280, 66);
            this.pnlRevision.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRevision.Name = "pnlRevision";
            this.pnlRevision.Size = new System.Drawing.Size(550, 503);
            this.pnlRevision.TabIndex = 5;
            // 
            // dtgdDesglose
            // 
            this.dtgdDesglose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdDesglose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdDesglose.Location = new System.Drawing.Point(37, 69);
            this.dtgdDesglose.Name = "dtgdDesglose";
            this.dtgdDesglose.Size = new System.Drawing.Size(482, 410);
            this.dtgdDesglose.TabIndex = 0;
            // 
            // frmReportMasiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(830, 569);
            this.Controls.Add(this.pnlRevision);
            this.Controls.Add(this.pnlImport);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportMasiv";
            this.Text = "frmReportMasiv";
            this.Load += new System.EventHandler(this.frmReportMasiv_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlImport.ResumeLayout(false);
            this.pnlImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbPrevia)).EndInit();
            this.pnlRevision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdDesglose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.Panel pnlRevision;
        private System.Windows.Forms.TextBox txtbRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgbPrevia;
        private System.Windows.Forms.DataGridView dtgdDesglose;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnElegirArchivo;
        private System.Windows.Forms.TextBox txtbRuta;
        private System.Windows.Forms.Label lblRutaArchivo;
    }
}