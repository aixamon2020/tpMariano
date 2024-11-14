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
            txtid = new TextBox();
            txtDisplayname = new TextBox();
            txtUsername = new TextBox();
            btnGuardar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(2, -1);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(341, 447);
            dgvUsuarios.TabIndex = 0;
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
            // txtid
            // 
            txtid.Location = new Point(614, 157);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 7;
            txtid.UseSystemPasswordChar = true;
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
            // btnGuardar
            // 
            btnGuardar.Location = new Point(480, 333);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(614, 333);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnGuardar);
            Controls.Add(txtUsername);
            Controls.Add(txtDisplayname);
            Controls.Add(txtid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtid;
        private TextBox txtDisplayname;
        private TextBox txtUsername;
        private Button btnGuardar;
        private Button btnAgregar;
    }
}