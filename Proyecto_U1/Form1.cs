namespace Proyecto_U1
{
    public partial class Form1 : Form
    {
        public static Usuario usuarioActual = null; // Usuario en sesión

        public Form1()
        {
            InitializeComponent();

            // Ocultar elementos al inicio
            lblBienvenida.Text = "";
            lblCorreo.Text = "";
            lblDireccion.Text = "";
            lblFechaNacimiento.Text = "";
            lblTipoUsuario.Text = "";

            btnCerrarSesion.Visible = false;
            cmbColorTexto.Visible = false;

            // Llenar ComboBox con opciones de colores
            cmbColorTexto.Items.AddRange(new string[] { "Rojo", "Azul", "Verde", "Negro" });

            cmbColorTexto.SelectedIndexChanged += CmbColorTexto_SelectedIndexChanged;

        }
        private void CmbColorTexto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorTexto.SelectedItem != null)
            {
                string colorSeleccionado = cmbColorTexto.SelectedItem.ToString();
                lblBienvenida.BackColor = Color.FromName(colorSeleccionado);
            }
        }
        public class Usuario
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Direccion { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string TipoUsuario { get; set; } // "Normal" o "Administrador"
            public string Contraseña { get; set; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.ShowDialog(); // Abrimos la pantalla de inicio de sesión

            if (usuarioActual != null) // Si el usuario inició sesión correctamente
            {
                lblBienvenida.Text = $"Bienvenido, {usuarioActual.Nombre}";
                lblCorreo.Text = $"Correo: {usuarioActual.Correo}";
                lblDireccion.Text = $"Dirección: {usuarioActual.Direccion}";
                lblFechaNacimiento.Text = $"Fecha de nacimiento: {usuarioActual.FechaNacimiento.ToShortDateString()}";
                lblTipoUsuario.Text = $"Tipo de usuario: {usuarioActual.TipoUsuario}";

                btnCerrarSesion.Visible = true; // Mostrar botón para cerrar sesión

                if (usuarioActual.TipoUsuario == "Administrador")
                {
                    cmbColorTexto.Visible = true;
                }
                else
                {
                    cmbColorTexto.Visible = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Restablecer los datos
            usuarioActual = null;
            lblBienvenida.Text = "";
            lblCorreo.Text = "";
            lblDireccion.Text = "";
            lblFechaNacimiento.Text = "";
            lblTipoUsuario.Text = "";

            btnCerrarSesion.Visible = false;
            cmbColorTexto.Visible = false;
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
