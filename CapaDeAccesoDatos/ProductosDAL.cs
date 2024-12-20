﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using CapaEntidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaDeAccesoDatos
{
    public class ProductosDAL
    {
        private Conexion conexion = Conexion.getInstancia();
        public DataTable CargarProductos()
        {
            using(NpgsqlConnection conn = conexion.CrearConexion())
            {
                DataTable tabla = new DataTable();
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from Productos", conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            tabla.Load(reader);
                        }
                    }
                    return tabla;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if(conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from productos", conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto
                                {
                                    Codigo = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Categoria = reader.GetString(2),
                                    Stock = reader.GetInt32(3),
                                    Precio = reader.GetDecimal(4)
                                };
                                productos.Add(producto);
                            }
                        }

                    }
                    return productos;
                }
                catch (Exception ex)
                {
                    throw ex;
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
        public void InsertarProductos(string Nombre, string categoria, int stock, decimal precio)
        {
            using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Productos (Nombre, Categoria, Stock, Precio) VALUES (@Nombre, @Categoria, @Stock, @Precio)", conn))
                    {
                        command.Parameters.AddWithValue("@nombre", Nombre);
                        command.Parameters.AddWithValue("@Categoria", categoria);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.Parameters.AddWithValue("@Precio", precio);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
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
        public void ModificarProductos(int Codigo, string Nombre, string categoria, int stock, decimal precio)
            {
                using (NpgsqlConnection conn = conexion.CrearConexion())
                {
                    try
                    {
                        conn.Open();
                        using (NpgsqlCommand command = new NpgsqlCommand("UPDATE Productos SET nombre=@nombre, categoria=@categoria, stock=@stock, precio=@precio WHERE codigo=@codigo", conn))
                        {
                            command.Parameters.AddWithValue("@codigo", Codigo);
                            command.Parameters.AddWithValue("@nombre", Nombre);
                            command.Parameters.AddWithValue("@categoria", categoria);
                            command.Parameters.AddWithValue("@stock", stock);
                            command.Parameters.AddWithValue("@precio", precio);

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
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
        public void EliminarProductos(int Codigo)
        {
            using (NpgsqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM Productos WHERE Codigo=@codigo",conn)) 
                    {
                        command.Parameters.AddWithValue("@codigo", Codigo);
                       

                         command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
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
