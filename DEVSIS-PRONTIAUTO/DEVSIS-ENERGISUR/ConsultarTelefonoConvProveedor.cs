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
    public partial class ConsultarTelefonoConvProveedor : Form
    {
        Conexion c = new Conexion();
        controlProveedor cp = new controlProveedor();
        static Validaciones v = new Validaciones();
        
        public ConsultarTelefonoConvProveedor()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void textNumeroConvencionalProveedor_Leave(object sender, EventArgs e)
        {
            if (v.validarNumeros(textNumeroConvencionalProveedor.Text))
            {

            }
            else
            {
                if (textNumeroConvencionalProveedor.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textNumeroConvencionalProveedor.TextLength < 9)
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

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.cp.Proveedores_Convencional(this.textNumeroConvencionalProveedor.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }

        private void botonConsultar_Click_1(object sender, EventArgs e)
        {
            if (cp.existeProveedor((this.textNumeroConvencionalProveedor.Text), "convencional").Equals("vacio"))
            {
                MessageBox.Show("Proveedor no se encuentra registrado");
                this.textNumeroConvencionalProveedor.Text = "";
            }
            else
            {
                cargarTabla();
            }
        }
    }
}
