using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Detalle_Venta
    {
        public int id_detalle { get; set; }
        public int id_producto {  get; set; }
        public int id_venta { get; set;}
        public int cantidad { get; set; }
        public decimal Total_linea { get; set; }
    }
}
