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
    public class NegocioCabeceraPostulacion
    {
        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "CABECERA_POSTULACION";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet ListarPostulaciones(int idProcesoVenta)
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName +
                    " WHERE CABECERA_PV = " + idProcesoVenta;
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

        public CabeceraPostulacion buscarCabeceraPostulacion(int idCabeceraPostulacion)
        {
            CabeceraPostulacion cabeceraPostulacion = new CabeceraPostulacion();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_CABECERA_POSTULACION = " + idCabeceraPostulacion;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                cabeceraPostulacion.IdCabeceraPostulacion = (int)dt.Rows[0]["ID_CABECERA_POSTULACION"];
                cabeceraPostulacion.FechaEmision = (DateTime)dt.Rows[0]["FECHA_EMISION"];
                cabeceraPostulacion.RutProductor = (int)dt.Rows[0]["RUT_PRODUCTOR"];
                cabeceraPostulacion.IdCabeceraProcesoVenta = (int)dt.Rows[0]["CABECERA_PV"];
                cabeceraPostulacion.IdEstadoPostulacion = (short)dt.Rows[0]["ID_ESTADO_POSTULACION"];
            }
            catch (Exception ex)
            {
                CabeceraPostulacion auxCabeceraPostulacion = new CabeceraPostulacion();
                return auxCabeceraPostulacion;
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return cabeceraPostulacion;
        }

        public void actualizarEstadoPostulacion(int idCabeceraPostulacion, int idEstadoPostulacion)
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "UPDATE " + this.con.TableName +
                                     " SET ID_ESTADO_POSTULACION = " + idEstadoPostulacion +
                                     " WHERE ID_CABECERA_POSTULACION = " + idCabeceraPostulacion;
                this.con.EsSelect = false;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR AL ACTUALIZAR ESTADO_POSTULACION: " + ex);
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
