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
using System.Windows.Forms.DataVisualization.Charting;

namespace Auditoria
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }



        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }

        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Estadisticas_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }
        private int cont = 0;
        private double f(int i)
        {

            cont += 5;
            return cont;
        }
        private double acumulador = 0;
        private double resultadoEncuesta()
        {
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                var auditoria = contexto.AuditoriaCapacitacionYBienestar.FirstOrDefault();

            }
                return 0;
         }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'nombreEmpresaDataSet.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.nombreEmpresaDataSet.Empresa);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {



            /*
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };
            this.chart1.Series.Add(series1);

            for (int i = 0; i < 8; i++)
            {
                series1.Points.AddXY(i, f(i));
            }
            chart1.Invalidate();*/
        }

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEncuestas.DataSource != null)
            {
                comboBoxEncuestas.DataSource = null;

            }

            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                var empresa = contexto.Empresa.Where(x => x.nombreFiscalEmpresa == comboBoxEmpresa.Text).FirstOrDefault();
                if (comboBoxAuditoria.Text == "Auditoria Capacitación y Bienestar")
                {
                    comboBoxEncuestas.DataSource = (from x in contexto.AuditoriaCapacitacionYBienestar
                                                    where x.idEmpresa == empresa.idEmpresa
                                                    select x.idAuditoriaCapacitacionYBienestar).ToList(); 
                }
                else if (comboBoxAuditoria.Text == "Auditoria Recursos Humanos")
                {
                    comboBoxEncuestas.DataSource = (from x in contexto.AuditoriaRecursosHumanos
                                                    where x.idEmpresa == empresa.idEmpresa
                                                    select x.idAuditoriaRecursosHumanos).ToList();
                }
                else if (comboBoxAuditoria.Text == "Auditoria Recursos y Reclutamiento")
                {
                    comboBoxEncuestas.DataSource = (from x in contexto.AuditoriaRecursosYReclutamiento
                                                    where x.idEmpresa == empresa.idEmpresa
                                                    select x.idAuditoriaRecursosYReclutamiento).ToList();
                }
            }
        }
    }
}
