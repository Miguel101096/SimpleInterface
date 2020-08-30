using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DEVSIS_ENERGISUR.control
{
    class controlProveedor
    {

        private Conexion c;

        public controlProveedor() { }

        ~controlProveedor() { }

        public String existeProveedor (String valor, String Parametro)
        {
            DataTable DT = new DataTable();
            String aux = "";
            try
            {
                this.c = new Conexion();
                if (Parametro == "RUC") {
                    DT = c.ejecutarSQL("EXECUTE existe_Proveedor_RUC '" + valor + "'").Tables[0];
                }
                else if (Parametro == "Razon")
                {
                    DT = c.ejecutarSQL("EXECUTE existe_Proveedor_RazonSocial '" + valor + "'").Tables[0];                   
                }
                else if (Parametro == "correo")
                {
                    DT = c.ejecutarSQL("EXECUTE existe_Proveedor_Correo '" + valor + "'").Tables[0];
                }
                else if (Parametro == "convencional")
                {
                    DT = c.ejecutarSQL("EXECUTE existe_Proveedor_TelfConv '" + valor + "'").Tables[0];
                }
                else if (Parametro == "celular")
                {
                    DT = c.ejecutarSQL("EXECUTE existe_Proveedor_TelfCel '" + valor + "'").Tables[0];
                }

                aux = Convert.ToString(DT.Rows[0].ItemArray[0]);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar Presupuesto: " + error);
            }
            return aux;
        }




        public String valor(String parametro) {

            String DT = c.ejecutarSQL("select RUC from PROVEEDOR where '" + parametro + "' not in (select RUC from PROVEEDOR)").ToString();
            return "";
        }
        


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

        public DataTable Proveedores_RUC(String RUC)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("EXECUTE consulta_proveedor_RUC '" + RUC + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar proveedor por su RUC: " + error);
            }
            return DT;
        }

        public DataTable Proveedores_RazonSocial(String razonSocial)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("EXECUTE consulta_proveedor_RazonSocial '" + razonSocial + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar proveedor por su Razon Social: " + error);
            }
            return DT;
        }

        public DataTable Proveedores_Correo(String correo)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();

                DT = this.c.ejecutarSQL("EXECUTE consulta_proveedor_Correo '" + correo + "'").Tables[0];

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar proveedor por su Correo: " + error);
            }
            return DT;
        }

        public DataTable Proveedores_Convencional(String telfconve)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("EXECUTE consulta_proveedor_Convencional '" + telfconve + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar proveedor por su Correo: " + error);
            }
            return DT;
        }

        public DataTable Proveedores_Ceularl(String telfconve)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("EXECUTE consulta_proveedor_Celular '" + telfconve + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar proveedor por su Correo: " + error);
            }
            return DT;
        }

        public void EliminarProveedor(String RUC)
        {
            try
            {
                this.c = new Conexion();
                c.ejecutarSQL("EXECUTE eliminar_Proveedor '" + RUC + "'");
                MessageBox.Show("Proveedor Eliminado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar nuevo proveedor: " + error);
            }
        }


    }
}
