namespace CapaPresentacion
{
    partial class Principal
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
            panelSuperior = new Panel();
            panelBotones = new Panel();
            btnSalir = new Button();
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            panelPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            panelSuperior.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.Olive;
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(984, 36);
            panelSuperior.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.DarkKhaki;
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Controls.Add(btnUsuarios);
            panelBotones.Controls.Add(btnVentas);
            panelBotones.Controls.Add(btnProductos);
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 36);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(182, 525);
            panelBotones.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LemonChiffon;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Location = new Point(0, 417);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(182, 35);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Location = new Point(0, 247);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(179, 49);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Location = new Point(0, 147);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(182, 46);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Location = new Point(0, 55);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(182, 45);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Beige;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(182, 36);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(802, 525);
            panelPrincipal.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(943, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnSalir_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panelPrincipal);
            Controls.Add(panelBotones);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            panelSuperior.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelBotones;
        private Panel panelPrincipal;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnSalir;
        private Button btnUsuarios;
        private PictureBox pictureBox1;
    }
}