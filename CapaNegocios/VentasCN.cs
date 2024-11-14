using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeAccesoDatos;

namespace CapaNegocios
{
    public class VentasCN
    {
        public VentasDAL ventasDAL = new VentasDAL();
        public bool RealizarVenta(string cliente, string monto, List<DetalleVenta> detalles)
        {
            if (detalles == null || detalles.Count == 0)
            {
                throw new ArgumentException("La venta no puede estar vacía");
            }

            decimal subtotal = 0;
            foreach (var detalle in detalles)
            {
                if (detalle.Cantidad <= 0)
                {
                    throw new ArgumentException("La cantidad debe ser mayor que cero");
                }
            }
            try
            {
                return ventasDAL.RealizarVenta(cliente, Convert.ToDouble(monto), detalles);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la venta", ex);
            }
        }
    }
}
