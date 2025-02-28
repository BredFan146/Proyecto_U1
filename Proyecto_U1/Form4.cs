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

namespace Proyecto_U1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            lblMensaje.Text = ""; // Ocultar mensaje al inicio
            lblMensaje.ForeColor = System.Drawing.Color.Red;
            lblNuevaContraseña.Visible = false;
            lblConfirmarContraseña.Visible = false;
            txtConfirmarContraseña.Visible = false;
            txtNuevaContraseña.Visible = false;
            btnGuardar.Visible = false;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(correo))
            {
                lblMensaje.Text = "Ingrese su correo electrónico.";
                return;
            }

            //Validar formato del correo
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                lblMensaje.Text = "Ingrese un correo válido.";
                return;
            }

            //Buscar usuario en la lista
            Usuario usuario = Form3.usuarios.FirstOrDefault(u => u.Correo == correo);
            
            if (usuario != null)
            {
                // Mostrar los campos para cambiar contraseña
                txtNuevaContraseña.Visible = true;
                lblNuevaContraseña.Visible = true;
                txtConfirmarContraseña.Visible = true;
                lblConfirmarContraseña.Visible = true;
                btnGuardar.Visible = true;
                btnRecuperar.Enabled = false; // Deshabilitar el boton de recuperar
            }
            else
            {
                lblMensaje.Text = "El correo no está registrado.";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        //Función para generar una contraseña aleatoria
        //private string GenerarContraseña()
        //{
        //    const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        //    StringBuilder contraseña = new StringBuilder();
        //    Random rnd = new Random();

        //    for (int i = 0; i < 8; i++) // Contraseña de 8 caracteres
        //    {
        //        int indice = rnd.Next(caracteres.Length);
        //        contraseña.Append(caracteres[indice]);
        //    }

        //    return contraseña.ToString();

        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevaContraseña = txtNuevaContraseña.Text;
            string confirmarContraseña = txtConfirmarContraseña.Text;

            //Validación de contraseña (mínimo 6 caracteres)
            if (nuevaContraseña.Length < 6)
            {
                lblMensaje.Text = "La contraseña debe tener al menos 6 caracteres.";
                return;
            }

            //Confirmación de contraseña
            if (nuevaContraseña != confirmarContraseña)
            {
                lblMensaje.Text = "Las contraseñas no coinciden.";
                return;
            }

            //Buscar usuario en la lista y actualizar contraseña
            Usuario usuario = Form3.usuarios.FirstOrDefault(u => u.Correo == txtCorreo.Text);
            if (usuario != null)
            {
                usuario.Contraseña = nuevaContraseña; // Guardar la nueva contraseña
                MessageBox.Show("Su contraseña ha sido cambiada con éxito.","Contraseña Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar `Form4`
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
