using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TipoCliente
    {
        private int idTipoCliente;
        private String descTipoCliente;

        public int IdTipoCliente { get => idTipoCliente; set => idTipoCliente = value; }
        public string DescTipoCliente { get => descTipoCliente; set => descTipoCliente = value; }
    }
}
