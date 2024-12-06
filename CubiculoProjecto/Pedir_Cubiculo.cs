using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubiculoProjecto
{
    public partial class Pedir_Cubiculo : Form
    {
        private int numeroCubiculo;
        private Menu_Cubiculos menuCubiculosForm;
        private TabControl tabControl;
        private TabPage tabPageAlumno;
        private TabPage tabPagePersonal;
        private TabPage tabPageExternos;


        public Pedir_Cubiculo(int numeroCubiculo, Menu_Cubiculos menuCubiculosForm)
        {
            InitializeComponent();

            this.numeroCubiculo = numeroCubiculo;
            this.menuCubiculosForm = menuCubiculosForm;

            // Inicializar referencias
            tabControl = this.tabControl1; 
            tabPageAlumno = this.tabAlumnos; 
            tabPagePersonal = this.tabPersonal;
            tabPageExternos = this.tabExternos;


            // Mostrar el número de cubículo en las pestañas
            lblNumeroCubiculoAlumno.Text = numeroCubiculo.ToString();
            lblNumeroCubiculoDocente.Text = numeroCubiculo.ToString();
            lblNumeroCubiculoExterno.Text = numeroCubiculo.ToString();


            // Eventos para alumnos
            txtNumControl.TextChanged += txtNumControl_TextChanged;
            btnRegistrarAlumno.Click += btnRegistrarAlumno_Click;

            // Eventos para docentes
            txtNoTarjeta.TextChanged += txtNoTarjeta_TextChanged;
            btnRegistrarDocente.Click += btnRegistrarDocente_Click;
           
            // Eventos para externos
            btnRegistrarExterno.Click += btnRegistrarExterno_Click;

        }

        // =======================
        // Código para pestaña Alumno
        // =======================

        private void txtNumControl_TextChanged(object sender, EventArgs e)
        {
            string numeroControl = txtNumControl.Text.Trim();

            // Verificar si el número de control tiene entre 8 y 11 caracteres
            if (numeroControl.Length >= 8 && numeroControl.Length <= 11)
            {
                BuscarAlumno(numeroControl);
            }
            else
            {
                // Limpiar campos si no se cumple la longitud requerida
                LimpiarCamposDatosAlumno();
            }
        }

        private void BuscarAlumno(string numeroControl)
        {
            if (tabControl.SelectedTab == tabPageAlumno)
            {
                try
                {
                    ConexionBD conexion = new ConexionBD();
                    Alumno alumno = conexion.ObtenerAlumno(numeroControl);


                    if (alumno != null)
                    {
                        lblNombreAlumno.Text = alumno.nombre_alumno;
                        lblApellidoPatAlumno.Text = alumno.apellido_paterno;
                        lblApellidoMatAlumno.Text = alumno.apellido_materno;
                        lblSexoAlumno.Text = alumno.sexo;
                        lblSemestreAlumno.Text = alumno.semestre.ToString();
                        dtpFechaNaciAlumno.Value = alumno.fecha_nacimiento;
                        lblNombreCarreraAlumno.Text = alumno.nombre_carrera;
                        lblidCarreraAlumno.Text = alumno.id_carrera.ToString();
                    }
                    else
                    {
                        //MessageBox.Show("No se encontró un alumno con ese número de control.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCamposDatosAlumno();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el alumno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCamposDatosAlumno()
        {
            lblNombreAlumno.Text = string.Empty;
            lblApellidoPatAlumno.Text = string.Empty;
            lblApellidoMatAlumno.Text = string.Empty;
            lblNombreCarreraAlumno.Text = string.Empty;
            lblidCarreraAlumno.Text = string.Empty;
            lblSemestreAlumno.Text = string.Empty;
            lblSexoAlumno.Text = string.Empty;
            dtpFechaNaciAlumno.Value = DateTime.Today;
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageAlumno)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtNumControl.Text.Trim()) ||
                        string.IsNullOrEmpty(lblNombreAlumno.Text.Trim()) ||
                        string.IsNullOrEmpty(lblApellidoPatAlumno.Text.Trim()) ||
                        string.IsNullOrEmpty(lblApellidoMatAlumno.Text.Trim()) ||
                        string.IsNullOrEmpty(lblSexoAlumno.Text.Trim()) ||
                        cmbNumPersonasAlumno.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, completa todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    RegistroCubiculoAlumnos registro = new RegistroCubiculoAlumnos
                    {
                        numero_control = txtNumControl.Text.Trim(),
                        nombre_alumno = lblNombreAlumno.Text.Trim(),
                        apellido_paterno = lblApellidoPatAlumno.Text.Trim(),
                        apellido_materno = lblApellidoMatAlumno.Text.Trim(),
                        sexo = lblSexoAlumno.Text.Trim(),
                        semestre = lblSemestreAlumno.Text.Trim(),
                        id_carrera = lblidCarreraAlumno.Text.Trim(),
                        fecha_nacimiento = dtpFechaNaciAlumno.Value,
                        numero_cubiculo = numeroCubiculo.ToString(),
                        numero_personas = cmbNumPersonasAlumno.SelectedItem.ToString(),
                        hora_entrada = DateTime.Now
                    };

                    ConexionBD conexion = new ConexionBD();
                    conexion.RegistrarAlumno(registro);

                    MessageBox.Show("Registro realizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    menuCubiculosForm.ActualizarBotonCubiculo(numeroCubiculo);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el alumno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =======================
        // Código para pestaña Docente
        // =======================

        private void txtNoTarjeta_TextChanged(object sender, EventArgs e)
        {
            string noTarjeta = txtNoTarjeta.Text.Trim();

            if (!string.IsNullOrEmpty(noTarjeta))
            {
                BuscarDocente(noTarjeta);
            }
            else
            {
                LimpiarCamposDatosDocente();
            }
        }

        private void BuscarDocente(string noTarjeta)
        {
            if (tabControl.SelectedTab == tabPagePersonal)
            {
                try
                {
                    ConexionBD conexion = new ConexionBD();
                    Personal_Activo docente = conexion.ObtenerPersonalActivo(noTarjeta);

                    if (docente != null)
                    {
                        lblNombreDocente.Text = docente.nombre_empleado;
                        lblApellidosDocente.Text = docente.apellidos_empleado;
                        lblAreaDocente.Text = docente.descripcion_area;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un docente con ese número de tarjeta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCamposDatosDocente();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al buscar el docente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCamposDatosDocente()
        {
            lblNombreDocente.Text = string.Empty;
            lblApellidosDocente.Text = string.Empty;
            lblAreaDocente.Text = string.Empty;
        }

        private void btnRegistrarDocente_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPagePersonal)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtNoTarjeta.Text.Trim()) ||
                        string.IsNullOrEmpty(lblNombreDocente.Text.Trim()) ||
                        string.IsNullOrEmpty(lblApellidosDocente.Text.Trim()) ||
                        string.IsNullOrEmpty(lblAreaDocente.Text.Trim()) ||
                        cmbNumPersonasDocente.SelectedItem == null)
                    {
                        //MessageBox.Show("Por favor, completa todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    RegistroCubiculoPersonal registro = new RegistroCubiculoPersonal
                    {
                        no_tarjeta = txtNoTarjeta.Text.Trim(),
                        nombre_personal = lblNombreDocente.Text.Trim(),
                        apellidos_personal = lblApellidosDocente.Text.Trim(),
                        descripcion_area = lblAreaDocente.Text.Trim(),
                        numero_cubiculo = numeroCubiculo.ToString(),
                        numero_personas = cmbNumPersonasDocente.SelectedItem.ToString(),
                        hora_entrada = DateTime.Now
                    };

                    ConexionBD conexion = new ConexionBD();
                    conexion.RegistrarPersonal(registro);

                    MessageBox.Show("Registro realizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    menuCubiculosForm.ActualizarBotonCubiculo(numeroCubiculo);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar al docente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegistrarExterno_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageExternos)
            {
                try
                {
                    // Validar que los campos requeridos no estén vacíos
                    if (string.IsNullOrEmpty(txtNombreExterno.Text.Trim()) ||
                        string.IsNullOrEmpty(txtApellidoPatExt.Text.Trim()) ||
                        string.IsNullOrEmpty(txtApellidoMatExt.Text.Trim()) ||
                        cmbNumPersonasExterno.SelectedItem == null)
                    {
                        //MessageBox.Show("Por favor, completa todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    RegistroCubiculoExternos registro = new RegistroCubiculoExternos
                    {
                        nombre = txtNombreExterno.Text.Trim(),
                        apellido_paterno = txtApellidoPatExt.Text.Trim(),
                        apellido_materno = txtApellidoMatExt.Text.Trim(),
                        numero_cubiculo = numeroCubiculo.ToString(),
                        numero_personas = cmbNumPersonasExterno.SelectedItem.ToString(),
                        hora_entrada = DateTime.Now
                    };

                    ConexionBD conexion = new ConexionBD();
                    conexion.RegistrarExterno(registro);

                    MessageBox.Show("Registro de externo realizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    menuCubiculosForm.ActualizarBotonCubiculo(numeroCubiculo);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar al externo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}