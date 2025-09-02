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
            btnRegistrar = new Button();
            btnCancelar = new Button();
            dtpFecha = new DateTimePicker();
            cmbProducto = new ComboBox();
            txtPrecioUnitario = new MaskedTextBox();
            nudCantidad = new NumericUpDown();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15.75F);
            lblFecha.Location = new Point(21, 22);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(67, 30);
            lblFecha.TabIndex = 1;
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
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Segoe UI", 15.75F);
            btnRegistrar.Location = new Point(443, 184);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(114, 35);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F);
            btnCancelar.Location = new Point(323, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 15.75F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(174, 17);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(383, 35);
            dtpFecha.TabIndex = 2;
            // 
            // cmbProducto
            // 
            cmbProducto.Font = new Font("Segoe UI", 15.75F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(174, 58);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(383, 38);
            cmbProducto.TabIndex = 3;
            cmbProducto.TextChanged += lstProducto_TextChanged;
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
            txtPrecioUnitario.TabIndex = 5;
            txtPrecioUnitario.TextChanged += txtPrecioUnitario_TextChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Font = new Font("Segoe UI", 16F);
            nudCantidad.Location = new Point(174, 101);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(383, 36);
            nudCantidad.TabIndex = 4;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(21, 222);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(536, 167);
            lblResultado.TabIndex = 8;
            // 
            // frmRegistroDeVentasDeHardware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 398);
            Controls.Add(lblResultado);
            Controls.Add(nudCantidad);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(cmbProducto);
            Controls.Add(dtpFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmRegistroDeVentasDeHardware";
            Text = "Registro de ventas de hardware";
            Load += frmRegistroDeVentasDeHardware_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private Button btnRegistrar;
        private Button btnCancelar;
        private DateTimePicker dtpFecha;
        private ComboBox cmbProducto;
        private MaskedTextBox txtPrecioUnitario;
        private NumericUpDown nudCantidad;
        private Label lblResultado;
    }
}
