using System.Data.SqlClient;

namespace AppSueldos
{
    class Conexion
    {

        private string Servidor;
        private string Base;

        private static Conexion conn = null;
        private Conexion()
        {
            this.Servidor = "NOTEBOOK";
            this.Base = "AppSueldosDB";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection conex = new SqlConnection();
            try
            {
                conex.ConnectionString = "Data Source=" + this.Servidor + ";" + "Initial Catalog=" + this.Base + ";" + "Integrated Security=true;";
            }
            catch
            {
                conex = null;
            }
            return conex;
        }

        public static Conexion CrearInstancia()
        {
            if (conn == null)
            {
                conn = new Conexion();
            }
            return conn;
        }
    }
}
