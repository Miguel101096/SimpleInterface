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
        public ConsultarRazonSocialProveedor()
        {
            InitializeComponent();
            cargarTabla();
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

        private void textBoxRazonSocialProveedor_Leave(object sender, EventArgs e)
        {
            if (validarNombre(textBoxRazonSocialProveedor.Text))
            {
                if (textBoxRazonSocialProveedor.TextLength > 60)
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
                this.dataGridView1.DataSource = this.cp.Proveedores_RazonSocial(this.textBoxRazonSocialProveedor.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {

            /*if (this.cp.provedorRegistro("Razon"))
            {
                cargarTabla();
            }
            else {
                MessageBox.Show("Proveedor no Registrado");
            } */
            //cargarTabla();
            cargarTabla();
            
            
        }
    }
}
