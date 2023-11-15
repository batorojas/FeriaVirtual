using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Negocios;
using MetroFramework.Controls;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Message = System.Windows.Forms.Message;

namespace FeriaApp
{
    public partial class vVentasExternas : UserControl
    {
        NegocioCabeceraProcesoVenta negocioCabeceraPV = new NegocioCabeceraProcesoVenta();

        // private int idProcesoVenta;

        // public int IdProcesoVenta { get => idProcesoVenta; set => idProcesoVenta = value; }

        public vVentasExternas()
        {
            InitializeComponent();
        }

        public void vVentasExternas_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = null;
            metroTabControl1.SelectedIndex = 0;

            DataSet listarProcesosVenta = negocioCabeceraPV.ListarProcesosVentaExterna();
            this.dgvListaVentas.AutoGenerateColumns = true;
            this.dgvListaVentas.DataSource = listarProcesosVenta.Tables["CABECERA_PV"];
        }

        private void metroButtonDetallesPV_Click(object sender, EventArgs e)
        {
            int indiceFila = this.dgvListaVentas.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaVentas.Rows[indiceFila];
            int ProcesoVenta = int.Parse(filaSeleccionada.Cells["ID"].Value.ToString());
            metroTabControl1.SelectedIndex = 1;
            cargaDetalles(ProcesoVenta);
        }

        private void cargaDetalles(int pventa)
        {
            try
            {
                NegocioCabeceraProcesoVenta negocioCabeceraPV = new NegocioCabeceraProcesoVenta();
                CabeceraProcesoVenta procesoVenta = negocioCabeceraPV.buscarCabeceraProcesoVenta(pventa);

                NegocioCliente negocioCliente = new NegocioCliente();
                Cliente cliente = negocioCliente.buscarCliente(procesoVenta.RutCliente);

                NegocioEstadoVenta negocioEstadoVenta = new NegocioEstadoVenta();
                EstadoVenta estadoVenta = negocioEstadoVenta.buscarEstado(procesoVenta.IdEstado);

                NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();
                EmpresaTransporte empresaTransporte =
                    negocioTransporte.buscarEmpresaTransporte(procesoVenta.IdEmpresaTransporte);

                this.txtbIDProcesoVenta.Text = procesoVenta.IdCabeceraVenta.ToString();
                this.txtbRutCliente.Text = cliente.RutCliente.ToString() + "-" + cliente.DvRutCliente;
                this.txtbRazonSocial.Text = cliente.RazonSocialCliente;
                this.mdtFechaEmisionPV.Value = procesoVenta.FechaEmision;
                this.txtbEstado.Text = estadoVenta.Descripcion;
                this.txtbEmpresaTransporte.Text = empresaTransporte.NombreEmpresaTransporte;
                this.txtbObservacionesPV.Text = procesoVenta.Observaciones.ToString();

                NegocioDetalleProcesoVenta negocioDetallePV = new NegocioDetalleProcesoVenta();
                DataSet detalleProcesoVenta = negocioDetallePV.ListarDetallesProcesoVenta(procesoVenta.IdCabeceraVenta);
                this.dgvDetalleProcesoVenta.DataSource = detalleProcesoVenta.Tables["DETALLE_PV"];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            DataSet listaPagosPendientes = negocioCabeceraPV.ListarProcesosVentaExterna();

            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Formato: AñoMesDia_HoraMinutoSegundo
            string pdfFileName = $"Reporte_VentasExternas_{fechaActual}.pdf";

            string title = "Reporte de ventas externas";
            negocioCabeceraPV.ExportDataSetToPdf(listaPagosPendientes, pdfFileName, title);

            MessageBox.Show("Se ha exportado la lista de ventas externas exitosamente.");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataSet listarProcesosVenta = negocioCabeceraPV.ListarProcesosVentaExterna();
            this.dgvListaVentas.AutoGenerateColumns = true;
            this.dgvListaVentas.DataSource = listarProcesosVenta.Tables["CABECERA_PV"];
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {

        }

        private void btnTransporte_Click_1(object sender, EventArgs e)
        {
            int idproceso = int.Parse(txtbIDProcesoVenta.Text);

            vSubastasTransporte vistaPostulacionesTransporte = new vSubastasTransporte(idproceso);
            vistaPostulacionesTransporte.ShowDialog();
        }

        private void btnProductores_Click(object sender, EventArgs e)
        {
            int idproceso = int.Parse(txtbIDProcesoVenta.Text);

            vPostulacionesProductores vistaPostulacionesProductores = new vPostulacionesProductores(idproceso);
            vistaPostulacionesProductores.ShowDialog();
        }

        private async void btnExportarDetalles_Click(object sender, EventArgs e)
        {
            int indiceFila = this.dgvListaVentas.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaVentas.Rows[indiceFila];
            int ProcesoVenta = int.Parse(filaSeleccionada.Cells["ID"].Value.ToString());
            DataSet listarDetallePagoVenta = negocioCabeceraPV.listarDetalleVenta(ProcesoVenta);
            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Formato: AñoMesDia_HoraMinutoSegundo
            string pdfFileName = $"Detalle_Pedido_{fechaActual}.pdf";
            string title = "DETALLE DE PEDIDO";
            negocioCabeceraPV.exportarDetallePedidoPDF(listarDetallePagoVenta, pdfFileName, title);
            MessageBox.Show("Se ha exportado el detalle del pedido.");
            var result = MessageBox.Show("¿Quiere enviar el detalle del pedido al usuario?", "Enviar a cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var botToken = "6762818327:AAHOiQlDwmDucqKgRacNDUBY7VRlHVNkYkA";
                var botClient = new TelegramBotClient(botToken);
                var chatId = 902743181;
                try
                {
                    using Stream stream = System.IO.File.OpenRead("facturas\\" + pdfFileName);
                    await botClient.SendDocumentAsync(chatId: chatId, document: InputFile.FromStream(stream: stream, fileName: pdfFileName), caption: "Gracias por su compra. Adjuntamos los detalles de su pedido.");
                    MessageBox.Show("Factura enviada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar el archivo a través de Telegram: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
