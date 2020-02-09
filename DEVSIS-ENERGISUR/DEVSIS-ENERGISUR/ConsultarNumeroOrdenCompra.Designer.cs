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
            this.textNumeroOrden = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.labelConsultarProveedor = new System.Windows.Forms.Label();
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
            this.dataGridView1.TabIndex = 69;
            // 
            // textNumeroOrden
            // 
            this.textNumeroOrden.Location = new System.Drawing.Point(240, 40);
            this.textNumeroOrden.Name = "textNumeroOrden";
            this.textNumeroOrden.Size = new System.Drawing.Size(329, 22);
            this.textNumeroOrden.TabIndex = 68;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(12, 40);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(190, 17);
            this.labelNumero.TabIndex = 67;
            this.labelNumero.Text = "Número de orden de compra";
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(240, 514);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(329, 27);
            this.botonConsultar.TabIndex = 66;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            // 
            // labelConsultarProveedor
            // 
            this.labelConsultarProveedor.AutoSize = true;
            this.labelConsultarProveedor.Location = new System.Drawing.Point(265, 11);
            this.labelConsultarProveedor.Name = "labelConsultarProveedor";
            this.labelConsultarProveedor.Size = new System.Drawing.Size(137, 17);
            this.labelConsultarProveedor.TabIndex = 65;
            this.labelConsultarProveedor.Text = "Consultar proveedor";
            // 
            // ConsultarNumeroOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNumeroOrden);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.labelConsultarProveedor);
            this.Name = "ConsultarNumeroOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarNumeroOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textNumeroOrden;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Label labelConsultarProveedor;
    }
}