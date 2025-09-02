namespace pyrLunaRegistroDeVentasGUI
{
    public partial class frmRegistroDeVentasDeHardware : Form
    {
        public frmRegistroDeVentasDeHardware()
        {
            InitializeComponent();
        }
        DateTime vFecha = DateTime.Now;
        string vProducto = "";
        int vCantidad = 0;
        int vPrecioUnitario = 0;

        private void lstProducto_TextChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text != "")
            {
                nudCantidad.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;
                txtPrecioUnitario.Enabled = false;
                nudCantidad.Text = "";
                txtPrecioUnitario.Text = "";
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Text != "")
            {
                txtPrecioUnitario.Enabled = true;
            }
            else
            {
                txtPrecioUnitario.Enabled = false;
                txtPrecioUnitario.Text = "";
            }
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioUnitario.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Text != "")
            {
                txtPrecioUnitario.Enabled = true;
            }
            else
            {
                txtPrecioUnitario.Enabled = false;
                txtPrecioUnitario.Text = "";
            }
        }

        private void frmRegistroDeVentasDeHardware_Load(object sender, EventArgs e)
        {
            cmbProducto.Items.Add("Procesador");
            cmbProducto.Items.Add("Grafica");
            cmbProducto.Items.Add("Disco duro");
            cmbProducto.Items.Add("Memoria ram");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = cmbProducto.Text;
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            vPrecioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            lblResultado.Text = "vFecha";
        }
    }
}