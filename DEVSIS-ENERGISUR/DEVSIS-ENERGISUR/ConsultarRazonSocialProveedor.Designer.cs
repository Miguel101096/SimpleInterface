namespace DEVSIS_ENERGISUR
{
    partial class ConsultarRazonSocialProveedor
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
            this.textBoxRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.labelRazonSocialProveedor = new System.Windows.Forms.Label();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.labelConsultarProveedor = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 400);
            this.dataGridView1.TabIndex = 74;
            // 
            // textBoxRazonSocialProveedor
            // 
            this.textBoxRazonSocialProveedor.Location = new System.Drawing.Point(240, 40);
            this.textBoxRazonSocialProveedor.Name = "textBoxRazonSocialProveedor";
            this.textBoxRazonSocialProveedor.Size = new System.Drawing.Size(329, 22);
            this.textBoxRazonSocialProveedor.TabIndex = 73;
            this.textBoxRazonSocialProveedor.Leave += new System.EventHandler(this.textBoxRazonSocialProveedor_Leave);
            // 
            // labelRazonSocialProveedor
            // 
            this.labelRazonSocialProveedor.AutoSize = true;
            this.labelRazonSocialProveedor.Location = new System.Drawing.Point(12, 40);
            this.labelRazonSocialProveedor.Name = "labelRazonSocialProveedor";
            this.labelRazonSocialProveedor.Size = new System.Drawing.Size(181, 17);
            this.labelRazonSocialProveedor.TabIndex = 72;
            this.labelRazonSocialProveedor.Text = "Razón social del proveedor";
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(375, 514);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(329, 27);
            this.botonConsultar.TabIndex = 71;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            // 
            // labelConsultarProveedor
            // 
            this.labelConsultarProveedor.AutoSize = true;
            this.labelConsultarProveedor.Location = new System.Drawing.Point(330, 11);
            this.labelConsultarProveedor.Name = "labelConsultarProveedor";
            this.labelConsultarProveedor.Size = new System.Drawing.Size(137, 17);
            this.labelConsultarProveedor.TabIndex = 70;
            this.labelConsultarProveedor.Text = "Consultar proveedor";
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(40, 514);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(329, 27);
            this.botonRegresar.TabIndex = 75;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // ConsultarRazonSocialProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxRazonSocialProveedor);
            this.Controls.Add(this.labelRazonSocialProveedor);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.labelConsultarProveedor);
            this.Name = "ConsultarRazonSocialProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar por medio de la razón social del proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxRazonSocialProveedor;
        private System.Windows.Forms.Label labelRazonSocialProveedor;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Label labelConsultarProveedor;
        private System.Windows.Forms.Button botonRegresar;
    }
}