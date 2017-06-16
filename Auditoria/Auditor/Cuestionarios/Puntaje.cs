using Auditoria.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditoria.Auditor.Cuestionarios
{
    public partial class Puntaje : Form
    {
        public int puntaje { get; set; }
        public int maximo { get; set; }

        public string texto { get; set; }

        public Puntaje(int puntaje, int maximo, string texto)
        {
            InitializeComponent();


            this.puntaje = puntaje;
            this.maximo = maximo;

            this.texto = texto;
        }

        private void Puntaje_Load(object sender, EventArgs e)
        {
            lblEmpresa.Text = ControladorAuditor.empresaActiva.nombreFiscalEmpresa;
            lblTexto.Text = texto;

            lblPuntaje.Text = puntaje.ToString();
            lblMaximo.Text = maximo.ToString();

            double porcentaje = puntaje / ((double)maximo);
            porcentaje = porcentaje * 100;

            lblPorcentaje.Text = ((int)porcentaje).ToString() + "%";
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
