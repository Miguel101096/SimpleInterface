using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR.control
{
    class consultarordencompra
    {
        private Conexion c;

        public DataTable consultarproductosdetalle(String codcompra)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("EXECUTE consultarordencompra '" + codcompra + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar productos: " + error);
            }
            return DT;
        }
        public DataTable consultardatosorden(String codcompra)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("EXECUTE datosordencompra '" + codcompra + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar productos: " + error);
            }
            return DT;
        }
    }
}

