using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PruebaTecnica05_MADELYN.Form2;

namespace PruebaTecnica05_MADELYN
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public class Productos
        {
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public string Precio { get; set; }
            public string Stock { get; set; }
        }

        public static List<Productos> ListaProductos = new List<Productos>();


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Add(txtNombre.Text, txtCategoria.Text, txtPrecio.Text, txtStock.Text);

            Productos nuevoProductos = new Productos
            {
                Nombre = txtNombre.Text,
                Categoria = txtCategoria.Text,
                Precio = txtPrecio.Text,
                Stock = txtStock.Text
            };

            ListaProductos.Add(nuevoProductos);

            MessageBox.Show("Producto guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
