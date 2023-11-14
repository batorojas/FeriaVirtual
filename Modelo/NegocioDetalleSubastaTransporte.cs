using Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocios
{
    public class NegocioDetalleSubastaTransporte
    {
        private ConexionOracle con;

        public ConexionOracle Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();

                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "DETALLE_SUBASTA";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet ListarDetallesSubasta(int idSubasta)
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = @$"
                    SELECT 
                        DS.ID_DETALLE_SUBASTA AS ""ID"", 
                        DS.FECHA_ESTIMADA_ENTREGA AS ""FECHA ESTIMADA"", 
                        DS.CAPACIDAD_CARGA AS ""CAPACIDAD CARGA"", 
                        DS.REFRIGERACION AS ""REFRIGERACION"", 
                        DS.PESO_MAX AS ""PESO MAX"", 
                        DS.EXTRAS AS ""EXTRAS"", 
                        DS.PRECIO AS ""PRECIO"", 
                        DS.ID_CABECERA_SUBASTA AS ""ID CABECERA SUBASTA"", 
                        DS.ID_EMPRESA_TRANS AS ""ID_EMPRESA_TRANS"", 
                        ET.NOMBRE_EMPRESA AS ""EMPRESA"" 
                    FROM {this.con.TableName} DS
                    JOIN EMPRESA_TRANSPORTE ET ON (DS.ID_EMPRESA_TRANS = ET.ID_EMPRESA)
                    WHERE ID_CABECERA_SUBASTA = {idSubasta}";
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO DETALLES TRANSPORTE " + ex);
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
    }
}
