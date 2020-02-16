using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEVSIS_ENERGISUR.control;

namespace DEVSIS_ENERGISUR
{
    public partial class ConsultarRucProveedor : Form
    {
        MenuPrincipal mp = new MenuPrincipal();
        Conexion c = new Conexion();
        controlProveedor cp = new controlProveedor();
        static Validaciones v = new Validaciones();

        public ConsultarRucProveedor()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void textRuc_Leave(object sender, EventArgs e)
        {
            if (v.RucPersonaNatural(textRuc.Text))
            {

            }
            else
            {
                if (this.botonRegresar.Focused)
                {
                    this.Visible = false;
                }
                else {
                    if (textRuc.Text == String.Empty)
                    {
                        MessageBox.Show("Ingrese un valor para la entrada actual");
                    }
                    else
                    {
                        if (textRuc.TextLength > 60)
                        {
                            MessageBox.Show("El RUC excede el límite de caracteres");
                        }
                        else
                        {
                            MessageBox.Show("RUC incorrecto");
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
                this.dataGridView1.DataSource = this.cp.Proveedores_RUC(this.textRuc.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error: " + error);
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            if (cp.existeProveedor((this.textRuc.Text), "RUC").Equals("vacio"))
            {
                MessageBox.Show("Proveedor no se encuentra registrado");
                this.textRuc.Text = "";
            }
            else
            {
                cargarTabla();
            }
        }
    }
}
