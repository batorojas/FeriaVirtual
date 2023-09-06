using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Provincia
    {
        private int idProvincia;
        private String nombreProvincia;
        private int idRegion;

        public int IdProvincia { get => idProvincia; set => idProvincia = value; }
        public string NombreProvincia { get => nombreProvincia; set => nombreProvincia = value; }
        public int IdRegion { get => idRegion; set => idRegion = value; }
    }
}
