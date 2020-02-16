using DEVSIS_ENERGISUR.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class productos : Form
    {
        Conexion c = new Conexion();
        controlOrdenCompra co = new controlOrdenCompra();
        private GenerarOrdenCompra goc;
        private String numorden = "";

        public productos(String numorden, GenerarOrdenCompra goc)
        {
            InitializeComponent();
            c.getConexion();
            this.cargarTabla();
            this.goc = goc;
            this.numorden = numorden;
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            String numprod = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String precio = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            double precionum = Convert.ToDouble(precio);
            String numorden = this.numorden;
            int cant = Convert.ToInt32(this.textCantidad.Text);
            int iddetalle = co.nuevoIDDetalle();
            double preciofinal = co.preciofinal(cant, precionum);

            String result1 = this.co.cambioTipoDecimal(precio);
            String result2 = this.co.cambioTipoDecimal(preciofinal.ToString());

            //MessageBox.Show( result2 +"\n" + result1);
            this.co.agregarProductoOrden(iddetalle, numprod, result1, cant, numorden, result2);
            this.goc.cargarTabla();
            Close();
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cargarTabla()
        {
            this.dataGridView1.DataSource = this.co.traerProductos();
        }
    }
}
