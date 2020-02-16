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
    public partial class ConsultarRazonSocialProveedor : Form
    {
        static Validaciones v = new Validaciones();

        public ConsultarRazonSocialProveedor()
        {
            InitializeComponent();
        }

        private void textBoxRazonSocialProveedor_Leave(object sender, EventArgs e)
        {
            if (v.validarNombre(textBoxRazonSocialProveedor.Text))
            {

            }
            else
            {
                if (textBoxRazonSocialProveedor.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if ((textBoxRazonSocialProveedor.TextLength > 50))
                    {
                        MessageBox.Show("La razón social excede el límite de cincuenta caracteres");
                    }
                    else
                    {

                    }

                }
            }
        }
    }
}
