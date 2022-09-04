using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class E_Usuarios
    {
        private string _Accion;
        private int _IdUsuario;
        private int _IdTipoUsuario;
        private int _IdEstadoUsuario;
        private string _NombreUsuario;
        private string _APaterno;
        private string _AMaterno;
        private string _EmailUsuario;
        private string _PassWordUsuario;
        private int _CodigoRecuperacion;

        public E_Usuarios(string accion, int idUsuario, int idTipoUsuario, int idEstadoUsuario, string nombreUsuario, string aPaterno, string aMaterno, string emailUsuario, string passWordUsuario, int codigoRecuperacion)
        {
            Accion = accion;
            IdUsuario = idUsuario;
            IdTipoUsuario = idTipoUsuario;
            IdEstadoUsuario = idEstadoUsuario;
            NombreUsuario = nombreUsuario;
            APaterno = aPaterno;
            AMaterno = aMaterno;
            EmailUsuario = emailUsuario;
            PassWordUsuario = passWordUsuario;
            CodigoRecuperacion = codigoRecuperacion;
        }

        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdTipoUsuario { get => _IdTipoUsuario; set => _IdTipoUsuario = value; }
        public int IdEstadoUsuario { get => _IdEstadoUsuario; set => _IdEstadoUsuario = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string APaterno { get => _APaterno; set => _APaterno = value; }
        public string AMaterno { get => _AMaterno; set => _AMaterno = value; }
        public string EmailUsuario { get => _EmailUsuario; set => _EmailUsuario = value; }
        public string PassWordUsuario { get => _PassWordUsuario; set => _PassWordUsuario = value; }
        public int CodigoRecuperacion { get => _CodigoRecuperacion; set => _CodigoRecuperacion = value; }
    }
}