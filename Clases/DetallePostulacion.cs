using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class DetallePostulacion
    {
        private int idDetallePostulacion;
        private int idCabeceraPostulacion;
        private int idProducto;
        private int cantidad;
        private int precioUnitario;

        public int IdDetallePostulacion { get => idDetallePostulacion; set => idDetallePostulacion = value; }
        public int IdCabeceraPostulacion { get => idCabeceraPostulacion; set => idCabeceraPostulacion = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
    }
}
