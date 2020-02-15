using DEVSIS_ENERGISUR.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DEVSIS_ENERGISUR
{
    public partial class GenerarOrdenCompra : Form
    {

        controlOrdenCompra co = new controlOrdenCompra();

        public GenerarOrdenCompra()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            productos tabla_productos = new productos(this.textBox1.Text, this);
            tabla_productos.Visible = true;
            
        }

        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.co.ProductosDetalle(this.textBox1.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }
    }
}
