namespace Auditoria.Administrador
{
    partial class VerEmpresas
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeLaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAuditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAuditoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verGraficasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.semestralAuditoriaDataSet1 = new Auditoria.semestralAuditoriaDataSet1();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new Auditoria.semestralAuditoriaDataSet1TableAdapters.EmpresaTableAdapter();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFiscalEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfcEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giroEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representanteLegalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleNumeroEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestralAuditoriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.verGraficasToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeLaEmpresaToolStripMenuItem,
            this.verEmpresasToolStripMenuItem,
            this.registrarAuditorToolStripMenuItem,
            this.verAuditoresToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // datosDeLaEmpresaToolStripMenuItem
            // 
            this.datosDeLaEmpresaToolStripMenuItem.Name = "datosDeLaEmpresaToolStripMenuItem";
            this.datosDeLaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.datosDeLaEmpresaToolStripMenuItem.Text = "Registrar Empresa";
            this.datosDeLaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.datosDeLaEmpresaToolStripMenuItem_Click);
            // 
            // verEmpresasToolStripMenuItem
            // 
            this.verEmpresasToolStripMenuItem.Name = "verEmpresasToolStripMenuItem";
            this.verEmpresasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verEmpresasToolStripMenuItem.Text = "Ver Empresas";
            this.verEmpresasToolStripMenuItem.Click += new System.EventHandler(this.verEmpresasToolStripMenuItem_Click);
            // 
            // registrarAuditorToolStripMenuItem
            // 
            this.registrarAuditorToolStripMenuItem.Name = "registrarAuditorToolStripMenuItem";
            this.registrarAuditorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registrarAuditorToolStripMenuItem.Text = "Registrar Auditor";
            this.registrarAuditorToolStripMenuItem.Click += new System.EventHandler(this.registrarAuditorToolStripMenuItem_Click);
            // 
            // verAuditoresToolStripMenuItem
            // 
            this.verAuditoresToolStripMenuItem.Name = "verAuditoresToolStripMenuItem";
            this.verAuditoresToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verAuditoresToolStripMenuItem.Text = "Ver Auditores";
            this.verAuditoresToolStripMenuItem.Click += new System.EventHandler(this.verAuditoresToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // verGraficasToolStripMenuItem
            // 
            this.verGraficasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem});
            this.verGraficasToolStripMenuItem.Name = "verGraficasToolStripMenuItem";
            this.verGraficasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.verGraficasToolStripMenuItem.Text = "Reporte";
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem1});
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Salir";
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpresaDataGridViewTextBoxColumn,
            this.razonSocialEmpresaDataGridViewTextBoxColumn,
            this.nombreFiscalEmpresaDataGridViewTextBoxColumn,
            this.rfcEmpresaDataGridViewTextBoxColumn,
            this.telefonoEmpresaDataGridViewTextBoxColumn,
            this.correoElectronicoEmpresaDataGridViewTextBoxColumn,
            this.giroEmpresaDataGridViewTextBoxColumn,
            this.representanteLegalDataGridViewTextBoxColumn,
            this.calleNumeroEmpresaDataGridViewTextBoxColumn,
            this.municipioEmpresaDataGridViewTextBoxColumn,
            this.cpEmpresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empresaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // semestralAuditoriaDataSet1
            // 
            this.semestralAuditoriaDataSet1.DataSetName = "semestralAuditoriaDataSet1";
            this.semestralAuditoriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.semestralAuditoriaDataSet1;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // idEmpresaDataGridViewTextBoxColumn
            // 
            this.idEmpresaDataGridViewTextBoxColumn.DataPropertyName = "idEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.HeaderText = "idEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.Name = "idEmpresaDataGridViewTextBoxColumn";
            this.idEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razonSocialEmpresaDataGridViewTextBoxColumn
            // 
            this.razonSocialEmpresaDataGridViewTextBoxColumn.DataPropertyName = "razonSocialEmpresa";
            this.razonSocialEmpresaDataGridViewTextBoxColumn.HeaderText = "razonSocialEmpresa";
            this.razonSocialEmpresaDataGridViewTextBoxColumn.Name = "razonSocialEmpresaDataGridViewTextBoxColumn";
            // 
            // nombreFiscalEmpresaDataGridViewTextBoxColumn
            // 
            this.nombreFiscalEmpresaDataGridViewTextBoxColumn.DataPropertyName = "nombreFiscalEmpresa";
            this.nombreFiscalEmpresaDataGridViewTextBoxColumn.HeaderText = "nombreFiscalEmpresa";
            this.nombreFiscalEmpresaDataGridViewTextBoxColumn.Name = "nombreFiscalEmpresaDataGridViewTextBoxColumn";
            // 
            // rfcEmpresaDataGridViewTextBoxColumn
            // 
            this.rfcEmpresaDataGridViewTextBoxColumn.DataPropertyName = "rfcEmpresa";
            this.rfcEmpresaDataGridViewTextBoxColumn.HeaderText = "rfcEmpresa";
            this.rfcEmpresaDataGridViewTextBoxColumn.Name = "rfcEmpresaDataGridViewTextBoxColumn";
            // 
            // telefonoEmpresaDataGridViewTextBoxColumn
            // 
            this.telefonoEmpresaDataGridViewTextBoxColumn.DataPropertyName = "telefonoEmpresa";
            this.telefonoEmpresaDataGridViewTextBoxColumn.HeaderText = "telefonoEmpresa";
            this.telefonoEmpresaDataGridViewTextBoxColumn.Name = "telefonoEmpresaDataGridViewTextBoxColumn";
            // 
            // correoElectronicoEmpresaDataGridViewTextBoxColumn
            // 
            this.correoElectronicoEmpresaDataGridViewTextBoxColumn.DataPropertyName = "correoElectronicoEmpresa";
            this.correoElectronicoEmpresaDataGridViewTextBoxColumn.HeaderText = "correoElectronicoEmpresa";
            this.correoElectronicoEmpresaDataGridViewTextBoxColumn.Name = "correoElectronicoEmpresaDataGridViewTextBoxColumn";
            // 
            // giroEmpresaDataGridViewTextBoxColumn
            // 
            this.giroEmpresaDataGridViewTextBoxColumn.DataPropertyName = "giroEmpresa";
            this.giroEmpresaDataGridViewTextBoxColumn.HeaderText = "giroEmpresa";
            this.giroEmpresaDataGridViewTextBoxColumn.Name = "giroEmpresaDataGridViewTextBoxColumn";
            // 
            // representanteLegalDataGridViewTextBoxColumn
            // 
            this.representanteLegalDataGridViewTextBoxColumn.DataPropertyName = "representanteLegal";
            this.representanteLegalDataGridViewTextBoxColumn.HeaderText = "representanteLegal";
            this.representanteLegalDataGridViewTextBoxColumn.Name = "representanteLegalDataGridViewTextBoxColumn";
            // 
            // calleNumeroEmpresaDataGridViewTextBoxColumn
            // 
            this.calleNumeroEmpresaDataGridViewTextBoxColumn.DataPropertyName = "calleNumeroEmpresa";
            this.calleNumeroEmpresaDataGridViewTextBoxColumn.HeaderText = "calleNumeroEmpresa";
            this.calleNumeroEmpresaDataGridViewTextBoxColumn.Name = "calleNumeroEmpresaDataGridViewTextBoxColumn";
            // 
            // municipioEmpresaDataGridViewTextBoxColumn
            // 
            this.municipioEmpresaDataGridViewTextBoxColumn.DataPropertyName = "municipioEmpresa";
            this.municipioEmpresaDataGridViewTextBoxColumn.HeaderText = "municipioEmpresa";
            this.municipioEmpresaDataGridViewTextBoxColumn.Name = "municipioEmpresaDataGridViewTextBoxColumn";
            // 
            // cpEmpresaDataGridViewTextBoxColumn
            // 
            this.cpEmpresaDataGridViewTextBoxColumn.DataPropertyName = "cpEmpresa";
            this.cpEmpresaDataGridViewTextBoxColumn.HeaderText = "cpEmpresa";
            this.cpEmpresaDataGridViewTextBoxColumn.Name = "cpEmpresaDataGridViewTextBoxColumn";
            // 
            // VerEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VerEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerEmpresas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerEmpresas_FormClosed);
            this.Load += new System.EventHandler(this.VerEmpresas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestralAuditoriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeLaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAuditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAuditoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verGraficasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private semestralAuditoriaDataSet1 semestralAuditoriaDataSet1;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private semestralAuditoriaDataSet1TableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFiscalEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giroEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representanteLegalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleNumeroEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpEmpresaDataGridViewTextBoxColumn;
    }
}