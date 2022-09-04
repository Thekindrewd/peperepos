using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Datos
{
    public class D_Conexion { 

        public SqlConnection Conexion;

    public D_Conexion()
    {
        Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
    }

    public SqlConnection GetConexion()
    {
        return Conexion;
    }

    public void AbrirConexion()
    {
        try
        {
            if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }

        }
        catch (Exception ex)
        {
            throw new Exception("Error al tratar de conectar", ex);
        }
    }

    public void CerrarConexion()
    {
        try
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }

        }
        catch (Exception ex)
        {
            throw new Exception("Error al tratar de Cerrar la conexion", ex);
        }
    }
}
}