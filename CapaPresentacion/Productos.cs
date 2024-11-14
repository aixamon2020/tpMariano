using CapaDeAccesoDatos;
using CapaNegocios;
using System.Data;
namespace CapaPresentacion
{
    public partial class Productos : Form
    {
        ProductosCN productosCN = new ProductosCN();
        public Productos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDetalles.DataSource = productosCN.CargarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            productosCN.InsertarProducto(txtNombre.Text, txtCategoria.Text, txtStock.Text, txtPrecio.Text);
            dgvDetalles.DataSource = productosCN.CargarProductos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre = txtNombre.Text;
                string categoria = txtCategoria.Text;
                int stock = int.Parse(txtStock.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);


                ProductosDAL productosDAL = new ProductosDAL();


                productosDAL.InsertarProductos(nombre, categoria, stock, precio);

                MessageBox.Show("Producto actualizado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }





}
