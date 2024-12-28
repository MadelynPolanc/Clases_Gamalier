using System.Windows.Forms;

namespace Madelyn_PruebaTecnica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNombre.Text, txtCargo.Text, txtHijos.Text, txtSueldo_Neto.Text, txtTotal_Descuentos.Text);

            MessageBox.Show("Datos guardados correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sueldo = decimal.Parse(txtSueldo.Text);

                decimal afp = sueldo * 0.0287m;
                decimal sfs = sueldo * 0.0304m; 

                decimal isr = 0;
                if (sueldo > 416220 && sueldo <= 624329) 
                {
                    isr = (sueldo - 416220) * 0.15m;
                }
                else if (sueldo > 624329 && sueldo <= 867123) 
                {
                    isr = 31216 + (sueldo - 624329) * 0.20m;
                }
                else if (sueldo > 867123) 
                {
                    isr = 79776 + (sueldo - 867123) * 0.25m;
                }

                decimal totalDescuentos = afp + sfs + isr;
                decimal sueldoNeto = sueldo - totalDescuentos;

                txtAFP.Text = afp.ToString("F2");
                txtSFS.Text = sfs.ToString("F2");
                txtISR.Text = isr.ToString("F2");
                txtTotal_Descuentos.Text = totalDescuentos.ToString("F2");
                txtSueldo_Neto.Text = sueldoNeto.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos en el campo de sueldo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtCargo.ReadOnly = false;
            txtSueldo.ReadOnly = false;
            txtHijos.ReadOnly = false;
            txtAFP.ReadOnly = false;
            txtSFS.ReadOnly = false;
            txtISR.ReadOnly = false;
            txtTotal_Descuentos.ReadOnly = false;
            txtSueldo_Neto.ReadOnly = false;

            MessageBox.Show("Los campos están listos para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                MessageBox.Show("Registro eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();
            txtHijos.Clear();
            txtAFP.Clear();
            txtSFS.Clear();
            txtISR.Clear();
            txtTotal_Descuentos.Clear();
            txtSueldo_Neto.Clear();
            txtSueldo_Ingreso.Clear();

            MessageBox.Show("Campos limpiados correctamente.", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
