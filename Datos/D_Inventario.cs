using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

using Entidades;

namespace Datos
{
    public class D_Inventario: D_Conexion
    {
        public D_Inventario() { }

        public int IBMInventario(string pAccion, E_Inventario objeE_Inventario)
        {
            int Resultado = 0;

            SqlCommand cmd = new SqlCommand("IBM_Inventario", Conexion)//si esta mal es por que el nombre del stored procedure esta mal
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdInventario", objeE_Inventario.IdInventario);
            cmd.Parameters.AddWithValue("@IdArticulo", objeE_Inventario.IdArticulo);
            cmd.Parameters.AddWithValue("@NombreArticulo", objeE_Inventario.NombreArticulo);
            cmd.Parameters.AddWithValue("@Descripcion", objeE_Inventario.Descripcion);
            cmd.Parameters.AddWithValue("@ClaveLaboratorio", objeE_Inventario.ClaveLaboratorio);
            cmd.Parameters.AddWithValue("@Cantidad", objeE_Inventario.Cantidad);

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Resultado = 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR al tratar de almacenar, modificar o borrar", ex);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return Resultado;
        }   
    }
}