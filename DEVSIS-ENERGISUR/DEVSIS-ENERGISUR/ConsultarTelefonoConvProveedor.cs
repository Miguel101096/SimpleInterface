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
        public ConsultarTelefonoConvProveedor()
        {
            InitializeComponent();
            cargarTabla();
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
