using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEVSIS_ENERGISUR.control;

namespace DEVSIS_ENERGISUR
{
    public partial class ModificarOrdenCompra : Form
    {
        MenuPrincipal mp = new MenuPrincipal();
        controlOrdenCompra co = new controlOrdenCompra();
        public ModificarOrdenCompra()
        {
            InitializeComponent();
            this.textBoxProveedor.Enabled = false;
            //this.textBoxNumOrden.Enabled = false;
            this.textBoxFecha.Enabled = false;
            
        }

        private void buttonConsultar_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.textBoxNumOrden.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un valor para la entrada actual");
            }
            else
            {

                if (co.OrdenExiste(this.textBoxNumOrden.Text).Equals("vacio")) {
                    MessageBox.Show("La orden de compra no se encuentra registrada");
                }
                else {
                    DataTable DT = new DataTable();
                    DT = co.ConsultarOrdenModificar(this.textBoxNumOrden.Text);
                    this.textBoxFecha.Text = DT.Rows[0].ItemArray[1].ToString();
                    this.textBoxProveedor.Text = DT.Rows[0].ItemArray[3].ToString();
                }

            }
               
        }    

        private void botonRegresar_MouseClick(object sender, MouseEventArgs e)
        {
            mp.Visible = true;
            this.Visible = false;
        }

        private void botonModificar_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.textBoxNumOrden.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un valor para la entrada actual");
            }
            else
            {
                String estado = this.comboBox1.Text;
                String nunm = this.textBoxNumOrden.Text;
                co.ModificarORden(estado, nunm);
                MessageBox.Show("La Orden de Compra ha sido modificada con éxito");
                this.textBoxProveedor.Text = "";
                this.textBoxNumOrden.Text = "";
                this.textBoxFecha.Text = "";
                this.comboBox1.Text = "";
            }
            
        }
    }
}

