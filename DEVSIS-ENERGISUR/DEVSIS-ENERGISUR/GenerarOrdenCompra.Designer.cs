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
            this.labelOrdenCompra = new System.Windows.Forms.Label();
            this.textBoxNombreProveedor = new System.Windows.Forms.TextBox();
            this.labelGenerarFactura = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.text_Numero_orden = new System.Windows.Forms.TextBox();
            this.bt_generar_orden = new System.Windows.Forms.Button();
            this.bt_regresar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrecioTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerarOrdenCompra
            // 
            this.buttonGenerarOrdenCompra.Location = new System.Drawing.Point(481, 651);
            this.buttonGenerarOrdenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerarOrdenCompra.Name = "buttonGenerarOrdenCompra";
            this.buttonGenerarOrdenCompra.Size = new System.Drawing.Size(247, 19);
            this.buttonGenerarOrdenCompra.TabIndex = 32;
            this.buttonGenerarOrdenCompra.Text = "Generar orden de compra";
            this.buttonGenerarOrdenCompra.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 224);
            this.dataGridView1.TabIndex = 31;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(152, 170);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(247, 19);
            this.buttonBuscar.TabIndex = 30;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 129);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(9, 135);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 26;
            this.labelFecha.Text = "Fecha";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(9, 98);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 22;
            this.labelEstado.Text = "Estado";
            // 
            // labelOrdenCompra
            // 
            this.labelOrdenCompra.AutoSize = true;
            this.labelOrdenCompra.Location = new System.Drawing.Point(9, 35);
            this.labelOrdenCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrdenCompra.Name = "labelOrdenCompra";
            this.labelOrdenCompra.Size = new System.Drawing.Size(142, 13);
            this.labelOrdenCompra.TabIndex = 20;
            this.labelOrdenCompra.Text = "Número de orden de compra";
            // 
            // textBoxNombreProveedor
            // 
            this.textBoxNombreProveedor.Location = new System.Drawing.Point(152, 65);
            this.textBoxNombreProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            this.textBoxNombreProveedor.Size = new System.Drawing.Size(248, 20);
            this.textBoxNombreProveedor.TabIndex = 19;
            // 
            // labelGenerarFactura
            // 
            this.labelGenerarFactura.AutoSize = true;
            this.labelGenerarFactura.Location = new System.Drawing.Point(295, 7);
            this.labelGenerarFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenerarFactura.Name = "labelGenerarFactura";
            this.labelGenerarFactura.Size = new System.Drawing.Size(128, 13);
            this.labelGenerarFactura.TabIndex = 17;
            this.labelGenerarFactura.Text = "Generar orden de compra";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Emitida",
            "Archivada"});
            this.comboBox1.Location = new System.Drawing.Point(152, 98);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(11, 68);
            this.labelRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(84, 13);
            this.labelRazonSocial.TabIndex = 34;
            this.labelRazonSocial.Text = "RUC  proveedor";
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(230, 651);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(247, 19);
            this.botonRegresar.TabIndex = 36;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // text_Numero_orden
            // 
            this.text_Numero_orden.Location = new System.Drawing.Point(152, 32);
            this.text_Numero_orden.Name = "text_Numero_orden";
            this.text_Numero_orden.Size = new System.Drawing.Size(247, 20);
            this.text_Numero_orden.TabIndex = 37;
            // 
            // bt_generar_orden
            // 
            this.bt_generar_orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_generar_orden.Location = new System.Drawing.Point(520, 503);
            this.bt_generar_orden.Name = "bt_generar_orden";
            this.bt_generar_orden.Size = new System.Drawing.Size(174, 23);
            this.bt_generar_orden.TabIndex = 38;
            this.bt_generar_orden.Text = "Generer Orden";
            this.bt_generar_orden.UseVisualStyleBackColor = true;
            this.bt_generar_orden.Click += new System.EventHandler(this.bt_generar_orden_Click);
            // 
            // bt_regresar
            // 
            this.bt_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_regresar.Location = new System.Drawing.Point(68, 503);
            this.bt_regresar.Name = "bt_regresar";
            this.bt_regresar.Size = new System.Drawing.Size(171, 23);
            this.bt_regresar.TabIndex = 39;
            this.bt_regresar.Text = "Regresar";
            this.bt_regresar.UseVisualStyleBackColor = true;
            this.bt_regresar.Click += new System.EventHandler(this.bt_regresar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Location = new System.Drawing.Point(298, 503);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(171, 23);
            this.bt_cancelar.TabIndex = 40;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Precio total";
            // 
            // textPrecioTotal
            // 
            this.textPrecioTotal.Enabled = false;
            this.textPrecioTotal.Location = new System.Drawing.Point(583, 451);
            this.textPrecioTotal.Name = "textPrecioTotal";
            this.textPrecioTotal.Size = new System.Drawing.Size(111, 20);
            this.textPrecioTotal.TabIndex = 42;
            // 
            // GenerarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 550);
            this.Controls.Add(this.textPrecioTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_regresar);
            this.Controls.Add(this.bt_generar_orden);
            this.Controls.Add(this.text_Numero_orden);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonGenerarOrdenCompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelOrdenCompra);
            this.Controls.Add(this.textBoxNombreProveedor);
            this.Controls.Add(this.labelGenerarFactura);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label labelOrdenCompra;
        private System.Windows.Forms.TextBox textBoxNombreProveedor;
        private System.Windows.Forms.Label labelGenerarFactura;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.TextBox text_Numero_orden;
        private System.Windows.Forms.Button bt_generar_orden;
        private System.Windows.Forms.Button bt_regresar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrecioTotal;
    }
}