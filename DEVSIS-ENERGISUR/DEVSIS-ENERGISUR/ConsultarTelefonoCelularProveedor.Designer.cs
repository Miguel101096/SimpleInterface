namespace DEVSIS_ENERGISUR
{
    partial class ConsultarTelefonoCelularProveedor
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
            this.textNumeroCelularProveedor = new System.Windows.Forms.TextBox();
            this.labelNumeroTelefonoCelular = new System.Windows.Forms.Label();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.labelConsultarProveedor = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 325);
            this.dataGridView1.TabIndex = 74;
            // 
            // textNumeroCelularProveedor
            // 
            this.textNumeroCelularProveedor.Location = new System.Drawing.Point(229, 32);
            this.textNumeroCelularProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNumeroCelularProveedor.Name = "textNumeroCelularProveedor";
            this.textNumeroCelularProveedor.Size = new System.Drawing.Size(248, 20);
            this.textNumeroCelularProveedor.TabIndex = 73;
            this.textNumeroCelularProveedor.Leave += new System.EventHandler(this.textNumeroCelularProveedor_Leave);
            // 
            // labelNumeroTelefonoCelular
            // 
            this.labelNumeroTelefonoCelular.AutoSize = true;
            this.labelNumeroTelefonoCelular.Location = new System.Drawing.Point(9, 32);
            this.labelNumeroTelefonoCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroTelefonoCelular.Name = "labelNumeroTelefonoCelular";
            this.labelNumeroTelefonoCelular.Size = new System.Drawing.Size(134, 13);
            this.labelNumeroTelefonoCelular.TabIndex = 72;
            this.labelNumeroTelefonoCelular.Text = "Número de teléfono celular";
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
            // ConsultarTelefonoCelularProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNumeroCelularProveedor);
            this.Controls.Add(this.labelNumeroTelefonoCelular);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.labelConsultarProveedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarTelefonoCelularProveedor";
            this.Text = "Consultar mediante el teléfono celular del proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textNumeroCelularProveedor;
        private System.Windows.Forms.Label labelNumeroTelefonoCelular;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Label labelConsultarProveedor;
        private System.Windows.Forms.Button botonRegresar;
    }
}