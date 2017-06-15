using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auditoria.Administrador;
using Auditoria.Auditor;

namespace Auditoria
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                buttonIngresar.PerformClick();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var contexto = new Modelo.AuditoriaModeloDataContext())
            {

                var usuario = contexto.Usuario.Where(x => x.nombreUsuario == textUsuario.Text && x.contrasenaUsuario == textContrasena.Text).FirstOrDefault();
                if (usuario != null)
                {
                    if (usuario.idRol == 1)
                    {
                        InicioAdministrador form = new InicioAdministrador();
                        form.Show();
                        this.Visible = false;
                    }
                    else if (usuario.idRol == 2)
                    {
                        InicioAuditor form = new InicioAuditor();
                        form.Show();
                        this.Visible = false;
                    }

                }
                else
                {
                    MessageBox.Show("Verifica tus Datos, Credenciales Incorrectas");
                }


            }

         
        }
    }
}
