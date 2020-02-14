namespace DEVSIS_ENERGISUR
{
    partial class IngresarProveedor
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
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoConvencional = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelTelefonoConvencional = new System.Windows.Forms.Label();
            this.labelDirección = new System.Windows.Forms.Label();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.textBoxRuc = new System.Windows.Forms.TextBox();
            this.labelRuc = new System.Windows.Forms.Label();
            this.labelIngresarProveedor = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.textBoxTelefonoCelular = new System.Windows.Forms.TextBox();
            this.labelTelefonoCelular = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(181, 98);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(248, 20);
            this.textBoxDireccion.TabIndex = 48;
            this.textBoxDireccion.Leave += new System.EventHandler(this.textMarca_Leave);
            // 
            // textBoxTelefonoConvencional
            // 
            this.textBoxTelefonoConvencional.Location = new System.Drawing.Point(181, 162);
            this.textBoxTelefonoConvencional.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTelefonoConvencional.Name = "textBoxTelefonoConvencional";
            this.textBoxTelefonoConvencional.Size = new System.Drawing.Size(248, 20);
            this.textBoxTelefonoConvencional.TabIndex = 47;
            this.textBoxTelefonoConvencional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefonoConvencional_KeyPress);
            this.textBoxTelefonoConvencional.Leave += new System.EventHandler(this.textTelefonoConvencional_Leave);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(181, 130);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(248, 20);
            this.textBoxCorreo.TabIndex = 46;
            this.textBoxCorreo.Leave += new System.EventHandler(this.textCorreo_Leave);
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(9, 130);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(93, 13);
            this.labelCorreo.TabIndex = 43;
            this.labelCorreo.Text = "Correo electrónico";
            // 
            // labelTelefonoConvencional
            // 
            this.labelTelefonoConvencional.AutoSize = true;
            this.labelTelefonoConvencional.Location = new System.Drawing.Point(9, 162);
            this.labelTelefonoConvencional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefonoConvencional.Name = "labelTelefonoConvencional";
            this.labelTelefonoConvencional.Size = new System.Drawing.Size(116, 13);
            this.labelTelefonoConvencional.TabIndex = 42;
            this.labelTelefonoConvencional.Text = "Teléfono convencional";
            // 
            // labelDirección
            // 
            this.labelDirección.AutoSize = true;
            this.labelDirección.Location = new System.Drawing.Point(9, 98);
            this.labelDirección.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirección.Name = "labelDirección";
            this.labelDirección.Size = new System.Drawing.Size(52, 13);
            this.labelDirección.TabIndex = 41;
            this.labelDirección.Text = "Dirección";
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(207, 418);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(220, 22);
            this.botonIngresar.TabIndex = 39;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            this.botonIngresar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botonIngresar_MouseClick_1);
            // 
            // textBoxRuc
            // 
            this.textBoxRuc.Location = new System.Drawing.Point(181, 33);
            this.textBoxRuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRuc.Name = "textBoxRuc";
            this.textBoxRuc.Size = new System.Drawing.Size(248, 20);
            this.textBoxRuc.TabIndex = 38;
            this.textBoxRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRuc_KeyPress);
            this.textBoxRuc.Leave += new System.EventHandler(this.textRuc_Leave);
            // 
            // labelRuc
            // 
            this.labelRuc.AutoSize = true;
            this.labelRuc.Location = new System.Drawing.Point(9, 33);
            this.labelRuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRuc.Name = "labelRuc";
            this.labelRuc.Size = new System.Drawing.Size(30, 13);
            this.labelRuc.TabIndex = 37;
            this.labelRuc.Text = "RUC";
            // 
            // labelIngresarProveedor
            // 
            this.labelIngresarProveedor.AutoSize = true;
            this.labelIngresarProveedor.Location = new System.Drawing.Point(150, 9);
            this.labelIngresarProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIngresarProveedor.Name = "labelIngresarProveedor";
            this.labelIngresarProveedor.Size = new System.Drawing.Size(96, 13);
            this.labelIngresarProveedor.TabIndex = 36;
            this.labelIngresarProveedor.Text = "Ingresar proveedor";
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(181, 65);
            this.textBoxRazonSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(248, 20);
            this.textBoxRazonSocial.TabIndex = 50;
            this.textBoxRazonSocial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRazonSocial_KeyPress);
            this.textBoxRazonSocial.Leave += new System.EventHandler(this.textBoxRazonSocial_Leave);
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(9, 65);
            this.labelRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.labelRazonSocial.TabIndex = 51;
            this.labelRazonSocial.Text = "Razón social";
            // 
            // textBoxTelefonoCelular
            // 
            this.textBoxTelefonoCelular.Location = new System.Drawing.Point(181, 195);
            this.textBoxTelefonoCelular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTelefonoCelular.Name = "textBoxTelefonoCelular";
            this.textBoxTelefonoCelular.Size = new System.Drawing.Size(248, 20);
            this.textBoxTelefonoCelular.TabIndex = 53;
            this.textBoxTelefonoCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefonoCelular_KeyPress);
            this.textBoxTelefonoCelular.Leave += new System.EventHandler(this.textTelefonoCelular_Leave);
            // 
            // labelTelefonoCelular
            // 
            this.labelTelefonoCelular.AutoSize = true;
            this.labelTelefonoCelular.Location = new System.Drawing.Point(9, 195);
            this.labelTelefonoCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefonoCelular.Name = "labelTelefonoCelular";
            this.labelTelefonoCelular.Size = new System.Drawing.Size(83, 13);
            this.labelTelefonoCelular.TabIndex = 52;
            this.labelTelefonoCelular.Text = "Teléfono celular";
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(9, 418);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(194, 22);
            this.botonRegresar.TabIndex = 69;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // IngresarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 449);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.textBoxTelefonoCelular);
            this.Controls.Add(this.labelTelefonoCelular);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxTelefonoConvencional);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelTelefonoConvencional);
            this.Controls.Add(this.labelDirección);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.textBoxRuc);
            this.Controls.Add(this.labelRuc);
            this.Controls.Add(this.labelIngresarProveedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IngresarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefonoConvencional;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelTelefonoConvencional;
        private System.Windows.Forms.Label labelDirección;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.TextBox textBoxRuc;
        private System.Windows.Forms.Label labelRuc;
        private System.Windows.Forms.Label labelIngresarProveedor;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox textBoxTelefonoCelular;
        private System.Windows.Forms.Label labelTelefonoCelular;
        private System.Windows.Forms.Button botonRegresar;
    }
}