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
    public partial class ConsultarCorreoProveedor : Form
    {

        Conexion c = new Conexion();
        controlProveedor cp = new controlProveedor();

        public ConsultarCorreoProveedor()
        {
            InitializeComponent();
            cargarTabla();
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

        private void textCorreoProveedor_Leave(object sender, EventArgs e)
        {
            if (validarEmail(textCorreoProveedor.Text))
            {
                if (textCorreoProveedor.TextLength > 60)
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
                this.dataGridView1.DataSource = this.cp.Proveedores_Correo(this.textCorreoProveedor.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            if (cp.existeProveedor((this.textCorreoProveedor.Text), "correo").Equals("vacio"))
            {
                MessageBox.Show("Proveedor no se encuentra registrado");
                this.textCorreoProveedor.Text = "";
            }
            else
            {
                cargarTabla();
            }
        }
    }
}
