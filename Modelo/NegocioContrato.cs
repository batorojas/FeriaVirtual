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
    }
}

            