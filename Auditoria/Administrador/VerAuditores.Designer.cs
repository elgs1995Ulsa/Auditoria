namespace Auditoria.Administrador
{
    partial class VerAuditores
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
            this.vincularAuditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombresPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callePersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCallePersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadFederativaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilProfesionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semestralAuditoriaDataSet = new Auditoria.semestralAuditoriaDataSet();
            this.personaTableAdapter = new Auditoria.semestralAuditoriaDataSetTableAdapters.PersonaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestralAuditoriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeLaEmpresaToolStripMenuItem,
            this.verEmpresasToolStripMenuItem,
            this.registrarAuditorToolStripMenuItem,
            this.verAuditoresToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.vincularAuditorToolStripMenuItem});
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
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // vincularAuditorToolStripMenuItem
            // 
            this.vincularAuditorToolStripMenuItem.Name = "vincularAuditorToolStripMenuItem";
            this.vincularAuditorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vincularAuditorToolStripMenuItem.Text = "Vincular Auditor";
            this.vincularAuditorToolStripMenuItem.Click += new System.EventHandler(this.vincularAuditorToolStripMenuItem_Click);
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
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombresPersonaDataGridViewTextBoxColumn,
            this.apellidoPaternoPersonaDataGridViewTextBoxColumn,
            this.apellidoMaternoPersonaDataGridViewTextBoxColumn,
            this.callePersonaDataGridViewTextBoxColumn,
            this.cpPersonaDataGridViewTextBoxColumn,
            this.paisPersonaDataGridViewTextBoxColumn,
            this.numeroCallePersonaDataGridViewTextBoxColumn,
            this.coloniaPersonaDataGridViewTextBoxColumn,
            this.entidadFederativaDataGridViewTextBoxColumn,
            this.perfilProfesionalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // nombresPersonaDataGridViewTextBoxColumn
            // 
            this.nombresPersonaDataGridViewTextBoxColumn.DataPropertyName = "nombresPersona";
            this.nombresPersonaDataGridViewTextBoxColumn.HeaderText = "nombresPersona";
            this.nombresPersonaDataGridViewTextBoxColumn.Name = "nombresPersonaDataGridViewTextBoxColumn";
            // 
            // apellidoPaternoPersonaDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoPersonaDataGridViewTextBoxColumn.DataPropertyName = "apellidoPaternoPersona";
            this.apellidoPaternoPersonaDataGridViewTextBoxColumn.HeaderText = "apellidoPaternoPersona";
            this.apellidoPaternoPersonaDataGridViewTextBoxColumn.Name = "apellidoPaternoPersonaDataGridViewTextBoxColumn";
            // 
            // apellidoMaternoPersonaDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoPersonaDataGridViewTextBoxColumn.DataPropertyName = "apellidoMaternoPersona";
            this.apellidoMaternoPersonaDataGridViewTextBoxColumn.HeaderText = "apellidoMaternoPersona";
            this.apellidoMaternoPersonaDataGridViewTextBoxColumn.Name = "apellidoMaternoPersonaDataGridViewTextBoxColumn";
            // 
            // callePersonaDataGridViewTextBoxColumn
            // 
            this.callePersonaDataGridViewTextBoxColumn.DataPropertyName = "callePersona";
            this.callePersonaDataGridViewTextBoxColumn.HeaderText = "callePersona";
            this.callePersonaDataGridViewTextBoxColumn.Name = "callePersonaDataGridViewTextBoxColumn";
            // 
            // cpPersonaDataGridViewTextBoxColumn
            // 
            this.cpPersonaDataGridViewTextBoxColumn.DataPropertyName = "cpPersona";
            this.cpPersonaDataGridViewTextBoxColumn.HeaderText = "cpPersona";
            this.cpPersonaDataGridViewTextBoxColumn.Name = "cpPersonaDataGridViewTextBoxColumn";
            // 
            // paisPersonaDataGridViewTextBoxColumn
            // 
            this.paisPersonaDataGridViewTextBoxColumn.DataPropertyName = "paisPersona";
            this.paisPersonaDataGridViewTextBoxColumn.HeaderText = "paisPersona";
            this.paisPersonaDataGridViewTextBoxColumn.Name = "paisPersonaDataGridViewTextBoxColumn";
            // 
            // numeroCallePersonaDataGridViewTextBoxColumn
            // 
            this.numeroCallePersonaDataGridViewTextBoxColumn.DataPropertyName = "numeroCallePersona";
            this.numeroCallePersonaDataGridViewTextBoxColumn.HeaderText = "numeroCallePersona";
            this.numeroCallePersonaDataGridViewTextBoxColumn.Name = "numeroCallePersonaDataGridViewTextBoxColumn";
            // 
            // coloniaPersonaDataGridViewTextBoxColumn
            // 
            this.coloniaPersonaDataGridViewTextBoxColumn.DataPropertyName = "coloniaPersona";
            this.coloniaPersonaDataGridViewTextBoxColumn.HeaderText = "coloniaPersona";
            this.coloniaPersonaDataGridViewTextBoxColumn.Name = "coloniaPersonaDataGridViewTextBoxColumn";
            // 
            // entidadFederativaDataGridViewTextBoxColumn
            // 
            this.entidadFederativaDataGridViewTextBoxColumn.DataPropertyName = "entidadFederativa";
            this.entidadFederativaDataGridViewTextBoxColumn.HeaderText = "entidadFederativa";
            this.entidadFederativaDataGridViewTextBoxColumn.Name = "entidadFederativaDataGridViewTextBoxColumn";
            // 
            // perfilProfesionalDataGridViewTextBoxColumn
            // 
            this.perfilProfesionalDataGridViewTextBoxColumn.DataPropertyName = "perfilProfesional";
            this.perfilProfesionalDataGridViewTextBoxColumn.HeaderText = "perfilProfesional";
            this.perfilProfesionalDataGridViewTextBoxColumn.Name = "perfilProfesionalDataGridViewTextBoxColumn";
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.semestralAuditoriaDataSet;
            // 
            // semestralAuditoriaDataSet
            // 
            this.semestralAuditoriaDataSet.DataSetName = "semestralAuditoriaDataSet";
            this.semestralAuditoriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ver Auditores:";
            // 
            // VerAuditores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(811, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VerAuditores";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerAuditores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerAuditores_FormClosed);
            this.Load += new System.EventHandler(this.VerAuditores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestralAuditoriaDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private semestralAuditoriaDataSet semestralAuditoriaDataSet;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private semestralAuditoriaDataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callePersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCallePersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniaPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadFederativaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilProfesionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem vincularAuditorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}