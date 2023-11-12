using Clases;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeriaApp
{
    public partial class vVentasLocales : UserControl
    {
        NegocioCabeceraProcesoVenta negocioCabeceraPV = new NegocioCabeceraProcesoVenta();


        public vVentasLocales()
        {
            InitializeComponent();
        }

        private void vVentasLocales_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = null;
            metroTabControl1.SelectedIndex = 0;

            DataSet listarProcesosVenta = negocioCabeceraPV.ListarProcesosVentaLocal();
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
                EmpresaTransporte empresaTransporte = negocioTransporte.buscarEmpresaTransporte(procesoVenta.IdEmpresaTransporte);

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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            DataSet listaVentasExternas = negocioCabeceraPV.ListarProcesosVentaLocal();

            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Formato: AñoMesDia_HoraMinutoSegundo
            string pdfFileName = $"Reporte_VentasLocales_{fechaActual}.pdf";

            string title = "Reporte de ventas locales";
            negocioCabeceraPV.ExportDataSetToPdf(listaVentasExternas, pdfFileName, title);

            MessageBox.Show("Se ha generado el reporte de ventas locales.");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataSet listarProcesosVenta = negocioCabeceraPV.ListarProcesosVentaLocal();
            this.dgvListaVentas.AutoGenerateColumns = true;
            this.dgvListaVentas.DataSource = listarProcesosVenta.Tables["CABECERA_PV"];
        }

        private void btnTransporte_Click(object sender, EventArgs e)
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
    }
}
