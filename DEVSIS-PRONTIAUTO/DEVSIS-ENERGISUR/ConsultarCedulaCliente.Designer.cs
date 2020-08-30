namespace DEVSIS_ENERGISUR
{
    partial class ConsultarCedulaCliente
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
            this.textCedula = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelConsultarCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(430, 514);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(329, 27);
            this.botonConsultar.TabIndex = 39;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(241, 41);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(329, 22);
            this.textCedula.TabIndex = 38;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 41);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(145, 17);
            this.labelCodigo.TabIndex = 37;
            this.labelCodigo.Text = "Cédula de ciudadanía";
            // 
            // labelConsultarCliente
            // 
            this.labelConsultarCliente.AutoSize = true;
            this.labelConsultarCliente.Location = new System.Drawing.Point(150, 11);
            this.labelConsultarCliente.Name = "labelConsultarCliente";
            this.labelConsultarCliente.Size = new System.Drawing.Size(221, 17);
            this.labelConsultarCliente.TabIndex = 36;
            this.labelConsultarCliente.Text = "Consultar cliente mediante cédula";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 400);
            this.dataGridView1.TabIndex = 40;
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(95, 514);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(329, 27);
            this.botonRegresar.TabIndex = 41;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // ConsultarCedulaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelConsultarCliente);
            this.Name = "ConsultarCedulaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta mediante cédula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelConsultarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonRegresar;
    }
}