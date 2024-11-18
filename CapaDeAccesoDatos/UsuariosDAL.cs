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
                    using(NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM users", conn))
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
                    throw new Exception("Error al cargar los usuarios", ex);
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
        public void AltaUsuario(string display_name, string user_name, string pass)
        {
            using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users (display_name, user_name, pass) VALUES(@display_name, @user_name, @pass)", conn))
                    {

                        cmd.Parameters.AddWithValue("@display_name", display_name);
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
        public void ModificarContraseña(int id, string pass)
        {
            using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE users SET pass=@pass where id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@pass", pass);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cambiar la contraseña", ex);
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
        public void EliminarUsuarios(int id)
        {
            using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM users WHERE id=@id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar usuario", ex);
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
        public bool Login(string user_name, string pass)
        {
            using (var conn = new Conexion().CrearConexion())
            {
                try
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = "select * from users where user_name=@user and pass=@pass";
                        command.Parameters.AddWithValue("@user", user_name);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;

                        int userCont = Convert.ToInt32(command.ExecuteScalar());
                        // Autenticación exitosa
                        if (userCont == 1)
                        {
                            return true;
                        }
                        else
                            //Autenticación fallida
                            return false;
                    }
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
