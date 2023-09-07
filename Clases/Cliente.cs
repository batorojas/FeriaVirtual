using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        private int rutCliente;
        private String dvRutCliente;
        private String razonSocialCliente;
        private String direccionCliente;
        private String giroCliente;
        private int idComunaCliente;
        private int idUsuarioCliente;
        private int idTipoCliente;

        public int RutCliente { get => rutCliente; set => rutCliente = value; }
        public string DvRutCliente { get => dvRutCliente; set => dvRutCliente = value; }
        public string RazonSocialCliente { get => razonSocialCliente; set => razonSocialCliente = value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }
        public string GiroCliente { get => giroCliente; set => giroCliente = value; }
        public int IdComunaCliente { get => idComunaCliente; set => idComunaCliente = value; }
        public int IdUsuarioCliente { get => idUsuarioCliente; set => idUsuarioCliente = value; }
        public int IdTipoCliente { get => idTipoCliente; set => idTipoCliente = value; }
    }
}
