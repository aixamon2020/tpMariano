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

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        UsuariosCN usuariosCN = new UsuariosCN();
        int idUsuario = 0;
        public Usuarios()
        {
            InitializeComponent();
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            //Cargo mis productos de la base de datos
            dgvUsuarios.DataSource = usuariosCN.cargarUsuarios();

            //Agrego un boton para editar
            if (!dgvUsuarios.Columns.Contains("Editar"))
            {
                DataGridViewImageColumn imgEditar = new DataGridViewImageColumn();
                imgEditar.Name = "Editar";
                imgEditar.HeaderText = "Editar";
                imgEditar.Image = Properties.Resources.pen;
                dgvUsuarios.Columns.Add(imgEditar);
            }

            //Agrego un boton para eliminar
            if (!dgvUsuarios.Columns.Contains("Eliminar"))
            {
                DataGridViewImageColumn imgEliminar = new DataGridViewImageColumn();
                imgEliminar.Name = "Eliminar";
                imgEliminar.HeaderText = "Eliminar";
                imgEliminar.Image = Properties.Resources.delete;
                dgvUsuarios.Columns.Add(imgEliminar);
            }
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Agrego usuario nuevo
            usuariosCN.AltaUsuarios(txtDisplayname.Text, txtUsername.Text, txtPass.Text);
            //Vuelvo a cargar la tabla con los usuarios
            dgvUsuarios.DataSource = usuariosCN.cargarUsuarios();
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var column = dgvUsuarios.Columns[e.ColumnIndex];
                if (column.Name == "Editar")
                {
                    // Obtener el ID del producto de la fila seleccionada
                    idUsuario = (int)dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value;

                    //Obtengo los datos de cada columna de la fila seleccionada
                    string dis_name = dgvUsuarios.Rows[e.RowIndex].Cells["display_name"].Value.ToString();
                    string user_name = dgvUsuarios.Rows[e.RowIndex].Cells["user_name"].Value.ToString();
                    string pass = dgvUsuarios.Rows[e.RowIndex].Cells["pass"].Value.ToString();

                    //LLeno los textbox
                    txtDisplayname.Text = dis_name;
                    txtUsername.Text = user_name;
                    txtPass.Text = pass;

                    //Modifico el comportamiento de los botones
                    btnAñadir.Enabled = false;
                    btnActualizar.Enabled = true;
                }
                else if (column.Name == "Eliminar")
                {
                    // Obtener el ID del producto de la fila seleccionada
                    idUsuario = (int)dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value;
                    // Llamar a tu método para eliminar el usuario
                    usuariosCN.EliminarUsuarios(idUsuario);
                    //Vuelvo a cargar la tabla con los usuarios
                    dgvUsuarios.DataSource = usuariosCN.cargarUsuarios();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                usuariosCN.ModificarContraseña(idUsuario, txtPass.Text);
                //Vuelvo a cargar la tabla con los productos
                dgvUsuarios.DataSource = usuariosCN.cargarUsuarios();

                MessageBox.Show("Contraseña actualizada con éxito.");

                //Modifico el comportamiento de los botones
                btnAñadir.Enabled = true;
                btnActualizar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
            }
        }
    }
}
