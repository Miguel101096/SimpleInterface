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
    public partial class productos : Form
    {
       Conexion c = new Conexion();
       controlOrdenCompra co = new controlOrdenCompra();

        public productos()
        {
            InitializeComponent();
            c.getConexion();
            this.cargarTabla();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {

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
