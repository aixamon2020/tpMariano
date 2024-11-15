using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeAccesoDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class VentasCN
    {
        public VentasDAL ventasDAL = new VentasDAL();
        public void RealizarVenta( string cliente, decimal monto, List<Detalle_Venta> detalles)
        {
            if (detalles == null || detalles.Count == 0)
            {
                throw new ArgumentException("La venta no puede estar vacía");
            }

            decimal subtotal = 0;
            foreach (var detalle in detalles)
            {
                if (detalle.cantidad <= 0)
                {
                    throw new ArgumentException("La cantidad debe ser mayor que cero");
                }
            }
            try
            {
                ventasDAL.RealizarVenta(cliente, monto, detalles);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la venta", ex);
            }
        }
    }
}
