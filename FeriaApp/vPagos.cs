using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Telegram.Bot;

namespace FeriaApp
{
    public partial class vPagos : UserControl
    {
        NegocioCabeceraProcesoVenta negocioCabeceraProcesoVenta = new NegocioCabeceraProcesoVenta();

        public vPagos()
        {
            InitializeComponent();
        }

        private void cargaPagosPendientes()
        {
            DataSet listaPagosPendientes = negocioCabeceraProcesoVenta.listarPagosPendientes();
            this.dgvListaPagosPendientes.AutoGenerateColumns = true;
            this.dgvListaPagosPendientes.DataSource = listaPagosPendientes.Tables["CABECERA_PV"];
        }

        private void cargaPagosRealizados()
        {
            DataSet listaPagosRealizados = negocioCabeceraProcesoVenta.listarPagosRealizados();
            this.dgvListaPagosRealizados.AutoGenerateColumns = true;
            this.dgvListaPagosRealizados.DataSource = listaPagosRealizados.Tables["CABECERA_PV"];
        }

        private void vPagos_Load(object sender, EventArgs e)
        {
            //cargaPagosPendientes();
            //cargaPagosRealizados();

            // define la pestaña actual seleccionada como null
            metroTabControl1.SelectedTab = null;
            metroTabControl1.SelectedIndex = 0;
        }

        private void metroButtonActualizarPago_Click(object sender, EventArgs e)
        {
            // Check if there are selected cells in the DataGridView
            if (this.dgvListaPagosPendientes.SelectedCells.Count > 0)
            {
                int indiceFila = this.dgvListaPagosPendientes.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = this.dgvListaPagosPendientes.Rows[indiceFila];

                // Get the value from the "ID_CABECERA_PV" cell
                object idCabeceraPVObject = filaSeleccionada.Cells["ID_CABECERA_PV"].Value;

                // Check if the value is not null
                if (idCabeceraPVObject != null)
                {
                    int idProcesoVenta;

                    // Try parsing the value to an integer
                    if (int.TryParse(idCabeceraPVObject.ToString(), out idProcesoVenta))
                    {
                        try
                        {
                            // Assuming negocioCabeceraProcesoVenta is properly initialized
                            negocioCabeceraProcesoVenta.actualizarEstadoProcesoVenta(idProcesoVenta,
                                2); // Marcar como pagada
                            MessageBox.Show("Se ha registrado el proceso de venta como PAGADO.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar el estado del proceso de venta: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor de ID_CABECERA_PV no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El valor de la celda ID_CABECERA_PV es nulo.");
                }
            }
            else
            {
                MessageBox.Show("Ninguna celda seleccionada.");
            }

            cargaPagosPendientes();
        }


        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el índice de la pestaña actualmente seleccionada
            int tabIndex = metroTabControl1.SelectedIndex;

            // Ejecuta funciones basadas en la pestaña seleccionada
            switch (tabIndex)
            {
                case 0:
                    cargaPagosPendientes();
                    break;

                case 1:
                    cargaPagosRealizados();
                    break;
            }
        }



        private void btnExportarPagosPendientes_Click(object sender, EventArgs e)
        {
            DataSet listaPagosPendientes = negocioCabeceraProcesoVenta.listarPagosPendientes();

            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Formato: AñoMesDia_HoraMinutoSegundo
            string pdfFileName = $"Reporte_PagosPendientes_{fechaActual}.pdf";

            string title = "Reporte de pagos pendientes";
            negocioCabeceraProcesoVenta.ExportDataSetToPdf(listaPagosPendientes, pdfFileName, title);

            MessageBox.Show("Se ha exportado el reporte de pagos pendientes.");
        }

        private void btnExportarHistorialPagos_Click(object sender, EventArgs e)
        {
            DataSet listaPagosRealizados = negocioCabeceraProcesoVenta.listarPagosRealizados();

            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Formato: AñoMesDia_HoraMinutoSegundo
            string pdfFileName = $"Reporte_VentasExternas_{fechaActual}.pdf";

            string title = "Reporte de ventas externas";
            negocioCabeceraProcesoVenta.ExportDataSetToPdf(listaPagosRealizados, pdfFileName, title);

            MessageBox.Show("Se ha exportado el reporte de pagos realizados.");
        }

        private async void metroEnviarCorreo_Click(object sender, EventArgs e)
        {
            var botToken = "6762818327:AAHOiQlDwmDucqKgRacNDUBY7VRlHVNkYkA";

            var botClient = new TelegramBotClient(botToken);

            // Replace "CHAT_ID" with the chat ID of the user or chat where you want to send the message
            var chatId = 902743181;

            // The message you want to send
            var message = "Su pago ha sido aceptado. ¡Gracias por su compra!";

            try
            {
                await botClient.SendTextMessageAsync(chatId, message);
                MessageBox.Show("El mensaje se ha enviado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el mensaje: {ex.Message}");
            }
        }
    }
}
