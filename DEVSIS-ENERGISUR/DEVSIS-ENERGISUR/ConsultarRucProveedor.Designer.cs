namespace DEVSIS_ENERGISUR
{
    partial class ConsultarRucProveedor
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
            this.botonConsultar = new System.Windows.Forms.Button();
            this.textRuc = new System.Windows.Forms.TextBox();
            this.labelRuc = new System.Windows.Forms.Label();
            this.labelConsultarProveedor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(281, 418);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(247, 22);
            this.botonConsultar.TabIndex = 39;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // textRuc
            // 
            this.textRuc.Location = new System.Drawing.Point(181, 33);
            this.textRuc.Margin = new System.Windows.Forms.Padding(2);
            this.textRuc.Name = "textRuc";
            this.textRuc.Size = new System.Drawing.Size(248, 20);
            this.textRuc.TabIndex = 38;
            this.textRuc.Leave += new System.EventHandler(this.textRuc_Leave);
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
            // labelConsultarProveedor
            // 
            this.labelConsultarProveedor.AutoSize = true;
            this.labelConsultarProveedor.Location = new System.Drawing.Point(150, 9);
            this.labelConsultarProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsultarProveedor.Name = "labelConsultarProveedor";
            this.labelConsultarProveedor.Size = new System.Drawing.Size(102, 13);
            this.labelConsultarProveedor.TabIndex = 36;
            this.labelConsultarProveedor.Text = "Consultar proveedor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 325);
            this.dataGridView1.TabIndex = 61;
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(30, 418);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(247, 22);
            this.botonRegresar.TabIndex = 62;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // ConsultarRucProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.textRuc);
            this.Controls.Add(this.labelRuc);
            this.Controls.Add(this.labelConsultarProveedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarRucProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.TextBox textRuc;
        private System.Windows.Forms.Label labelRuc;
        private System.Windows.Forms.Label labelConsultarProveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonRegresar;
    }
}