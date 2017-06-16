namespace Auditoria
{
    partial class Estadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeLaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAuditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAuditoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxAuditoria = new System.Windows.Forms.ComboBox();
            this.comboBoxEncuestas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreEmpresaDataSet = new Auditoria.nombreEmpresaDataSet();
            this.empresaTableAdapter = new Auditoria.nombreEmpresaDataSetTableAdapters.EmpresaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.vincularAuditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreEmpresaDataSet)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
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
            this.datosDeLaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.datosDeLaEmpresaToolStripMenuItem_Click_1);
            // 
            // verEmpresasToolStripMenuItem
            // 
            this.verEmpresasToolStripMenuItem.Name = "verEmpresasToolStripMenuItem";
            this.verEmpresasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verEmpresasToolStripMenuItem.Text = "Ver Empresas";
            this.verEmpresasToolStripMenuItem.Click += new System.EventHandler(this.verEmpresasToolStripMenuItem_Click_1);
            // 
            // registrarAuditorToolStripMenuItem
            // 
            this.registrarAuditorToolStripMenuItem.Name = "registrarAuditorToolStripMenuItem";
            this.registrarAuditorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registrarAuditorToolStripMenuItem.Text = "Registrar Auditor";
            this.registrarAuditorToolStripMenuItem.Click += new System.EventHandler(this.registrarAuditorToolStripMenuItem_Click_1);
            // 
            // verAuditoresToolStripMenuItem
            // 
            this.verAuditoresToolStripMenuItem.Name = "verAuditoresToolStripMenuItem";
            this.verAuditoresToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verAuditoresToolStripMenuItem.Text = "Ver Auditores";
            this.verAuditoresToolStripMenuItem.Click += new System.EventHandler(this.verAuditoresToolStripMenuItem_Click_1);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click_1);
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
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click_1);
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(117, 117);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(501, 246);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // comboBoxAuditoria
            // 
            this.comboBoxAuditoria.FormattingEnabled = true;
            this.comboBoxAuditoria.Items.AddRange(new object[] {
            "Auditoria Capacitación y Bienestar",
            "Auditoria Recursos Humanos",
            "Auditoria Recursos y Reclutamiento"});
            this.comboBoxAuditoria.Location = new System.Drawing.Point(117, 59);
            this.comboBoxAuditoria.Name = "comboBoxAuditoria";
            this.comboBoxAuditoria.Size = new System.Drawing.Size(185, 21);
            this.comboBoxAuditoria.TabIndex = 3;
            this.comboBoxAuditoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxEncuestas
            // 
            this.comboBoxEncuestas.FormattingEnabled = true;
            this.comboBoxEncuestas.Location = new System.Drawing.Point(688, 231);
            this.comboBoxEncuestas.Name = "comboBoxEncuestas";
            this.comboBoxEncuestas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEncuestas.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Graficar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.DataSource = this.empresaBindingSource;
            this.comboBoxEmpresa.DisplayMember = "nombreFiscalEmpresa";
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(433, 59);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(185, 21);
            this.comboBoxEmpresa.TabIndex = 6;
            this.comboBoxEmpresa.ValueMember = "nombreFiscalEmpresa";
            this.comboBoxEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpresa_SelectedIndexChanged);
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.nombreEmpresaDataSet;
            // 
            // nombreEmpresaDataSet
            // 
            this.nombreEmpresaDataSet.DataSetName = "nombreEmpresaDataSet";
            this.nombreEmpresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Obtener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vincularAuditorToolStripMenuItem
            // 
            this.vincularAuditorToolStripMenuItem.Name = "vincularAuditorToolStripMenuItem";
            this.vincularAuditorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vincularAuditorToolStripMenuItem.Text = "Vincular Auditor";
            this.vincularAuditorToolStripMenuItem.Click += new System.EventHandler(this.vincularAuditorToolStripMenuItem_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxEncuestas);
            this.Controls.Add(this.comboBoxAuditoria);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Estadisticas_FormClosed);
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreEmpresaDataSet)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxAuditoria;
        private System.Windows.Forms.ComboBox comboBoxEncuestas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private nombreEmpresaDataSet nombreEmpresaDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private nombreEmpresaDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem vincularAuditorToolStripMenuItem;
    }
}