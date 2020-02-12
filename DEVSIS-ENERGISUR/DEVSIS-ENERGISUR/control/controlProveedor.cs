using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR.control
{
    class controlProveedor
    {

        private Conexion c;

        public controlProveedor() { }

        ~controlProveedor() { }

        public void RregistrarProveedor(String RUC, String razons, String direcc, String correo, String telfconv, String telfcel)
        {
            try
            {
                this.c = new Conexion();
                c.ejecutarSQL("EXECUTE Ingresar_Proveedor '" + RUC + "', '" + razons + "', '"
                    + direcc + "', '" + correo + "', '" + telfconv + "', '" + telfcel + "'");
                MessageBox.Show("Proveedor registrado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al ingresar nuevo proveedor: " + error);
            }
        }
    }
}
