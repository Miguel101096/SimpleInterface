using System;
using System.Collections.Generic;
using System.Data;
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

        /*public Boolean provedorRegistro(String parametro) {
            Boolean bandera = true;
            DataTable DT = new DataTable();
            switch (parametro)
            {
                case "RUC":
                    DT = c.ejecutarSQL("select RUC from PROVEEDOR where '" + parametro + "' not in (select RUC from PROVEEDOR)").Tables[0];
                    if (Convert.ToString(DT.Rows[0].ItemArray[0]) == "") {
                        bandera = false;
                    }      
                    break;
                case "Razon":
                    DT = c.ejecutarSQL("select RUC from PROVEEDOR where '" + parametro + "' not in (select razonSocial from PROVEEDOR)").Tables[0];
                    if (Convert.ToString(DT.Rows[0].ItemArray[0].ToString()).Equals(null))
                    {
                        bandera = false;
                    }
                    break;
            }
            return bandera;
        }*/

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
                DT = this.c.ejecutarSQL("EXECUTE consulta_proveedor_RUC '" + correo + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar proveedor por su Correo: " + error);
            }
            return DT;
        }
    }
}
