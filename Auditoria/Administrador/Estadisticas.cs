using Auditoria.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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



        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'nombreEmpresaDataSet.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.nombreEmpresaDataSet.Empresa);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private double obtenerResultadoCapacitacion(int i)
        {
            double retornar = 0;
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                var auditoria = contexto.AuditoriaCapacitacionYBienestar.Where(x => x.idAuditoriaCapacitacionYBienestar == Convert.ToInt32(comboBoxEncuestas.Text)).FirstOrDefault();
                switch (i)
                {
                    case 0:
                        retornar = auditoria.p1;
                        break;
                    case 1:
                        retornar = auditoria.p2;
                        break;
                    case 2:
                        retornar = auditoria.p3;
                        break;
                    case 3:
                        retornar = auditoria.p4;
                        break;
                    case 4:
                        retornar = auditoria.p5;
                        break;
                    case 5:
                        retornar = auditoria.p6;
                        break;

                    case 6:
                        retornar = auditoria.p7;
                        break;
                    case 7:
                        retornar = auditoria.p8;
                        break;


                }
            }
            return retornar;
        }

        private double obtenerResultadoRecursosHumanos(int i)
        {
            double retornar = 0;
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                var auditoria = contexto.AuditoriaRecursosHumanos.Where(x => x.idAuditoriaRecursosHumanos == Convert.ToInt32(comboBoxEncuestas.Text)).FirstOrDefault();
                switch (i)
                {
                    case 0:
                        retornar = auditoria.p1;
                        break;
                    case 1:
                        retornar = auditoria.p2;
                        break;
                    case 2:
                        retornar = auditoria.p3;
                        break;
                    case 3:
                        retornar = auditoria.p4;
                        break;
                    case 4:
                        retornar = auditoria.p5;
                        break;
                    case 5:
                        retornar = auditoria.p6;
                        break;

                    case 6:
                        retornar = auditoria.p7;
                        break;
                    case 7:
                        retornar = auditoria.p8;
                        break;
                    case 8:
                        retornar = auditoria.p9;
                        break;
                    case 9:
                        retornar = auditoria.p10;
                        break;



                }
            }
            return retornar;
        }
        private double obtenerResultadosReclutamiento(int i)
        {
            double retornar = 0;
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                var auditoria = contexto.AuditoriaRecursosYReclutamiento.Where(x => x.idAuditoriaRecursosYReclutamiento == Convert.ToInt32(comboBoxEncuestas.Text)).FirstOrDefault();
                switch (i)
                {
                    case 0:
                        retornar = auditoria.p1;
                        break;
                    case 1:
                        retornar = auditoria.p2;
                        break;
                    case 2:
                        retornar = auditoria.p3;
                        break;
                    case 3:
                        retornar = auditoria.p4;
                        break;
                    case 4:
                        retornar = auditoria.p5;
                        break;
                    case 5:
                        retornar = auditoria.p6;
                        break;

                    case 6:
                        retornar = auditoria.p7;
                        break;
                    case 7:
                        retornar = auditoria.p8;
                        break;
                }
            }
            return retornar;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {
                if (comboBoxAuditoria.Text == "Auditoria Capacitación y Bienestar")
                {
                    var auditoria = contexto.AuditoriaCapacitacionYBienestar.Where(x => x.idAuditoriaCapacitacionYBienestar == Convert.ToInt32(comboBoxEncuestas.Text)).FirstOrDefault();
                    chart1.Series.Clear();
                    var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Series1",
                        Color = System.Drawing.Color.Green,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Series2",
                        Color = System.Drawing.Color.Red,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    this.chart1.Series.Add(series1);
                    this.chart1.Series.Add(series2);


                    for (int i = 0; i < 8; i++)
                    {
                        series1.Points.AddXY(i,5);
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        series2.Points.AddXY(i, obtenerResultadoCapacitacion(i));
                    }
                    chart1.Invalidate();

                }
                else if (comboBoxAuditoria.Text == "Auditoria Recursos Humanos")
                {
                    var auditoria = contexto.AuditoriaRecursosHumanos.Where(x => x.idAuditoriaRecursosHumanos == Convert.ToInt32(comboBoxEncuestas.Text)).FirstOrDefault();
                    chart1.Series.Clear();
                    var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Series1",
                        Color = System.Drawing.Color.Blue,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Series2",
                        Color = System.Drawing.Color.Red,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    this.chart1.Series.Add(series1);
                    this.chart1.Series.Add(series2);
                    for (int i = 0; i < 10; i++)
                    {
                        series1.Points.AddXY(i, 5);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        series2.Points.AddXY(i, obtenerResultadoRecursosHumanos(i));
                    }
                    chart1.Invalidate();
                }
                else if (comboBoxAuditoria.Text == "Auditoria Recursos y Reclutamiento")
                {
                    var auditoria = contexto.AuditoriaRecursosYReclutamiento.Where(x => x.idAuditoriaRecursosYReclutamiento == Convert.ToInt32(comboBoxEncuestas.Text)).FirstOrDefault();
                    chart1.Series.Clear();
                    var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Enabled = true,
                        Name = "Puntaje Maximo",
                        Color = System.Drawing.Color.Blue,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Enabled = true,
                        Name = "Puntaje Obtenido",
                        Color = System.Drawing.Color.Red,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = true,
                        ChartType = SeriesChartType.Line
                    };
                    this.chart1.Series.Add(series1);
                    this.chart1.Series.Add(series2);
                    for (int i = 0; i < 8; i++)
                    {
                        series1.Points.AddXY(i, 5);
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        series2.Points.AddXY(i, obtenerResultadosReclutamiento(i));
                    }
                    chart1.Invalidate();

                }
            }

        }

        
        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void vincularAuditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VincularAuditor form = new VincularAuditor();
            form.Show();
            this.Visible = false;
        }
        private void guardarCaptura( String nombre)
        {


            using (MemoryStream memory = new MemoryStream())
            {
                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    }
                    //      bitmap.Save("test.jpg", ImageFormat.Jpeg);

                    using (FileStream fs = new FileStream("C:\\Users\\Eduardo\\Desktop\\Graficas/" + nombre + ".Jpeg", FileMode.Create, FileAccess.ReadWrite))
                    {
                        bitmap.Save(memory, ImageFormat.Jpeg);
                        byte[] bytes = memory.ToArray();
                        fs.Write(bytes, 0, bytes.Length);
                        MessageBox.Show("Imagen Guardada Correctamente.");
                    }
                }


            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrafica_Click(object sender, EventArgs e)
        { 

            guardarCaptura( txtTitulo.Text);
        }
    }
}
