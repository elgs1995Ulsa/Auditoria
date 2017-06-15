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
    public partial class PlanificacionCuestionario : Form
    {
        public PlanificacionCuestionario()
        {
            InitializeComponent();
        }

        private void PlanificacionCuestionario_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.OpenForms["PanelDeCuestionarios"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }
    }
}
