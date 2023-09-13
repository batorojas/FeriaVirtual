using Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Negocios
{
    public class NegocioEmpresaTransporte
    {
        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "EMPRESA_TRANSPORTE";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:001EMP NAME:NEGOCIO EMPRESA TRANSPORTE " + ex);
            }
        }
        public DataSet retornarEmpresasTranporte()
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

                MessageBox.Show("ERROR ID:002EMP NAME:NEGOCIO EMPRESA TRANSPORTE " + ex);
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

        public EmpresaTransporte buscarPorIdUsr(int idUsr)
        {
            EmpresaTransporte empresaTransporte = new EmpresaTransporte();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_USUARIO = " + idUsr;
            this.con.EsSelect = true;
            this.con.conectar();


            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                empresaTransporte.IdEmpresaTransporte = (int)dt.Rows[0]["ID_EMPRESA"];
                empresaTransporte.NombreEmpresaTransporte = (String)dt.Rows[0]["NOMBRE_EMPRESA"];
                empresaTransporte.IdUsuarioEmpresaTransporte = (int)dt.Rows[0]["ID_USUARIO"];

            }
            catch (Exception ex)
            {
                //Usuario auxUsuario = new Usuario();
                //return auxUsuario;
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return empresaTransporte;
        }
        public void ingresarEmpresaTransporte(EmpresaTransporte empTransporte)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "NOMBRE_EMPRESA", "ID_USUARIO" };
                OracleDbType[] tipos = { OracleDbType.Varchar2, OracleDbType.Int32 };
                Object[] valores = { empTransporte.NombreEmpresaTransporte, empTransporte.IdUsuarioEmpresaTransporte };

                this.con.ejecutarProcedimiento("SP_INGRESAR_EMPRESA_TRANSP", parametros, tipos, valores);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:003EMP NAME:NEGOCIO EMPRESA TRANSPORTE " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }

        public void eliminarEmpresaTransporte(int idUserEmpresa)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "ID_USER" };
                OracleDbType[] tipos = { OracleDbType.Int32 };
                Object[] valores = { idUserEmpresa };

                this.con.ejecutarProcedimiento("SP_ELIMINAR_EMPRESA_TRANSPORTE", parametros, tipos, valores);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:004EMP NAME:NEGOCIO EMPRESA TRANSPORTE " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }

        public void actualizarEmpresaTransporte(EmpresaTransporte empTransporte)
        {
            try
            {

                this.configurarConexion();
                String[] parametros = { "ID", "NOMBRE", "USUARIO" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Int32 };
                Object[] valores = { empTransporte.IdEmpresaTransporte, empTransporte.NombreEmpresaTransporte, empTransporte.IdUsuarioEmpresaTransporte };

                this.con.ejecutarProcedimiento("SP_ACTUALIZAR_EMPRESA_TRANSP", parametros, tipos, valores);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:004EMP NAME:NEGOCIO EMPRESA TRANSPORTE " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }


        public EmpresaTransporte buscarEmpresaTransporte(int idEmpresa)
        {
            EmpresaTransporte empTransporte = new EmpresaTransporte();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_EMPRESA = " + idEmpresa;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                empTransporte.IdEmpresaTransporte = (int)dt.Rows[0]["ID_EMPRESA"];
                empTransporte.NombreEmpresaTransporte = (String)dt.Rows[0]["NOMBRE_EMPRESA"];
                empTransporte.IdUsuarioEmpresaTransporte = (int)dt.Rows[0]["ID_USUARIO"];
            }
            catch (Exception ex)
            {
                EmpresaTransporte auxEmpTransporte = new EmpresaTransporte();
                return auxEmpTransporte;
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return empTransporte;
        }
    }
}
