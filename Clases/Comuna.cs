using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Comuna
    {
        private int idComuna;
        private String nombreComuna;
        private int idProvincia;

        public int IdComuna { get => idComuna; set => idComuna = value; }
        public string NombreComuna { get => nombreComuna; set => nombreComuna = value; }
        public int IdProvincia { get => idProvincia; set => idProvincia = value; }
    }
}
