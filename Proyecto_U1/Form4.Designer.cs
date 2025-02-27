namespace Proyecto_U1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            lblTitulo = new Label();
            lblCorreo = new Label();
            lblMensaje = new Label();
            btnRecuperar = new Button();
            btnCancelar = new Button();
            txtCorreo = new TextBox();
            lblNuevaContraseña = new Label();
            lblConfirmarContraseña = new Label();
            btnGuardar = new Button();
            txtNuevaContraseña = new TextBox();
            txtConfirmarContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkBlue;
            lblTitulo.Location = new Point(95, 114);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(326, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recuperar Contraseña";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.DarkSlateGray;
            lblCorreo.Location = new Point(22, 217);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(192, 28);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Correo Electrónico:";
            lblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(104, 261);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 2;
            // 
            // btnRecuperar
            // 
            btnRecuperar.BackColor = Color.RoyalBlue;
            btnRecuperar.FlatStyle = FlatStyle.Flat;
            btnRecuperar.ForeColor = SystemColors.Window;
            btnRecuperar.Location = new Point(104, 295);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(94, 29);
            btnRecuperar.TabIndex = 3;
            btnRecuperar.Text = "Recuperar";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.RoyalBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(317, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10.8F);
            txtCorreo.Location = new Point(273, 217);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 31);
            txtCorreo.TabIndex = 5;
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.AutoSize = true;
            lblNuevaContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNuevaContraseña.ForeColor = Color.DarkSlateGray;
            lblNuevaContraseña.Location = new Point(22, 363);
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(190, 28);
            lblNuevaContraseña.TabIndex = 6;
            lblNuevaContraseña.Text = "Nueva Contraseña:";
            lblNuevaContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfirmarContraseña
            // 
            lblConfirmarContraseña.AutoSize = true;
            lblConfirmarContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConfirmarContraseña.ForeColor = Color.DarkSlateGray;
            lblConfirmarContraseña.Location = new Point(22, 429);
            lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            lblConfirmarContraseña.Size = new Size(224, 28);
            lblConfirmarContraseña.TabIndex = 7;
            lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            lblConfirmarContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.RoyalBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(155, 505);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(208, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Nueva Contraseña";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Font = new Font("Segoe UI", 10.8F);
            txtNuevaContraseña.Location = new Point(273, 363);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.PasswordChar = '•';
            txtNuevaContraseña.Size = new Size(125, 31);
            txtNuevaContraseña.TabIndex = 9;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Font = new Font("Segoe UI", 10.8F);
            txtConfirmarContraseña.Location = new Point(273, 429);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.PasswordChar = '•';
            txtConfirmarContraseña.Size = new Size(125, 31);
            txtConfirmarContraseña.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 594);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(btnGuardar);
            Controls.Add(lblConfirmarContraseña);
            Controls.Add(lblNuevaContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(btnCancelar);
            Controls.Add(btnRecuperar);
            Controls.Add(lblMensaje);
            Controls.Add(lblCorreo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCorreo;
        private Label lblMensaje;
        private Button btnRecuperar;
        private Button btnCancelar;
        private TextBox txtCorreo;
        private Label lblNuevaContraseña;
        private Label lblConfirmarContraseña;
        private Button btnGuardar;
        private TextBox txtNuevaContraseña;
        private TextBox txtConfirmarContraseña;
        private PictureBox pictureBox1;
    }
}