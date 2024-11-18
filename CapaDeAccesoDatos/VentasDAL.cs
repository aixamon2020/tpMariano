using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using CapaEntidades;

namespace CapaDeAccesoDatos
{
    public class VentasDAL
    {
        private Conexion conn = Conexion.getInstancia();
        public void RealizarVenta(DateTime fecha, string cliente, decimal monto, List<Detalle_Venta> detalles)
        {
            int codigo_venta = 0;
            using (NpgsqlConnection connection = conn.CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var command = new NpgsqlCommand("INSERT INTO Ventas (fecha, cliente, monto) VALUES (@fecha, @cliente, @monto) RETURNING id_venta", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@fecha", fecha);
                            command.Parameters.AddWithValue("@cliente", cliente);
                            command.Parameters.AddWithValue("@monto", monto);

                            codigo_venta = (int)command.ExecuteScalar();
                        }
                        foreach (var detalle in detalles)
                        {
                            using (var detalleCommand = new NpgsqlCommand("INSERT INTO Detalle_ventas (id_producto, id_venta, cantidad, total_linea) VALUES (@id_producto, @id_venta, @cantidad, @total_linea)", connection, transaction))
                            {
                                detalleCommand.Parameters.AddWithValue("@id_producto", detalle.id_producto);
                                detalleCommand.Parameters.AddWithValue("@id_venta", codigo_venta);
                                detalleCommand.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                                detalleCommand.Parameters.AddWithValue("@total_linea", detalle.Total_linea);

                                detalleCommand.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar venta", ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
