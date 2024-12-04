using ClosedXML.Excel;
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
    public partial class Menu_Cubiculos : Form
    {
        // Lista para almacenar los botones
        private List<Button> listaBotones;
        private Dictionary<int, Timer> timersCubiculos = new Dictionary<int, Timer>();

        public Menu_Cubiculos()
        {
            InitializeComponent();

            // Inicializar la lista de botones
            listaBotones = new List<Button> { btnCubiculos1, btnCubiculos2, btnCubiculos3, btnCubiculos4, btnCubiculos5, btnCubiculos6, btnCubiculos7, btnCubiculos8 };

            // Establecer el color verde para los botones desocupados
            foreach (var boton in listaBotones)
            {
                boton.BackColor = Color.Green;
            }

            // Asignar eventos a los botones
            for (int i = 0; i < listaBotones.Count; i++)
            {
                int numeroCubiculo = i + 1; // Los cubículos están numerados del 1 al 8
                listaBotones[i].Click += (sender, e) => BotonCubiculo_Click(sender, e, numeroCubiculo);
            }

            // Suscribirse al evento Load del formulario
            this.Load += Menu_Cubiculos_Load;
        }

        private void BotonCubiculo_Click(object sender, EventArgs e, int numeroCubiculo)
        {
            // Crear una instancia de ConexionBD
            ConexionBD conexion = new ConexionBD();

            // Verificar si el cubículo está ocupado por un alumno
            RegistroCubiculoAlumnos registroAlumno = conexion.ObtenerRegistroActivoPorCubiculo(numeroCubiculo);

            if (registroAlumno != null)
            {
                // Si el cubículo está ocupado por un alumno, abrir Pedir_Salida_Cubiculo_Alumno
                Pedir_Salida_Cubiculo_Alumno salidaAlumnoForm = new Pedir_Salida_Cubiculo_Alumno(numeroCubiculo, this);
                salidaAlumnoForm.Show();
            }
            else
            {
                // Verificar si el cubículo está ocupado por un docente
                RegistroCubiculoPersonal registroDocente = conexion.ObtenerRegistroActivoPorCubiculoPersonal(numeroCubiculo);

                if (registroDocente != null)
                {
                    // Si el cubículo está ocupado por un docente, abrir Pedir_Salida_Cubiculo_Docente
                    Pedir_Salida_Cubiculo_Docente salidaDocenteForm = new Pedir_Salida_Cubiculo_Docente(numeroCubiculo, this);
                    salidaDocenteForm.Show();
                }
                else
                {
                    // Si el cubículo está libre, abrir Pedir_Cubiculo
                    Pedir_Cubiculo pedirCubiculoForm = new Pedir_Cubiculo(numeroCubiculo, this);
                    pedirCubiculoForm.Show();
                }
            }
        }

        // Método para actualizar el botón, cambiar color y agregar temporizador
        public void ActualizarBotonCubiculo(int numeroCubiculo)
        {
            // Cambiar el color del botón a rojo
            Button boton = listaBotones[numeroCubiculo - 1];
            boton.BackColor = Color.Red;

            // Iniciar un temporizador para contar el tiempo
            Timer timer = new Timer();
            timer.Interval = 1000; // Actualizar cada segundo
            DateTime horaFinal = DateTime.Now.AddSeconds(10);

            timer.Tick += (s, args) =>
            {
                TimeSpan tiempoRestante = horaFinal - DateTime.Now;
                if (tiempoRestante.TotalSeconds > 0)
                {
                    boton.Text = $"Cubículo {numeroCubiculo}\n{tiempoRestante:hh\\:mm\\:ss}";
                }
                else
                {
                    // Tiempo completado
                    timer.Stop();
                    LiberarCubiculo(numeroCubiculo);
                }
            };

            timer.Start();

            // Almacenar el temporizador en el diccionario
            timersCubiculos[numeroCubiculo] = timer;
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            // Llamar al método para exportar datos
            ExportarDatosAExcel();
        }

        private void ExportarDatosAExcel()
        {
            try
            {
                // Crear una instancia de ConexionBD y obtener los datos
                ConexionBD conexion = new ConexionBD();
                DataTable datos = conexion.ObtenerRegistrosAlumnos();

                if (datos.Rows.Count > 0)
                {
                    // Crear un libro de Excel
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        // Añadir una hoja con el nombre "Registros"
                        var hoja = workbook.Worksheets.Add(datos, "Registros");

                        // Guardar el archivo en una ruta especificada
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
                        saveFileDialog.FileName = "Registros_Alumnos.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LiberarCubiculo(int numeroCubiculo)
        {
            ConexionBD conexion = new ConexionBD();

            // Intentar obtener registro de alumno
            RegistroCubiculoAlumnos registroAlumno = conexion.ObtenerRegistroActivoPorCubiculo(numeroCubiculo);
            if (registroAlumno != null)
            {
                conexion.ActualizarHoraSalidaAlumnos(int.Parse(registroAlumno.num_prestamo));
            }
            else
            {
                // Intentar obtener registro de docente
                RegistroCubiculoPersonal registroDocente = conexion.ObtenerRegistroActivoPorCubiculoPersonal(numeroCubiculo);
                if (registroDocente != null)
                {
                    conexion.ActualizarHoraSalidaPersonal(int.Parse(registroDocente.num_prestamo));
                }
            }

            // Actualizar UI
            Button boton = listaBotones[numeroCubiculo - 1];
            boton.BackColor = Color.Green; // Cambiar a verde
            boton.Text = $"Cubículo {numeroCubiculo}";

            // Detener y eliminar el temporizador asociado
            if (timersCubiculos.ContainsKey(numeroCubiculo))
            {
                timersCubiculos[numeroCubiculo].Stop();
                timersCubiculos.Remove(numeroCubiculo);
            }
        }
        private void Menu_Cubiculos_Load(object sender, EventArgs e)
        {
            // Verificar el estado de cada cubículo y actualizar el botón
            for (int i = 1; i <= listaBotones.Count; i++)
            {
                ConexionBD conexion = new ConexionBD();
                bool estaOcupado = conexion.CubiculoEstaOcupado(i);

                if (estaOcupado)
                {
                    // Si el cubículo está ocupado, actualizar el botón a rojo
                    ActualizarBotonCubiculo(i);
                }
                else
                {
                    // Si está desocupado, asegurarse de que el botón esté en verde
                    Button boton = listaBotones[i - 1];
                    boton.BackColor = Color.Green;
                    boton.Text = $"Cubículo {i}";
                }
            }
        }
    }
}
