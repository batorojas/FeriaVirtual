using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Conexion;
using Oracle.ManagedDataAccess.Client;
using static System.Collections.Specialized.BitVector32;

namespace Negocios
{
    public class ServicioBaseDatos
    {
        private ConexionOracle con;

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();

                //this.con.NombreBaseDeDatos = "feriamaipogrande";
                this.con.TableName = "USUARIO";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=feriamaipogrande;Password=123;";
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ID:001SES NAME:NEGOCIO SESION  " + ex);
            }
        }

        public Boolean IngresarSistema(Sesion ingreso)
        {

            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName + " WHERE "
                                     + " NOMBRE_USUARIO = '" + ingreso.Username + "' AND"
                                     + " PASSWORD = '" + ingreso.Password + "'";
                this.con.EsSelect = true;
                this.con.Conectar();

                return this.con.DbDataSet.Tables[this.con.TableName].Rows.Count == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:002SES NAME:NEGOCIO SESION  " + ex);
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.CerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }
    }
}