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
    }
}