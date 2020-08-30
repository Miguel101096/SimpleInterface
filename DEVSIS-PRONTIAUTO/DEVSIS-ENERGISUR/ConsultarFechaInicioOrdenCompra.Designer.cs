namespace DEVSIS_ENERGISUR
{
    partial class ConsultarFechaInicioOrdenCompra
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
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.labelConsultarFIOrdenCompra = new System.Windows.Forms.Label();
            this.dateTimefechainicio = new System.Windows.Forms.DateTimePicker();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.dateTimefechafin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 325);
            this.dataGridView1.TabIndex = 69;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(36, 32);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(79, 13);
            this.labelFechaInicio.TabIndex = 67;
            this.labelFechaInicio.Text = "Fecha de inicio";
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(546, 418);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(247, 22);
            this.botonConsultar.TabIndex = 66;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // labelConsultarFIOrdenCompra
            // 
            this.labelConsultarFIOrdenCompra.AutoSize = true;
            this.labelConsultarFIOrdenCompra.Location = new System.Drawing.Point(378, 9);
            this.labelConsultarFIOrdenCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsultarFIOrdenCompra.Name = "labelConsultarFIOrdenCompra";
            this.labelConsultarFIOrdenCompra.Size = new System.Drawing.Size(134, 13);
            this.labelConsultarFIOrdenCompra.TabIndex = 65;
            this.labelConsultarFIOrdenCompra.Text = "Consultar orden de compra";
            // 
            // dateTimefechainicio
            // 
            this.dateTimefechainicio.Location = new System.Drawing.Point(141, 32);
            this.dateTimefechainicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimefechainicio.Name = "dateTimefechainicio";
            this.dateTimefechainicio.Size = new System.Drawing.Size(248, 20);
            this.dateTimefechainicio.TabIndex = 70;
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(83, 418);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(247, 22);
            this.botonRegresar.TabIndex = 71;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // dateTimefechafin
            // 
            this.dateTimefechafin.Location = new System.Drawing.Point(559, 32);
            this.dateTimefechafin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimefechafin.Name = "dateTimefechafin";
            this.dateTimefechafin.Size = new System.Drawing.Size(248, 20);
            this.dateTimefechafin.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Fecha de inicio";
            // 
            // ConsultarFechaInicioOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.dateTimefechafin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dateTimefechainicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.labelConsultarFIOrdenCompra);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarFechaInicioOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar orden de compra entre dos fechas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Label labelConsultarFIOrdenCompra;
        private System.Windows.Forms.DateTimePicker dateTimefechainicio;
        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.DateTimePicker dateTimefechafin;
        private System.Windows.Forms.Label label1;
    }
}