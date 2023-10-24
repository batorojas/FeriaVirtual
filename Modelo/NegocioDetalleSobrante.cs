using Clases;
using Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocios
{
    public class NegocioDetalleSobrante
    {
        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "CABECERA_SOBRANTE";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }


            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001CON NAME:NEGOCIO CONTRATO " + ex);
            }
        }

        public void ingresarDetalleSobrante(DetalleSobrante detalleSobrante)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "ID_CAB_SOBRANTE", "ID_PRODUCTO", "CANTIDAD" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { detalleSobrante.IdCabeceraSobrante, detalleSobrante.IdProducto, detalleSobrante.Cantidad };

                this.con.ejecutarProcedimiento("SP_INGRESAR_DET_SOBRANTE", parametros, tipos, valores);

            }

            catch (Exception exingresocliente)
            {
                MessageBox.Show("ERROR ID:003CLI NAME:NEGOCIO CLIENTE" + exingresocliente);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

        }


    }
}
