using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CapaDeAccesoDatos
{
  public class Conexion
    {
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Password;
        private string BaseDeDatos;
        private static Conexion Con = null;
        public Conexion()
        {
            this.Servidor = "localhost";
            this.Puerto = "5432";
            this.Usuario = "postgres";
            //this.Password = "1234";
            //this.BaseDeDatos = "postgres";
            this.Password = "432156";
            this.BaseDeDatos = "postgres2";

        }
        public NpgsqlConnection CrearConexion()
        {
            NpgsqlConnection cadena = new NpgsqlConnection();
            try
            {
                cadena.ConnectionString = $"host={this.Servidor};" +
                                         $"port={this.Puerto};" +
                                         $"username={this.Usuario};" +
                                         $"password={this.Password};" +
                                         $"Database={this.BaseDeDatos};";
            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
               
        }
        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
