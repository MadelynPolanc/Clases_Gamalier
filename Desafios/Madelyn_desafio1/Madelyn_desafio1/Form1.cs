using System.Data;

namespace Madelyn_desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldoBase = Convert.ToDouble(txtSueldo.Text);
            int numHijos = Convert.ToInt32(txtHijos.Text);

            double incentivoPorHijo = 500;
            double totalIncentivo = incentivoPorHijo * numHijos;
            double afp = sueldoBase * 2.87;
            double sfs = sueldoBase * 3.04;
            double isr = sueldoBase * 0.12;
            double otros = 100;
            double sueldoNeto = sueldoBase + totalIncentivo - afp - sfs - isr - otros;

            txtAFP.Text = afp.ToString();
            txtSFS.Text = sfs.ToString();
            txtISR.Text = isr.ToString();
            txtnumHijos.Text = otros.ToString();
            txtSueldoNETO.Text = sueldoNeto.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAFP.Clear();
            txtSFS.Clear();
            txtISR.Clear();
            txtnumHijos.Clear();
            txtSueldoNETO.Clear();
        }
    }
}

