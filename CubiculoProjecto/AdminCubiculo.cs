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

namespace CubiculoProjecto
{
    public partial class AdminCubiculo : Form
    {
        private ConexionBD conexionBD = new ConexionBD();

        public AdminCubiculo()
        {
            InitializeComponent();

            // Inicializa el ComboBox con las opciones de reporte
            cmbTipoReporte.Items.Add("Día");
            cmbTipoReporte.Items.Add("Semana");
            cmbTipoReporte.Items.Add("Mes");
            cmbTipoReporte.SelectedIndex = 0; // Selecciona "Día" por defecto
        }

        private void btnExportarReporte_Click(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada
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
                default:
                    MessageBox.Show("Selecciona un tipo de reporte válido.");
                    return;
            }

            // Obtener los datos de las tablas dentro del rango de fechas
            DataTable dtAlumnos = conexionBD.ObtenerRegistrosAlumnosPorFecha(fechaInicio, fechaFin);
            DataTable dtPersonal = conexionBD.ObtenerRegistrosPersonalPorFecha(fechaInicio, fechaFin);
            DataTable dtExternos = conexionBD.ObtenerRegistrosExternosPorFecha(fechaInicio, fechaFin);

            // Exportar los datos a Excel
            ExportarDatosAExcel(dtAlumnos, dtPersonal, dtExternos);
        }

        private void ExportarDatosAExcel(DataTable dtAlumnos, DataTable dtPersonal, DataTable dtExternos)
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    // Añadir hojas al libro
                    workbook.Worksheets.Add(dtAlumnos, "Registros Alumnos");
                    workbook.Worksheets.Add(dtPersonal, "Registros Personal");
                    workbook.Worksheets.Add(dtExternos, "Registros Externos");

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
    }
}
