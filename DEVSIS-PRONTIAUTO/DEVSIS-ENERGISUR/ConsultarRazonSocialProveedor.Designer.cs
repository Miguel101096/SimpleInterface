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
            this.dataGridView1.Location = new System.Drawing.Point(30, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 325);
            this.dataGridView1.TabIndex = 74;
            // 
            // textBoxRazonSocialProveedor
            // 
            this.textBoxRazonSocialProveedor.Location = new System.Drawing.Point(180, 32);
            this.textBoxRazonSocialProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRazonSocialProveedor.Name = "textBoxRazonSocialProveedor";
            this.textBoxRazonSocialProveedor.Size = new System.Drawing.Size(248, 20);
            this.textBoxRazonSocialProveedor.TabIndex = 73;
            this.textBoxRazonSocialProveedor.Leave += new System.EventHandler(this.textBoxRazonSocialProveedor_Leave);
            // 
            // labelRazonSocialProveedor
            // 
            this.labelRazonSocialProveedor.AutoSize = true;
            this.labelRazonSocialProveedor.Location = new System.Drawing.Point(9, 32);
            this.labelRazonSocialProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRazonSocialProveedor.Name = "labelRazonSocialProveedor";
            this.labelRazonSocialProveedor.Size = new System.Drawing.Size(136, 13);
            this.labelRazonSocialProveedor.TabIndex = 72;
            this.labelRazonSocialProveedor.Text = "Razón social del proveedor";
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(281, 418);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(247, 22);
            this.botonConsultar.TabIndex = 71;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // labelConsultarProveedor
            // 
            this.labelConsultarProveedor.AutoSize = true;
            this.labelConsultarProveedor.Location = new System.Drawing.Point(248, 9);
            this.labelConsultarProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsultarProveedor.Name = "labelConsultarProveedor";
            this.labelConsultarProveedor.Size = new System.Drawing.Size(102, 13);
            this.labelConsultarProveedor.TabIndex = 70;
            this.labelConsultarProveedor.Text = "Consultar proveedor";
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(30, 418);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(247, 22);
            this.botonRegresar.TabIndex = 75;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // ConsultarRazonSocialProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxRazonSocialProveedor);
            this.Controls.Add(this.labelRazonSocialProveedor);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.labelConsultarProveedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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