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
using System.Numerics;

namespace CapaPresentacion
{
    public partial class Ventas : Form
    {
        VentasCN ventasCN = new VentasCN();
        ProductosCN productosCN = new ProductosCN();
        List<Producto> productos = new List<Producto>();
        List<Detalle_Venta> detalle=new List<Detalle_Venta>();
        decimal total = 0;
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

            dgvVentas.Columns.Add("Codigo", "Codigo");
            dgvVentas.Columns.Add("Nombre", "Producto");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("Total", "Total");
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem != null)
            {
                Producto productoSeleccionado = (Producto)cmbProductos.SelectedItem;

                lblNombre.Text = productoSeleccionado.Nombre.ToString();
                lblCategoria.Text = productoSeleccionado.Categoria.ToString();
                lblStock.Text = productoSeleccionado.Stock.ToString();
                lblPrecio.Text = productoSeleccionado.Precio.ToString("N2");
                txtCantidad.Text = "0";
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Seleccione un producto y especifique una cantidad.");
                return;
            }

            Producto productoSeleccionado = (Producto)cmbProductos.SelectedItem;

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad valida.");
                return;

            }
            decimal totalLine = productoSeleccionado.Precio * cantidad;
            total += totalLine;
            lblMonto.Text = total.ToString();

            dgvVentas.Rows.Add(
                productoSeleccionado.Codigo,
                productoSeleccionado.Nombre,
                cantidad,
                totalLine.ToString("N2")
                );
            txtCantidad.Text = "0";
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtCliente.Text;


                foreach(DataGridViewRow row in dgvVentas.Rows)
                {
                    if (row.Cells["codigo"].Value != null && row.Cells["cantidad"].Value != null)
                    {
                        int idproducto = Convert.ToInt32(row.Cells["codigo"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                        decimal Total_linea = Convert.ToDecimal(row.Cells["total"].Value);

                        detalle.Add(new Detalle_Venta { id_producto=idproducto, cantidad=cantidad, Total_linea=Total_linea});
                    }
                }
                ventasCN.RealizarVenta( cliente, total, detalle);

                MessageBox.Show("venta realizada con exito");

                txtCliente.Clear();
                dgvVentas.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta:" + ex.Message);
            }
        }
    }
}
