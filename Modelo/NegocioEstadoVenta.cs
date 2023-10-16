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
    public class NegocioEstadoVenta
    {
        private ConexionOracle con;
        
        private ConexionOracle Con { get => con; set => con = value; }
        
        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();
                
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "ESTADO_VENTA";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            
            catch (Exception ex)
            {
                
                MessageBox.Show("ERROR ID:001EST NAME:NEGOCIO ESTADO VENTA " + ex);
            }
        }

        public EstadoVenta buscarEstado(int idEstado)
        {
            EstadoVenta estadoVenta = new EstadoVenta();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                   + "WHERE ID_ESTADO_PV = " + idEstado;
            this.con.EsSelect = true;
            this.con.conectar();
            
            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                estadoVenta.IdEstadoVenta = (short)dt.Rows[0]["ID_ESTADO_PV"];
                estadoVenta.Descripcion = (String)dt.Rows[0]["DESC_ESTADO"];
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:006EST NAME:NEGOCIO ESTADO VENTA " + ex);
            }
            return estadoVenta;
        }
    }
}