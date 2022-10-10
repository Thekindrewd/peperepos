using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

using Datos;
using Entidades;

namespace Negocios
{
    public class N_Inventario
    {
        D_Inventario objNegocioinventario = new D_Inventario();
        public int IBMInventario(string pAccion, E_Inventario objeE_Inventario)
        {
            return objNegocioinventario.IBMInventario(pAccion, objeE_Inventario);
        }
        
        public DataSet IBMListadoInventario()
        {
            return objNegocioinventario.IBMListadoInventario();
        }

        public DataSet IBMSeleccionarInventario(int pIdArticulo)
        {
            return objNegocioinventario.IBMSeleccionarInventario(pIdArticulo);
        }
    }
}