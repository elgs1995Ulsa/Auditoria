using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditoria.Administrador
{
    public partial class VincularAuditor : Form
    {
        public VincularAuditor()
        {
            InitializeComponent();
        }

        private void VincularAuditor_Load(object sender, EventArgs e)
        {
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                comboBoxAuditor.DataSource = (from x in contexto.Persona
                                 select x.nombresPersona).ToList();
                comboBoxEmpresa.DataSource = (from x in contexto.Empresa
                                              select x.nombreFiscalEmpresa).ToList();
                
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                var persona = contexto.Persona.Where(x => x.nombresPersona == comboBoxAuditor.Text).FirstOrDefault();
                var usuario = contexto.Usuario.Where(x => x.idPersona == persona.idPersona).FirstOrDefault();
                var auditor = contexto.Auditor.Where(x => x.idUsuario == usuario.idUsuario).FirstOrDefault();
                var empresa = contexto.Empresa.Where(x => x.nombreFiscalEmpresa == comboBoxEmpresa.Text).FirstOrDefault();
                var vinculo = new Modelo.AuditorXEmpresa
                {
                    idEmpresa = empresa.idEmpresa,
                    idAuditor = auditor.idAuditor
                };
                contexto.AuditorXEmpresa.InsertOnSubmit(vinculo);
                contexto.SubmitChanges();
                MessageBox.Show("Auditor Asignado Correctamente");

            }
        }


        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }



        private void datosDeLaEmpresaToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void vincularAuditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VincularAuditor form = new VincularAuditor();
            form.Show();
            this.Visible = false;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda form = new Ayuda();
            form.Show();
            this.Visible = false;
        }

        private void cerrarSesionToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms["IniciarSesion"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }

        private void VincularAuditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }
    }
}
