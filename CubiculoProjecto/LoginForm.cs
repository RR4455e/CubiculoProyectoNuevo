using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubiculoProyectoNuevo
{
    public partial class LoginForm : Form
    {
        // Puedes ajustar estos valores para el inicio de sesión
        private string usuarioValido = "admin";
        private string contraseñaValida = "12345";

        public LoginForm()
        {
            InitializeComponent();
            btnIniciarSesion.Click += btnIniciarSesion_Click;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == usuarioValido && contraseña == contraseñaValida)
            {
                // Inicio de sesión exitoso
                AdminCubiculo adminCubiculoForm = new AdminCubiculo();
                adminCubiculoForm.Show();

                // Cerrar el formulario de inicio de sesión
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
