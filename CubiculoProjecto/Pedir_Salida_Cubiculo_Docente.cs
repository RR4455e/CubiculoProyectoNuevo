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
    public partial class Pedir_Salida_Cubiculo_Docente : Form
    {
        private int numeroCubiculo;
        private Menu_Cubiculos menuCubiculosForm;

        public Pedir_Salida_Cubiculo_Docente(int numeroCubiculo, Menu_Cubiculos menuCubiculosForm)
        {
            InitializeComponent();

            this.numeroCubiculo = numeroCubiculo;
            this.menuCubiculosForm = menuCubiculosForm;

            // Mostrar el número de cubículo
            lblNumeroCubiculo.Text = numeroCubiculo.ToString();

            // Enlazar el evento del botón
            btnRegistrarSalidaDocente.Click += btnRegistrarSalidaDocente_Click;
        }

        private void btnRegistrarSalidaDocente_Click(object sender, EventArgs e)
        {
            try
            {
                string noTarjeta = txtNoTarjetaSalida.Text.Trim();

                if (string.IsNullOrEmpty(noTarjeta))
                {
                    MessageBox.Show("Por favor, ingresa el número de tarjeta del personal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ConexionBD conexion = new ConexionBD();

                // Obtener el registro activo del docente en el cubículo actual
                RegistroCubiculoPersonal registroDocente = conexion.ObtenerRegistroActivoPorCubiculoYTarjeta(numeroCubiculo, noTarjeta);

                if (registroDocente != null)
                {
                    // Actualizar la hora de salida
                    conexion.ActualizarHoraSalidaPersonal(int.Parse(registroDocente.num_prestamo));

                    // Actualizar el botón en el formulario principal
                    menuCubiculosForm.LiberarCubiculo(numeroCubiculo);

                    MessageBox.Show("Salida registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar el formulario actual
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró un registro activo para este docente en el cubículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
