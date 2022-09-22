using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class E_Inventario
    {
        
        private int _IdInventario;
        private int _IdArticulo;
        private string _NombreArticulo;
        private string _Descripcion;
        private int _ClaveLaboratorio;
        private int _Cantidad;

        public E_Inventario()
        {
        }

        public E_Inventario(int idInventario, int idArticulo, string nombreArticulo, string descripcion, int claveLaboratorio, int cantidad)
        {
            IdInventario = idInventario;
            IdArticulo = idArticulo;
            NombreArticulo = nombreArticulo;
            Descripcion = descripcion;
            ClaveLaboratorio = claveLaboratorio;
            Cantidad = cantidad;
        }
       
        public int IdInventario { get => _IdInventario; set => _IdInventario = value; }
        public int IdArticulo { get => _IdArticulo; set => _IdArticulo = value; }
        public string NombreArticulo { get => _NombreArticulo; set => _NombreArticulo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int ClaveLaboratorio { get => _ClaveLaboratorio; set => _ClaveLaboratorio = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
    }
}