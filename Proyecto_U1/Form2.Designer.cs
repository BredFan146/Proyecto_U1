namespace Proyecto_U1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblCorreo = new Label();
            lblContraseña = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            lblTitulo = new Label();
            lblError = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblRegistrar = new Label();
            lblRecuperarContraseña = new Label();
            picUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            SuspendLayout();
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.DarkSlateGray;
            lblCorreo.Location = new Point(70, 113);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(141, 20);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo electronico:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblContraseña.ForeColor = Color.DarkSlateGray;
            lblContraseña.Location = new Point(70, 161);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(92, 20);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 10.8F);
            txtCorreo.Location = new Point(253, 106);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(110, 27);
            txtCorreo.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 10.8F);
            txtContraseña.Location = new Point(253, 161);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '•';
            txtContraseña.Size = new Size(110, 27);
            txtContraseña.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(142, 62);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(167, 32);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Iniciar Sesion";
            lblTitulo.Click += label3_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Arial Rounded MT Bold", 8.25F);
            lblError.Location = new Point(113, 200);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 12);
            lblError.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.RoyalBlue;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(113, 217);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(80, 29);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(253, 217);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Location = new Point(113, 280);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(187, 15);
            lblRegistrar.TabIndex = 8;
            lblRegistrar.Text = "¿No tienes cuenta? Regístrate aqui";
            lblRegistrar.Click += label3_Click_1;
            // 
            // lblRecuperarContraseña
            // 
            lblRecuperarContraseña.AutoSize = true;
            lblRecuperarContraseña.Cursor = Cursors.Hand;
            lblRecuperarContraseña.ForeColor = Color.Blue;
            lblRecuperarContraseña.Location = new Point(113, 305);
            lblRecuperarContraseña.Name = "lblRecuperarContraseña";
            lblRecuperarContraseña.Size = new Size(141, 15);
            lblRecuperarContraseña.TabIndex = 9;
            lblRecuperarContraseña.Text = "¿Olvidaste tu contraseña?";
            lblRecuperarContraseña.Click += label1_Click;
            // 
            // picUsuario
            // 
            picUsuario.BackgroundImageLayout = ImageLayout.Center;
            picUsuario.Image = (Image)resources.GetObject("picUsuario.Image");
            picUsuario.InitialImage = (Image)resources.GetObject("picUsuario.InitialImage");
            picUsuario.Location = new Point(172, 14);
            picUsuario.Margin = new Padding(3, 2, 3, 2);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(109, 46);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 10;
            picUsuario.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 338);
            Controls.Add(picUsuario);
            Controls.Add(lblRecuperarContraseña);
            Controls.Add(lblRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblError);
            Controls.Add(lblTitulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contraseña";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreo;
        private Label lblContraseña;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Label lblTitulo;
        private Label lblError;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblRegistrar;
        private Label lblRecuperarContraseña;
        private PictureBox picUsuario;
    }
}