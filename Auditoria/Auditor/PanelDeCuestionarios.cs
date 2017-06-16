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
using Auditoria.Controladores;
using Auditoria.Modelo;

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PanelDeCuestionarios_Load(object sender, EventArgs e)
        {
            lblEmpresa.Text = ControladorAuditor.empresaActiva.nombreFiscalEmpresa;
        }

        private void lblEstadisticaCG_Click(object sender, EventArgs e)
        {
            List<AuditoriaRecursosHumanos> lista = ControladorAuditor.seleccionarAuditoriaRecursosHumanos();

            if (lista.Count > 0)
            {
                int numeroCuestionarios = lista.Count;
                double puntaje = lista.Average(a => a.p1 + a.p2 + a.p3 + a.p4 + a.p5 + a.p6 + a.p7 + a.p8 + a.p9 + a.p10);
                double maximo = 50;

                double porcentaje = puntaje / maximo * 100;

                EstadisticaAngel ea = new EstadisticaAngel("Caracter general", numeroCuestionarios, (int)puntaje, (int)maximo, (int)porcentaje);
                ea.ShowDialog();
            }
            else
            {
                EstadisticaAngel ea = new EstadisticaAngel("Caracter general", 0, 0, 50, 0);
                ea.ShowDialog();
            }
        }

        private void lblEstadisticaCB_Click(object sender, EventArgs e)
        {
            List<AuditoriaCapacitacionYBienestar> lista = ControladorAuditor.seleccionarAuditoriaCapacitacionYBienestar();

            if (lista.Count > 0)
            {
                int numeroCuestionarios = lista.Count;
                double puntaje = lista.Average(a => a.p1 + a.p2 + a.p3 + a.p4 + a.p5 + a.p6 + a.p7 + a.p8);
                double maximo = 40;

                double porcentaje = puntaje / maximo * 100;

                EstadisticaAngel ea = new EstadisticaAngel("Capacitación y bienestar", numeroCuestionarios, (int)puntaje, (int)maximo, (int)porcentaje);
                ea.ShowDialog();
            }
            else
            {
                EstadisticaAngel ea = new EstadisticaAngel("Capacitación y bienestar", 0, 0, 40, 0);
                ea.ShowDialog();
            }
        }

        private void lblEstadisticaPR_Click(object sender, EventArgs e)
        {
            List<AuditoriaRecursosYReclutamiento> lista = ControladorAuditor.seleccionarAuditoriaRecursosYReclutamiento();

            if (lista.Count > 0)
            {
                int numeroCuestionarios = lista.Count;
                double puntaje = lista.Average(a => a.p1 + a.p2 + a.p3 + a.p4 + a.p5 + a.p6 + a.p7 + a.p8);
                double maximo = 40;

                double porcentaje = puntaje / maximo * 100;

                EstadisticaAngel ea = new EstadisticaAngel("Planificación y reclutamiento", numeroCuestionarios, (int)puntaje, (int)maximo, (int)porcentaje);
                ea.ShowDialog();
            }
            else
            {
                EstadisticaAngel ea = new EstadisticaAngel("Planificación y reclutamiento", 0, 0, 40, 0);
                ea.ShowDialog();
            }
        }
    }
}
