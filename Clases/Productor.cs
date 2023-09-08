using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Productor
    {
        private int rutProductor;
        private String dvRutProductor;
        private String razonSocialProductor;
        private String direccionProductor;
        private String giroProductor;
        private int idComunaProductor;
        private int idUsuarioProductor;

        public int RutProductor { get => rutProductor; set => rutProductor = value; }
        public string DvRutProductor { get => dvRutProductor; set => dvRutProductor = value; }
        public string RazonSocialProductor { get => razonSocialProductor; set => razonSocialProductor = value; }
        public string DireccionProductor { get => direccionProductor; set => direccionProductor = value; }
        public string GiroProductor { get => giroProductor; set => giroProductor = value; }
        public int IdComunaProductor { get => idComunaProductor; set => idComunaProductor = value; }
        public int IdUsuarioProductor { get => idUsuarioProductor; set => idUsuarioProductor = value; }
    }
}