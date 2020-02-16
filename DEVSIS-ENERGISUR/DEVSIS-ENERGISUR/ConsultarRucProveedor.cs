using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class ConsultarRucProveedor : Form
    {
        static Validaciones v = new Validaciones();

        public ConsultarRucProveedor()
        {
            InitializeComponent();
        }

        private void textRuc_Leave(object sender, EventArgs e)
        {
            if (v.RucPersonaNatural(textRuc.Text))
            {

            }
            else
            {
                if (textRuc.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un valor para la entrada actual");
                }
                else
                {
                    if (textRuc.TextLength < 13)
                    {
                        MessageBox.Show("Número de RUC incompleto");
                    }
                    else
                    {
                        MessageBox.Show("RUC incorrecto");
                    }
                }
            }
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }
    }
}
