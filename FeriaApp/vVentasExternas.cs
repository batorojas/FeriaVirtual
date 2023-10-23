using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Negocios;

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
            DataSet listarProcesosVenta = negocioCabeceraPV.ListarProcesosVenta();
            this.dgvListaVentas.AutoGenerateColumns = true;
            this.dgvListaVentas.DataSource = listarProcesosVenta.Tables["CABECERA_PV"];
        }
        
        private void metroButtonDetallesPV_Click(object sender, EventArgs e)
        {
            int indiceFila = this.dgvListaVentas.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaVentas.Rows[indiceFila];
            int ProcesoVenta = int.Parse(filaSeleccionada.Cells["ID_CABECERA_PV"].Value.ToString());
            metroTabControl1.SelectedIndex = 1;
            cargaDetalles(ProcesoVenta);
        }

        private void cargaDetalles(int pventa)
        {
            try { 
                NegocioCabeceraProcesoVenta negocioCabeceraPV = new NegocioCabeceraProcesoVenta();
                CabeceraProcesoVenta procesoVenta = negocioCabeceraPV.buscarCabeceraProcesoVenta(pventa);

                NegocioCliente negocioCliente = new NegocioCliente();
                Cliente cliente = negocioCliente.buscarCliente(procesoVenta.RutCliente);
            
                NegocioEstadoVenta negocioEstadoVenta = new NegocioEstadoVenta();
                EstadoVenta estadoVenta = negocioEstadoVenta.buscarEstado(procesoVenta.IdEstado);
            
                NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();
                EmpresaTransporte empresaTransporte = negocioTransporte.buscarEmpresaTransporte(procesoVenta.IdEmpresaTransporte);

                this.txtbIDProcesoVenta.Text = procesoVenta.IdCabeceraVenta.ToString();
                this.txtbRutCliente.Text = cliente.RutCliente.ToString()+"-"+cliente.DvRutCliente;
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
            DataSet listaVentasExternas = negocioCabeceraPV.ListarProcesosVenta();

            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); // Formato: AñoMesDia_HoraMinutoSegundo
            string pdfFileName = $"Reporte_VentasExternas_{fechaActual}.pdf";

            string title = "Reporte de ventas externas";
            negocioCabeceraPV.ExportDataSetToPdf(listaVentasExternas, pdfFileName, title);

            MessageBox.Show("Se ha generado el reporte de ventas externas.");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataSet listarProcesosVenta = negocioCabeceraPV.ListarProcesosVenta();
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
    }
}
