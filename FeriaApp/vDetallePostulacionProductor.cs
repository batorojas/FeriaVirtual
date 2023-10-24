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
    public partial class vDetallePostulacionProductor : UserControl
    {
        private int idPostulacion;

        public vDetallePostulacionProductor()
        {
            InitializeComponent();
        }

        public int IdCabezera
        {
            get { return idPostulacion; }
            set { idPostulacion = value; }
        }

        public void cargarDatos()
        {
            // cargar cabecera y detalles de proceso de venta
            NegocioCabeceraPostulacion negocioCabeceraPostulacion = new NegocioCabeceraPostulacion();
            CabeceraPostulacion postulacion = negocioCabeceraPostulacion.buscarCabeceraPostulacion(idPostulacion);

            NegocioProductor negocioProductor = new NegocioProductor();
            Productor productor = negocioProductor.buscarProductor(postulacion.RutProductor);

            NegocioEstadoPostulacion negocioEstadoPostulacion = new NegocioEstadoPostulacion();
            EstadoPostulacion estadoPostulacion = negocioEstadoPostulacion.buscarEstado(postulacion.IdEstadoPostulacion);

            this.txtIDPostulacion.Text = postulacion.IdCabeceraPostulacion.ToString();
            this.txtRutProductor.Text = productor.RutProductor.ToString() + "-" + productor.DvRutProductor;
            this.txtRazonSocial.Text = productor.RazonSocialProductor;
            this.mdtFechaEmision.Value = postulacion.FechaEmision;
            this.txtEstado.Text = estadoPostulacion.Descripcion;

            NegocioDetallePostulacion negocioDetallePostulacion = new NegocioDetallePostulacion();
            DataSet detallePostulacion = negocioDetallePostulacion.listarDetallesPostulacion(postulacion.IdCabeceraPostulacion);

            this.dgvDetallePostulacion.DataSource = detallePostulacion.Tables["DETALLE_POSTULACION"];

        }

        private void btnSeleccionarProductor_Click(object sender, EventArgs e)
        {
            // Buscar Postulacion Productor
            NegocioCabeceraPostulacion negocioCabeceraPostulacion = new NegocioCabeceraPostulacion();
            CabeceraPostulacion postulacion = negocioCabeceraPostulacion.buscarCabeceraPostulacion(idPostulacion);

            if (postulacion.IdEstadoPostulacion == 2)
            {
                MessageBox.Show("Esta postulación ya se encuentra aceptada.");
            }
            else
            {
                // Buscar detalles proceso de venta
                NegocioDetalleProcesoVenta negocioDetalleProcesoVenta = new NegocioDetalleProcesoVenta();
                DataSet detallesProcesoVenta = negocioDetalleProcesoVenta.ListarDetallesProcesoVenta(postulacion.IdCabeceraProcesoVenta);

                // Buscar postulaciones del proceso de venta
                DataSet postulacionesProcesoVenta = negocioCabeceraPostulacion.ListarPostulaciones(postulacion.IdCabeceraProcesoVenta);

                // Ver si es que quedan cupos para realizar la postulacion
                CabeceraSobrante cabeceraSobrante = new CabeceraSobrante();
                cabeceraSobrante.IdCabeceraProcesoVenta = -1;

                Boolean cerrarProcesoVenta = true;

                foreach (DataRow detalleProcesoVenta in detallesProcesoVenta.Tables["DETALLE_PV"].Rows)
                {
                    int unidadesCubiertas = 0;
                    int unidadesTotales = (int)detalleProcesoVenta["CANTIDAD"];

                    // Buscar las postulaciones que se han aceptado
                    foreach (DataRow postulacionProcesoVenta in postulacionesProcesoVenta.Tables["CABECERA_POSTULACION"].Rows)
                    {
                        if ((short)postulacionProcesoVenta["ID_ESTADO_POSTULACION"] == 2) // Postulacion fue aceptada
                        {
                            // Ir a buscar el detalle de la postulacion para saber la cantidad postulada
                            NegocioDetallePostulacion negocioDetallePostulacion = new NegocioDetallePostulacion();
                            DetallePostulacion detallePostulacion = negocioDetallePostulacion.buscarDetallePostulacion((int)postulacionProcesoVenta["ID_CABECERA_POSTULACION"], (short)detalleProcesoVenta["ID_PRODUCTO"]);

                            int unidadesPostuladas = detallePostulacion.Cantidad;
                            unidadesCubiertas += unidadesPostuladas;
                        }
                    }

                    // buscar unidades postuladas de esta postulacion
                    NegocioDetallePostulacion negDetallePostulacion = new NegocioDetallePostulacion();
                    DetallePostulacion detPostulacion = negDetallePostulacion.buscarDetallePostulacion(postulacion.IdCabeceraPostulacion, (short)detalleProcesoVenta["ID_PRODUCTO"]);
                    int unidPostuladas = detPostulacion.Cantidad;

                    if (unidadesCubiertas + unidPostuladas > unidadesTotales)
                    {
                        int diferencia = unidadesCubiertas + unidPostuladas - unidadesTotales;

                        // Agregar diferencia a sobrantes
                        if (cabeceraSobrante.IdCabeceraProcesoVenta == -1)
                        {
                            NegocioCabeceraSobrante negocioCabeceraSobrante = new NegocioCabeceraSobrante();
                            cabeceraSobrante.IdCabeceraProcesoVenta = postulacion.IdCabeceraProcesoVenta;
                            negocioCabeceraSobrante.ingresarCabeceraSobrante(cabeceraSobrante);

                            cabeceraSobrante.IdCabeceraSobrante = negocioCabeceraSobrante.buscarUltimaInsercion().IdCabeceraSobrante;
                        }
                        else
                        {
                            NegocioCabeceraSobrante negocioCabeceraSobrante = new NegocioCabeceraSobrante();
                            cabeceraSobrante = negocioCabeceraSobrante.buscarCabeceraSobrante(cabeceraSobrante.IdCabeceraSobrante);
                        }

                        NegocioDetalleSobrante negocioDetalleSobrante = new NegocioDetalleSobrante();
                        DetalleSobrante detalleSobrante = new DetalleSobrante();
                        detalleSobrante.IdCabeceraSobrante = cabeceraSobrante.IdCabeceraSobrante;
                        detalleSobrante.IdProducto = (short)detalleProcesoVenta["ID_PRODUCTO"];
                        detalleSobrante.Cantidad = diferencia;

                        negocioDetalleSobrante.ingresarDetalleSobrante(detalleSobrante);
                    }

                    if (unidadesCubiertas + unidPostuladas < unidadesTotales) cerrarProcesoVenta = false;
                }

                // Aceptar postulacion (Cambiar estado)
                negocioCabeceraPostulacion.actualizarEstadoPostulacion(postulacion.IdCabeceraPostulacion, 2); // Aceptada

                MessageBox.Show("La postulación ha sido aceptada exitosamente.");

                // Cerrar proceso de venta
                if (cerrarProcesoVenta == true)
                {
                    NegocioCabeceraProcesoVenta negocioCabeceraProcesoVenta = new NegocioCabeceraProcesoVenta();
                    negocioCabeceraProcesoVenta.actualizarEstadoProcesoVenta(postulacion.IdCabeceraProcesoVenta, 2);
                    MessageBox.Show("El proceso de venta ha sido cerrado, debido a que se han completado todos productos solicitados.");
                }

            }
        }
    }
}
