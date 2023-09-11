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
    public class NegocioProductor
    {
        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "PRODUCTOR";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:001CTOR NAME:NEGOCIO PRODUCTOR " + ex);
            }
        }
        public DataSet retornarProductores()
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

                MessageBox.Show("ERROR ID:002CTOR NAME:NEGOCIO PRODUCTOR  " + ex);
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

        public Productor buscarPorIdUsr(int idUsr)
        {
            Productor productor = new Productor();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_USUARIO = " + idUsr;
            this.con.EsSelect = true;
            this.con.conectar();


            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                productor.RutProductor = (int)dt.Rows[0]["RUT"];
                productor.DvRutProductor = (String)dt.Rows[0]["DV_RUT"];
                productor.RazonSocialProductor = (String)dt.Rows[0]["RAZON_SOCIAL"];
                productor.DireccionProductor = (String)dt.Rows[0]["DIRECCION"];
                productor.GiroProductor = (String)dt.Rows[0]["GIRO"];
                productor.IdComunaProductor = (short)dt.Rows[0]["ID_COMUNA"];
                productor.IdUsuarioProductor = (int)dt.Rows[0]["ID_USUARIO"];
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

            return productor;
        }


        public void ingresarProductor(Productor productor)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "RUT", "DV_RUT", "RAZON_SOCIAL", "DIRECCION", "GIRO", "ID_COMUNA", "ID_USUARIO" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { productor.RutProductor, productor.DvRutProductor, productor.RazonSocialProductor, productor.DireccionProductor, productor.GiroProductor, productor.IdComunaProductor, productor.IdUsuarioProductor };

                this.con.ejecutarProcedimiento("SP_INGRESAR_PRODUCTOR", parametros, tipos, valores);
            }
            catch (Exception exingresoproductor)
            {
                MessageBox.Show("ERROR ID:003CTOR NAME:NEGOCIO PRODUCTOR  " + exingresoproductor);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

        }

        public void eliminarProductor(int rutProductor)
        {
            try
            {


                this.configurarConexion();
                String[] parametros = { "RUTP" };
                OracleDbType[] tipos = { OracleDbType.Int32 };
                Object[] valores = { rutProductor };

                this.con.ejecutarProcedimiento("SP_ELIMINAR_PRODUCTOR", parametros, tipos, valores);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:004CTOR NAME:NEGOCIO PRODUCTOR  " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

        }

        public void actualizarProductor(Productor productor)
        {
            try
            {
                this.configurarConexion();
                String[] parametros = { "RUTP", "DV_RUTP", "RAZON_SOCIALP", "DIRECCIONP", "GIROP", "ID_COMUNAP", "ID_USUARIOP" };
                OracleDbType[] tipos = { OracleDbType.Int32, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Varchar2, OracleDbType.Int32, OracleDbType.Int32 };
                Object[] valores = { productor.RutProductor, productor.DvRutProductor, productor.RazonSocialProductor, productor.DireccionProductor, productor.GiroProductor, productor.IdComunaProductor, productor.IdUsuarioProductor };

                this.con.ejecutarProcedimiento("SP_ACTUALIZAR_PRODUCTOR", parametros, tipos, valores);
            }
            catch (Exception exactualizarProductor)
            {
                MessageBox.Show("ERROR ID:005CTOR NAME:NEGOCIO PRODUCTOR " + exactualizarProductor);

            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

        }


        public Productor buscarProductor(int rutProductor)
        {
            Productor productor = new Productor();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE RUT = " + rutProductor;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                productor.RutProductor = (int)dt.Rows[0]["RUT"];
                productor.DvRutProductor = (String)dt.Rows[0]["DV_RUT"];
                productor.RazonSocialProductor = (String)dt.Rows[0]["RAZON_SOCIAL"];
                productor.DireccionProductor = (String)dt.Rows[0]["DIRECCION"];
                productor.GiroProductor = (String)dt.Rows[0]["GIRO"];
                productor.IdComunaProductor = (short)dt.Rows[0]["ID_COMUNA"]; //esya en short lo cambio a int
                productor.IdUsuarioProductor = (short)dt.Rows[0]["ID_USUARIO"];
            }
            catch (Exception ex)
            {
                //Productor auxProductor = new Productor();
                //return auxProductor;
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return productor;
        }
    }
}
