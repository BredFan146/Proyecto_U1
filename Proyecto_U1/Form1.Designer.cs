namespace Proyecto_U1
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
            btnIniciarSesion = new Button();
            btnCerrarSesion = new Button();
            lblBienvenida = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            lblFechaNacimiento = new Label();
            lblTipoUsuario = new Label();
            cmbColorTexto = new ComboBox();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.RoyalBlue;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnIniciarSesion.ForeColor = SystemColors.Window;
            btnIniciarSesion.Location = new Point(136, 422);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(172, 44);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += button1_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Crimson;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = SystemColors.Window;
            btnCerrarSesion.Location = new Point(383, 422);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(172, 44);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.DarkBlue;
            lblBienvenida.Location = new Point(68, 56);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(142, 32);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Bienvenido";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.DarkSlateGray;
            lblCorreo.Location = new Point(68, 116);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(61, 21);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo";
            lblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.DarkSlateGray;
            lblDireccion.Location = new Point(68, 186);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(83, 21);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFechaNacimiento.ForeColor = Color.DarkSlateGray;
            lblFechaNacimiento.Location = new Point(68, 251);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(171, 21);
            lblFechaNacimiento.TabIndex = 5;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            lblFechaNacimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTipoUsuario.ForeColor = Color.DarkSlateGray;
            lblTipoUsuario.Location = new Point(68, 322);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(130, 21);
            lblTipoUsuario.TabIndex = 6;
            lblTipoUsuario.Text = "Tipo de Usuario";
            lblTipoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbColorTexto
            // 
            cmbColorTexto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColorTexto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbColorTexto.FormattingEnabled = true;
            cmbColorTexto.Location = new Point(249, 509);
            cmbColorTexto.Name = "cmbColorTexto";
            cmbColorTexto.Size = new Size(169, 27);
            cmbColorTexto.TabIndex = 7;
            cmbColorTexto.SelectedIndexChanged += cmbColorTexto_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(652, 625);
            Controls.Add(cmbColorTexto);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblDireccion);
            Controls.Add(lblCorreo);
            Controls.Add(lblBienvenida);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnIniciarSesion);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private Button btnCerrarSesion;
        private Label lblBienvenida;
        private Label lblCorreo;
        private Label lblDireccion;
        private Label lblFechaNacimiento;
        private Label lblTipoUsuario;
        private ComboBox cmbColorTexto;
    }
}
