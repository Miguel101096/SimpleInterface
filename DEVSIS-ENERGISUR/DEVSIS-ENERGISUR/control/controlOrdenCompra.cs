using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DEVSIS_ENERGISUR.control
{
    class controlOrdenCompra
    {
        private Conexion c;

        public DataTable traerProductos()
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("EXECUTE traer_productos").Tables[0];
            }
            catch (Exception error)
            {

            }
            return DT;
        }
    }
}
