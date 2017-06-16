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
    public partial class EstadisticaAngel : Form
    {
        public string nombre { get; set; }

        public int numeroCuestionarios { get; set; }

        public int puntaje { get; set; }
        public int maximo { get; set; }

        public int porcentaje { get; set; }

        public EstadisticaAngel(string nombre, int numeroCuestionarios, int puntaje, int maximo, int porcentaje)
        {
            InitializeComponent();

            this.nombre = nombre;
            this.numeroCuestionarios = numeroCuestionarios;
            this.puntaje = puntaje;
            this.maximo = maximo;
            this.porcentaje = porcentaje;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Estadistica_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre;

            lblNumeroCuestionarios.Text = numeroCuestionarios + " aplicados";

            lblPuntaje.Text = puntaje.ToString();
            lblMaximo.Text = maximo.ToString();

            lblPorcentaje.Text = porcentaje.ToString() + "%";
        }
    }
}
