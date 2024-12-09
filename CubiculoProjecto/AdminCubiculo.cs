using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace CubiculoProyectoNuevo
{
    public partial class AdminCubiculo : Form
    {
        private ConexionBD conexionBD = new ConexionBD();

        public AdminCubiculo()
        {
            InitializeComponent();

            // Inicializa el ComboBox con las opciones de tipo de reporte
            cmbTipoReporte.Items.Add("Día");
            cmbTipoReporte.Items.Add("Semana");
            cmbTipoReporte.Items.Add("Mes");
            cmbTipoReporte.Items.Add("Todo"); 
            cmbTipoReporte.SelectedIndex = 0; // Selecciona "Día" por defecto

            // Inicializa el ComboBox con las opciones de tablas a exportar
            cmbTabla.Items.Add("Alumnos");
            cmbTabla.Items.Add("Personal");
            cmbTabla.Items.Add("Externos");
            cmbTabla.Items.Add("Todas");
            cmbTabla.SelectedIndex = 3; // Selecciona "Todas" por defecto

            btnExportarReporte.Click += btnExportarReporte_Click;

        }


        private void btnExportarReporte_Click(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada (no será relevante si se selecciona "Todo")
            DateTime fechaSeleccionada = dtpFechaReporte.Value.Date;

            // Determinar el rango de fechas según el tipo de reporte
            DateTime fechaInicio;
            DateTime fechaFin;

            switch (cmbTipoReporte.SelectedItem.ToString())
            {
                case "Día":
                    fechaInicio = fechaSeleccionada;
                    fechaFin = fechaSeleccionada.AddDays(1).AddSeconds(-1);
                    break;
                case "Semana":
                    int diaSemana = (int)fechaSeleccionada.DayOfWeek;
                    fechaInicio = fechaSeleccionada.AddDays(-diaSemana + 1); // Asumiendo que la semana empieza el lunes
                    fechaFin = fechaInicio.AddDays(7).AddSeconds(-1);
                    break;
                case "Mes":
                    fechaInicio = new DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, 1);
                    fechaFin = fechaInicio.AddMonths(1).AddSeconds(-1);
                    break;
                case "Todo":
                    fechaInicio = new DateTime(1753, 1, 1); // Fecha mínima válida para SQL Server
                    fechaFin = new DateTime(9999, 12, 31, 23, 59, 59); // Fecha máxima válida para SQL Server
                    break;
                default:
                    MessageBox.Show("Selecciona un tipo de reporte válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Obtener los datos de la tabla seleccionada
            string tablaSeleccionada = cmbTabla.SelectedItem.ToString();
            DataTable dtAlumnos = null;
            DataTable dtPersonal = null;
            DataTable dtExternos = null;

            switch (tablaSeleccionada)
            {
                case "Alumnos":
                    dtAlumnos = conexionBD.ObtenerRegistrosAlumnosPorFecha(fechaInicio, fechaFin);
                    break;
                case "Personal":
                    dtPersonal = conexionBD.ObtenerRegistrosPersonalPorFecha(fechaInicio, fechaFin);
                    break;
                case "Externos":
                    dtExternos = conexionBD.ObtenerRegistrosExternosPorFecha(fechaInicio, fechaFin);
                    break;
                case "Todas":
                    dtAlumnos = conexionBD.ObtenerRegistrosAlumnosPorFecha(fechaInicio, fechaFin);
                    dtPersonal = conexionBD.ObtenerRegistrosPersonalPorFecha(fechaInicio, fechaFin);
                    dtExternos = conexionBD.ObtenerRegistrosExternosPorFecha(fechaInicio, fechaFin);
                    break;
                default:
                    MessageBox.Show("Selecciona una tabla válida para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Exportar los datos a Excel
            ExportarDatosAExcel(dtAlumnos, dtPersonal, dtExternos);
        }

        private void ExportarDatosAExcel(DataTable dtAlumnos, DataTable dtPersonal, DataTable dtExternos)
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    // Añadir hojas al libro según las tablas disponibles
                    if (dtAlumnos != null && dtAlumnos.Rows.Count > 0)
                    {
                        workbook.Worksheets.Add(dtAlumnos, "Registros Alumnos");
                    }

                    if (dtPersonal != null && dtPersonal.Rows.Count > 0)
                    {
                        workbook.Worksheets.Add(dtPersonal, "Registros Personal");
                    }

                    if (dtExternos != null && dtExternos.Rows.Count > 0)
                    {
                        workbook.Worksheets.Add(dtExternos, "Registros Externos");
                    }

                    if (workbook.Worksheets.Count == 0)
                    {
                        MessageBox.Show("No hay datos para exportar en el rango de fechas seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Guardar el archivo Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Reporte_Cubiculos.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Reporte generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReAlumnos_Click(object sender, EventArgs e)
        {
            // Mostrar MessageBox de advertencia
            var result = MessageBox.Show("¿Está seguro de que desea reiniciar los registros de alumnos? Esta acción no se puede deshacer.",
                                         "Advertencia",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            // Si el usuario confirma, ejecutar el query SQL
            if (result == DialogResult.Yes)
            {
                try
                {
                    ConexionBD conexion = new ConexionBD();
                    using (var conn = conexion.CreateConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Registros_Alumnos; DBCC CHECKIDENT ('Registros_Alumnos', RESEED, 0);";
                        using (var command = new SqlCommand(query, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Los registros de alumnos han sido reiniciados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al reiniciar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRePersonal_Click(object sender, EventArgs e)
        {
            // Mostrar MessageBox de advertencia
            var result = MessageBox.Show("¿Está seguro de que desea reiniciar los registros del personal? Esta acción no se puede deshacer.",
                                         "Advertencia",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            // Si el usuario confirma, ejecutar el query SQL
            if (result == DialogResult.Yes)
            {
                try
                {
                    ConexionBD conexion = new ConexionBD();
                    using (var conn = conexion.CreateConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Registros_Personal; DBCC CHECKIDENT ('Registros_Personal', RESEED, 0);";
                        using (var command = new SqlCommand(query, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Los registros del personal han sido reiniciados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al reiniciar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReExternos_Click(object sender, EventArgs e)
        {
            // Mostrar MessageBox de advertencia
            var result = MessageBox.Show("¿Está seguro de que desea reiniciar los registros de usuarios externos? Esta acción no se puede deshacer.",
                                         "Advertencia",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            // Si el usuario confirma, ejecutar el query SQL
            if (result == DialogResult.Yes)
            {
                try
                {
                    ConexionBD conexion = new ConexionBD();
                    using (var conn = conexion.CreateConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Registros_Externos; DBCC CHECKIDENT ('Registros_Externos', RESEED, 0);";
                        using (var command = new SqlCommand(query, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Los registros de los Externos han sido reiniciados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al reiniciar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtNuevoUsuario.Text.Trim();
            string nuevaContraseña = txtContraseñaNuevoUsuario.Text.Trim();

            if (string.IsNullOrEmpty(nuevoUsuario) || string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conexionBD.AgregarAdministrador(nuevoUsuario, nuevaContraseña);
                MessageBox.Show("Administrador agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de texto
                txtNuevoUsuario.Clear();
                txtContraseñaNuevoUsuario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el administrador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioACambiar.Text.Trim();
            string contraExistente = txtContraExistente.Text.Trim();
            string contraNueva = txtContraCambiada.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraExistente) || string.IsNullOrEmpty(contraNueva))
            {
                MessageBox.Show("Por favor, complete todos los campos para cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Verificar las credenciales existentes
                bool credencialesValidas = conexionBD.VerificarCredencialesAdministrador(usuario, contraExistente);
                if (!credencialesValidas)
                {
                    MessageBox.Show("Nombre de usuario o contraseña existente incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cambiar la contraseña
                conexionBD.CambiarContraseñaAdministrador(usuario, contraNueva);
                MessageBox.Show("Contraseña actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de texto
                txtUsuarioACambiar.Clear();
                txtContraExistente.Clear();
                txtContraCambiada.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
