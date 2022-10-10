using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

using Entidades;

namespace Datos
{
    public class D_Inventario : D_Conexion
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

            cmd.Parameters.AddWithValue("@IdArticulo", objeE_Inventario.IdArticulo);
            cmd.Parameters.AddWithValue("@NombreArticulo", objeE_Inventario.NombreArticulo);
            cmd.Parameters.AddWithValue("@Descripcion", objeE_Inventario.Descripcion);
            cmd.Parameters.AddWithValue("@ClaveLaboratorio", objeE_Inventario.ClaveLaboratorio);
            cmd.Parameters.AddWithValue("@Cantidad", objeE_Inventario.Cantidad);

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();

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
        public DataSet IBMListadoInventario()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[IBM_ListadoInventario]";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos Inventario ", ex);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;

        }

        public DataSet IBMSeleccionarInventario(int pIdArticulo)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[IBM_SelecionarInventario]";
               
                cmd.Parameters.AddWithValue("@IdArticulo", pIdArticulo);

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos Inventario ", ex);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;

        }
    }
}