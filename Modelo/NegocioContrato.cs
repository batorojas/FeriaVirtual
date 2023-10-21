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
        
        public Contrato buscarContrato(int idContrato)
        {
            Contrato contrato = new Contrato();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                 + "WHERE ID_CONTRATO = " + idContrato;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                contrato.IdContrato = (int)dt.Rows[0]["ID_CONTRATO"];
                contrato.FechaInicio = (DateTime)dt.Rows[0]["FECHA_INICIO"];
                contrato.FechaTermino = (DateTime)dt.Rows[0]["FECHA_TERMINO"];
                contrato.RutProductor = (int)dt.Rows[0]["RUT_PRODUCTOR"];
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:006CON NAME:NEGOCIO CONTRATO " + ex);
            }

            return contrato;
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

        public void actualizarContrato(Contrato contrato)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "ID", "F_INICIO", "F_TERMINO", "PRODUCTOR" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Date, OracleDbType.Date, OracleDbType.Int32 };
                Object[] valores = { contrato.IdContrato, contrato.FechaInicio, contrato.FechaTermino, contrato.RutProductor };

                this.con.ejecutarProcedimiento("SP_ACTUALIZAR_CONTRATO", parametros, tipos, valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:005CON NAME:NEGOCIO CONTRATO " + ex);
            }

        }
    }
}

            