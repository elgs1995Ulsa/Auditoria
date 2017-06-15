using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auditoria.Auditor;
using Auditoria.Auditor.Cuestionarios;

namespace Auditoria.Auditor
{
    public partial class PanelDeCuestionarios : Form
    {
        public PanelDeCuestionarios()
        {
            InitializeComponent();
        }

        private void caracterGeneral_Click(object sender, EventArgs e)
        {
            CaracterGeneralCuestionario form = new CaracterGeneralCuestionario();
            form.Show();
            this.Visible = false;
        }

        private void planificacion_Click(object sender, EventArgs e)
        {
            PlanificacionCuestionario form = new PlanificacionCuestionario();
            form.Show();
            this.Visible = false;
        }

        private void reclutamiento_Click(object sender, EventArgs e)
        {
            ReclutamientoCuestionario form = new ReclutamientoCuestionario();
            form.Show();
            this.Visible = false;
        }

        private void formacionDesarrollo_Click(object sender, EventArgs e)
        {
            CapacitacionesCuestionario form = new CapacitacionesCuestionario();
            form.Show();
            this.Visible = false;
        }

        private void relacionesLaborales_Click(object sender, EventArgs e)
        {
            RelacionesLaboralesCuestionario form = new RelacionesLaboralesCuestionario();
            form.Show();
            this.Visible = false;
        }

        private void recursosInformaticos_Click(object sender, EventArgs e)
        {
            RecursosInformaticosCuestionario form = new RecursosInformaticosCuestionario();         
            form.Show();
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

        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerEmpresa form = new VerEmpresa();
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

        private void PanelDeCuestionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }
    }
}
