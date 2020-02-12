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
    public partial class IngresarProveedor : Form
    {
        private controlProveedor cp = new controlProveedor();
        Validaciones v = new Validaciones();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxRazonSocial_Leave(object sender, EventArgs e)
        {
            if (validarNombre(textBoxRazonSocial.Text))
            {
                
            }
            else if (textBoxRazonSocial.Text == String.Empty)
            {
                MessageBox.Show("Entrada de razón social vacía");
            }
            else if (textBoxRazonSocial.TextLength > 60)
            {
                MessageBox.Show("La razón social excede el límite de caracteres");
            }
            else
            {
                MessageBox.Show("La razón social no cumple con el formato");
            }
        }

        private void textMarca_Leave(object sender, EventArgs e)
        {
            if (validarDireccion(textBoxDireccion.Text))
            {
                
            }
            else if (textBoxDireccion.Text == String.Empty)
            {
                MessageBox.Show("Entrada de la marca vacía");
            }
            else if (textBoxDireccion.TextLength > 60)
            {
                MessageBox.Show("La marca excede el límite de caracteres");
            }
            else
            {
                MessageBox.Show("La marca no cumple con el formato");
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (validarEmail(textBoxCorreo.Text))
            {
                
            }
            else if (textBoxCorreo.Text == String.Empty)
            {
                MessageBox.Show("Entrada de correo vacía");
            }
            else if (textBoxCorreo.TextLength > 60)
            {
                MessageBox.Show("El correo excede el límite de caracteres");
            }
            else
            {
                MessageBox.Show("El correo no cumple con el formato");
            }
        }

        private void textTelefonoConvencional_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textBoxTelefonoConvencional.Text))
            {
                
            }
            else if (textBoxTelefonoConvencional.Text == String.Empty)
            {
                MessageBox.Show("Entrada de teléfono convencional vacía");
            }
            else if (textBoxTelefonoConvencional.TextLength < 9)
            {
                MessageBox.Show("Teléfono convencional incompleto");
            }
            else
            {
                MessageBox.Show("Telefono convencional no cumple con el formato");
            }
        }

        private void textTelefonoCelular_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textBoxTelefonoCelular.Text))
            {
                
            }
            else if (textBoxTelefonoCelular.Text == String.Empty)
            {
                MessageBox.Show("Entrada de teléfono celular vacía");
            }
            else if (textBoxTelefonoCelular.TextLength < 10)
            {
                MessageBox.Show("Teléfono celular incompleto");
            }
            else
            {
                MessageBox.Show("Telefono celular no cumple con el formato");
            }
        }

        private void textRuc_Leave(object sender, EventArgs e)
        {
            if (RucPersonaNatural(textBoxRuc.Text))
            {
                
            }
            else if (textBoxRuc.Text == String.Empty)
            {
                MessageBox.Show("Entrada de RUC vacía");
            }
            else if (textBoxRuc.TextLength < 13)
            {
                MessageBox.Show("Número de RUC incompleto");
            }
            else
            {
                MessageBox.Show("Número de RUC no valido");
            }
        }


        private void botonIngresar_MouseClick_1(object sender, MouseEventArgs e)
        {
            String ruc = this.textBoxRuc.Text;
            String razonSocial = this.textBoxRazonSocial.Text;
            String direccion = this.textBoxDireccion.Text;
            String correo = this.textBoxCorreo.Text;
            String telfconv = this.textBoxTelefonoConvencional.Text;
            String telfCel = this.textBoxTelefonoCelular.Text;
            controlProveedor cp = new controlProveedor();
            cp.RregistrarProveedor(ruc, razonSocial, direccion, correo, telfconv, telfCel);
        }

        private void textBoxRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        private void textBoxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Nombres(e);
        }
    }
}
