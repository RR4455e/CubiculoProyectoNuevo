using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Security.Cryptography;

namespace CubiculoProyectoNuevo
{
    public class ConexionBD
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionCubiculos"].ConnectionString;
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
        //Obtiene los datos de los alumnos
        public Alumno ObtenerAlumno(string numero_control)
        {
            const string query = @"
                SELECT a.nombre_alumno, a.apellido_paterno, a.apellido_materno, a.id_carrera, a.sexo, a.fecha_nacimiento, a.semestre, c.nombre_carrera
                FROM Alumnos a
                JOIN Carrera c ON a.id_carrera = c.id_carrera
                WHERE a.numero_control = @numero_control;";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@numero_control", numero_control));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Alumno
                            {
                                nombre_alumno = reader.GetString(0),
                                apellido_paterno = reader.GetString(1),
                                apellido_materno = reader.GetString(2),
                                id_carrera = reader.GetInt32(3),
                                sexo = reader.GetString(4),
                                fecha_nacimiento = reader.GetDateTime(5),
                                semestre = reader.GetInt32(6),
                                nombre_carrera = reader.GetString(7)
                            };
                        }
                        else
                        {
                            //Si no encuentra informacion, devuelve null;
                            return null;
                        }

                    }
                }
            }
        }

        //Registra la entrada de los alumnos
        public void RegistrarAlumno(RegistroCubiculoAlumnos registro)
        {
            const string query = "INSERT INTO Registros_Alumnos (numero_control, numero_cubiculo, hora_entrada, numero_personas) " +
                                 "VALUES (@numero_control, @numero_cubiculo, @hora_entrada, @numero_personas)";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@numero_control", registro.numero_control));
                    command.Parameters.Add(new SqlParameter("@numero_cubiculo", registro.numero_cubiculo));
                    command.Parameters.Add(new SqlParameter("@hora_entrada", registro.hora_entrada));
                    command.Parameters.Add(new SqlParameter("@numero_personas", registro.numero_personas));

                    command.ExecuteNonQuery();
                }
            }
        }
        //Registra la hora de salida de los alumnos
        public void ActualizarHoraSalidaAlumnos(int numPrestamo)
        {
            const string query = "UPDATE Registros_Alumnos SET hora_salida = @hora_salida WHERE num_prestamo = @num_prestamo";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@hora_salida", DateTime.Now));
                    command.Parameters.Add(new SqlParameter("@num_prestamo", numPrestamo));

                    command.ExecuteNonQuery();
                }
            }
        }
        // Obtiene los datos del personal activo
        public Personal_Activo ObtenerPersonalActivo(string no_tarjeta)
        {
            const string query = @"
                SELECT descripcion_area, no_tarjeta, apellidos_empleado, nombre_empleado
                FROM Personal_activo
                WHERE no_tarjeta = @no_tarjeta;";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@no_tarjeta", no_tarjeta));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Personal_Activo
                            {
                                descripcion_area = reader.GetString(0),
                                no_tarjeta = reader.GetString(1),
                                apellidos_empleado = reader.GetString(2),
                                nombre_empleado = reader.GetString(3)
                            };
                        }
                        else
                        {
                            // Si no se encuentra informacion, devuelve null
                            return null;
                        }
                    }
                }
            }
        }
                    // Registra la entrada del personal
        public void RegistrarPersonal(RegistroCubiculoPersonal registro)
        {
            const string query = "INSERT INTO Registros_Personal (no_tarjeta, numero_cubiculo, hora_entrada, numero_personas) " +
                                 "VALUES (@no_tarjeta, @numero_cubiculo, @hora_entrada, @numero_personas)";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@no_tarjeta", registro.no_tarjeta));
                    command.Parameters.Add(new SqlParameter("@numero_cubiculo", registro.numero_cubiculo));
                    command.Parameters.Add(new SqlParameter("@hora_entrada", registro.hora_entrada));
                    command.Parameters.Add(new SqlParameter("@numero_personas", registro.numero_personas));

                    command.ExecuteNonQuery();
                }
            }
        }
        //Registra la hora de salida del personal
        public void ActualizarHoraSalidaPersonal(int numPrestamo)
        {
            const string query = "UPDATE Registros_Personal SET hora_salida = @hora_salida WHERE num_prestamo = @num_prestamo";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@hora_salida", DateTime.Now));
                    command.Parameters.Add(new SqlParameter("@num_prestamo", numPrestamo));

                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable ObtenerRegistrosAlumnos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consulta = "SELECT * FROM Registros_Alumnos";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        conexion.Open();
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepción si es necesario
                throw ex;
            }

            return tabla;
        }
        public RegistroCubiculoAlumnos ObtenerRegistroAlumnoSinSalida(string numeroControl)
        {
            const string query = @"
                SELECT num_prestamo, numero_control, numero_cubiculo, hora_entrada
                FROM Registros_Alumnos
                WHERE numero_control = @numero_control AND hora_salida IS NULL";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@numero_control", numeroControl));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RegistroCubiculoAlumnos
                            {
                                num_prestamo = reader["num_prestamo"].ToString(),
                                numero_control = reader["numero_control"].ToString(),
                                numero_cubiculo = reader["numero_cubiculo"].ToString(),
                                hora_entrada = Convert.ToDateTime(reader["hora_entrada"])
                            };
                        }
                        else
                        {
                            // No hay registros activos para el alumno
                            return null;
                        }
                    }
                }
            }
        }
        public bool CubiculoEstaOcupado(int numeroCubiculo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT COUNT(*) FROM (
                            SELECT numero_cubiculo FROM Registros_Alumnos WHERE numero_cubiculo = @NumeroCubiculo AND hora_salida IS NULL
                            UNION
                            SELECT numero_cubiculo FROM Registros_Personal WHERE numero_cubiculo = @NumeroCubiculo AND hora_salida IS NULL
                            UNION
                            SELECT numero_cubiculo FROM Registros_Externos WHERE numero_cubiculo = @NumeroCubiculo AND hora_salida IS NULL
                        ) AS ocupados";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NumeroCubiculo", numeroCubiculo.ToString());

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar si el cubículo está ocupado: " + ex.Message);
            }
        }
        public RegistroCubiculoAlumnos ObtenerRegistroActivoPorCubiculo(int numeroCubiculo)
        {
            const string query = @"
                SELECT num_prestamo, numero_control, numero_cubiculo, hora_entrada
                FROM Registros_Alumnos
                WHERE numero_cubiculo = @numero_cubiculo AND hora_salida IS NULL";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@numero_cubiculo", numeroCubiculo.ToString()));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RegistroCubiculoAlumnos
                            {
                                num_prestamo = reader["num_prestamo"].ToString(),
                                numero_control = reader["numero_control"].ToString(),
                                numero_cubiculo = reader["numero_cubiculo"].ToString(),
                                hora_entrada = Convert.ToDateTime(reader["hora_entrada"])
                            };
                        }
                        else
                        {
                            // No hay registros activos para el cubículo
                            return null;
                        }
                    }
                }
            }
        }
        public RegistroCubiculoPersonal ObtenerRegistroActivoPorCubiculoPersonal(int numeroCubiculo)
        {
            const string query = @"
                SELECT num_prestamo, no_tarjeta, numero_cubiculo, hora_entrada
                FROM Registros_Personal
                WHERE numero_cubiculo = @numero_cubiculo AND hora_salida IS NULL";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@numero_cubiculo", numeroCubiculo.ToString()));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RegistroCubiculoPersonal
                            {
                                num_prestamo = reader["num_prestamo"].ToString(),
                                no_tarjeta = reader["no_tarjeta"].ToString(),
                                numero_cubiculo = reader["numero_cubiculo"].ToString(),
                                hora_entrada = Convert.ToDateTime(reader["hora_entrada"])
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public RegistroCubiculoPersonal ObtenerRegistroActivoPorCubiculoYTarjeta(int numeroCubiculo, string noTarjeta)
        {
            const string query = @"
                SELECT num_prestamo, no_tarjeta, numero_cubiculo, hora_entrada
                FROM Registros_Personal
                WHERE numero_cubiculo = @numero_cubiculo AND no_tarjeta = @no_tarjeta AND hora_salida IS NULL";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@numero_cubiculo", numeroCubiculo.ToString()));
                    command.Parameters.Add(new SqlParameter("@no_tarjeta", noTarjeta));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RegistroCubiculoPersonal
                            {
                                num_prestamo = reader["num_prestamo"].ToString(),
                                no_tarjeta = reader["no_tarjeta"].ToString(),
                                numero_cubiculo = reader["numero_cubiculo"].ToString(),
                                hora_entrada = Convert.ToDateTime(reader["hora_entrada"])
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }        public void RegistrarExterno(RegistroCubiculoExternos registro)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Registros_Externos (nombre, apellido_paterno, apellido_materno, numero_cubiculo, numero_personas, hora_entrada) VALUES (@nombre, @apellido_paterno, @apellido_materno, @cubiculo, @personas, @horaentrada)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nombre", registro.nombre);
                    command.Parameters.AddWithValue("@apellido_paterno", registro.apellido_paterno);
                    command.Parameters.AddWithValue("@apellido_materno", registro.apellido_materno);
                    command.Parameters.AddWithValue("@cubiculo", registro.numero_cubiculo);
                    command.Parameters.AddWithValue("@personas", registro.numero_personas);
                    command.Parameters.AddWithValue("@horaentrada", registro.hora_entrada);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar al externo: " + ex.Message);
            }
        }
        public RegistroCubiculoExternos ObtenerRegistroActivoPorCubiculoExterno(int numeroCubiculo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 1 * FROM Registros_Externos WHERE numero_cubiculo = @NumeroCubiculo AND hora_salida IS NULL ORDER BY hora_entrada DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NumeroCubiculo", numeroCubiculo.ToString());

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        RegistroCubiculoExternos registro = new RegistroCubiculoExternos
                        {
                            num_prestamo = reader["num_prestamo"].ToString(),
                            nombre = reader["nombre"].ToString(),
                            apellido_paterno = reader["apellido_paterno"].ToString(),
                            apellido_materno = reader["apellido_materno"].ToString(),
                            numero_cubiculo = reader["numero_cubiculo"].ToString(),
                            numero_personas = reader["numero_personas"].ToString(),
                            hora_entrada = DateTime.Parse(reader["hora_entrada"].ToString())
                        };
                        return registro;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el registro activo del usuario externo: " + ex.Message);
            }
        }
        public void ActualizarHoraSalidaExterno(int numPrestamo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Registros_Externos SET hora_salida = @HoraSalida WHERE num_prestamo = @NumPrestamo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@HoraSalida", DateTime.Now);
                    command.Parameters.AddWithValue("@NumPrestamo", numPrestamo);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la hora de salida del usuario externo: " + ex.Message);
            }
        }

        public DataTable ObtenerRegistrosAlumnosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = CreateConnection())
            {
                string consulta = @"
                    SELECT ra.*, 
                           a.nombre_alumno, a.apellido_paterno, a.apellido_materno, 
                           a.semestre, a.id_carrera, a.fecha_nacimiento, a.sexo,
                           c.nombre_carrera
                    FROM Registros_Alumnos ra
                    JOIN Alumnos a ON ra.numero_control = a.numero_control
                    JOIN Carrera c ON a.id_carrera = c.id_carrera
                    WHERE ra.hora_entrada BETWEEN @fechaInicio AND @fechaFin";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", fechaFin);
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable ObtenerRegistrosPersonalPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = CreateConnection())
            {
                string consulta = @"
                    SELECT rp.*, pa.nombre_empleado, pa.apellidos_empleado, pa.descripcion_area
                    FROM Registros_Personal rp
                    JOIN Personal_activo pa ON rp.no_tarjeta = pa.no_tarjeta
                    WHERE rp.hora_entrada BETWEEN @fechaInicio AND @fechaFin";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", fechaFin);
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable ObtenerRegistrosExternosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = CreateConnection())
            {
                string consulta = "SELECT * FROM Registros_Externos WHERE hora_entrada BETWEEN @fechaInicio AND @fechaFin";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", fechaFin);
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
        public bool VerificarCredencialesAdministrador(string nombreUsuario, string contraseña)
        {
            const string query = @"
            SELECT COUNT(*)
            FROM Administradores
            WHERE nombre_usuario = @nombre_usuario AND contraseña_usuario = @contraseña_usuario";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@nombre_usuario", nombreUsuario));
                    command.Parameters.Add(new SqlParameter("@contraseña_usuario", HashContraseña(contraseña)));

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public void AgregarAdministrador(string nombreUsuario, string contraseña)
        {
            const string query = @"
                INSERT INTO Administradores (nombre_usuario, contraseña_usuario)
                VALUES (@nombre_usuario, @contraseña_usuario)";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@nombre_usuario", nombreUsuario));
                    command.Parameters.Add(new SqlParameter("@contraseña_usuario", HashContraseña(contraseña)));

                    command.ExecuteNonQuery();
                }
            }
        }
        public void CambiarContraseñaAdministrador(string nombreUsuario, string nuevaContraseña)
        {
            const string query = @"
                UPDATE Administradores
                SET contraseña_usuario = @nueva_contraseña
                WHERE nombre_usuario = @nombre_usuario";

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@nombre_usuario", nombreUsuario));
                    command.Parameters.Add(new SqlParameter("@nueva_contraseña", HashContraseña(nuevaContraseña)));

                    command.ExecuteNonQuery();
                }
            }
        }
        private string HashContraseña(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void InsertarAlumnosDesdeDataTable(DataTable dtAlumnos)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in dtAlumnos.Rows)
                {
                    // Crear el comando para insertar un registro
                    SqlCommand command = new SqlCommand("INSERT INTO Alumnos (numero_control, nombre_alumno, apellido_paterno, apellido_materno, id_carrera, sexo, semestre, fecha_nacimiento, estatus_alumno, correo_electronico) VALUES (@numero_control, @nombre_alumno, @apellido_paterno, @apellido_materno, @id_carrera, @sexo, @semestre, @fecha_nacimiento, @estatus_alumno, @correo_electronico)", connection);

                    // Asignar los parámetros (ajusta los nombres de columnas según tu base de datos)
                    command.Parameters.AddWithValue("@numero_control", row["numero_control"]);
                    command.Parameters.AddWithValue("@nombre_alumno", row["nombre_alumno"]);
                    command.Parameters.AddWithValue("@apellido_paterno", row["apellido_paterno"]);
                    command.Parameters.AddWithValue("@apellido_materno", row["apellido_materno"]);
                    command.Parameters.AddWithValue("@id_carrera", row["id_carrera"]);
                    command.Parameters.AddWithValue("@sexo", row["sexo"]);
                    command.Parameters.AddWithValue("@semestre", row["semestre"]);
                    command.Parameters.AddWithValue("@estatus_alumno", row["estatus_alumno"]);
                    command.Parameters.AddWithValue("@correo_electronico", row["correo_electronico"]);
                    command.Parameters.AddWithValue("@fecha_nacimiento", DateTime.Parse(row["fecha_nacimiento"].ToString()));

                    // Ejecutar el comando
                    command.ExecuteNonQuery();
                }
            }
        }
        public void InsertarPersonalDesdeDataTable(DataTable dtPersonal)
        {
            using (SqlConnection connection = CreateConnection())
            {
                connection.Open();

                foreach (DataRow row in dtPersonal.Rows)
                {
                    // Crear el comando para insertar un registro
                    SqlCommand command = new SqlCommand("INSERT INTO Personal_activo (no_tarjeta, apellidos_empleado, nombre_empleado, descripcion_area) VALUES (@no_tarjeta, @apellidos_empleado, @nombre_empleado, @descripcion_area)", connection);

                    // Asignar los parámetros (ajusta los nombres de columnas según tu base de datos)
                    command.Parameters.AddWithValue("@no_tarjeta", row["no_tarjeta"]);
                    command.Parameters.AddWithValue("@apellidos_empleado", row["apellidos_empleado"]);
                    command.Parameters.AddWithValue("@nombre_empleado", row["nombre_empleado"]);
                    command.Parameters.AddWithValue("@descripcion_area", row["descripcion_area"]);

                    // Ejecutar el comando
                    command.ExecuteNonQuery();
                }
            }
        }
        public void InsertarCarrerasDesdeDataTable(DataTable dtCarreras)
        {
            using (SqlConnection connection = CreateConnection())
            {
                connection.Open();

                foreach (DataRow row in dtCarreras.Rows)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Carreras (id_carrera, nombre_carrera, nombre_reducido) VALUES (@id_carrera, @nombre_carrera, @nombre_reducido)", connection);

                    command.Parameters.AddWithValue("@id_carrera", row["id_carrera"]);
                    command.Parameters.AddWithValue("@nombre_carrera", row["nombre_carrera"]);
                    command.Parameters.AddWithValue("@nombre_reducido", row["nombre_reducido"]);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
