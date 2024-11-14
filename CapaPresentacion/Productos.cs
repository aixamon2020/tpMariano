using CapaDeAccesoDatos;
using CapaNegocios;
using System.Data;
namespace CapaPresentacion
{
    public partial class Productos : Form
    {
        ProductosCN productosCN = new ProductosCN();
        int idProducto = 0;
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
                DataGridViewImageColumn imgEditar = new DataGridViewImageColumn();
                imgEditar.Name = "Editar";
                imgEditar.HeaderText = "Editar";
                imgEditar.Image = Properties.Resources.pen;
                dgvDetalles.Columns.Add(imgEditar);
            }

            //Agrego un boton para eliminar
            if (!dgvDetalles.Columns.Contains("Eliminar"))
            {
                DataGridViewImageColumn imgEliminar = new DataGridViewImageColumn();
                imgEliminar.Name = "Eliminar";
                imgEliminar.HeaderText = "Eliminar";
                imgEliminar.Image = Properties.Resources.delete;
                dgvDetalles.Columns.Add(imgEliminar);
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
                productosCN.EditarProductos(idProducto, txtNombre.Text, txtCategoria.Text, txtStock.Text, txtPrecio.Text);
                //Vuelvo a cargar la tabla con los productos
                dgvDetalles.DataSource = productosCN.CargarProductos();
                
                MessageBox.Show("Producto actualizado con éxito.");

                //Modifico el comportamiento de los botones
                btnAñadir.Enabled = true;
                btnActualizar.Enabled = false;
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
        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifico que haya una celda seleccionada
            if (e.RowIndex >= 0)
            {
                var column = dgvDetalles.Columns[e.ColumnIndex];
                if (column.Name == "Editar")
                {
                    // Obtener el ID del producto de la fila seleccionada
                    idProducto = (int)dgvDetalles.Rows[e.RowIndex].Cells["codigo"].Value;

                    //Obtengo los datos de cada columna de la fila seleccionada
                    string nombreProducto = dgvDetalles.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    string categoriaProducto = dgvDetalles.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
                    int stockProducto = Convert.ToInt32(dgvDetalles.Rows[e.RowIndex].Cells["stock"].Value.ToString());
                    decimal precioProducto = Convert.ToDecimal(dgvDetalles.Rows[e.RowIndex].Cells["precio"].Value.ToString());

                    //LLeno los textbox
                    txtNombre.Text = nombreProducto;
                    txtCategoria.Text = categoriaProducto;
                    txtStock.Text = stockProducto.ToString();
                    txtPrecio.Text = precioProducto.ToString();

                    //Modifico el comportamiento de los botones
                    btnAñadir.Enabled = false;
                    btnActualizar.Enabled = true;
                }
                else if (column.Name == "Eliminar")
                {
                    // Obtener el ID del producto de la fila seleccionada
                    idProducto = (int)dgvDetalles.Rows[e.RowIndex].Cells["codigo"].Value;
                    // Llamar a tu método para eliminar el producto
                    productosCN.EliminarProducto(idProducto);
                    //Vuelvo a cargar la tabla con los productos
                    dgvDetalles.DataSource = productosCN.CargarProductos();
                }
            }
        }
    }
}