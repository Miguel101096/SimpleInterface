﻿namespace DEVSIS_ENERGISUR
{
    partial class ConsultarCodigoProducto
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
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelConsultarProducto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(411, 514);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(329, 27);
            this.botonConsultar.TabIndex = 39;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(241, 41);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(329, 22);
            this.textCodigo.TabIndex = 38;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 41);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(132, 17);
            this.labelCodigo.TabIndex = 37;
            this.labelCodigo.Text = "Código de producto";
            // 
            // labelConsultarProducto
            // 
            this.labelConsultarProducto.AutoSize = true;
            this.labelConsultarProducto.Location = new System.Drawing.Point(200, 11);
            this.labelConsultarProducto.Name = "labelConsultarProducto";
            this.labelConsultarProducto.Size = new System.Drawing.Size(128, 17);
            this.labelConsultarProducto.TabIndex = 36;
            this.labelConsultarProducto.Text = "Consultar producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 400);
            this.dataGridView1.TabIndex = 41;
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(76, 514);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(329, 27);
            this.botonRegresar.TabIndex = 42;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // ConsultarCodigoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelConsultarProducto);
            this.Name = "ConsultarCodigoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarCodigoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelConsultarProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonRegresar;
    }
}