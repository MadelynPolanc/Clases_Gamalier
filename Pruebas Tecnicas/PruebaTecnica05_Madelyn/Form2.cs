using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica05_MADELYN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { }
        public class Proveedor
        {
            public string Nombre { get; set; }
            public string RNC { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string Ciudad { get; set; }
        }

        public static List<Proveedor> ListaProveedores = new List<Proveedor>();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtRNC.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtCiudad.Text))

            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Add(txtNombre.Text, txtRNC.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtCiudad.Text);

            Proveedor nuevoProveedor = new Proveedor
            {
                Nombre = txtNombre.Text,
                RNC = txtRNC.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Ciudad = txtCiudad.Text
            };

            ListaProveedores.Add(nuevoProveedor);

            MessageBox.Show("Proveedor guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtRNC.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

        


