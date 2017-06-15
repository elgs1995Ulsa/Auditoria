using Auditoria.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditoria
{
    public partial class InicioAdministrador : Form
    {
        public InicioAdministrador()
        {
            InitializeComponent();
        }

        private void verCuestionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["IniciarSesion"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }


        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void InicioAuditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }

        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosDeLaEmpresa form = new DatosDeLaEmpresa();
            form.Show();
            this.Visible = false;
        }

        private void verEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerEmpresas form = new VerEmpresas();
            form.Show();
            this.Visible = false;
        }

        private void registrarAuditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAuditor form = new AltaAuditor();
            form.Show();
            this.Visible = false;
        }

        private void verAuditoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAuditores form = new VerAuditores();
            form.Show();
            this.Visible = false;
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas form = new Estadisticas();
            form.Show();
            this.Visible = false;
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarExcel form = new ExportarExcel();
            form.Show();
            this.Visible = false;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda form = new Ayuda();
            form.Show();
            this.Visible = false;
        }

   
        
        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }
    }
}
