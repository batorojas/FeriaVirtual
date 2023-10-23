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

namespace FeriaApp
{
    public partial class vPostulacionesProductores : MetroForm
    {
        private int idProcesoVenta;
        public int IdProcesoVenta { get => idProcesoVenta; set => idProcesoVenta = value; }
        
        public vPostulacionesProductores(int idProcesoVenta)
        {
            InitializeComponent();
            this.IdProcesoVenta = idProcesoVenta;
        }

        private void vPostulacionesProductores_Load(object sender, EventArgs e)
        {
            // Cargar Postulaciones de Productores
            NegocioCabeceraPostulacion negocioCabeceraPostulacion = new NegocioCabeceraPostulacion();
            DataSet listaSubastasTransporte = negocioCabeceraPostulacion.ListarPostulaciones(this.IdProcesoVenta);

            this.dgvListaProductores.AutoGenerateColumns = true;
            this.dgvListaProductores.DataSource = listaSubastasTransporte.Tables["CABECERA_POSTULACION"];
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            int indiceFila = this.dgvListaProductores.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = this.dgvListaProductores.Rows[indiceFila];

            //int valorIdCabezera = int.Parse(filaSeleccionada.Cells["ID_CABECERA_POSTULACION"].Value.ToString());
            //vDetallePostulacionProductor1.IdCabezera = valorIdCabezera;
        }

        private void vDetallePostulacionProductor1_Load(object sender, EventArgs e)
        {

        }
    }
}
