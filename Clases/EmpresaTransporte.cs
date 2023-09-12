using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class EmpresaTransporte
    {
        private int idEmpresaTransporte;
        private String nombreEmpresaTransporte;
        private int idUsuarioEmpresaTransporte;

        public int IdEmpresaTransporte { get => idEmpresaTransporte; set => idEmpresaTransporte = value; }
        public string NombreEmpresaTransporte { get => nombreEmpresaTransporte; set => nombreEmpresaTransporte = value; }
        public int IdUsuarioEmpresaTransporte { get => idUsuarioEmpresaTransporte; set => idUsuarioEmpresaTransporte = value; }
    }
}
