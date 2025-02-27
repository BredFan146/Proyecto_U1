using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_U1.Form1;
using static System.Windows.Forms.DataFormats;

namespace Proyecto_U1
{
    public partial class Form2 : Form
    {
        private int intentosFallidos = 0;
        public Form2()
        {
            InitializeComponent();

            lblError.Text = ""; // Ocultar mensaje de error al inicio
            lblError.ForeColor = Color.Red;

            // Hacer que el label "Registrarse" sea interactivo
            lblRegistrar.ForeColor = Color.Blue;
            lblRegistrar.Cursor = Cursors.Hand;
            lblRegistrar.MouseEnter += (s, e) => lblRegistrar.ForeColor = Color.DarkBlue;
            lblRegistrar.MouseLeave += (s, e) => lblRegistrar.ForeColor = Color.Blue;
            lblRegistrar.Click += label3_Click_1;


            // 🔹 Hacer que lblRecuperarContraseña sea interactivo
            lblRecuperarContraseña.ForeColor = Color.Blue;
            lblRecuperarContraseña.Cursor = Cursors.Hand;
            lblRecuperarContraseña.MouseEnter += (s, e) => lblRecuperarContraseña.ForeColor = Color.DarkBlue;
            lblRecuperarContraseña.MouseLeave += (s, e) => lblRecuperarContraseña.ForeColor = Color.Blue;
            lblRecuperarContraseña.Click += label1_Click;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form3 registroForm = new Form3();
            registroForm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contraseña = txtContraseña.Text;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                lblError.Text = "Por favor, complete todos los campos.";
                return;
            }

            // Buscar usuario en la lista de registros
            Usuario usuario = Form3.usuarios.FirstOrDefault(u => u.Correo == correo && u.Contraseña == contraseña);

            if (usuario != null)
            {
                // Guardar usuario en sesión global de Form1
                Form1.usuarioActual = usuario;
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                intentosFallidos++;
                lblError.Text = $"Credenciales incorrectas. Intento {intentosFallidos}/3";

                if (intentosFallidos >= 3)
                {
                    txtContraseña.Enabled = false;
                    MessageBox.Show("Se ha bloqueado el campo de contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form4 recuperarForm = new Form4();
            recuperarForm.ShowDialog();

        }
    }
}
