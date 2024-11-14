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
            dataGridView1 = new DataGridView();
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblStock = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(469, 372);
            dataGridView1.TabIndex = 0;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(487, 386);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(301, 52);
            btnVenta.TabIndex = 1;
            btnVenta.Text = "Realizar venta";
            btnVenta.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(487, 348);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(301, 32);
            btnAñadir.TabIndex = 2;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(12, 12);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(469, 23);
            cmbProductos.TabIndex = 3;
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
            // textBox1
            // 
            textBox1.Location = new Point(604, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(604, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(604, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
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
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblStock;
        private Label lblPrecio;
    }
}