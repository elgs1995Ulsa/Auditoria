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
    public partial class AltaAuditor : Form
    {
        public AltaAuditor()
        {
            InitializeComponent();
        }
        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
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

        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosDeLaEmpresa form = new DatosDeLaEmpresa();
            form.Show();
            this.Visible = false;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void AltaAuditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }
        public void limpiar()
        {
            this.textapellidoMaterno.Text = "";
            this.textApellidoPaterno.Text = "";
            this.textCalle.Text = "";
            this.textCodigoPostal.Text = "";
            this.textColonia.Text = "";
            this.textContrasena.Text = "";
            this.textEntidadFederativa.Text = "";
            this.textNombreAuditor.Text = "";
            this.textNumero.Text = "";
            this.textPais.Text = "";
            this.textPerfilPRofesional.Text = "";
            this.textUsuario.Text = "";

        }
        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                var persona = new Modelo.Persona
                {
                    nombresPersona = textNombreAuditor.Text,
                    apellidoMaternoPersona = textapellidoMaterno.Text,
                    apellidoPaternoPersona = textApellidoPaterno.Text,
                    callePersona = textCalle.Text,
                    numeroCallePersona = Convert.ToInt32(textNumero.Text),
                    cpPersona = Convert.ToInt32( textCodigoPostal.Text),
                    paisPersona = textPais.Text,
                    coloniaPersona = textColonia.Text,
                    entidadFederativa = textEntidadFederativa.Text,
                    perfilProfesional = textPerfilPRofesional.Text
                };
                contexto.Persona.InsertOnSubmit(persona);
                contexto.SubmitChanges();
                var person = contexto.Persona.Where(x => x.nombresPersona == textNombreAuditor.Text).FirstOrDefault();
                var usuario = new Modelo.Usuario
                {
                    idPersona = person.idPersona,
                    nombreUsuario = textUsuario.Text,
                    contrasenaUsuario = textContrasena.Text,
                    idRol = 2
                };
                contexto.Usuario.InsertOnSubmit(usuario);
                contexto.SubmitChanges();
                var user = contexto.Usuario.Where(x => x.nombreUsuario == textUsuario.Text).FirstOrDefault();
                var auditor = new Modelo.Auditor
                {
                    idUsuario = user.idUsuario
                };
                contexto.Auditor.InsertOnSubmit(auditor);
                contexto.SubmitChanges();
                limpiar();
                MessageBox.Show("Auditor Registrado Correctamente");
            }
        }
    }
}
