using System;
using System.Data;
using System.Windows.Forms;
using Negocios;

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
                            negocioCabeceraProcesoVenta.actualizarEstadoProcesoVenta(idProcesoVenta, 2); // Marcar como pagada
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

                default:
                    // Realizar acción predeterminada si no coincide con ninguna opción
                    MessageBox.Show("Opción no reconocida");
                    break;
            }
        }
    }
}