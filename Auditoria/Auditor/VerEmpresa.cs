using Auditoria.Controladores;
using Auditoria.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditoria.Auditor
{
    public partial class VerEmpresa : Form
    {
        public Empresa empresaSeleccionada
        {
            get
            {
                return (Empresa)dataGridView1.SelectedRows[0].DataBoundItem;
            }
        }

        public VerEmpresa()
        {
            InitializeComponent();
        }

        private void botonAuditar_Click(object sender, EventArgs e)
        {
            PanelDeCuestionarios  form = new PanelDeCuestionarios();
            form.Show();

            ControladorAuditor.empresaActiva = empresaSeleccionada;

            this.Visible = false;
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["IniciarSesion"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaAuditor form = new AyudaAuditor();
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
        private void VerEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }

        private void VerEmpresa_Load(object sender, EventArgs e)
        {
            List<Empresa> empresas = ControladorAuditor.seleccionarEmpresas();
            dataGridView1.DataSource = empresas;

            dataGridView1.Columns["idEmpresa"].Visible = false;

            botonAuditar.Enabled = empresas.Count > 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
