using Clases;
using Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Negocios
{
    public class NegocioProducto
    {
        private ConexionOracle con;
        public ConexionOracle Con { get => con; set => con = value; }
        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "PRODUCTO";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:001CTOR NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet listarProductos()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName;
                this.con.EsSelect = true;
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR ID:002CTOR NAME:NEGOCIO PRODUCTO " + e);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion();
                }
            }
            return this.con.DbDataSet;
        }
    }
}