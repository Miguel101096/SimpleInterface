namespace DEVSIS_ENERGISUR
{
    partial class ConsultarCorreoProveedor
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
            this.textCorreoProveedor = new System.Windows.Forms.TextBox();
            this.labelCorreoProveedor = new System.Windows.Forms.Label();
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
            // textCorreoProveedor
            // 
            this.textCorreoProveedor.Location = new System.Drawing.Point(240, 40);
            this.textCorreoProveedor.Name = "textCorreoProveedor";
            this.textCorreoProveedor.Size = new System.Drawing.Size(329, 22);
            this.textCorreoProveedor.TabIndex = 68;
            this.textCorreoProveedor.Leave += new System.EventHandler(this.textCorreoProveedor_Leave);
            // 
            // labelCorreoProveedor
            // 
            this.labelCorreoProveedor.AutoSize = true;
            this.labelCorreoProveedor.Location = new System.Drawing.Point(12, 40);
            this.labelCorreoProveedor.Name = "labelCorreoProveedor";
            this.labelCorreoProveedor.Size = new System.Drawing.Size(216, 17);
            this.labelCorreoProveedor.TabIndex = 67;
            this.labelCorreoProveedor.Text = "Correo electrónico del proveedor";
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
            // ConsultarCorreoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textCorreoProveedor);
            this.Controls.Add(this.labelCorreoProveedor);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.labelConsultarProveedor);
            this.Name = "ConsultarCorreoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar mediante el correo electrónico del proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textCorreoProveedor;
        private System.Windows.Forms.Label labelCorreoProveedor;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Label labelConsultarProveedor;
    }
}