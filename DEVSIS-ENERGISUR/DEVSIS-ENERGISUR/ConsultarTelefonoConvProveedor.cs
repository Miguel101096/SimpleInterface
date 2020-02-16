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

namespace DEVSIS_ENERGISUR
{
    public partial class ConsultarTelefonoConvProveedor : Form
    {
        static Validaciones v = new Validaciones();

        public ConsultarTelefonoConvProveedor()
        {
            InitializeComponent();
        }

        private void textNumeroConvencionalProveedor_Leave(object sender, EventArgs e)
        {
            if (v.validarNumeros(textNumeroConvencionalProveedor.Text))
            {

            }
            else
            {
                if (textNumeroConvencionalProveedor.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textNumeroConvencionalProveedor.TextLength < 9)
                    {
                        MessageBox.Show("Teléfono convencional incompleto");
                    }
                    else
                    {
                        MessageBox.Show("Teléfono convencional incorrecto");
                    }
                }
            }
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }
    }
}
