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
        MenuPrincipal mp = new MenuPrincipal();
        private controlProveedor cp = new controlProveedor();
        static Validaciones v = new Validaciones();


        public IngresarProveedor()
        {
            InitializeComponent();

        }

       private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRuc_Leave(object sender, EventArgs e)
        {
            if (v.RucPersonaNatural(textBoxRuc.Text))
            {
                if (!cp.existeProveedor((this.textBoxRuc.Text), "RUC").Equals("vacio"))
                {
                    MessageBox.Show("Proveedor ya se encuentra registrado");
                    return;
                }
            }
            else
            {
                if (this.botonRegresar.Focused)
                {
                    this.Visible = false;
                    mp.Visible = true;
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
                            textBoxTelefonoCelular.Enabled = false;
                            textBoxTelefonoConvencional.Enabled = false;
                            textBoxRazonSocial.Enabled = false;
                            textBoxCorreo.Enabled = false;
                            textBoxDireccion.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("RUC incorrecto");
                        }
                    }
                }
            }
        }

        private void textBoxRazonSocial_Leave(object sender, EventArgs e)
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

        private void textMarca_Leave(object sender, EventArgs e)
        {
            if (v.validarDireccion(textBoxDireccion.Text))
            {

            }
            else
            {
                if (textBoxDireccion.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textBoxDireccion.TextLength > 60)
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

        private void textCorreo_Leave(object sender, EventArgs e)
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

        private void textTelefonoConvencional_Leave(object sender, EventArgs e)
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

        private void textTelefonoCelular_Leave(object sender, EventArgs e)
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

        private void botonIngresar_MouseClick_1(object sender, MouseEventArgs e)
        {
            String ruc = this.textBoxRuc.Text;
            String razonSocial = this.textBoxRazonSocial.Text;
            String direccion = this.textBoxDireccion.Text;
            String correo = this.textBoxCorreo.Text;
            String telfconv = this.textBoxTelefonoConvencional.Text;
            String telfCel = this.textBoxTelefonoCelular.Text;
            controlProveedor cp = new controlProveedor();
            if (cp.existeProveedor((this.textBoxRuc.Text), "RUC").Equals("vacio")) {
                cp.RregistrarProveedor(ruc, razonSocial, direccion, correo, telfconv, telfCel);
                //MessageBox.Show("Proveedor registrado correctamente");
                textBoxCorreo.Text = "";
                textBoxRazonSocial.Text = "";
                textBoxDireccion.Text = "";
                textBoxRuc.Text = "";
                textBoxTelefonoCelular.Text = "";
                textBoxTelefonoConvencional.Text = "";
            } 
            else {
                MessageBox.Show("Proveedor ya se encuentra registrado");
            }
            
        }

        private void textBoxRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxRazonSocial.Focus();
            }
        }

        private void textBoxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Nombres(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxDireccion.Focus();
            }
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            mp.Visible = true;
            this.Visible = false;
        }

        private void textBoxTelefonoConvencional_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxTelefonoCelular.Focus();
            }
        }

        private void textBoxTelefonoCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                botonIngresar.Focus();
            }
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxCorreo.Focus();
            }
        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxTelefonoConvencional.Focus();
            }
        }
    }
}
