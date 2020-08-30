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
    public partial class ConsultarRazonSocialProveedor : Form
    {
        Conexion c = new Conexion();
        controlProveedor cp = new controlProveedor();
        static Validaciones v = new Validaciones();


        public ConsultarRazonSocialProveedor()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void textBoxRazonSocialProveedor_Leave(object sender, EventArgs e)
        {
            if (v.validarNombre(textBoxRazonSocialProveedor.Text))
            {

            }
            else
            {
                if (this.botonRegresar.Focused)
                {
                    this.Visible = false;
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

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.cp.Proveedores_RazonSocial(this.textBoxRazonSocialProveedor.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            if (cp.existeProveedor((this.textBoxRazonSocialProveedor.Text), "Razon").Equals("vacio"))
            {
                MessageBox.Show("Proveedor no se encuentra registrado");
                this.textBoxRazonSocialProveedor.Text = "";
            }
            else {
                cargarTabla();
            }
            
        }
    }
}
