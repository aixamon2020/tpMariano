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
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.OliveDrab;
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(984, 36);
            panelSuperior.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.LightYellow;
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
            btnSalir.BackColor = Color.Red;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(0, 450);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(182, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Location = new Point(3, 308);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(179, 23);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Location = new Point(0, 220);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(182, 23);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Location = new Point(0, 113);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(182, 45);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Ivory;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(182, 36);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(802, 525);
            panelPrincipal.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panelPrincipal);
            Controls.Add(panelBotones);
            Controls.Add(panelSuperior);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            panelBotones.ResumeLayout(false);
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
    }
}