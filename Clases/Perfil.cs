using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Perfil
    {
        private int idPerfil;
        private String descPerfil;

        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public string DescPerfil { get => descPerfil; set => descPerfil = value; }
    }
}
