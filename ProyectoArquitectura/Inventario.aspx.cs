using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;


namespace ProyectoArquitectura
{
    public partial class Inventario : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(local)\DESKTOP-D8UU1S6; initial Catalog = SQL_DataBase; Integrate security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
            }

        }
    }
}