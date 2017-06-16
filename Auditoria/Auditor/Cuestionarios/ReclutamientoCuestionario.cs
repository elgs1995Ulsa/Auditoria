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

namespace Auditoria
{
    public partial class ReclutamientoCuestionario : Form
    {
        public ReclutamientoCuestionario()
        {
            InitializeComponent();
        }

        private void ReclutamientoCuestionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["PanelDeCuestionarios"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            bool insertado = ControladorAuditor.insertarCuestionarioRecursosReclutamiento(
                comboBox1.SelectedIndex + 1,
                comboBox2.SelectedIndex + 1,
                comboBox3.SelectedIndex + 1,
                comboBox4.SelectedIndex + 1,
                comboBox5.SelectedIndex + 1,
                comboBox6.SelectedIndex + 1,
                comboBox7.SelectedIndex + 1,
                comboBox8.SelectedIndex + 1,
                txtComentario.Text
            );

            if (insertado)
            {
                MessageBox.Show("Se ha generado el checklist de forma correcta");
            }
            else
            {
                MessageBox.Show("Error al generar el checklist");
            }
        }

        private void ReclutamientoCuestionario_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
            comboBox2.SelectedIndex = 2;
            comboBox3.SelectedIndex = 2;
            comboBox4.SelectedIndex = 2;
            comboBox5.SelectedIndex = 2;
            comboBox6.SelectedIndex = 2;
            comboBox7.SelectedIndex = 2;
            comboBox8.SelectedIndex = 2;
        }
    }
}
