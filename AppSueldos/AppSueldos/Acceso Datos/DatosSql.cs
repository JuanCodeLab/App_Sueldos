using System;
using System.Data.SqlClient;

namespace AppSueldos
{
    class DatosSql
    {
        private Conexion conexion;

        public DatosSql()
        {
            conexion = Conexion.CrearInstancia(); // Llamamos a la instancia que genera nuestra Conexion
        }

        #region Getters
        public bool IniciarSesion(string nombreUsuario, string contrasena) // Generamos el metodo Iniciar Sesion
        {
            try // Usamos el metodo try, catch para identificar errores.
            {
                using (SqlConnection conn = conexion.CrearConexion())
                {
                    conn.Open(); // Iniciamos la conexion con el Servidor BD

                    string consulta = "SELECT COUNT(*) FROM Usuario WHERE Username = @nombreUsuario AND Pass = @contrasena";

                    using (SqlCommand comando = new SqlCommand(consulta, conn))
                    {
                        // Especificamos los parametros de nombreUsuario y contrasena en nuestra BD en base a lo escrito por el usuario.
                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@contrasena", contrasena);

                        int resultado = (int)comando.ExecuteScalar();

                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al iniciar sesión: " + ex.Message);
                return false;
            }
        }

        public string ObtenerTipoUsuario(string nombreUsuario, string contrasena) // Generamos el metodo Iniciar Sesion
        {
            try // Usamos el metodo try, catch para identificar errores.
            {
                using (SqlConnection conn = conexion.CrearConexion())
                {
                    conn.Open(); // Iniciamos la conexion con el Servidor BD

                    string consulta = "SELECT UserType FROM Usuario WHERE Username = @nombreUsuario AND Pass = @contrasena";

                    using (SqlCommand comando = new SqlCommand(consulta, conn))
                    {
                        // Especificamos los parametros de nombreUsuario y contrasena en nuestra BD en base a lo escrito por el usuario.
                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@contrasena", contrasena);

                        string resultado = (string)comando.ExecuteScalar();

                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al iniciar sesión: " + ex.Message);
                return "ERROR";
            }
        }
        #endregion
    }
}
