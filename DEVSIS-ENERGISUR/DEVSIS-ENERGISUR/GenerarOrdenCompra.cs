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
            textPrecioTotal.Text = "";
            
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
            cargarnumeroOrden();
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
            precioTotalOrden();
        }


        
        public void precioTotalOrden()
        {
            double precioTotal = 0.0;
            for (int i =0; i < dataGridView1.RowCount -1; i++)
            {
                precioTotal += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                String precio = Convert.ToString(precioTotal);
                textPrecioTotal.Text = precio;
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

        private void botonRegresar_Click(object sender, EventArgs e)
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

        public void cargarnumeroOrden()
        {
            DataTable DT = new DataTable();
            DT = this.co.traernumorden();
            String numorden = Convert.ToString(DT.Rows[0].ItemArray[0]);
            int num = 1 + Convert.ToInt32(numorden);
            String ordennueva = Convert.ToString(num);
            String final = "";
            for (int i = 0; i < (6 - ordennueva.Length); i++)
            {
                final = final + "0";
            }
            final = final + ordennueva;
            this.text_Numero_orden.Text = final;
            this.text_Numero_orden.Enabled = false;
            //MessageBox.Show("" + final + "");
        }
    }
}
