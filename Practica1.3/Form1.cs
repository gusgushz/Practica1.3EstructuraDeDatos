using Practica1._3.Entities;

namespace Practica1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Biblioteca gus = new();

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text)) ||
                (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrWhiteSpace(textBox2.Text)) ||
                (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrWhiteSpace(textBox3.Text)) ||
                (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrWhiteSpace(textBox4.Text)))
            {
                MessageBox.Show("Por favor, ingrese información en todos los cuadros", "AVISO");
            }
            else
            {
                listBox1.Items.Clear();
                string titulo = textBox1.Text;
                string autor = textBox2.Text;
                int año = int.Parse(textBox3.Text);
                string isbn = textBox4.Text;
                gus.InsertarLibro(new Libro(titulo, autor, año, isbn));

                List<Libro> libros = gus.ObtenerListaPorAnchura();
                foreach (Libro libro in libros)
                {
                    listBox1.Items.Add($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AñoPublicacion}, ISBN: {libro.ISBN}");
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor, ingrese información en todos los cuadros", "AVISO");
            }
            else
            {
                listBox1.Items.Clear();
                string isbn = textBox5.Text;
                gus.EliminarLibro(isbn);

                List<Libro> libros = gus.ObtenerListaPorAnchura();
                foreach (Libro libro in libros)
                {
                    listBox1.Items.Add($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AñoPublicacion}, ISBN: {libro.ISBN}");
                }
            }
            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Libro> libros = gus.ObtenerListaPorAnchura();
            foreach (Libro libro in libros)
            {
                listBox1.Items.Add($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AñoPublicacion}, ISBN: {libro.ISBN}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Libro> libros = gus.BusquedaPreorden();
            foreach (Libro libro in libros)
            {
                listBox1.Items.Add($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AñoPublicacion}, ISBN: {libro.ISBN}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Libro> libros = gus.BusquedaInorden();
            foreach (Libro libro in libros)
            {
                listBox1.Items.Add($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AñoPublicacion}, ISBN: {libro.ISBN}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Libro> libros = gus.BusquedaPostorden();
            foreach (Libro libro in libros)
            {
                listBox1.Items.Add($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AñoPublicacion}, ISBN: {libro.ISBN}");
            }
        }
    }
}