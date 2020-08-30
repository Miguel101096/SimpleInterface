
﻿using System;
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
                MessageBox.Show("Error al consultar productos: " + error);
            }
            return DT;
        }

        public void agregarProductoOrden(int idetalle, String codprod, String precio, int cant, String idOrden, String preciofinal)
        {
            try
            {
                this.c = new Conexion();
                c.ejecutarSQL("EXECUTE Insertar_Detalle " + idetalle + ", '" + codprod + "', " + precio + ", " + cant + ", '" + idOrden + "', " + preciofinal + "");
                //MessageBox.Show("Registro agregado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar un producto: " + error);
            }
        }

        public int nuevoIDDetalle()
        {
            int a = -1;

            try
            {
                this.c = new Conexion();
                DataTable DT = c.ejecutarSQL("IF EXISTS (SELECT MAX(idDetalle) FROM DETALLE_COMPRA HAVING MAX(idDetalle) IS NOT NULL)" +
                            "SELECT MAX(idDetalle) FROM DETALLE_COMPRA ELSE SELECT '0'").Tables[0];
                a = Convert.ToInt32(DT.Rows[0].ItemArray[0]);

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al recuperar idEstudiante: " + error);
            }
            return ++a;
        }

        public double preciofinal(int cant, double precio) {
            double preciofinal = 0;
            preciofinal = cant * precio;
            return preciofinal;
        
        }

        public DataTable ProductosDetalle(String numorden)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("EXECUTE productos_detalle '" + numorden + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar detalle productos: " + error);
            }
            return DT;
        }

        public String cambioTipoDecimal(String valor) 
        {
            var temp = valor.Replace(".", "<TEMP>");
            var temp2 = temp.Replace(",", ".");
            var replaced = temp2.Replace("<TEMP>", ",");
            return replaced;
        }

        public void RregistrarOrdenCompra(String numOrden, String fecha, String estado, String nombrePro)
        {
            try
            {
                this.c = new Conexion();
                c.ejecutarSQL("EXECUTE crear_orden_compra '" + numOrden + "', '" + fecha + "', '"
                    + estado + "', '" + nombrePro + "' ");
                //MessageBox.Show("Orden generada correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al ingresar la orden: " + error);
            }
        }

        public void elimarDetalleCompra()
        {
            try
            {
                this.c = new Conexion();
                c.ejecutarSQL("EXECUTE eliminar_detalle_compra");
                //MessageBox.Show("Detalle eliminado con exito");
            }
            catch(Exception e)
            {
                //MessageBox.Show("No se pudo eliminar detalle");

            }
        }

        public void elimarOrdenCompra(String numORden)
        {
            try
            {
                this.c = new Conexion();
                c.ejecutarSQL("EXECUTE eliminar_orden_compra '"+ numORden +"' ");
                //MessageBox.Show("Orden eliminado con exito");
            }
            catch (Exception e)
            {
                //MessageBox.Show("No se pudo eliminar orden");

            }
        }
        public DataTable traernumorden()
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("SELECT numOrden FROM ORDEN_COMPRA WHERE numOrden = (SELECT MAX(numOrden) from ORDEN_COMPRA)").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar productos: " + error);
            }
            return DT;
        }

        public DataTable ConsultarOrdenModificar(String numorden)
        {
            DataTable DT = new DataTable();
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("select * from ORDEN_COMPRA where numOrden = '" + numorden + "'").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar orden compra: " + error);
            }
            return DT;
        }

        public void ModificarORden(String cambio, String numorden)
        {
            try
            {
                this.c = new Conexion();
                this.c.ejecutarSQL("execute modificar_estado_orden '" + cambio + "', '" + numorden + "'");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al modificar la orden de compra: " + error);
            }
        }

        public String OrdenExiste(String numorden)
        {
            DataTable DT = new DataTable();
            String aux = "";
            try
            {
                this.c = new Conexion();
                DT = this.c.ejecutarSQL("execute existe_Orden_numero '" + numorden + "'").Tables[0];
                aux = Convert.ToString(DT.Rows[0].ItemArray[0]);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al consultar orden compra: " + error);
            }
            return aux;
        }
    }
}