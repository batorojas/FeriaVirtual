using Clases;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using Conexion;

namespace Negocios
{
    public class NegocioContrato
    {
        private ConexionOracle con;

        public ConexionOracle Con
        {
            get => con;
            set => con = value;
        }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "CONTRATO";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }

            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001CON NAME:NEGOCIO TIPO CONTRATOS" + ex);
            }
        }

        public DataSet retornarContratos()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName;
                this.con.EsSelect = true;
                this.con.conectar();
            }

            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002CON NAME:NEGOCIO TIPO CONTRATOS" + ex);
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

        public void ingresarContrato(Contrato contrato)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "FECHAINICIO", "FECHATERMINO", "RUTPRODUCTOR" };
                OracleDbType[] tipos = { OracleDbType.Date, OracleDbType.Date, OracleDbType.Int32 };
                Object[] valores = { contrato.FechaInicio, contrato.FechaTermino, contrato.RutProductor };
                this.con.ejecutarProcedimiento("SP_INGRESAR_CONTRATO", parametros, tipos, valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR INGRESAR CONTRATO");
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }

        public int obtenerUltimoIDContrato()
        {
            int ultimoIdContrato = -1;
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT MAX(ID_CONTRATO) FROM CONTRATO";
                this.con.EsSelect = true;
                this.con.conectar();
                if (this.con.DbDataSet.Tables[0].Rows.Count > 0)
                {
                    object result = this.con.DbDataSet.Tables[0].Rows[0][0];
                    if (result != DBNull.Value)
                    {
                        ultimoIdContrato = Convert.ToInt32(result);
                    }

                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR OBTENER ULTIMO ID CONTRATO");
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return ultimoIdContrato;
        }
        public void eliminarContrato(int idContrato)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "ID" };
                OracleDbType[] tipos = { OracleDbType.Int32 };
                Object[] valores = { idContrato };

                this.con.ejecutarProcedimiento("SP_ELIMINAR_CONTRATO", parametros, tipos, valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:004CON NAME:NEGOCIO CONTRATO " + ex);
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

            