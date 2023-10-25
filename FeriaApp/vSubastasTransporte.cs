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

        private void btnSeleccionarTransporte_Click(object sender, EventArgs e)
        {
            if (dgvListaTransporte.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Se seleccionará este transporte para el proceso de venta. ¿Está seguro que desea seleccionar este transporte?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int indiceFila = this.dgvListaTransporte.SelectedCells[0].RowIndex;
                    DataGridViewRow filaSeleccionada = this.dgvListaTransporte.Rows[indiceFila];

                    int idEmpresaTransporte = int.Parse(filaSeleccionada.Cells["ID_EMPRESA_TRANS"].Value.ToString());

                    NegocioCabeceraProcesoVenta negocioProcesoVenta = new NegocioCabeceraProcesoVenta();
                    negocioProcesoVenta.asignarTransporte(this.IdProcesoVenta, idEmpresaTransporte);

                    MessageBox.Show("Transporte seleccionado correctamente.");

                    this.Dispose();
                    System.GC.Collect();
                }
            }
            else
            {
                // Manejar el caso en el que no se ha seleccionado ninguna celda
                MessageBox.Show("No se ha seleccionado ninguna celda.");
            }
        }
    }
}
