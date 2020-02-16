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
    public partial class ConsultarTelefonoCelularProveedor : Form
    {
        Conexion c = new Conexion();
        controlProveedor cp = new controlProveedor();

        public ConsultarTelefonoCelularProveedor()
        {
            InitializeComponent();
            cargarTabla();
        }

        public static bool validarNumeros(String cadena)
        {
            String rx = "^[0-9]{10}$";
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

        private void textNumeroCelularProveedor_Leave(object sender, EventArgs e)
        {
            if (validarNumeros(textNumeroCelularProveedor.Text))
            {
                if (textNumeroCelularProveedor.TextLength > 10)
                {
                    MessageBox.Show("Formato incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.cp.Proveedores_Ceularl(this.textNumeroCelularProveedor.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            if (cp.existeProveedor((this.textNumeroCelularProveedor.Text), "celular").Equals("vacio"))
            {
                MessageBox.Show("Proveedor no se encuentra registrado");
                this.textNumeroCelularProveedor.Text = "";
            }
            else
            {
                cargarTabla();
            }
        }
    }
}
