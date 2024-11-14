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
            //Cargo mis productos de la base de datos
            dgvDetalles.DataSource = productosCN.CargarProductos();

            //Agrego un boton para editar
            if (!dgvDetalles.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvDetalles.Columns.Add(btnEditar);
            }

            //Agrego un boton para eliminar
            if (!dgvDetalles.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvDetalles.Columns.Add(btnEliminar);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Inserto nuevo producto en la base de datos
            productosCN.InsertarProducto(txtNombre.Text, txtCategoria.Text, txtStock.Text, txtPrecio.Text);
            //Vuelvo a cargar la tabla con los productos
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
    }
}