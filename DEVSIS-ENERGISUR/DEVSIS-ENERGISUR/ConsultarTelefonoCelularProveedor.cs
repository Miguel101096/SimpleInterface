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
    public partial class ConsultarTelefonoCelularProveedor : Form
    {
        static Validaciones v = new Validaciones();

        public ConsultarTelefonoCelularProveedor()
        {
            InitializeComponent();
        }

        private void textNumeroCelularProveedor_Leave(object sender, EventArgs e)
        {
            if (v.validarNumeros(textNumeroCelularProveedor.Text))
            {

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
}
