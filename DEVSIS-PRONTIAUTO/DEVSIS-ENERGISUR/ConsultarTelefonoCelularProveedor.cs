using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DEVSIS_ENERGISUR.control;

namespace DEVSIS_ENERGISUR
{
    public partial class ConsultarTelefonoCelularProveedor : Form
    {
        MenuPrincipal mp = new MenuPrincipal();
        Conexion c = new Conexion();
        controlProveedor cp = new controlProveedor();
        static Validaciones v = new Validaciones();

        public ConsultarTelefonoCelularProveedor()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void textNumeroCelularProveedor_Leave(object sender, EventArgs e)
        {
            if (v.validarNumeros(textNumeroCelularProveedor.Text))
            {

            }
            else
            {
                if (this.botonRegresar.Focused)
                {
                    this.Visible = false;
                }
                else
                {
                    if (textNumeroCelularProveedor.Text == String.Empty)
                    {
                        MessageBox.Show("Ingrese un valor para la entrada actual");
                    }
                    else
                    {
                        if (textNumeroCelularProveedor.TextLength < 10)
                        {
                            MessageBox.Show("Teléfono celular incompleto");
                        }
                        else
                        {
                            MessageBox.Show("Teléfono celular incorrecto");
                        }
                    }
                }
            }
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            mp.Visible = true;
            this.Visible = false;
        }

        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.cp.Proveedores_Ceularl(this.textNumeroCelularProveedor.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            if (cp.existeProveedor((this.textNumeroCelularProveedor.Text), "celular").Equals("vacio"))
            {
                MessageBox.Show("Proveedor no se encuentra registrado");
                this.textNumeroCelularProveedor.Text = "";
            }
            else
            {
                cargarTabla();
            }
        }
    }
}
