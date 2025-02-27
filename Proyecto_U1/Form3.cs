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
    public partial class Form3 : Form
    {
        public static List<Usuario> usuarios = new List<Usuario>(); // Lista para almacenar usuarios

        public Form3()
        {
            InitializeComponent();

            lblError.Text = ""; // Ocultar mensaje de error al inicio
            lblError.ForeColor = System.Drawing.Color.Red;

            // Agregar opciones al ComboBox de Tipo de Usuario
            cmbTipoUsuario.Items.Add("Normal");
            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.SelectedIndex = 0; // Seleccionar "Normal" por defecto
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();
            string contraseña = txtContraseña.Text;
            string confirmarContraseña = txtConfirmarContraseña.Text;

            // 🔴 Validaciones de los datos ingresados
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(confirmarContraseña))
            {
                lblError.Text = "Todos los campos son obligatorios.";
                return;
            }

            // 📧 Validación de correo (Debe contener "@" y ".")
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                lblError.Text = "Ingrese un correo electrónico válido.";
                return;
            }

            // 🔞 Validación de edad (Debe ser mayor de 18 años)
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (edad < 18)
            {
                lblError.Text = "Debe ser mayor de 18 años para registrarse.";
                return;
            }

            // 🔐 Validación de contraseña (mínimo 6 caracteres)
            if (contraseña.Length < 6)
            {
                lblError.Text = "La contraseña debe tener al menos 6 caracteres.";
                return;
            }

            // 🔄 Confirmación de contraseña
            if (contraseña != confirmarContraseña)
            {
                lblError.Text = "Las contraseñas no coinciden.";
                return;
            }

            // ⚠️ Verificar si el correo ya está registrado
            if (usuarios.Any(u => u.Correo == correo))
            {
                lblError.Text = "Este correo ya está registrado.";
                return;
            }

            // ✅ Crear y guardar el nuevo usuario
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Correo = correo,
                Direccion = direccion,
                FechaNacimiento = fechaNacimiento,
                TipoUsuario = tipoUsuario,
                Contraseña = contraseña // Guardar la contraseña creada por el usuario
            };

            usuarios.Add(nuevoUsuario);
            MessageBox.Show("Usuario registrado correctamente.",
                "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Cerrar el formulario de registro
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
