using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class EstadoPostulacion
    {
        private int idEstadoPostulacion;
        private String descripcion;

        public int IdEstadoPostulacion { get => idEstadoPostulacion; set => idEstadoPostulacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
