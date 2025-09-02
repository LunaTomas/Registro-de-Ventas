namespace pyrLunaRegistroDeVentasGUI
{
    public partial class frmRegistroDeVentasDeHardware : Form
    {
        public frmRegistroDeVentasDeHardware()
        {
            InitializeComponent();
        }

        private void lstProducto_TextChanged(object sender, EventArgs e)
        {
            if (lstProducto.Text != "")
            {
                txtCantidad.Enabled = true;
            }
            else
            {
                txtCantidad.Enabled = false;
                txtPrecioUnitario.Enabled = false;
                txtCantidad.Text = "";
                txtPrecioUnitario.Text = "";
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
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
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}