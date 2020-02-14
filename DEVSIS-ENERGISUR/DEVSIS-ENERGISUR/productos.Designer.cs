namespace DEVSIS_ENERGISUR
{
    partial class productos
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
            this.bt_regresar = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(429, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_regresar
            // 
            this.bt_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_regresar.Location = new System.Drawing.Point(51, 201);
            this.bt_regresar.Name = "bt_regresar";
            this.bt_regresar.Size = new System.Drawing.Size(146, 28);
            this.bt_regresar.TabIndex = 1;
            this.bt_regresar.Text = "Regresar";
            this.bt_regresar.UseVisualStyleBackColor = true;
            this.bt_regresar.Click += new System.EventHandler(this.bt_regresar_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscar.Location = new System.Drawing.Point(215, 201);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(152, 28);
            this.bt_buscar.TabIndex = 2;
            this.bt_buscar.Text = "Seleccionar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 239);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.bt_regresar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productos";
            this.Text = "productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_regresar;
        private System.Windows.Forms.Button bt_buscar;
    }
}