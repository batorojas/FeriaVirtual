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
    public class NegocioCabeceraProcesoVenta
    {
        private ConexionOracle con;

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "CABECERA_PV";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet listarPagosPendientes()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName + " WHERE ESTADO_PV = 1";
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO CABECERA PV " + ex);
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

        public DataSet listarPagosRealizados()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName + " WHERE ESTADO_PV = 2";
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO CABECERA PV " + ex);
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

        public void actualizarEstadoProcesoVenta(int idCabeceraProcesoVenta, int idEstado)
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "UPDATE " + this.con.TableName +
                                     " SET ESTADO_PV = " + idEstado +
                                     " WHERE ID_CABECERA_PV = " + idCabeceraProcesoVenta;
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:005CLI NAME:NEGOCIO CABECERA PV " + ex);
            }
        }
    }
}
