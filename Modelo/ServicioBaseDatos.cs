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
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex);
            }
        }

        public Boolean ingresarSistema(Sesion ingreso)
        {

            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName + " WHERE "
                                     + " NOMBRE_USUARIO = '" + ingreso.Username + "' AND"
                                     + " PASSWORD = '" + ingreso.Password + "'"
                                     + " AND ID_PERFIL = 1 AND ID_ESTD_CTA = 1";
                this.con.EsSelect = true;
                this.con.conectar();

                return this.con.DbDataSet.Tables[this.con.TableName].Rows.Count == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
                return false;
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