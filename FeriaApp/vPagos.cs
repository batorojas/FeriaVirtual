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
            this.dgvListaPagosPendientes.DataSource = listaPagosPendientes.Tables["CABECERA_PV"];
            this.dgvListaPagosPendientes.AutoGenerateColumns = true;
        }

        private void cargaPagosRealizados()
        {
            DataSet listaPagosRealizados = negocioCabeceraProcesoVenta.listarPagosRealizados();
            this.dgvListaPagosRealizados.DataSource = listaPagosRealizados.Tables["CABECERA_PV"];
            this.dgvListaPagosRealizados.AutoGenerateColumns = true;
        }

        private void vPagos_Load(object sender, EventArgs e)
        {
            cargaPagosPendientes();
            cargaPagosRealizados();
            
        }

        private void metroButtonActualizarPago_Click(object sender, EventArgs e)
        {
            int indiceFila = this.dgvListaPagosPendientes.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaPagosPendientes.Rows[indiceFila];
            int idProcesoVenta = int.Parse(filaSeleccionada.Cells["ID_CABECERA_PV"].Value.ToString());
            negocioCabeceraProcesoVenta.actualizarEstadoProcesoVenta(idProcesoVenta, 2); // Marcar como pagada
            MessageBox.Show("Se ha registrado el proceso de venta como PAGADO.");
        }
    }
}