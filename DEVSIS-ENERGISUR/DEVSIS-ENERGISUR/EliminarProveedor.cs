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
        static Validaciones v = new Validaciones();

        public EliminarProveedor()
        {
            InitializeComponent();
        }

        private void textBoxRuc_Leave(object sender, EventArgs e)
        {
            if (v.RucPersonaNatural(textBoxRuc.Text))
            {

            }
            else
            {
                if (textBoxRuc.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textBoxRuc.TextLength < 13)
                    {
                        MessageBox.Show("Número de RUC incompleto");
                    }
                    else
                    {
                        MessageBox.Show("RUC incorrecto");
                        textBoxTelefonoCelular.Enabled = false;
                        textBoxTelefonoConvencional.Enabled = false;
                        textBoxRazonSocial.Enabled = false;
                        textBoxCorreo.Enabled = false;
                        textBoxMarca.Enabled = false;
                    }
                }
            }
        }

        private void textBoxRazonSocial_Leave_1(object sender, EventArgs e)
        {
            if (v.validarNombre(textBoxRazonSocial.Text))
            {

            }
            else
            {
                if (textBoxRazonSocial.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if ((textBoxRazonSocial.TextLength > 50))
                    {
                        MessageBox.Show("La razón social excede el límite de cincuenta caracteres");
                    }
                    else
                    {

                    }

                }
            }
            
        }

        private void textBoxMarca_Leave(object sender, EventArgs e)
        {
            if (v.validarDireccion(textBoxMarca.Text))
            {

            }
            else
            {
                if (textBoxMarca.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textBoxMarca.TextLength > 60)
                    {
                        MessageBox.Show("La dirección excede el límite de caracteres");
                    }
                    else
                    {
                        MessageBox.Show("Dirección incorrecta");
                    }
                }
            }
        }

        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            if (v.validarEmail(textBoxCorreo.Text))
            {

            }
            else
            {
                if (textBoxCorreo.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textBoxCorreo.TextLength > 60)
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

        private void textBoxTelefonoConvencional_Leave(object sender, EventArgs e)
        {
            if (v.validarNumeros(textBoxTelefonoConvencional.Text))
            {

            }
            else
            {
                if (textBoxTelefonoConvencional.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textBoxTelefonoConvencional.TextLength < 9)
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

        private void textBoxTelefonoCelular_Leave(object sender, EventArgs e)
        {
            if (v.validarNumeros(textBoxTelefonoCelular.Text))
            {

            }
            else
            {
                if (textBoxTelefonoCelular.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textBoxTelefonoCelular.TextLength < 10)
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
