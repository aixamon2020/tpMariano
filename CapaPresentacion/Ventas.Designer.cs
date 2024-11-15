namespace CapaPresentacion
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVentas = new DataGridView();
            btnVenta = new Button();
            btnAñadir = new Button();
            cmbProductos = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblMonto = new Label();
            label6 = new Label();
            txtCantidad = new TextBox();
            lblStock = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            lblCategoria = new Label();
            txtCliente = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.GridColor = Color.Beige;
            dgvVentas.Location = new Point(12, 66);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(469, 372);
            dgvVentas.TabIndex = 0;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(487, 386);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(301, 52);
            btnVenta.TabIndex = 1;
            btnVenta.Text = "Realizar venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(487, 348);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(301, 32);
            btnAñadir.TabIndex = 2;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // cmbProductos
            // 
            cmbProductos.BackColor = Color.Olive;
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(12, 12);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(469, 23);
            cmbProductos.TabIndex = 3;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 70);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 110);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 150);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 190);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 286);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Total:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(619, 286);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(12, 15);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 224);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 4;
            label6.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(604, 221);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(604, 150);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(12, 15);
            lblStock.TabIndex = 6;
            lblStock.Text = "-";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(604, 190);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(12, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "-";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(604, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(12, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "-";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(612, 107);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(12, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "-";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(604, 22);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(529, 28);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 10;
            label7.Text = "Cliente:";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(txtCliente);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(txtCantidad);
            Controls.Add(lblMonto);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbProductos);
            Controls.Add(btnAñadir);
            Controls.Add(btnVenta);
            Controls.Add(dgvVentas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnVenta;
        private Button btnAñadir;
        private ComboBox cmbProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblMonto;
        private Label label6;
        private TextBox txtCantidad;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblCategoria;
        private TextBox txtCliente;
        private Label label7;
    }
}