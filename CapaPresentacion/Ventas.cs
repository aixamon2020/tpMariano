using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Ventas : Form
    {
        VentasCN ventasCN = new VentasCN();
        ProductosCN productosCN = new ProductosCN();
        List<Producto> productos = new List<Producto>();
        public Ventas()
        {
            InitializeComponent();
        }
        private void CargarProductos()
        {
            productos = productosCN.ObtenerProductos();

            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Codigo";
            cmbProductos.DataSource = productos;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
