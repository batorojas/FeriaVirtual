using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Clases;

namespace Negocios
{
    public class NegocioDetallePostulacion
    {
        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "DETALLE_POSTULACION";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet listarDetallesPostulacion(int idSubasta)
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName
                                + " WHERE ID_CABECERA_POSTULACION = " + idSubasta;
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return this.con.DbDataSet;
        }

        public DetallePostulacion buscarDetallePostulacion(int idCabeceraPostulacion, int idProducto)
        {
            DetallePostulacion detallePostulacion = new DetallePostulacion();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_CABECERA_POSTULACION = " + idCabeceraPostulacion + " AND ID_PRODUCTO = " + idProducto;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                detallePostulacion.IdDetallePostulacion = (int)dt.Rows[0]["ID_DETALLE_POSTULACION"];
                detallePostulacion.IdCabeceraPostulacion = (int)dt.Rows[0]["ID_CABECERA_POSTULACION"];
                detallePostulacion.IdProducto = (short)dt.Rows[0]["ID_PRODUCTO"];
                detallePostulacion.Cantidad = (int)dt.Rows[0]["CANTIDAD"];
                detallePostulacion.PrecioUnitario = (int)dt.Rows[0]["PRECIO_UNITARIO"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:006CLI NAME:NEGOCIO CLIENTE " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return detallePostulacion;

        }
    }
}
