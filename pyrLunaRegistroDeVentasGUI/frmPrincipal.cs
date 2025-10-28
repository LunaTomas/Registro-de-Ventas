namespace pyrLunaRegistroDeVentasGUI
{
    public partial class frmRegistroDeVentasDeHardware : Form
    {
        // clase interna para representar una venta
        class Venta
        {
            public DateTime Fecha { get; set; }
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            public int PrecioUnitario { get; set; }
            public override string ToString()
            {
                return $"{Fecha.ToShortDateString()} - {Producto} - Cantidad: {Cantidad} - Precio Unitario: ${PrecioUnitario:N2}";
            }
        }

        // lista para almacenar las ventas
        List<Venta> ventas = new List<Venta>();
        public frmRegistroDeVentasDeHardware()
        {
            InitializeComponent();
        }
        private void frmRegistroDeVentasDeHardware_Load(object sender, EventArgs e)
        {
            // agregar productos al ComboBox
            cmbProducto.Items.AddRange(new string[] { "Procesador", "Grafica", "Disco duro", "Memoria ram" });
            // leer archivo de texto y cargar las ventas en la lista
            if (File.Exists("registro_de_ventas.txt"))
            {
                foreach (string linea in File.ReadAllLines("registro_de_ventas.txt"))
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 4)
                    {
                        Venta v = new Venta()
                        {
                            Fecha = DateTime.Parse(partes[0]),
                            Producto = partes[1],
                            Cantidad = int.Parse(partes[2]),
                            PrecioUnitario = int.Parse(partes[3])
                        };
                        ventas.Add(v);
                        lstVentas.Items.Add(v.ToString());
                    }
                }
            }
            // agregar ejemplos al ListBox
            lstVentas.Items.Add("01/01/2024 - Procesador - Cantidad: 2 - Precio Unitario: $250.00");
            lstVentas.Items.Add("02/01/2024 - Grafica - Cantidad: 1 - Precio Unitario: $500.00");
            lstVentas.Items.Add("03/01/2024 - Disco duro - Cantidad: 3 - Precio Unitario: $100.00");
            lstVentas.Items.Add("04/01/2024 - Memoria ram - Cantidad: 4 - Precio Unitario: $75.00");
        }
        private void lstProducto_TextChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text != "")
                mskCantidad.Enabled = true;
            else
            {
                mskCantidad.Enabled = false;
                txtPrecioUnitario.Enabled = false;
                mskCantidad.Text = "";
                txtPrecioUnitario.Text = "";
            }
        }
        private void mskCantidad_TextChanged(object sender, EventArgs e)
        {
            /*if (nudCantidad.Text != "")
            {
                txtPrecioUnitario.Enabled = true;
            }
            else
            {
                txtPrecioUnitario.Enabled = false;
                txtPrecioUnitario.Text = "";
            }*/ //esto da error asi que cambie nud por msk
            if (mskCantidad.Text != "")
                txtPrecioUnitario.Enabled = true;
            else
            {
                txtPrecioUnitario.Enabled = false;
                txtPrecioUnitario.Text = "";
            }
        }
        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = (txtPrecioUnitario.Text != "");
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            /*vFecha = dtpFecha.Value;
            vProducto = cmbProducto.Text;
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            vPrecioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            lblResultado.Text = "vFecha"; */ //esto ya no sirve asi que lo comente
            try
            {
                Venta v = new Venta()
                {
                    Fecha = dtpFecha.Value,
                    Producto = cmbProducto.Text,
                    Cantidad = Convert.ToInt32(mskCantidad.Text),
                    PrecioUnitario = Convert.ToInt32(txtPrecioUnitario.Text)
                };

                ventas.Add(v);
                lstVentas.Items.Add(v.ToString());
                // Guardar en el archivo
                using (StreamWriter sw = new StreamWriter("registro_de_ventas.txt", true))
                {
                    sw.WriteLine($"{v.Fecha.ToShortDateString()},{v.Producto},{v.Cantidad},{v.PrecioUnitario}");
                }
                MessageBox.Show("Venta registrada con éxito:\n\n" +
                    $"Fecha: {v.Fecha.ToShortDateString()}\n" +
                    $"Producto: {v.Producto}\n" +
                    $"Cantidad: {v.Cantidad}\n" +
                    $"Precio Unitario: ${v.PrecioUnitario:N2}",
                    "Registro Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Limpiar controles
                dtpFecha.Value = DateTime.Now;
                cmbProducto.SelectedIndex = -1;
                mskCantidad.Text = "";
                txtPrecioUnitario.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            cmbProducto.SelectedIndex = -1;
            mskCantidad.Text = "";
            txtPrecioUnitario.Text = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstVentas.SelectedIndex != -1)
            {
                int indice = lstVentas.SelectedIndex;
                // eliminar de la lista en memoria y del ListBox
                ventas.RemoveAt(indice);
                lstVentas.Items.RemoveAt(indice);
                // reescribir todo el archivo con los registros actuales
                using (StreamWriter sw = new StreamWriter("registro_de_ventas.txt"))
                {
                    foreach (Venta v in ventas)
                    {
                        sw.WriteLine($"{v.Fecha.ToShortDateString()},{v.Producto},{v.Cantidad},{v.PrecioUnitario}");
                    }
                }
                MessageBox.Show("Registro eliminado correctamente.",
                    "Eliminación Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}