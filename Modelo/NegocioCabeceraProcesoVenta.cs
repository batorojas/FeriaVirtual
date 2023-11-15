using Conexion;
using iText.Kernel.Pdf;
using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;
using iTextSharp.text.html.simpleparser;

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
        public DataSet ListarProcesosVentaExterna()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = @$"
                    SELECT 
                        CA.ID_CABECERA_PV AS ""ID"", 
                        CA.FECHA_EMISION AS ""FECHA EMISION"", 
                        CA.OBS_PV AS ""OBSERVACIONES"", 
                        CA.RUT_CLIENTE AS ""RUT CLIENTE"", 
                        ES.DESC_ESTADO_POSTULACION AS ""ESTADO POSTULACION"", 
                        ET.NOMBRE_EMPRESA AS ""EMPRESA TRANSPORTE"", 
                        TI.DESC_TIPO AS ""TIPO VENTA"" 
                    FROM {this.con.TableName} CA
                    JOIN TIPO_VENTA TI ON (CA.ID_TIPO_VENTA = TI.ID_TIPO_VENTA)
                    JOIN ESTADO_POSTULACION ES ON (CA.ESTADO_PV = ES.ID_ESTADO_POSTULACION)
                    JOIN EMPRESA_TRANSPORTE ET ON (CA.EMPRESA_TRANS = ET.ID_EMPRESA) 
                    WHERE CA.ID_TIPO_VENTA = 1";

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

        public DataSet ListarProcesosVentaLocal()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = @$"
                    SELECT 
                        CA.ID_CABECERA_PV AS ""ID"", 
                        CA.FECHA_EMISION AS ""FECHA EMISION"", 
                        CA.OBS_PV AS ""OBSERVACIONES"", 
                        CA.RUT_CLIENTE AS ""RUT CLIENTE"", 
                        ES.DESC_ESTADO_POSTULACION AS ""ESTADO POSTULACION"", 
                        ET.NOMBRE_EMPRESA AS ""EMPRESA TRANSPORTE"", 
                        TI.DESC_TIPO AS ""TIPO VENTA"" 
                    FROM {this.con.TableName} CA
                    JOIN TIPO_VENTA TI ON (CA.ID_TIPO_VENTA = TI.ID_TIPO_VENTA)
                    JOIN ESTADO_POSTULACION ES ON (CA.ESTADO_PV = ES.ID_ESTADO_POSTULACION)
                    JOIN EMPRESA_TRANSPORTE ET ON (CA.EMPRESA_TRANS = ET.ID_EMPRESA) 
                    WHERE CA.ID_TIPO_VENTA = 2";

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

        public DataSet listarPagosPendientes()
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = @$"SELECT 
                        CA.ID_CABECERA_PV AS ""ID"", 
                        CA.FECHA_EMISION AS ""FECHA EMISION"", 
                        CA.OBS_PV AS ""OBSERVACIONES"", 
                        CA.RUT_CLIENTE AS ""RUT CLIENTE"", 
                        ES.DESC_ESTADO_POSTULACION AS ""ESTADO POSTULACION"", 
                        ET.NOMBRE_EMPRESA AS ""EMPRESA TRANSPORTE"", 
                        TI.DESC_TIPO AS ""TIPO VENTA"",
                        EV.DESC_ESTADO AS ""ESTADO""
                    FROM {this.con.TableName} CA
                    JOIN TIPO_VENTA TI ON (CA.ID_TIPO_VENTA = TI.ID_TIPO_VENTA)
                    JOIN ESTADO_POSTULACION ES ON (CA.ESTADO_PV = ES.ID_ESTADO_POSTULACION)
                    JOIN EMPRESA_TRANSPORTE ET ON (CA.EMPRESA_TRANS = ET.ID_EMPRESA)
                    JOIN ESTADO_VENTA EV ON (CA.ESTADO_PV = EV.ID_ESTADO_PV)
                    WHERE CA.ESTADO_PV = 1";
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO CABECERA PV " + ex);
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
                this.con.SqlString = @$"SELECT 
                        CA.ID_CABECERA_PV AS ""ID"", 
                        CA.FECHA_EMISION AS ""FECHA EMISION"", 
                        CA.OBS_PV AS ""OBSERVACIONES"", 
                        CA.RUT_CLIENTE AS ""RUT CLIENTE"", 
                        ES.DESC_ESTADO_POSTULACION AS ""ESTADO POSTULACION"", 
                        ET.NOMBRE_EMPRESA AS ""EMPRESA TRANSPORTE"", 
                        TI.DESC_TIPO AS ""TIPO VENTA"",
                        EV.DESC_ESTADO AS ""ESTADO""
                    FROM {this.con.TableName} CA
                    JOIN TIPO_VENTA TI ON (CA.ID_TIPO_VENTA = TI.ID_TIPO_VENTA)
                    JOIN ESTADO_POSTULACION ES ON (CA.ESTADO_PV = ES.ID_ESTADO_POSTULACION)
                    JOIN EMPRESA_TRANSPORTE ET ON (CA.EMPRESA_TRANS = ET.ID_EMPRESA)
                    JOIN ESTADO_VENTA EV ON (CA.ESTADO_PV = EV.ID_ESTADO_PV)
                    WHERE CA.ESTADO_PV = 2";
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                // CORREGIR MENSAJE DE ERROR
                MessageBox.Show("ERROR ID:002PRO NAME:NEGOCIO CABECERA PV " + ex);
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
        public CabeceraProcesoVenta buscarCabeceraProcesoVenta(int idCabeceraProcesoVenta)
        {
            CabeceraProcesoVenta procesoVenta = new CabeceraProcesoVenta();
            this.configurarConexion();
            this.con.SqlString = "SELECT * FROM " + this.con.TableName + " "
                                 + "WHERE ID_CABECERA_PV = " + idCabeceraProcesoVenta;
            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.TableName];

            try
            {
                procesoVenta.IdCabeceraVenta = (int)dt.Rows[0]["ID_CABECERA_PV"];
                procesoVenta.IdEmpresaTransporte = (int)dt.Rows[0]["EMPRESA_TRANS"];
                procesoVenta.FechaEmision = (DateTime)dt.Rows[0]["FECHA_EMISION"];
                procesoVenta.Observaciones = (String)dt.Rows[0]["OBS_PV"];
                procesoVenta.IdEstado = (short)dt.Rows[0]["ESTADO_PV"];
                procesoVenta.RutCliente = (int)dt.Rows[0]["RUT_CLIENTE"];
            }
            catch (Exception ex)
            {
                CabeceraProcesoVenta auxCabeceraProcesoVenta = new CabeceraProcesoVenta();
                return auxCabeceraProcesoVenta;
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }

            return procesoVenta;
        }

        public void asignarTransporte(int idCabeceraProcesoVenta, int idTransporte)
        {
            this.configurarConexion();
            this.con.SqlString = "UPDATE " + this.con.TableName +
                                 " SET EMPRESA_TRANS = " + idTransporte +
                                 " WHERE ID_CABECERA_PV = " + idCabeceraProcesoVenta;
            this.con.EsSelect = false;
            this.con.conectar();
        }

        public void actualizarEstadoProcesoVenta(int idCabeceraProcesoVenta, int idEstado)
        {
            try
            {
                this.configurarConexion();
                this.con.SqlString = "UPDATE " + this.con.TableName +
                                     " SET ESTADO_PV = " + idEstado +
                                     " WHERE ID_CABECERA_PV = " + idCabeceraProcesoVenta;
                this.con.EsSelect = true;
                this.con.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ID:005CLI NAME:NEGOCIO CABECERA PV " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.cerrarConexion(); // Llamada al método personalizado CerrarConexion
                }
            }
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
        
        public DataSet listarDetalleVenta(int idCabeceraPV)
        {
            DataSet dataSet = null;

            try
            {
                configurarConexion();
                con.SqlString = "SELECT\n    V.ID_CABECERA_PV AS \"N\u00b0 VENTA\",\n    V.FECHA_EMISION AS \"FECHA\",\n    V.OBS_PV AS \"OBSERVACIONES\",\n    V.RUT_CLIENTE AS \"RUT CLIENTE\",\n    E.DESC_ESTADO AS \"ESTADO VENTA\",\n    T.NOMBRE_EMPRESA AS \"EMPRESA TRANSPORTE\",\n    TV.DESC_TIPO AS \"TIPO VENTA\",\n    D.ID_PRODUCTO AS \"CÓDIGO PRODUCTO\",\n    P.NOMBRE_PRODUCTO AS \"NOMBRE PRODUCTO\",\n    D.CANTIDAD AS \"CANTIDAD\",\n    D.CANTIDAD * D.PRECIO_UNITARIO AS \"TOTAL\"\nFROM CABECERA_PV V\n         INNER JOIN ESTADO_VENTA E ON V.ESTADO_PV = E.ID_ESTADO_PV\n         INNER JOIN TIPO_VENTA TV ON V.ID_TIPO_VENTA = TV.ID_TIPO_VENTA\n         INNER JOIN DETALLE_PV D ON V.ID_CABECERA_PV = D.ID_DETALLE_PV\n         INNER JOIN PRODUCTO P ON D.ID_PRODUCTO = P.ID_PRODUCTO\n         INNER JOIN EMPRESA_TRANSPORTE T ON V.EMPRESA_TRANS = T.ID_EMPRESA\nWHERE V.ID_CABECERA_PV = " + idCabeceraPV;
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

        public void exportarDetallePedidoPDF(DataSet dataSet, string pdfFileName, string title)
        {
            string folderPath = "facturas";

            // Crear el directorio si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Construir la ruta completa, incluyendo el directorio "./facturas/" y el nombre del archivo
            string pdfFilePath = Path.Combine(folderPath, pdfFileName);

            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));
            doc.Open();

            // Título de la factura
            Paragraph titleParagraph = new Paragraph(title, new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD));
            titleParagraph.Alignment = Element.ALIGN_CENTER;
            doc.Add(titleParagraph);
            doc.Add(Chunk.NEWLINE); // Agregar espacio entre el título y la tabla

            // Crear una tabla para los detalles de la factura
            PdfPTable table = new PdfPTable(dataSet.Tables[0].Columns.Count);
            table.WidthPercentage = 100; // Establecer el ancho de la tabla al 100% del ancho disponible

            // Obtener el ancho relativo de cada columna basado en el tamaño del texto
            float[] columnWidths = new float[dataSet.Tables[0].Columns.Count];
            for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
            {
                columnWidths[i] = 1f; // Establecer un ancho inicial igual para todas las columnas
            }

            table.SetWidths(columnWidths);

            // Agregar encabezados
            foreach (DataColumn column in dataSet.Tables[0].Columns)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName,
                    new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD)));
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCell);
            }

            // Agregar filas con datos
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                foreach (var cell in row.ItemArray)
                {
                    PdfPCell dataCell =
                        new PdfPCell(new Phrase(cell.ToString(), new Font(Font.FontFamily.HELVETICA, 12)));
                    dataCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(dataCell);
                }
            }

            doc.Add(table);

            // Información adicional, como el total, se puede agregar aquí debajo de la tabla

            // Cerrar el documento
            doc.Close();
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
