namespace Auditoria.Administrador
{
    partial class VincularAuditor
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
            this.comboBoxAuditor = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAuditor
            // 
            this.comboBoxAuditor.FormattingEnabled = true;
            this.comboBoxAuditor.Location = new System.Drawing.Point(49, 94);
            this.comboBoxAuditor.Name = "comboBoxAuditor";
            this.comboBoxAuditor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAuditor.TabIndex = 0;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(207, 94);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmpresa.TabIndex = 1;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(372, 92);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.datosDeLaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.datosDeLaEmpresaToolStripMenuItem_Click);
            // 
            // verEmpresasToolStripMenuItem
            // 
            this.verEmpresasToolStripMenuItem.Name = "verEmpresasToolStripMenuItem";
            this.verEmpresasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verEmpresasToolStripMenuItem.Text = "Ver Empresas";
            // 
            // registrarAuditorToolStripMenuItem
            // 
            this.registrarAuditorToolStripMenuItem.Name = "registrarAuditorToolStripMenuItem";
            this.registrarAuditorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registrarAuditorToolStripMenuItem.Text = "Registrar Auditor";
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
            // 
            // vincularAuditorToolStripMenuItem
            // 
            this.vincularAuditorToolStripMenuItem.Name = "vincularAuditorToolStripMenuItem";
            this.vincularAuditorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vincularAuditorToolStripMenuItem.Text = "Vincular Auditor";
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
            // 
            // VincularAuditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 263);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.comboBoxAuditor);
            this.Name = "VincularAuditor";
            this.Text = "VincularAuditor";
            this.Load += new System.EventHandler(this.VincularAuditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAuditor;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeLaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAuditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAuditoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vincularAuditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
    }
}