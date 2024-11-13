namespace CapaPresentacion
{
    partial class Form1
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
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(12, 31);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.Size = new Size(490, 232);
            dgvDetalles.TabIndex = 0;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(610, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(612, 78);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(610, 134);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(612, 186);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(555, 299);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 25);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(675, 299);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 25);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(684, 368);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombre);
            Controls.Add(dgvDetalles);
            Name = "Form1";
            Text = "Form1";
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
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnSalir;
   
    }
}
