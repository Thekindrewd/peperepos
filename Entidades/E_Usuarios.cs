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
        private int _IdUsuarioFK;
        private int _IdEstadoUsuario;
        private string _NombreUsuario;
        private string _APaternoUsuario;
        private string _AMaternoUsuario;
        private string _Email;
        private string _Clave;
        private int _CRecuperacion;

        public E_Usuarios(string accion, int idUsuario, int idUsuarioFK, int idEstadoUsuario, string nombreUsuario, string aPaternoUsuario, string aMaternoUsuario, string email, string clave, int cRecuperacion)
        {
            Accion = accion;
            IdUsuario = idUsuario;
            IdUsuarioFK = idUsuarioFK;
            IdEstadoUsuario = idEstadoUsuario;
            NombreUsuario = nombreUsuario;
            APaternoUsuario = aPaternoUsuario;
            AMaternoUsuario = aMaternoUsuario;
            Email = email;
            Clave = clave;
            CRecuperacion = cRecuperacion;
        }

        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdUsuarioFK { get => _IdUsuarioFK; set => _IdUsuarioFK = value; }
        public int IdEstadoUsuario { get => _IdEstadoUsuario; set => _IdEstadoUsuario = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string APaternoUsuario { get => _APaternoUsuario; set => _APaternoUsuario = value; }
        public string AMaternoUsuario { get => _AMaternoUsuario; set => _AMaternoUsuario = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public int CRecuperacion { get => _CRecuperacion; set => _CRecuperacion = value; }
    }
}