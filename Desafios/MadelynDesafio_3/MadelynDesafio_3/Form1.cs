namespace MadelynDesafio_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        class reserva
        {

            public string Cliente { get; set; }

            public string Fecha_Entrada { get; set; }

            public string Fecha_Salida { get; set; }

            public string Tipo_habitacion { get; set; }

            public int Precio { get; set; }

        }

        reserva Reserva = new reserva();


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtPrecio.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Reserva.Cliente = txtCliente.Text;
            Reserva.Fecha_Entrada = DateTimeEntrada.Text;
            Reserva.Fecha_Salida = DateTimeSalida.Text;
            Reserva.Tipo_habitacion = cmbTipoHab.Text;
            int precio = (Convert.ToInt32(txtPrecio.Text));
            Reserva.Precio = precio;

            lbox_reserva.Items.Add($"El cliente es:{Reserva.Cliente}");
            lbox_reserva.Items.Add($"La fecha de reserva es:{Reserva.Fecha_Entrada}");
            lbox_reserva.Items.Add($"Y finaliza el:{Reserva.Fecha_Salida}");
            lbox_reserva.Items.Add($"El cliente reservo una habitacion tipo:{Reserva.Tipo_habitacion}");
            lbox_reserva.Items.Add($"El monto a pagar es:{Reserva.Precio}");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                if (lbox_reserva.Items.Count > 0)
                {
                lbox_reserva.Items.Clear();

                    MessageBox.Show("Todos los registros han sido eliminados.");
                }
                else
                {
                    MessageBox.Show("El ListBox ya está vacío.");
                }
            }

        }

    }
    


