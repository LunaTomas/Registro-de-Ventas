namespace pyrLunaRegistroDeVentasGUI
{
    partial class frmRegistroDeVentasDeHardware
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dtpFecha = new DateTimePicker();
            lstProducto = new ComboBox();
            txtCantidad = new MaskedTextBox();
            txtPrecioUnitario = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15.75F);
            lblFecha.Location = new Point(21, 22);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(67, 30);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 15.75F);
            lblProducto.Location = new Point(21, 66);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(97, 30);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 15.75F);
            lblCantidad.Location = new Point(21, 107);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(96, 30);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 15.75F);
            lblPrecioUnitario.Location = new Point(21, 148);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(147, 30);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Font = new Font("Segoe UI", 15.75F);
            btnAceptar.Location = new Point(443, 184);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(114, 35);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F);
            btnCancelar.Location = new Point(323, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 15.75F);
            dtpFecha.Location = new Point(174, 17);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(383, 35);
            dtpFecha.TabIndex = 1;
            dtpFecha.ValueChanged += this.dtpFecha_ValueChanged;
            // 
            // lstProducto
            // 
            lstProducto.Font = new Font("Segoe UI", 15.75F);
            lstProducto.FormattingEnabled = true;
            lstProducto.Location = new Point(174, 58);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(383, 38);
            lstProducto.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 15.75F);
            txtCantidad.HidePromptOnLeave = true;
            txtCantidad.Location = new Point(174, 102);
            txtCantidad.Mask = "99999";
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PromptChar = ' ';
            txtCantidad.Size = new Size(383, 35);
            txtCantidad.TabIndex = 3;
            txtCantidad.MaskInputRejected += this.txtCantidad_MaskInputRejected;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Enabled = false;
            txtPrecioUnitario.Font = new Font("Segoe UI", 15.75F);
            txtPrecioUnitario.HidePromptOnLeave = true;
            txtPrecioUnitario.Location = new Point(174, 143);
            txtPrecioUnitario.Mask = "99999";
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.PromptChar = ' ';
            txtPrecioUnitario.Size = new Size(383, 35);
            txtPrecioUnitario.TabIndex = 4;
            // 
            // frmRegistroDeVentasDeHardware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 237);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidad);
            Controls.Add(lstProducto);
            Controls.Add(dtpFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmRegistroDeVentasDeHardware";
            Text = "Registro de ventas de hardware";
            Load += this.frmRegistroDeVentasDeHardware_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private Button btnAceptar;
        private Button btnCancelar;
        private DateTimePicker dtpFecha;
        private ComboBox lstProducto;
        private MaskedTextBox txtCantidad;
        private MaskedTextBox txtPrecioUnitario;

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que desees ejecutar cuando cambie la fecha
        }

        private void txtCantidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Aquí puedes agregar la lógica que desees ejecutar cuando la entrada de la máscara sea rechazada
        }

        private void frmRegistroDeVentasDeHardware_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que desees ejecutar cuando se cargue el formulario
        }
    }
}
