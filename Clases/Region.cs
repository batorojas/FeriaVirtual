using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Region
    {
        private int idRegion;
        private String nombreRegion;
        private int idPais;

        public int IdRegion { get => idRegion; set => idRegion = value; }
        public string NombreRegion { get => nombreRegion; set => nombreRegion = value; }
        public int IdPais { get => idPais; set => idPais = value; }
    }
}
