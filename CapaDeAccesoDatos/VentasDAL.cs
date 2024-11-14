using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CapaDeAccesoDatos
{
    public class DetalleVenta
    {
        public int id_detalle { get; set; }
        public int id_venta { get; set; }
        public int id_producto { get; set; }
        public int Cantidad { get; set; }
    }
    public class VentasDAL
    {
        private Conexion conn = Conexion.getInstancia();
        public bool RealizarVenta(string cliente, double monto, List<DetalleVenta> detalles)
        {
            int codigo_venta = 0;
            using (NpgsqlConnection connection = conn.CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var command = new NpgsqlCommand("INSERT INTO Ventas (cliente, monto) VALUES (@cliente, @monto) RETURNING id_venta", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@dni_cliente", cliente);
                            command.Parameters.AddWithValue("@dni_empleado", monto);

                            codigo_venta = (int)command.ExecuteScalar();
                        }
                        foreach (var detalle in detalles)
                        {
                            using (var detalleCommand = new NpgsqlCommand("INSERT INTO Detalle_ventas (id_producto, id_venta, cantidad) VALUES (@id_producto, @id_venta, @cantidad)", connection, transaction))
                            {
                                detalleCommand.Parameters.AddWithValue("@id_producto", detalle.id_producto);
                                detalleCommand.Parameters.AddWithValue("@id_venta", codigo_venta);
                                detalleCommand.Parameters.AddWithValue("@cantidad", detalle.Cantidad);

                                detalleCommand.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        return true;
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
