namespace CapaPresentacion
{
    partial class Usuarios
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
            dgvUsuarios = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPass = new TextBox();
            txtDisplayname = new TextBox();
            txtUsername = new TextBox();
            btnAñadir = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 12);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(444, 426);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 165);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Pass:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Display_name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 108);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 3;
            label3.Text = "User_name";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(614, 157);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 7;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtDisplayname
            // 
            txtDisplayname.Location = new Point(614, 46);
            txtDisplayname.Name = "txtDisplayname";
            txtDisplayname.Size = new Size(100, 23);
            txtDisplayname.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(614, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 9;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(472, 333);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 10;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(639, 333);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnAñadir);
            Controls.Add(txtUsername);
            Controls.Add(txtDisplayname);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPass;
        private TextBox txtDisplayname;
        private TextBox txtUsername;
        private Button btnAñadir;
        private Button btnActualizar;
    }
}