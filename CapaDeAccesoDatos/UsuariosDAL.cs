using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CapaDeAccesoDatos
{
    public class UsuariosDAL
    {
        private Conexion conexion = Conexion.getInstancia();


        public DataTable CargarUsuarios() { 
        using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                DataTable table = new DataTable();
                try
                {
                    conn.Open();
                    using(NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FORM users", conn))
                    {
                        using(NpgsqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            table.Load(dataReader);
                        }
                    }
                    return table;

                }
                catch(Exception ex)
                {
                    throw new Exception("error al cargar los usuarios", ex);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public void AltaUsuario(string displey_name, string user_name, string pass)
        {
            using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users (displey_name, user_name, pass) VALUES(@displey_name, @user_name, @pass)", conn))
                    {

                        cmd.Parameters.AddWithValue("@displey_name", displey_name);
                        cmd.Parameters.AddWithValue("@user_name", user_name);
                        cmd.Parameters.AddWithValue("@pass", pass);

                        cmd.ExecuteNonQuery();

                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error al crear nuevo usuario", ex);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            
            
        }

        public void ModificarContraseña(string displey_name, string user_name, string pass)
        {
            using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                try
                {



                    using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE users SET displey_name=@displey_name,user_id=@user_id, pass=@pass)", conn))
                    {

                        cmd.Parameters.AddWithValue("@displey_name", displey_name);
                        cmd.Parameters.AddWithValue("@user_name", user_name);
                        cmd.Parameters.AddWithValue("@pass", pass);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar el usuario", ex);

                }
                finally
                {

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }  
            
        }
    }
}
