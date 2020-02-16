using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR.control
{
    class Conexion
    {

        private SqlConnection conexion;

        public Conexion() { }

        ~Conexion() { }

        public SqlConnection getConexion()
        {
            return this.conexion;
        }

        public void setConexion(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        private SqlConnection abrirConexion()
        {
            String url = "Data Source=.;Initial Catalog=ProyectoSoftware;Persist Security Info=True;User ID=sa;Password=1234";


            if (this.conexion == null)
            {
                try
                {
                    this.conexion = new SqlConnection(url);
                    this.conexion.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al conectar la base de datos: " + error.Message);
                }
            }

            return this.conexion;
        }

        private void cerrarConexion()
        {
            if (this.conexion != null)
            {
                try
                {
                    this.conexion.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al cerrar la conexion a la base de datos: " + error.Message);
                }
            }
        }

        public DataSet ejecutarSQL(String consulta)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(consulta, this.abrirConexion());
            DP.Fill(DS);
            this.cerrarConexion();
            return DS;

        }

    }
}
