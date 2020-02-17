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
    public partial class ConsultarFechaFinOrdenCompra : Form
    {
        private consultarordencompra coc = new consultarordencompra();
        public ConsultarFechaFinOrdenCompra()
        {
            InitializeComponent();
        }
        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.coc.consultarfechaexpedicion(dateTimePicker1.Value.ToString());
                if (dataGridView1.Rows[0].Cells[0].Value.ToString() == "")
                    MessageBox.Show("No exitsen registros", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("No exitsen registros" + error);
            }
        }
        private void botonRegresar_Click(object sender, EventArgs e)
        {
            //new MenuPrincipal().Show();
            //this.Visible = false;
            this.Close();
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
    }
}
