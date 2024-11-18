namespace CapaPresentacion
{
    partial class Productos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDetalles = new DataGridView();
            txtNombre = new TextBox();
            txtCategoria = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            btnAñadir = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.BackgroundColor = Color.Beige;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(12, 12);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.Size = new Size(490, 426);
            dgvDetalles.TabIndex = 0;
            dgvDetalles.CellClick += dgvDetalles_CellClick;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Ivory;
            txtNombre.Location = new Point(610, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.Ivory;
            txtCategoria.Location = new Point(612, 75);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.Ivory;
            txtStock.Location = new Point(612, 134);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.Ivory;
            txtPrecio.Location = new Point(612, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.LemonChiffon;
            btnAñadir.FlatStyle = FlatStyle.Flat;
            btnAñadir.Location = new Point(555, 299);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(93, 25);
            btnAñadir.TabIndex = 5;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LemonChiffon;
            btnActualizar.Enabled = false;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(675, 299);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 25);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 78);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 142);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 189);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 10;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(540, 83);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 11;
            label5.Text = "Categorias:";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(btnAñadir);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombre);
            Controls.Add(dgvDetalles);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalles;
        private TextBox txtNombre;
        private TextBox txtCategoria;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private Button btnAñadir;
        private Button btnActualizar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
