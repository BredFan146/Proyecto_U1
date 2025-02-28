namespace Proyecto_U1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            lblNombre = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            lblFechaNacimiento = new Label();
            lblTipoUsuario = new Label();
            lblError = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            cmbTipoUsuario = new ComboBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lblContraseña = new Label();
            lblConfirmarContraseña = new Label();
            txtContraseña = new TextBox();
            txtConfirmarContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(166, 81);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblNombre.ForeColor = Color.DarkSlateGray;
            lblNombre.Location = new Point(33, 145);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.DarkSlateGray;
            lblCorreo.Location = new Point(33, 189);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(60, 20);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo:";
            lblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.DarkSlateGray;
            lblDireccion.Location = new Point(33, 323);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(78, 20);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Direccion:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblFechaNacimiento.ForeColor = Color.DarkSlateGray;
            lblFechaNacimiento.Location = new Point(33, 373);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(159, 20);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            lblFechaNacimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTipoUsuario.ForeColor = Color.DarkSlateGray;
            lblTipoUsuario.Location = new Point(33, 422);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(123, 20);
            lblTipoUsuario.TabIndex = 5;
            lblTipoUsuario.Text = "Tipo de Usuario:";
            lblTipoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(121, 466);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10.8F);
            txtNombre.Location = new Point(247, 142);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 10.8F);
            txtCorreo.Location = new Point(247, 184);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(110, 27);
            txtCorreo.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Segoe UI", 10.8F);
            txtDireccion.Location = new Point(247, 321);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(110, 27);
            txtDireccion.TabIndex = 9;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(247, 369);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(231, 23);
            dtpFechaNacimiento.TabIndex = 10;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Normal", "Administrador" });
            cmbTipoUsuario.Location = new Point(247, 422);
            cmbTipoUsuario.Margin = new Padding(3, 2, 3, 2);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(133, 27);
            cmbTipoUsuario.TabIndex = 11;
            cmbTipoUsuario.SelectedIndexChanged += cmbTipoUsuario_SelectedIndexChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.RoyalBlue;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRegistrar.ForeColor = SystemColors.Window;
            btnRegistrar.Location = new Point(148, 503);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(83, 34);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(322, 503);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblContraseña.ForeColor = Color.DarkSlateGray;
            lblContraseña.Location = new Point(33, 232);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(92, 20);
            lblContraseña.TabIndex = 14;
            lblContraseña.Text = "Contraseña:";
            lblContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfirmarContraseña
            // 
            lblConfirmarContraseña.AutoSize = true;
            lblConfirmarContraseña.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblConfirmarContraseña.ForeColor = Color.DarkSlateGray;
            lblConfirmarContraseña.Location = new Point(33, 281);
            lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            lblConfirmarContraseña.Size = new Size(167, 20);
            lblConfirmarContraseña.TabIndex = 15;
            lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            lblConfirmarContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 10.8F);
            txtContraseña.Location = new Point(247, 232);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '•';
            txtContraseña.Size = new Size(110, 27);
            txtContraseña.TabIndex = 16;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContraseña.Font = new Font("Segoe UI", 10.8F);
            txtConfirmarContraseña.Location = new Point(247, 279);
            txtConfirmarContraseña.Margin = new Padding(3, 2, 3, 2);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.PasswordChar = '•';
            txtConfirmarContraseña.Size = new Size(110, 27);
            txtConfirmarContraseña.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 579);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(lblConfirmarContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lblError);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblDireccion);
            Controls.Add(lblCorreo);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblCorreo;
        private Label lblDireccion;
        private Label lblFechaNacimiento;
        private Label lblTipoUsuario;
        private Label lblError;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbTipoUsuario;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label lblContraseña;
        private Label lblConfirmarContraseña;
        private TextBox txtContraseña;
        private TextBox txtConfirmarContraseña;
        private PictureBox pictureBox1;
    }
}