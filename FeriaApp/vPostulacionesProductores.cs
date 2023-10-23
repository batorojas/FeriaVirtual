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
using MetroFramework.Controls;

namespace FeriaApp
{
    public partial class vPostulacionesProductores : MetroForm
    {
        private int idProcesoVenta;
        public int IdProcesoVenta { get => idProcesoVenta; set => idProcesoVenta = value; }
        
        private vDetallePostulacionProductor detallePostulacionProductor = new vDetallePostulacionProductor();

        public vPostulacionesProductores(int idProcesoVenta)
        {
            InitializeComponent();
            this.IdProcesoVenta = idProcesoVenta;
        }

        private void vPostulacionesProductores_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = null;
            metroTabControl1.SelectedIndex = 0;

            // Cargar Postulaciones de Productores
            NegocioCabeceraPostulacion negocioCabeceraPostulacion = new NegocioCabeceraPostulacion();
            DataSet listaSubastasTransporte = negocioCabeceraPostulacion.ListarPostulaciones(this.IdProcesoVenta);

            this.dgvListaProductores.AutoGenerateColumns = true;
            this.dgvListaProductores.DataSource = listaSubastasTransporte.Tables["CABECERA_POSTULACION"];
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvListaProductores.SelectedCells.Count > 0)
            {
                int indiceFila = this.dgvListaProductores.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = this.dgvListaProductores.Rows[indiceFila];

                int valorIdCabezera = int.Parse(filaSeleccionada.Cells["ID_CABECERA_POSTULACION"].Value.ToString());

                // Esto carga el Control de Usuario (vDetallePostulacionProductor) dentro de la pestaña (metroTabPage2)
                if (!metroTabPage2.Controls.Contains(detallePostulacionProductor))
                {
                    // Elimina el Label metroLabelDetalles del formulario
                    this.Controls.Remove(metroLabelDetalles);
                    metroLabelDetalles.Dispose();
                    
                    metroTabPage2.Controls.Add(detallePostulacionProductor);
                }

                detallePostulacionProductor.IdCabezera = valorIdCabezera;
                detallePostulacionProductor.cargarDatos();
                
                metroTabControl1.SelectedIndex = 1;
            }
            else
            {
                // Manejar el caso en el que no se ha seleccionado ninguna celda
                MessageBox.Show("No se ha seleccionado ninguna celda.");
            }
        }

        private void vDetallePostulacionProductor1_Load(object sender, EventArgs e)
        {

        }
    }
}
