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
    public partial class EliminarProveedor : Form
    {
        Conexion c = new Conexion();
        MenuPrincipal mp = new MenuPrincipal();
        controlProveedor cp = new controlProveedor();
        static Validaciones v = new Validaciones();

        public EliminarProveedor()
        {
            InitializeComponent();
            this.textBoxRazonSocial.Enabled = false;
            this.textBoxCorreo.Enabled = false;
            this.textBoxMarca.Enabled = false;
            this.textBoxTelefonoConvencional.Enabled = false;
            this.textBoxTelefonoCelular.Enabled = false;
            this.botonEliminar.Enabled = false;
        }

        private void textBoxRuc_Leave(object sender, EventArgs e)
        {
            if (v.RucPersonaNatural(textBoxRuc.Text))
            {

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

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            mp.Visible = true;
            this.Visible = false;
        }

        private void textBoxRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1.Focus();
            }
        }

        private void textBoxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxMarca.Focus();
            }
        }

        private void textBoxMarca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTelefonoConvencional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxTelefonoCelular.Focus();
            }
        }

        private void textBoxTelefonoCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                botonEliminar.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = this.cp.Proveedores_RUC(textBoxRuc.Text);
            if (cp.existeProveedor((this.textBoxRuc.Text), "RUC").Equals("vacio"))
            {
                MessageBox.Show("Proveedor no se encuentra registrado");
                this.textBoxRuc.Text = "";
                this.textBoxRuc.Text = "";
                this.textBoxRazonSocial.Text = "";
                this.textBoxMarca.Text = "";
                this.textBoxCorreo.Text = "";
                this.textBoxTelefonoConvencional.Text = "";
                this.textBoxTelefonoCelular.Text = "";
            }
            else {
                this.textBoxRazonSocial.Text = DT.Rows[0].ItemArray[1].ToString();
                this.textBoxMarca.Text = DT.Rows[0].ItemArray[2].ToString();
                this.textBoxCorreo.Text = DT.Rows[0].ItemArray[3].ToString();
                this.textBoxTelefonoConvencional.Text = DT.Rows[0].ItemArray[4].ToString();
                this.textBoxTelefonoCelular.Text = DT.Rows[0].ItemArray[5].ToString();
                this.botonEliminar.Enabled = true;
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar este Proveedor?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.cp.EliminarProveedor(textBoxRuc.Text);
                this.textBoxRuc.Text = "";
                this.textBoxRazonSocial.Text = "";
                this.textBoxMarca.Text = "";
                this.textBoxCorreo.Text = "";
                this.textBoxTelefonoConvencional.Text = "";
                this.textBoxTelefonoCelular.Text = "";
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                botonEliminar.Focus();
            }
        }
    }
}
