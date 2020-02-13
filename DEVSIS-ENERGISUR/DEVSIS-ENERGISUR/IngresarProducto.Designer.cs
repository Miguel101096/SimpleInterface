namespace DEVSIS_ENERGISUR
{
    partial class IngresarProducto
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
            this.labelIngresarProducto = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelVoltaje = new System.Windows.Forms.Label();
            this.labelAmperaje = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textAmperaje = new System.Windows.Forms.TextBox();
            this.textVoltaje = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textNombreProducto = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelGarantía = new System.Windows.Forms.Label();
            this.textBoxGarantia = new System.Windows.Forms.TextBox();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIngresarProducto
            // 
            this.labelIngresarProducto.AutoSize = true;
            this.labelIngresarProducto.Location = new System.Drawing.Point(200, 10);
            this.labelIngresarProducto.Name = "labelIngresarProducto";
            this.labelIngresarProducto.Size = new System.Drawing.Size(120, 17);
            this.labelIngresarProducto.TabIndex = 0;
            this.labelIngresarProducto.Text = "Ingresar producto";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 40);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(132, 17);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Código de producto";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(241, 40);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(329, 22);
            this.textCodigo.TabIndex = 2;
            this.textCodigo.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            this.textCodigo.Leave += new System.EventHandler(this.textCodigo_Leave);
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(274, 513);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(296, 27);
            this.botonIngresar.TabIndex = 3;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del producto";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(12, 120);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(47, 17);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(12, 160);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(36, 17);
            this.labelTipo.TabIndex = 6;
            this.labelTipo.Text = "Tipo";
            // 
            // labelVoltaje
            // 
            this.labelVoltaje.AutoSize = true;
            this.labelVoltaje.Location = new System.Drawing.Point(12, 200);
            this.labelVoltaje.Name = "labelVoltaje";
            this.labelVoltaje.Size = new System.Drawing.Size(51, 17);
            this.labelVoltaje.TabIndex = 7;
            this.labelVoltaje.Text = "Voltaje";
            // 
            // labelAmperaje
            // 
            this.labelAmperaje.AutoSize = true;
            this.labelAmperaje.Location = new System.Drawing.Point(12, 240);
            this.labelAmperaje.Name = "labelAmperaje";
            this.labelAmperaje.Size = new System.Drawing.Size(68, 17);
            this.labelAmperaje.TabIndex = 8;
            this.labelAmperaje.Text = "Amperaje";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(12, 280);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(103, 17);
            this.labelCantidad.TabIndex = 9;
            this.labelCantidad.Text = "Cantidad inicial";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(12, 320);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(48, 17);
            this.labelPrecio.TabIndex = 10;
            this.labelPrecio.Text = "Precio";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(241, 320);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(329, 22);
            this.textPrecio.TabIndex = 11;
            this.textPrecio.Leave += new System.EventHandler(this.textPrecio_Leave);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(241, 280);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(329, 22);
            this.textCantidad.TabIndex = 12;
            this.textCantidad.TextChanged += new System.EventHandler(this.textCantidad_TextChanged);
            this.textCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidad_KeyPress);
            // 
            // textAmperaje
            // 
            this.textAmperaje.Location = new System.Drawing.Point(241, 240);
            this.textAmperaje.Name = "textAmperaje";
            this.textAmperaje.Size = new System.Drawing.Size(329, 22);
            this.textAmperaje.TabIndex = 13;
            this.textAmperaje.TextChanged += new System.EventHandler(this.textAmperaje_TextChanged);
            this.textAmperaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmperaje_KeyPress);
            this.textAmperaje.Leave += new System.EventHandler(this.textAmperaje_Leave);
            // 
            // textVoltaje
            // 
            this.textVoltaje.Location = new System.Drawing.Point(241, 200);
            this.textVoltaje.Name = "textVoltaje";
            this.textVoltaje.Size = new System.Drawing.Size(329, 22);
            this.textVoltaje.TabIndex = 14;
            this.textVoltaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVoltaje_KeyPress);
            this.textVoltaje.Leave += new System.EventHandler(this.textVoltaje_Leave);
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(241, 120);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(329, 22);
            this.textMarca.TabIndex = 16;
            this.textMarca.Leave += new System.EventHandler(this.textMarca_Leave);
            // 
            // textNombreProducto
            // 
            this.textNombreProducto.Location = new System.Drawing.Point(241, 80);
            this.textNombreProducto.Name = "textNombreProducto";
            this.textNombreProducto.Size = new System.Drawing.Size(329, 22);
            this.textNombreProducto.TabIndex = 17;
            this.textNombreProducto.TextChanged += new System.EventHandler(this.textNombreProducto_TextChanged);
            this.textNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreProducto_KeyPress);
            this.textNombreProducto.Leave += new System.EventHandler(this.textNombreProducto_Leave);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Sellado",
            "No Sellado"});
            this.comboBoxTipo.Location = new System.Drawing.Point(241, 160);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(329, 24);
            this.comboBoxTipo.TabIndex = 37;
            this.comboBoxTipo.Text = "Tipo";
            // 
            // labelGarantía
            // 
            this.labelGarantía.AutoSize = true;
            this.labelGarantía.Location = new System.Drawing.Point(12, 360);
            this.labelGarantía.Name = "labelGarantía";
            this.labelGarantía.Size = new System.Drawing.Size(217, 17);
            this.labelGarantía.TabIndex = 38;
            this.labelGarantía.Text = "Número de garantía del producto";
            // 
            // textBoxGarantia
            // 
            this.textBoxGarantia.Location = new System.Drawing.Point(241, 360);
            this.textBoxGarantia.Name = "textBoxGarantia";
            this.textBoxGarantia.Size = new System.Drawing.Size(329, 22);
            this.textBoxGarantia.TabIndex = 39;
            this.textBoxGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGarantia_KeyPress);
            this.textBoxGarantia.Leave += new System.EventHandler(this.textBoxGarantia_Leave);
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(15, 513);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(253, 28);
            this.botonRegresar.TabIndex = 40;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            // 
            // IngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.textBoxGarantia);
            this.Controls.Add(this.labelGarantía);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textNombreProducto);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textVoltaje);
            this.Controls.Add(this.textAmperaje);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelAmperaje);
            this.Controls.Add(this.labelVoltaje);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelIngresarProducto);
            this.Name = "IngresarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIngresarProducto;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelVoltaje;
        private System.Windows.Forms.Label labelAmperaje;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textAmperaje;
        private System.Windows.Forms.TextBox textVoltaje;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textNombreProducto;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label labelGarantía;
        private System.Windows.Forms.TextBox textBoxGarantia;
        private System.Windows.Forms.Button botonRegresar;
    }
}