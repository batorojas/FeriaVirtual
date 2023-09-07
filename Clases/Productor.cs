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
        private String giroProductor;

        public int RutProductor { get => rutProductor; set => rutProductor = value; }
        public string DvRutProductor { get => dvRutProductor; set => dvRutProductor = value; }
        public string RazonSocialProductor { get => razonSocialProductor; set => razonSocialProductor = value; }
        public string GiroProductor { get => giroProductor; set => giroProductor = value; }
    }
}
