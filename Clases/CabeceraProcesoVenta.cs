using System;

namespace Clases
{
    public class CabeceraProcesoVenta
    {
        private int idCabeceraVenta;
        private int idEmpresaTransporte;
        private DateTime fechaEmision;
        private String observaciones;
        private int idEstado;
        private int rutCliente;

        public int IdCabeceraVenta { get => idCabeceraVenta; set => idCabeceraVenta = value; }
        public int IdEmpresaTransporte { get => idEmpresaTransporte; set => idEmpresaTransporte = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public int RutCliente { get => rutCliente; set => rutCliente = value; }
    }
}