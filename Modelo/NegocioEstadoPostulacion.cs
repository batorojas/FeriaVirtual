using Conexion;
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
    public class NegocioEstadoPostulacion
    {
        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "ESTADO_POSTULACION";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }


            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001CON NAME:NEGOCIO CONTRATO " + ex);
            }
        }

        public EstadoPostulacion buscarEstado(int idEstado)
        {
            EstadoPostulacion estadoPostulacion = new EstadoPostulacion();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_ESTADO_POSTULACION = " + idEstado;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                estadoPostulacion.IdEstadoPostulacion = (short)dt.Rows[0]["ID_ESTADO_POSTULACION"];
                estadoPostulacion.Descripcion = (String)dt.Rows[0]["DESC_ESTADO"];
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:006CON NAME:NEGOCIO CONTRATO " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return estadoPostulacion;
        }
    }
}
