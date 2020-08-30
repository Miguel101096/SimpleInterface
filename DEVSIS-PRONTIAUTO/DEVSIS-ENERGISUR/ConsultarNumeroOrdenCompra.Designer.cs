namespace DEVSIS_ENERGISUR
{
    partial class ConsultarNumeroOrdenCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.labelConsultarProveedor = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.text_Numero_orden = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelOrdenCompra = new System.Windows.Forms.Label();
            this.textBoxNombreProveedor = new System.Windows.Forms.TextBox();
            this.textBoxestado = new System.Windows.Forms.TextBox();
            this.textBoxfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(688, 183);
            this.dataGridView1.TabIndex = 69;
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(539, 418);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(247, 22);
            this.botonConsultar.TabIndex = 66;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // labelConsultarProveedor
            // 
            this.labelConsultarProveedor.AutoSize = true;
            this.labelConsultarProveedor.Location = new System.Drawing.Point(359, 9);
            this.labelConsultarProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsultarProveedor.Name = "labelConsultarProveedor";
            this.labelConsultarProveedor.Size = new System.Drawing.Size(134, 13);
            this.labelConsultarProveedor.TabIndex = 65;
            this.labelConsultarProveedor.Text = "Consultar orden de compra";
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(30, 418);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(247, 22);
            this.botonRegresar.TabIndex = 70;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // text_Numero_orden
            // 
            this.text_Numero_orden.Location = new System.Drawing.Point(154, 50);
            this.text_Numero_orden.Name = "text_Numero_orden";
            this.text_Numero_orden.Size = new System.Drawing.Size(247, 20);
            this.text_Numero_orden.TabIndex = 78;
            this.text_Numero_orden.Leave += new System.EventHandler(this.text_Numero_orden_Leave);
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(13, 86);
            this.labelRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(119, 13);
            this.labelRazonSocial.TabIndex = 77;
            this.labelRazonSocial.Text = "Razón social proveedor";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(11, 153);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 74;
            this.labelFecha.Text = "Fecha";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(11, 116);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 73;
            this.labelEstado.Text = "Estado";
            // 
            // labelOrdenCompra
            // 
            this.labelOrdenCompra.AutoSize = true;
            this.labelOrdenCompra.Location = new System.Drawing.Point(11, 53);
            this.labelOrdenCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrdenCompra.Name = "labelOrdenCompra";
            this.labelOrdenCompra.Size = new System.Drawing.Size(142, 13);
            this.labelOrdenCompra.TabIndex = 72;
            this.labelOrdenCompra.Text = "Número de orden de compra";
            // 
            // textBoxNombreProveedor
            // 
            this.textBoxNombreProveedor.Enabled = false;
            this.textBoxNombreProveedor.Location = new System.Drawing.Point(154, 83);
            this.textBoxNombreProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            this.textBoxNombreProveedor.Size = new System.Drawing.Size(248, 20);
            this.textBoxNombreProveedor.TabIndex = 71;
            // 
            // textBoxestado
            // 
            this.textBoxestado.Enabled = false;
            this.textBoxestado.Location = new System.Drawing.Point(154, 116);
            this.textBoxestado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxestado.Name = "textBoxestado";
            this.textBoxestado.Size = new System.Drawing.Size(248, 20);
            this.textBoxestado.TabIndex = 79;
            // 
            // textBoxfecha
            // 
            this.textBoxfecha.Enabled = false;
            this.textBoxfecha.Location = new System.Drawing.Point(153, 146);
            this.textBoxfecha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxfecha.Name = "textBoxfecha";
            this.textBoxfecha.Size = new System.Drawing.Size(248, 20);
            this.textBoxfecha.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Detalle de productos";
            // 
            // ConsultarNumeroOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxfecha);
            this.Controls.Add(this.textBoxestado);
            this.Controls.Add(this.text_Numero_orden);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelOrdenCompra);
            this.Controls.Add(this.textBoxNombreProveedor);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.labelConsultarProveedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarNumeroOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarNumeroOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Label labelConsultarProveedor;
        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.TextBox text_Numero_orden;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelOrdenCompra;
        private System.Windows.Forms.TextBox textBoxNombreProveedor;
        private System.Windows.Forms.TextBox textBoxestado;
        private System.Windows.Forms.TextBox textBoxfecha;
        private System.Windows.Forms.Label label1;
    }
}