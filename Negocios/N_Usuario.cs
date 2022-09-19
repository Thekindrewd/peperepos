using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Datos;
using Entidades;

namespace Negocios
{
    public class N_Usuario
    {
        D_Usuarios objNegocioUsuario = new D_Usuarios();

        public int IBMUsuario(string pAccion, E_Usuarios objeE_Usuario)
        {
            return objNegocioUsuario.IBMUsuario(pAccion, objeE_Usuario: objeE_Usuario);
        }
    }
}