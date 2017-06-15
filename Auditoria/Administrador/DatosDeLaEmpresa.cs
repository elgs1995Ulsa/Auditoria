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
    public partial class DatosDeLaEmpresa : Form
    {
        public DatosDeLaEmpresa()
        {
            InitializeComponent();
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

        private void datosDeLaEmpresaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DatosDeLaEmpresa form = new DatosDeLaEmpresa();
            form.Show();
            this.Visible = false;
        }

        private void verEmpresasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            VerEmpresas form = new VerEmpresas();
            form.Show();
            this.Visible = false;
        }

        private void registrarAuditorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AltaAuditor form = new AltaAuditor();
            form.Show();
            this.Visible = false;
        }

        private void verAuditoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            VerAuditores form = new VerAuditores();
            form.Show();
            this.Visible = false;
        }

        private void estadisticasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Estadisticas form = new Estadisticas();
            form.Show();
            this.Visible = false;
        }

        private void exportarAExcelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ExportarExcel form = new ExportarExcel();
            form.Show();
            this.Visible = false;
        }

        private void ayudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ayuda form = new Ayuda();
            form.Show();
            this.Visible = false;
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["IniciarSesion"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           InicioAdministrador form = new InicioAdministrador();
            form.Show();
            this.Visible = false;
        }


        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void DatosDeLaEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                var empresa = new Modelo.Empresa
                {
                    razonSocialEmpresa= txtRazonSocial.Text,
                    nombreFiscalEmpresa=txtNombreFiscal.Text,
                    rfcEmpresa = txtRFC.Text,
                    telefonoEmpresa = txtTelefono.Text,
                    correoElectronicoEmpresa = txtCorreoElectronico.Text,
                    giroEmpresa = txtGiro.Text,
                    representanteLegal = txtRepresentanteLega.Text,
                    calleNumeroEmpresa = txtCalleNumero.Text,
                    municipioEmpresa = txtMunicipio.Text,
                    cpEmpresa = txtCodigoPostal.Text

                };

                contexto.Empresa.InsertOnSubmit(empresa);
                contexto.SubmitChanges();
                MessageBox.Show("Empresa Registrada Correctamente");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
