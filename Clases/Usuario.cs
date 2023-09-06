using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        private int idUser;
        private String userName;
        private String password;
        private DateTime fechaCreacion;
        private int idPerfil;
        private int idEstadoCuenta;

        public int IdUser { get => idUser; set => idUser = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public int IdEstadoCuenta { get => idEstadoCuenta; set => idEstadoCuenta = value; }
    }
}
