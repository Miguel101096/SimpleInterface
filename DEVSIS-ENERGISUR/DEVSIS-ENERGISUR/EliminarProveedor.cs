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
    public partial class EliminarProveedor : Form
    {
        public EliminarProveedor()
        {
            InitializeComponent();
        }

        public static bool validarNombre(String cadena)
        {
            String rx = "^[a-zA-Z_]+( [a-zA-Z_]+)*$";
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

        public static bool validarDireccion(String cadena)
        {
            String rx = "^[a-zA-Z0-9_\\-]+( [a-zA-Z0-9_]+)*$";
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

        public static bool validarEmail(String cadena)
        {
            String rx = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
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

        public bool RucPersonaNatural(string ruc)
        {
            long isNumeric;
            const int tamanoLongitudRuc = 13;
            const string establecimiento = "001";
            if (long.TryParse(ruc, out isNumeric) && ruc.Length.Equals(tamanoLongitudRuc))
            {
                var numeroProvincia = Convert.ToInt32(string.Concat(ruc[0] + string.Empty, ruc[1] + string.Empty));
                var personaNatural = Convert.ToInt32(ruc[2] + string.Empty);
                if ((numeroProvincia >= 1 && numeroProvincia <= 24) && (personaNatural >= 0 && personaNatural < 6))
                {
                    return ruc.Substring(10, 3) == establecimiento && VerificaCedula(ruc.Substring(0, 10));
                }
                return false;
            }
            return false;
        }

        public bool VerificaCedula(string ced)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincia = 24;
            const int tercerDigito = 6;

            if (int.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincia) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) * Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
                return false;
            }
            return false;
        }

        private void textBoxRuc_Leave(object sender, EventArgs e)
        {
            if (RucPersonaNatural(textBoxRuc.Text))
            {
                if (textBoxRuc.TextLength > 14)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textBoxRazonSocial_Leave_1(object sender, EventArgs e)
        {
            if (validarNombre(textBoxRazonSocial.Text))
            {
                if (textBoxRazonSocial.TextLength > 60)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textBoxMarca_Leave(object sender, EventArgs e)
        {
            if (validarDireccion(textBoxMarca.Text))
            {
                if (textBoxMarca.TextLength > 60)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            if (validarEmail(textBoxCorreo.Text))
            {
                if (textBoxCorreo.TextLength > 60)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textBoxTelefonoConvencional_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textBoxTelefonoConvencional.Text))
            {
                if (textBoxTelefonoConvencional.TextLength > 9)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textBoxTelefonoCelular_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textBoxTelefonoCelular.Text))
            {
                if (textBoxTelefonoCelular.TextLength > 10)
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
