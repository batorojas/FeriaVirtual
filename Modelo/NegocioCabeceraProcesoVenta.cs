using Conexion;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;

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

        public DataSet listarPagos(int estadoPV)
        {
            DataSet dataSet = null;

            try
            {
                configurarConexion();
                con.SqlString = "SELECT * FROM " + con.TableName + " WHERE ESTADO_PV = " + estadoPV;
                con.EsSelect = true;
                con.conectar();

                dataSet = con.DbDataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO PRODUCTO " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Assuming a method to close the database connection in your ConexionOracle class
                }
            }

            return dataSet;
        }

        public void ExportDataSetToPdf(DataSet dataSet, string pdfFileName, string title)
        {
            string folderPath = "reportes";

            // Create the directory if it doesn't exist
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Construct the full path including the "./reportes/" directory and file name
            string pdfFilePath = Path.Combine(folderPath, pdfFileName);

            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));
            doc.Open();
            
            Paragraph titleParagraph = new Paragraph(title, new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD));
            titleParagraph.Alignment = Element.ALIGN_CENTER;
            doc.Add(titleParagraph);
            doc.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(dataSet.Tables[0].Columns.Count);

            // Add table headers
            for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
            {
                table.AddCell(new Phrase(dataSet.Tables[0].Columns[i].ColumnName));
            }

            // Add data rows
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
                {
                    table.AddCell(new Phrase(row[i].ToString()));
                }
            }

            doc.Add(table);
            doc.Close();
        }

        public void ExportPaymentsToPdf(int estadoPV, string pdfFileName, string title)
        {
            DataSet dataSet = listarPagos(estadoPV);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                ExportDataSetToPdf(dataSet, pdfFileName, title);
            }
            else
            {
                MessageBox.Show("No data to export.");
            }
        }
    }
}