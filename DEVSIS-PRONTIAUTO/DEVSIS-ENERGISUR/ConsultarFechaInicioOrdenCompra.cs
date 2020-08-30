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
    public partial class ConsultarFechaInicioOrdenCompra : Form
    {
        private consultarordencompra coc = new consultarordencompra();
        public ConsultarFechaInicioOrdenCompra()
        {
            InitializeComponent();
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }
        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.coc.consultardosfechas(dateTimefechainicio.Value.ToString(), dateTimefechafin.Value.ToString());
                if (dataGridView1.Rows[0].Cells[0].Value.ToString()=="")
                    MessageBox.Show("No exitsen registros", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("No exitsen registros");
            }
        }
        private void botonConsultar_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
    }
}
