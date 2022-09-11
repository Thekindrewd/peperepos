using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

using Entidades;

namespace Datos
{
    public class D_Usuarios: D_Conexion
    {
        public D_Usuarios() { }

        public int IBMUsuario(string pAccion, E_Usuarios objeE_Usuario)
        {
            int Resultado =0;
            SqlCommand cmd = new SqlCommand("IBM_Usuario", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdUsuario", objeE_Usuario.IdUsuario);
            cmd.Parameters.AddWithValue("@IdEstadoUsuario", objeE_Usuario.IdEstadoUsuario);
            cmd.Parameters.AddWithValue("@IdTipoUsuario", objeE_Usuario.IdTipoUsuario);
            cmd.Parameters.AddWithValue("@NombreUsuario", objeE_Usuario.NombreUsuario);
            cmd.Parameters.AddWithValue("@APaterno", objeE_Usuario.APaterno);
            cmd.Parameters.AddWithValue("@AMaterno", objeE_Usuario.AMaterno);
            cmd.Parameters.AddWithValue("@EmailUsuario", objeE_Usuario.EmailUsuario);
            cmd.Parameters.AddWithValue("@PassWordUsuario", objeE_Usuario.PassWordUsuario);
            cmd.Parameters.AddWithValue("@CodigoRecuperacion", objeE_Usuario.CodigoRecuperacion);

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR al tratar de almacenar, modificar o borrar",ex);
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