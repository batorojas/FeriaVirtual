using Clases;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using System.Data.SqlClient;

namespace Negocios
{
    public class NegocioUsuario
    {
        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "USUARIO";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:001USU NAME:NEGOCIO USUARIO  " + ex);
            }
        }
        public DataSet retornarUsuarios()
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

                MessageBox.Show("ERROR ID:002USU NAME:NEGOCIO USUARIO  " + ex);
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

        public void ingresarUsuario(Usuario usuario)
        {
            try
            {


                this.configurarConexion();
                String[] parametros = { "NOMBRE_USUARIO", "PASSWORD", "FECHA_CREACION", "ID_PERFIL", "ID_ESTD_CTA" };
                OracleDbType[] tipos = { OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Date, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { usuario.UserName, usuario.Password, DateTime.Now, usuario.IdPerfil, usuario.IdEstadoCuenta };

                this.con.ejecutarProcedimiento("SP_INGRESAR_USUARIO", parametros, tipos, valores);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:003USU NAME:NEGOCIO USUARIO  " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }

        public void eliminarUsuario(int idUsuario)
        {
            try
            {


                this.configurarConexion();
                String[] parametros = { "ID" };
                OracleDbType[] tipos = { OracleDbType.Int32 };
                Object[] valores = { idUsuario };

                this.con.ejecutarProcedimiento("SP_ELIMINAR_USUARIO", parametros, tipos, valores);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:004USU NAME:NEGOCIO USUARIO  " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }

        public void actualizarUsuario(Usuario usuario)
        {
            try
            {


                this.configurarConexion();
                String[] parametros = { "ID", "NOMBRE", "PASS", "FECHA", "PERFIL", "ESTD_CTA" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Date, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { usuario.IdUser, usuario.UserName, usuario.Password, DateTime.Now, usuario.IdPerfil, usuario.IdEstadoCuenta };

                this.con.ejecutarProcedimiento("SP_ACTUALIZAR_USUARIO", parametros, tipos, valores);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:005USU NAME:NEGOCIO USUARIO  " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }

        public Usuario buscarPorNombre(String nombreUsuario)
        {
            Usuario usuario = new Usuario();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE NOMBRE_USUARIO = '" + nombreUsuario + "'";
            this.con.EsSelect = true;
            this.con.conectar();


            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                usuario.IdUser = (int)dt.Rows[0]["ID_USUARIO"];
                usuario.UserName = (String)dt.Rows[0]["NOMBRE_USUARIO"];
                usuario.Password = (String)dt.Rows[0]["PASSWORD"];
                usuario.FechaCreacion = (DateTime)dt.Rows[0]["FECHA_CREACION"];
                usuario.IdPerfil = (short)dt.Rows[0]["ID_PERFIL"];
                usuario.IdEstadoCuenta = (short)dt.Rows[0]["ID_ESTD_CTA"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: NEGOCIO USUARIO  " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return usuario;
        }

        public Usuario buscarPorId(int idUsuario)
        {
            Usuario usuario = new Usuario();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_USUARIO = " + idUsuario;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                usuario.IdUser = (int)dt.Rows[0]["ID_USUARIO"];
                usuario.UserName = (String)dt.Rows[0]["NOMBRE_USUARIO"];
                usuario.Password = (String)dt.Rows[0]["PASSWORD"];
                usuario.FechaCreacion = (DateTime)dt.Rows[0]["FECHA_CREACION"];
                usuario.IdPerfil = (short)dt.Rows[0]["ID_PERFIL"];
                usuario.IdEstadoCuenta = (short)dt.Rows[0]["ID_ESTD_CTA"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: NEGOCIO USUARIO  " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return usuario;
        }

        public Usuario buscarUsuario(int idUsuario)
        {
            Usuario usuario = new Usuario();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_USUARIO = " + idUsuario;
            this.con.EsSelect = true;
            this.con.conectar();


            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                usuario.IdUser = (int)dt.Rows[0]["ID_USUARIO"];
                usuario.UserName = (String)dt.Rows[0]["NOMBRE_USUARIO"];
                usuario.Password = (String)dt.Rows[0]["PASSWORD"];
                usuario.FechaCreacion = (DateTime)dt.Rows[0]["FECHA_CREACION"];
                usuario.IdPerfil = (short)dt.Rows[0]["ID_PERFIL"];
                usuario.IdEstadoCuenta = (short)dt.Rows[0]["ID_ESTD_CTA"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: NEGOCIO USUARIO  " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return usuario;

        }

        public int obtenerUltimoIdUsuario()
        {
            int ultimoId = -1; // Valor predeterminado en caso de error

            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT MAX(ID_USUARIO) FROM USUARIO";
                this.con.EsSelect = true;
                this.con.conectar();

                // Verificar si se encontró un resultado
                if (this.con.DbDataSet.Tables.Count > 0 && this.con.DbDataSet.Tables[0].Rows.Count > 0)
                {
                    object result = this.con.DbDataSet.Tables[0].Rows[0][0];

                    if (result != DBNull.Value)
                    {
                        ultimoId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:002USU NAME:NEGOCIO USUARIO " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return ultimoId;
        }

    }
}
