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
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            productos tabla_productos = new productos();
            tabla_productos.Visible = true;
            
        }
    }
}
