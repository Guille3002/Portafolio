namespace _115432GC_S11C1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _nombre;
            _nombre = txtNombre.Text;
            MessageBox.Show("El nombre ingresado es: " + _nombre);
            label1.Text = _nombre;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}