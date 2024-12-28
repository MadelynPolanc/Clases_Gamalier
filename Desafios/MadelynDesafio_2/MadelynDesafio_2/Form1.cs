namespace MadelynDesafio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(txtN1.Text);
                double n2 = double.Parse(txtN2.Text);
                double n3 = double.Parse(txtN3.Text);
                double n4 = double.Parse(txtN4.Text);

                double promedio = (n1 + n2 + n3 + n4) / 4;

                txtPromedio.Text = promedio.ToString("F2");

                if (promedio >= 70)
                {
                    txtCondicion.Text = "Aprobado";
                }
                else
                {
                    txtCondicion.Text = "Desaprobado";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos en las calificaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtPromedio.Clear();
            txtCondicion.Clear();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



