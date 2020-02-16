namespace DEVSIS_ENERGISUR
{
    partial class GenerarOrdenCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerarOrdenCompra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelNumeroCuenta = new System.Windows.Forms.Label();
            this.labelOrdenCompra = new System.Windows.Forms.Label();
            this.textBoxNombreProveedor = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelGenerarFactura = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.botonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerarOrdenCompra
            // 
            this.buttonGenerarOrdenCompra.Location = new System.Drawing.Point(641, 801);
            this.buttonGenerarOrdenCompra.Name = "buttonGenerarOrdenCompra";
            this.buttonGenerarOrdenCompra.Size = new System.Drawing.Size(329, 23);
            this.buttonGenerarOrdenCompra.TabIndex = 32;
            this.buttonGenerarOrdenCompra.Text = "Generar orden de compra";
            this.buttonGenerarOrdenCompra.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 474);
            this.dataGridView1.TabIndex = 31;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(203, 240);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(329, 23);
            this.buttonBuscar.TabIndex = 30;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(12, 200);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(47, 17);
            this.labelFecha.TabIndex = 26;
            this.labelFecha.Text = "Fecha";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(12, 120);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(52, 17);
            this.labelEstado.TabIndex = 22;
            this.labelEstado.Text = "Estado";
            // 
            // labelNumeroCuenta
            // 
            this.labelNumeroCuenta.AutoSize = true;
            this.labelNumeroCuenta.Location = new System.Drawing.Point(200, 40);
            this.labelNumeroCuenta.Name = "labelNumeroCuenta";
            this.labelNumeroCuenta.Size = new System.Drawing.Size(16, 17);
            this.labelNumeroCuenta.TabIndex = 21;
            this.labelNumeroCuenta.Text = "1";
            // 
            // labelOrdenCompra
            // 
            this.labelOrdenCompra.AutoSize = true;
            this.labelOrdenCompra.Location = new System.Drawing.Point(12, 40);
            this.labelOrdenCompra.Name = "labelOrdenCompra";
            this.labelOrdenCompra.Size = new System.Drawing.Size(190, 17);
            this.labelOrdenCompra.TabIndex = 20;
            this.labelOrdenCompra.Text = "Número de orden de compra";
            // 
            // textBoxNombreProveedor
            // 
            this.textBoxNombreProveedor.Location = new System.Drawing.Point(203, 80);
            this.textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            this.textBoxNombreProveedor.Size = new System.Drawing.Size(329, 22);
            this.textBoxNombreProveedor.TabIndex = 19;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 80);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(150, 17);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Nombre del proveedor";
            // 
            // labelGenerarFactura
            // 
            this.labelGenerarFactura.AutoSize = true;
            this.labelGenerarFactura.Location = new System.Drawing.Point(393, 9);
            this.labelGenerarFactura.Name = "labelGenerarFactura";
            this.labelGenerarFactura.Size = new System.Drawing.Size(173, 17);
            this.labelGenerarFactura.TabIndex = 17;
            this.labelGenerarFactura.Text = "Generar orden de compra";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox1.Location = new System.Drawing.Point(203, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(12, 160);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(158, 17);
            this.labelRazonSocial.TabIndex = 34;
            this.labelRazonSocial.Text = "Razón social proveedor";
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(203, 160);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(329, 22);
            this.textBoxRazonSocial.TabIndex = 35;
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(306, 801);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(329, 23);
            this.botonRegresar.TabIndex = 36;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // GenerarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 833);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonGenerarOrdenCompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelNumeroCuenta);
            this.Controls.Add(this.labelOrdenCompra);
            this.Controls.Add(this.textBoxNombreProveedor);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelGenerarFactura);
            this.Name = "GenerarOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar orden de compra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarOrdenCompra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelNumeroCuenta;
        private System.Windows.Forms.Label labelOrdenCompra;
        private System.Windows.Forms.TextBox textBoxNombreProveedor;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelGenerarFactura;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Button botonRegresar;
    }
}