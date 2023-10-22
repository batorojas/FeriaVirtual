using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CabeceraSubastaTransporte
    {
        private int idCabeceraSubasta;
        private DateTime fechaLimiteEntrega;
        private int idComuna;
        private int idCabeceraProcesoVenta;
        private int idEstadoSubasta;

        public int IdCabeceraSubasta { get => idCabeceraSubasta; set => idCabeceraSubasta = value; }
        public DateTime FechaLimiteEntrega { get => fechaLimiteEntrega; set => fechaLimiteEntrega = value; }
        public int IdComuna { get => idComuna; set => idComuna = value; }
        public int IdCabeceraProcesoVenta { get => idCabeceraProcesoVenta; set => idCabeceraProcesoVenta = value; }
        public int IdEstadoSubasta { get => idEstadoSubasta; set => idEstadoSubasta = value; }
    }
}
