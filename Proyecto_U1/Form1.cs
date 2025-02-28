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

            // Se llena el ComboBox con opciones de colores
            cmbColorTexto.Items.AddRange(new string[] { "Rojo", "Azul", "Verde", "Negro" });


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

                btnCerrarSesion.Visible = true; // Ahroa se muestra el botón de cerrar sesión

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
            cmbColorTexto.Items.Add("Blanco");
            cmbColorTexto.Items.Add("Amarillo");
            cmbColorTexto.Items.Add("Cian");
            cmbColorTexto.Items.Add("Magenta");

            // Ocultar ComboBox hasta que un admin inicie sesión
            cmbColorTexto.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Restablecer los datos cuandoi se cierra sesión
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

        private void cmbColorTexto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string colorSeleccionado = cmbColorTexto.SelectedItem.ToString();
            Color nuevoColor = Color.White; // Valor por defecto
            //Se asigna el color seleccionado
            switch (colorSeleccionado)
            {
                case "Blanco":
                    nuevoColor = Color.White;
                    break;
                case "Amarillo":
                    nuevoColor = Color.Yellow;
                    break;
                case "Verde":
                    nuevoColor = Color.LimeGreen;
                    break;
                case "Rojo":
                    nuevoColor = Color.Red;
                    break;
                case "Cian":
                    nuevoColor = Color.Cyan;
                    break;
                case "Magenta":
                    nuevoColor = Color.Magenta;
                    break;
                case "Azul":
                    nuevoColor = Color.Blue;
                    break;
                case "Negro":
                    nuevoColor = Color.Black;
                    break;
            }

            // Aplicar el color a todos los Labels
            lblBienvenida.ForeColor = nuevoColor;
            lblCorreo.ForeColor = nuevoColor;
            lblDireccion.ForeColor = nuevoColor;
            lblFechaNacimiento.ForeColor = nuevoColor;
            lblTipoUsuario.ForeColor = nuevoColor;
        }
    }
}
