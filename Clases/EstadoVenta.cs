using System;

namespace Clases
{
    public class EstadoVenta
    {
        private int idEstadoVenta;
        private String descripcion;
        public int IdEstadoVenta { get => idEstadoVenta; set => idEstadoVenta = value; }
        public String Descripcion { get => descripcion; set => descripcion = value; }
    }
}