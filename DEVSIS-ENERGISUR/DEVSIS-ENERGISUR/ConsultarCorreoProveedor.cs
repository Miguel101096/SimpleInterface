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
    public partial class ConsultarCorreoProveedor : Form
    {
        public ConsultarCorreoProveedor()
        {
            InitializeComponent();
        }

        static Validaciones v = new Validaciones();

        private void textCorreoProveedor_Leave(object sender, EventArgs e)
        {
            if (v.validarEmail(textCorreoProveedor.Text))
            {

            }
            else
            {
                if (textCorreoProveedor.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textCorreoProveedor.TextLength > 60)
                    {
                        MessageBox.Show("El correo excede el límite de caracteres");
                    }
                    else
                    {
                        MessageBox.Show("Correo electrónico incorrecto");
                    }
                }
            }
        }
    }
}
