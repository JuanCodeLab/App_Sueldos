using System;
using System.Data;
using System.Data.SqlClient;

namespace AppSueldos
{
    public class Empleados
    {
        #region Getters
        public DataTable Listar()
        {
            SqlDataReader rdr;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                string sql = "SELECT * FROM Empleado";
                conn = Conexion.CrearInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public DataTable BuscarEmpleados(string valorBuscado)
        {
            SqlDataReader rdr;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                string sql = "SELECT * FROM Empleado WHERE Nombre LIKE @valorBuscado OR Apellido LIKE @valorBuscado OR Rut LIKE @valorBuscado";
                conn = Conexion.CrearInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@valorBuscado", "%" + valorBuscado + "%"); // Búsqueda parcial basada en Nombre o Apellido
                conn.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        #endregion
        #region Setters
        public string EliminarEmpleado(string rutEmpleado)
        {
            string respuesta = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                string sql = "DELETE FROM Empleado WHERE Rut = @rutEmpleado";
                conn = Conexion.CrearInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@rutEmpleado", rutEmpleado);
                conn.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR DE INGRESO DE DATOS";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return respuesta;
        }

        public string InsertarEmpleado(Empleado obj)
        {
            string respuesta = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                string sql = "INSERT INTO Empleado " +
                    "(Rut, Nombre, Apellido, Direccion, Telefono, Email, ValorHora, ValorExtra) VALUES(" +
                    "'" + obj.RUT +         "'," +
                    "'" + obj.NOMBRE +      "'," +
                    "'" + obj.APELLIDO +    "'," +
                    "'" + obj.DIRECCION +   "'," +
                    "'" + obj.TELEFONO +    "'," +
                    "'" + obj.EMAIL +       "'," +
                    "'" + obj.VALOR_HORA +  "'," +
                    "'" + obj.VALOR_EXTRA + "')";
                conn = Conexion.CrearInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR DE INGRESO DE DATOS";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return respuesta;
        }

        public string ActualizarEmpleado(string rutEmpleado, string SueldoLiquido, string SueldoBruto)
        {
            string respuesta = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                string consulta = "UPDATE Empleado SET SueldoLiquido = @SueldoLiquido, SueldoBruto = @SueldoBruto WHERE Rut = @rutEmpleado";
                conn = Conexion.CrearInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand(consulta, conn);

                cmd.Parameters.AddWithValue("@RutEmpleado", rutEmpleado);
                cmd.Parameters.AddWithValue("@SueldoLiquido", SueldoLiquido);
                cmd.Parameters.AddWithValue("@SueldoBruto", SueldoBruto);

                conn.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR DE INGRESO DE DATOS";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return respuesta;
        }
        #endregion
    }
}
