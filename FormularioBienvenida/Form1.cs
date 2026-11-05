namespace FormularioBienvenida
{
    public partial class Form1 : Form


    {

        public Form1()
        {

            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string textoEdad = txtEdad.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce tu nombre.");
                return;
            }
            if (!int.TryParse(textoEdad, out int edad) || edad < 0)
            {
                MessageBox.Show("Introduce una edad válida.");
                return;
            }
            if (edad < 18)
            {
                MessageBox.Show("No eres mayor de edad.");
                return;
            }

            lblResultado.Text =
                    $"Hola, {nombre}. \nTienes {edad} años.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtEdad.Text = null;
            lblResultado.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
