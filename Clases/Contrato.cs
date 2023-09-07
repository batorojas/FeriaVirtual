using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Contrato
    {
        private int idContrato;
        private DateTime fechaInicio;
        private DateTime fechaTermino;
        private int rutProductor;

        public int IdContrato { get => idContrato; set => idContrato = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaTermino { get => fechaTermino; set => fechaTermino = value; }
        public int RutProductor { get => rutProductor; set => rutProductor = value; }
    }
}
