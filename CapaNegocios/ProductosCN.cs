using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeAccesoDatos;

namespace CapaNegocios
{
    public class ProductosCN
    {
        ProductosDAL productosDAL = new ProductosDAL();

        public DataTable CargarProductos()
        {
            return productosDAL.CargarProductos();
        }
        public void InsertarProducto(string nombre, string categoria, string stock, string precio)
        {
            productosDAL.InsertarProductos(nombre, categoria, Convert.ToInt32(stock), Decimal.Parse(precio));
        }

        public void EditarProductos(int id, string nombre, string categoria, string stock, string precio)
        {
            productosDAL.ModificarProductos(id, nombre, categoria, Convert.ToInt32(stock), Decimal.Parse(precio));
        }

        public void EliminarProducto(int id)
        {
            productosDAL.EliminarProductos(id);

        }
    }
}
