using Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocios
{
    public class NegocioCabeceraProcesoVenta
    {
        private ConexionOracle con;

        public void configurarConexion()
        {
            try
            {
                this.con = new ConexionOracle();
                this.con.NombreBaseDeDatos = "maipo_grande";
                this.con.TableName = "CABECERA_PV";
                this.con.ConnectionString = "Data Source=localhost:1521/xe;User Id=maipogrande;Password=123;";
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:001PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
        }

        public DataSet listarPagosPendientes()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName + " WHERE ESTADO_PV = 1";
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex);
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

        public DataSet listarPagosRealizados()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName + " WHERE ESTADO_PV = 2";
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex);
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

        public void actualizarEstadoProcesoVenta(int idCabeceraProcesoVenta, int idEstado)
        {
            this.configurarConexion();
            this.con.SqlString = "UPDATE " + this.con.TableName +
                                 " SET ESTADO_PV = " + idEstado +
                                 " WHERE ID_CABECERA_PV = " + idCabeceraProcesoVenta;
            this.con.EsSelect = false;
            this.con.conectar();
        }

        public void ExportarDatosCSV(DataSet dataSet, string filePath)
        {
            try
            {
                // Verifica si la carpeta "reportes" existe y, de lo contrario, créala
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                if (dataSet != null && dataSet.Tables.Count > 0)
                {
                    DataTable dataTable = dataSet.Tables[0];
                    if (dataTable.Rows.Count > 0)
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            // Escribir cabeceras de columnas
                            writer.WriteLine(string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(col => col.ColumnName)));

                            // Escribir datos
                            foreach (DataRow row in dataTable.Rows)
                            {
                                writer.WriteLine(string.Join(",", row.ItemArray));
                            }
                        }

                        Console.WriteLine("Datos exportados a CSV correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No hay datos para exportar.");
                    }
                }
                else
                {
                    Console.WriteLine("El DataSet está vacío o nulo.");
                }
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR al exportar a CSV: " + ex);
            }
        }

        public void ExportarPagosPendientes()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName + " WHERE ESTADO_PV = 1";
                this.con.EsSelect = true;
                this.con.conectar();

                // Exportar a CSV
                ExportarDatosCSV(this.con.DbDataSet, "PagosPendientes.csv");
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
        }

        public void ExportarPagosRealizados()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "SELECT * FROM " + this.con.TableName + " WHERE ESTADO_PV = 2";
                this.con.EsSelect = true;
                this.con.conectar();

                // Exportar a CSV
                ExportarDatosCSV(this.con.DbDataSet, "PagosRealizados.csv");
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex);
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