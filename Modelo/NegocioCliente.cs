using Clases;
using Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocios
{
    public class NegocioCliente
    {

        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "CLIENTE";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:001CLI NAME:NEGOCIO CLIENTE " + ex);
            }

        }

        public Cliente buscarPorIdUsr(int idUsr)
        {
            Cliente cliente = new Cliente();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_USUARIO = " + idUsr;
            this.con.EsSelect = true;
            this.con.conectar();


            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                cliente.RutCliente = (int)dt.Rows[0]["RUT"];
                cliente.DvRutCliente = (String)dt.Rows[0]["DV_RUT"];
                cliente.RazonSocialCliente = (String)dt.Rows[0]["RAZON_SOCIAL"];
                cliente.DireccionCliente = (String)dt.Rows[0]["DIRECCION"];
                cliente.GiroCliente = (String)dt.Rows[0]["GIRO"];
                cliente.IdComunaCliente = (short)dt.Rows[0]["ID_COMUNA"];
                cliente.IdUsuarioCliente = (int)dt.Rows[0]["ID_USUARIO"];
                cliente.IdTipoCliente = (short)dt.Rows[0]["ID_PERFIL"];
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

            return cliente;
        }

        public DataSet retornarClientes()
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
                MessageBox.Show("ERROR ID:002CLI NAME:NEGOCIO CLIENTE " + ex);
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

        public void ingresarCliente(Cliente cliente)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "RUT", "DV_RUT", "RAZON_SOCIAL", "DIRECCION", "GIRO", "ID_COMUNA", "ID_USUARIO", "ID_TIPO" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { cliente.RutCliente, cliente.DvRutCliente, cliente.RazonSocialCliente, cliente.DireccionCliente, cliente.GiroCliente, cliente.IdComunaCliente, cliente.IdUsuarioCliente, cliente.IdTipoCliente };

                this.con.ejecutarProcedimiento("SP_INGRESAR_CLIENTE", parametros, tipos, valores);

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

        public void eliminarCliente(int rut)
        {
            try
            {
                this.configurarConexion();

                this.configurarConexion();
                String[] parametros = { "RUT" };
                OracleDbType[] tipos = { OracleDbType.Int32 };
                Object[] valores = { rut };

                this.con.ejecutarProcedimiento("SP_ELIMINAR_CLIENTE", parametros, tipos, valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:004CLI NAME:NEGOCIO CLIENTE " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

        }

        public void actualizarCliente(Cliente cliente)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "RUT", "DV_RUT", "RAZON_SOCIAL", "DIRECCION", "GIRO", "ID_COMUNA", "ID_USUARIO", "ID_TIPO" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { cliente.RutCliente, cliente.DvRutCliente, cliente.RazonSocialCliente, cliente.DireccionCliente, cliente.GiroCliente, cliente.IdComunaCliente, cliente.IdUsuarioCliente, cliente.IdTipoCliente };

                this.con.ejecutarProcedimiento("SP_ACTUALIZAR_CLIENTE", parametros, tipos, valores);
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:005CLI NAME:NEGOCIO CLIENTE " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }


        public Cliente buscarCliente(int rutcliente)
        {
            Cliente cliente = new Cliente();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE RUT = " + rutcliente;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                cliente.RutCliente = (int)dt.Rows[0]["RUT"];
                cliente.DvRutCliente = (String)dt.Rows[0]["DV_RUT"];
                cliente.RazonSocialCliente = (String)dt.Rows[0]["RAZON_SOCIAL"];
                cliente.DireccionCliente = (String)dt.Rows[0]["DIRECCION"];
                cliente.GiroCliente = (String)dt.Rows[0]["GIRO"];
                cliente.IdComunaCliente = (short)dt.Rows[0]["ID_COMUNA"];
                cliente.IdUsuarioCliente = (int)dt.Rows[0]["ID_USUARIO"];
                cliente.IdTipoCliente = (short)dt.Rows[0]["ID_TIPO"];
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

            return cliente;

        }

    }
}
