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
        public ConsultarTelefonoConvProveedor()
        {
            InitializeComponent();
        }

        public static bool validarNumeros(String cadena)
        {
            String rx = "^[0-9]+$";
            if (Regex.IsMatch(cadena, rx))
            {
                if (Regex.Replace(cadena, rx, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void textNumeroConvencionalProveedor_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textNumeroConvencionalProveedor.Text))
            {
                if (textNumeroConvencionalProveedor.TextLength > 9)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }
    }
}
