using Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocios
{
    public class NegocioDetalleProcesoVenta
    {
        private ConexionOracle con;
        
        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "DETALLE_PV";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO DETALLE PROCESO VENTA " + ex);
            }
        }

        public DataSet ListarDetallesProcesoVenta(int idProcesoVenta)
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = $@"SELECT
            P.NOMBRE_PRODUCTO AS ""PRODUCTO"",
            DV.CANTIDAD,
            DV.PRECIO_UNITARIO AS ""PRECIO UNIDAD"",
            DV.CANTIDAD * DV.PRECIO_UNITARIO AS ""TOTAL""
        FROM DETALLE_PV DV
        JOIN PRODUCTO P ON (DV.ID_PRODUCTO = P.ID_PRODUCTO) 
        WHERE DV.ID_CABECERA_PV = {idProcesoVenta}";

                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex.Message);
            }
            return this.con.DbDataSet;
        }

    }
}