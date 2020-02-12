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
    public partial class IngresarProveedor : Form
    {
        public IngresarProveedor()
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

        //public bool RucPersonaNatural(string ruc)
        //{
        //    long isNumeric;
        //    const int tamanoLongitudRuc = 13;
        //    const string establecimiento = "001";
        //    if (long.TryParse(ruc, out isNumeric) && ruc.Length.Equals(tamanoLongitudRuc))
        //    {
        //        var numeroProvincia = Convert.ToInt32(string.Concat(ruc[0] + string.Empty, ruc[1] + string.Empty));
        //        var personaNatural = Convert.ToInt32(ruc[2] + string.Empty);
        //        if ((numeroProvincia >= 1 && numeroProvincia <= 24) && (personaNatural >= 0 && personaNatural < 6))
        //        {
        //            return ruc.Substring(10, 3) == establecimiento && VerificaCedula(ruc.Substring(0, 10));
        //        }
        //        return false;
        //    }
        //    return false;
        //}

        //public String MetodoValidarCI(String strCedula)
        //{
        //    //boolean correctCI=true;

        //    int[] coefValCedula = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
        //    try
        //    {
        //        int verificador = Integer.parseInt(strCedula.substring(9, 10));
        //    }
        //    catch (Exception e)
        //    {
        //        mensaje = "cedula Incorrecta\n";
        //    }
        //    try
        //    {
        //        int verificador = Integer.parseInt(strCedula.substring(9, 10));
        //        int suma = 0;
        //        int digito = 0;
        //        for (int i = 0; i < (strCedula.length() - 1); i++)
        //        {
        //            digito = Integer.parseInt(strCedula.substring(i, i + 1)) * coefValCedula[i];
        //            suma += ((digito % 10) + (digito / 10));
        //        }

        //        if (!((10 - (suma % 10)) == verificador))
        //        {
        //            mensaje = "La cedula no es ecuatoriana\n";
        //        }
        //        if (((10 - (suma % 10)) == verificador))
        //        {
        //            mensaje = "";
        //        }
        //    }
        //    catch (Exception e) { }
        //    return mensaje;
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxRazonSocial_Leave(object sender, EventArgs e)
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

        private void textMarca_Leave(object sender, EventArgs e)
        {
            if (validarDireccion(textMarca.Text))
            {
                if (textMarca.TextLength > 60)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (validarEmail(textCorreo.Text))
            {
                if (textCorreo.TextLength > 60)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textTelefonoConvencional_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textTelefonoConvencional.Text))
            {
                if (textTelefonoConvencional.TextLength > 9)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void textTelefonoCelular_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textTelefonoCelular.Text))
            {
                if (textTelefonoCelular.TextLength > 10)
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
