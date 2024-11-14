using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object panelPrincipal)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = panelPrincipal as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Productos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Usuarios());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ventas());
        }
    }
}
