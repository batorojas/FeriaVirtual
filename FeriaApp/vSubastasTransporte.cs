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
using Negocios;
using Clases;

namespace FeriaApp
{
    public partial class vSubastasTransporte : MetroForm
    {
        private int idProcesoVenta;
        public int IdProcesoVenta { get => idProcesoVenta; set => idProcesoVenta = value; }

        public vSubastasTransporte(int idProcesoVenta)
        {
            InitializeComponent();
            this.IdProcesoVenta = idProcesoVenta;
        }

        private void vSubastasTransporte_Load(object sender, EventArgs e)
        {
            // Cargar subastas de transporte 
            NegocioCabeceraSubastaTransporte negocioCabeceraSubasta = new NegocioCabeceraSubastaTransporte();
            CabeceraSubastaTransporte subastaTransporte = negocioCabeceraSubasta.buscarSubastaTransporteDeProcesoVenta(this.IdProcesoVenta);

            NegocioDetalleSubastaTransporte negocioDetalleSubastaTransporte = new NegocioDetalleSubastaTransporte();
            DataSet listaSubastasTransporte = negocioDetalleSubastaTransporte.ListarDetallesSubasta(subastaTransporte.IdCabeceraSubasta);

            this.dgvListaTransporte.AutoGenerateColumns = true;
            this.dgvListaTransporte.DataSource = listaSubastasTransporte.Tables["DETALLE_SUBASTA"];
        }
    }
}
