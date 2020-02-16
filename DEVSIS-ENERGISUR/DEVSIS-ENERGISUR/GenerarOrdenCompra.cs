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

        public void limpiarCampos()
        {
            textBoxNombreProveedor.Text = "";
            text_Numero_orden.Text = "";
            comboBox1.Text = "";
            
            try {

                DataSet dt = new DataSet();
                dataGridView1.DataSource = dt;
                dt.Clear();
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo limpiar la tabla " + e);
            }
            
        }
        controlOrdenCompra co = new controlOrdenCompra();

        public GenerarOrdenCompra()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            productos tabla_productos = new productos(this.text_Numero_orden.Text, this);
            tabla_productos.Visible = true;
            String numOrden = this.text_Numero_orden.Text;
            String razonSocial = this.textBoxNombreProveedor.Text;
            String fecha = this.dateTimePicker1.Text;
            String estado = this.comboBox1.Text;
            controlOrdenCompra co = new controlOrdenCompra();
            co.RregistrarOrdenCompra(numOrden, fecha, estado, razonSocial);

        }

        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.co.ProductosDetalle(this.text_Numero_orden.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }

        private void bt_generar_orden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orden de compra generada y almacenada correctamente");
            limpiarCampos();

        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Visible = false;
            menu.Visible = true;
            controlOrdenCompra co = new controlOrdenCompra();
            String numero = this.text_Numero_orden.Text;
            co.elimarDetalleCompra();
            co.elimarOrdenCompra(numero);
            MessageBox.Show("Orden de compra cancelada");

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            controlOrdenCompra co = new controlOrdenCompra();
            String numero = this.text_Numero_orden.Text;
            co.elimarDetalleCompra();
            co.elimarOrdenCompra(numero);
            MessageBox.Show("Orden de compra cancelada");
            
        }
    }
}
