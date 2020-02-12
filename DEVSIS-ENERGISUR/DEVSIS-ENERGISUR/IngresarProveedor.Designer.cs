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
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textTelefonoConvencional = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelTelefonoConvencional = new System.Windows.Forms.Label();
            this.labelDirección = new System.Windows.Forms.Label();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.textRuc = new System.Windows.Forms.TextBox();
            this.labelRuc = new System.Windows.Forms.Label();
            this.labelIngresarProveedor = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.textTelefonoCelular = new System.Windows.Forms.TextBox();
            this.labelTelefonoCelular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(241, 120);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(329, 22);
            this.textMarca.TabIndex = 48;
            this.textMarca.Leave += new System.EventHandler(this.textMarca_Leave);
            // 
            // textTelefonoConvencional
            // 
            this.textTelefonoConvencional.Location = new System.Drawing.Point(241, 200);
            this.textTelefonoConvencional.Name = "textTelefonoConvencional";
            this.textTelefonoConvencional.Size = new System.Drawing.Size(329, 22);
            this.textTelefonoConvencional.TabIndex = 47;
            this.textTelefonoConvencional.Leave += new System.EventHandler(this.textTelefonoConvencional_Leave);
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(241, 160);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(329, 22);
            this.textCorreo.TabIndex = 46;
            this.textCorreo.Leave += new System.EventHandler(this.textCorreo_Leave);
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(12, 160);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(124, 17);
            this.labelCorreo.TabIndex = 43;
            this.labelCorreo.Text = "Correo electrónico";
            // 
            // labelTelefonoConvencional
            // 
            this.labelTelefonoConvencional.AutoSize = true;
            this.labelTelefonoConvencional.Location = new System.Drawing.Point(12, 200);
            this.labelTelefonoConvencional.Name = "labelTelefonoConvencional";
            this.labelTelefonoConvencional.Size = new System.Drawing.Size(151, 17);
            this.labelTelefonoConvencional.TabIndex = 42;
            this.labelTelefonoConvencional.Text = "Teléfono convencional";
            // 
            // labelDirección
            // 
            this.labelDirección.AutoSize = true;
            this.labelDirección.Location = new System.Drawing.Point(12, 120);
            this.labelDirección.Name = "labelDirección";
            this.labelDirección.Size = new System.Drawing.Size(67, 17);
            this.labelDirección.TabIndex = 41;
            this.labelDirección.Text = "Dirección";
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(241, 514);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(329, 27);
            this.botonIngresar.TabIndex = 39;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            // 
            // textRuc
            // 
            this.textRuc.Location = new System.Drawing.Point(241, 41);
            this.textRuc.Name = "textRuc";
            this.textRuc.Size = new System.Drawing.Size(329, 22);
            this.textRuc.TabIndex = 38;
            this.textRuc.Leave += new System.EventHandler(this.textRuc_Leave);
            // 
            // labelRuc
            // 
            this.labelRuc.AutoSize = true;
            this.labelRuc.Location = new System.Drawing.Point(12, 41);
            this.labelRuc.Name = "labelRuc";
            this.labelRuc.Size = new System.Drawing.Size(37, 17);
            this.labelRuc.TabIndex = 37;
            this.labelRuc.Text = "RUC";
            // 
            // labelIngresarProveedor
            // 
            this.labelIngresarProveedor.AutoSize = true;
            this.labelIngresarProveedor.Location = new System.Drawing.Point(200, 11);
            this.labelIngresarProveedor.Name = "labelIngresarProveedor";
            this.labelIngresarProveedor.Size = new System.Drawing.Size(129, 17);
            this.labelIngresarProveedor.TabIndex = 36;
            this.labelIngresarProveedor.Text = "Ingresar proveedor";
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(241, 80);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(329, 22);
            this.textBoxRazonSocial.TabIndex = 50;
            this.textBoxRazonSocial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxRazonSocial.Leave += new System.EventHandler(this.textBoxRazonSocial_Leave);
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(12, 80);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(89, 17);
            this.labelRazonSocial.TabIndex = 51;
            this.labelRazonSocial.Text = "Razón social";
            // 
            // textTelefonoCelular
            // 
            this.textTelefonoCelular.Location = new System.Drawing.Point(241, 240);
            this.textTelefonoCelular.Name = "textTelefonoCelular";
            this.textTelefonoCelular.Size = new System.Drawing.Size(329, 22);
            this.textTelefonoCelular.TabIndex = 53;
            this.textTelefonoCelular.Leave += new System.EventHandler(this.textTelefonoCelular_Leave);
            // 
            // labelTelefonoCelular
            // 
            this.labelTelefonoCelular.AutoSize = true;
            this.labelTelefonoCelular.Location = new System.Drawing.Point(12, 240);
            this.labelTelefonoCelular.Name = "labelTelefonoCelular";
            this.labelTelefonoCelular.Size = new System.Drawing.Size(110, 17);
            this.labelTelefonoCelular.TabIndex = 52;
            this.labelTelefonoCelular.Text = "Teléfono celular";
            // 
            // IngresarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.textTelefonoCelular);
            this.Controls.Add(this.labelTelefonoCelular);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textTelefonoConvencional);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelTelefonoConvencional);
            this.Controls.Add(this.labelDirección);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.textRuc);
            this.Controls.Add(this.labelRuc);
            this.Controls.Add(this.labelIngresarProveedor);
            this.Name = "IngresarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textTelefonoConvencional;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelTelefonoConvencional;
        private System.Windows.Forms.Label labelDirección;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.TextBox textRuc;
        private System.Windows.Forms.Label labelRuc;
        private System.Windows.Forms.Label labelIngresarProveedor;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox textTelefonoCelular;
        private System.Windows.Forms.Label labelTelefonoCelular;
    }
}