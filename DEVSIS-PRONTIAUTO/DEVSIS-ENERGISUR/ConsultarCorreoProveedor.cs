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
        MenuPrincipal mp = new MenuPrincipal();
        Conexion c = new Conexion();
        controlProveedor cp = new controlProveedor();

        public ConsultarCorreoProveedor()
        {
            InitializeComponent();
            cargarTabla();
        }

        static Validaciones v = new Validaciones();

        private void textCorreoProveedor_Leave(object sender, EventArgs e)
        {
            if (v.validarEmail(textCorreoProveedor.Text))
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
                    if (textCorreoProveedor.Text == String.Empty)
                    {
                        MessageBox.Show("Ingrese un valor para la entrada actual");
                    }
                    else
                    {
                        if (textCorreoProveedor.TextLength > 60)
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
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            mp.Visible = true;
            this.Visible = false;
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
