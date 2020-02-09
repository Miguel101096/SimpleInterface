namespace DEVSIS_ENERGISUR
{
    partial class ConsultarNombreProveedor
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
            this.textNombreProveedor = new System.Windows.Forms.TextBox();
            this.labelNombreProveedor = new System.Windows.Forms.Label();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.labelConsultarProveedor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombreProveedor
            // 
            this.textNombreProveedor.Location = new System.Drawing.Point(241, 40);
            this.textNombreProveedor.Name = "textNombreProveedor";
            this.textNombreProveedor.Size = new System.Drawing.Size(329, 22);
            this.textNombreProveedor.TabIndex = 63;
            // 
            // labelNombreProveedor
            // 
            this.labelNombreProveedor.AutoSize = true;
            this.labelNombreProveedor.Location = new System.Drawing.Point(12, 40);
            this.labelNombreProveedor.Name = "labelNombreProveedor";
            this.labelNombreProveedor.Size = new System.Drawing.Size(150, 17);
            this.labelNombreProveedor.TabIndex = 54;
            this.labelNombreProveedor.Text = "Nombre del proveedor";
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(241, 514);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(329, 27);
            this.botonConsultar.TabIndex = 53;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            // 
            // labelConsultarProveedor
            // 
            this.labelConsultarProveedor.AutoSize = true;
            this.labelConsultarProveedor.Location = new System.Drawing.Point(200, 11);
            this.labelConsultarProveedor.Name = "labelConsultarProveedor";
            this.labelConsultarProveedor.Size = new System.Drawing.Size(137, 17);
            this.labelConsultarProveedor.TabIndex = 50;
            this.labelConsultarProveedor.Text = "Consultar proveedor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 400);
            this.dataGridView1.TabIndex = 64;
            // 
            // ConsultarNombreProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNombreProveedor);
            this.Controls.Add(this.labelNombreProveedor);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.labelConsultarProveedor);
            this.Name = "ConsultarNombreProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarNombreProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombreProveedor;
        private System.Windows.Forms.Label labelNombreProveedor;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Label labelConsultarProveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}