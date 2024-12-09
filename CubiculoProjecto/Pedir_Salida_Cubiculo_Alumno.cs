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
    public partial class Pedir_Salida_Cubiculo_Alumno : Form
    {
        private int numeroCubiculo;
        private Menu_Cubiculos menuCubiculosForm;

        public Pedir_Salida_Cubiculo_Alumno(int numeroCubiculo, Menu_Cubiculos menuCubiculosForm)
        {
            InitializeComponent();

            this.numeroCubiculo = numeroCubiculo;
            this.menuCubiculosForm = menuCubiculosForm;

            // Mostrar el número de cubículo en un Label
            lblNumeroCubiculo.Text = numeroCubiculo.ToString();

            // Enlazar evento al botón
            btnRegistrarSalida.Click += btnRegistrarSalida_Click;
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            // Obtener el número de control ingresado
            string numeroControl = txtNumControl.Text.Trim();

            if (string.IsNullOrEmpty(numeroControl))
            {
                MessageBox.Show("Por favor, ingresa el número de control.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConexionBD conexion = new ConexionBD();

                // Verificar si el número de control es el código genérico "12345"
                if (numeroControl == "12345")
                {
                    // Obtener el registro activo del cubículo sin verificar el número de control
                    RegistroCubiculoAlumnos registro = conexion.ObtenerRegistroActivoPorCubiculo(numeroCubiculo);

                    if (registro != null)
                    {
                        // Actualizar la hora de salida
                        conexion.ActualizarHoraSalidaAlumnos(int.Parse(registro.num_prestamo));

                        MessageBox.Show("Salida registrada exitosamente mediante código genérico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el botón en Menu_Cubiculos
                        menuCubiculosForm.LiberarCubiculo(numeroCubiculo);

                        // Cerrar el formulario
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un registro activo para este cubículo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Obtener el registro activo del alumno en el cubículo
                    RegistroCubiculoAlumnos registro = conexion.ObtenerRegistroActivoPorCubiculo(numeroCubiculo);

                    if (registro != null && registro.numero_control == numeroControl)
                    {
                        // Actualizar la hora de salida
                        conexion.ActualizarHoraSalidaAlumnos(int.Parse(registro.num_prestamo));

                        MessageBox.Show("Salida registrada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el botón en Menu_Cubiculos
                        menuCubiculosForm.LiberarCubiculo(numeroCubiculo);

                        // Cerrar el formulario
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un registro activo para este cubículo y número de control.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
