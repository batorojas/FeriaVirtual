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
            // Eliminar despues de arreglar la tabla CABECERA_POSTULACION, le falta el campo idEstadoPostulacion
            metroLabel1.Text = idPostulacion.ToString();

            // cargar cabecera y detalles de proceso de venta
            NegocioCabeceraPostulacion negocioCabeceraPostulacion = new NegocioCabeceraPostulacion();
            CabeceraPostulacion postulacion = negocioCabeceraPostulacion.buscarCabeceraPostulacion(idPostulacion);

            MessageBox.Show(postulacion.RutProductor.ToString());

            NegocioProductor negocioProductor = new NegocioProductor();
            Productor productor = negocioProductor.buscarProductor(postulacion.RutProductor);

            // TO DO: REVISAR TABLA
            //NegocioEstadoPostulacion negocioEstadoPostulacion = new NegocioEstadoPostulacion();
            //EstadoPostulacion estadoPostulacion = negocioEstadoPostulacion.buscarEstado(postulacion.IdEstadoPostulacion);

            this.txtIDPostulacion.Text = postulacion.IdCabeceraPostulacion.ToString();
            this.txtRutProductor.Text = productor.RutProductor.ToString() + "-" + productor.DvRutProductor;
            this.txtRazonSocial.Text = productor.RazonSocialProductor;
            // this.mdtFechaEmision.Value = postulacion.FechaEmision;
            // this.txtEstado.Text = estadoPostulacion.Descripcion;

            NegocioDetallePostulacion negocioDetallePostulacion = new NegocioDetallePostulacion();
            DataSet detallePostulacion = negocioDetallePostulacion.listarDetallesPostulacion(postulacion.IdCabeceraPostulacion);

            this.dgvDetallePostulacion.DataSource = detallePostulacion.Tables["DETALLE_POSTULACION"];

        }
    }
}
