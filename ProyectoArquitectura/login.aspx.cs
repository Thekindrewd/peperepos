using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Entidades;
using Negocios;
using System.Data.SqlClient;

namespace ProyectoArquitectura
{
    public partial class login : System.Web.UI.Page
    {
        public E_Usuarios ObjUsuario = new E_Usuarios();
        public N_Usuario ObjNegocio = new N_Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void TextObjValidar()
        {
            ObjUsuario.NombreUsuario = tbClave.Text;
            ObjUsuario.APaterno = tbClave.Text;
            ObjUsuario.AMaterno = tbClave.Text;
            //ObjUsuario.IdEstadoUsuario = 1;

            ObjUsuario.EmailUsuario = tbEmail.Text;
            ObjUsuario.PassWordUsuario = tbClave.Text;
        }

        protected void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text == "")
            {
                lbErrorValidar.Text = "Email Incorrecto, vuelva a ingresar su correo";
            }
            else
            {
                if (tbClave.Text == "")
                {
                    lbErrorValidar.Text = "Contraseña Incorrectar, vuelva a ingresar su contraseña";
                }
                else
                { 
                    int nValidar = -1;

                    TextObjValidar();
                    nValidar = ObjNegocio.IBMUsuario("Validar", ObjUsuario);
                    
                    if (nValidar == 1)
                    {

                        Response.Redirect("MainEstudiante.aspx");
                    }
                    else
                    {
                        if(nValidar == 2)
                        {
                            Response.Redirect("MainMaestro.aspx");
                        }
                        else
                        {
                            if (nValidar == 3)
                            {
                                Response.Redirect("MainPasante.aspx");
                            }
                            else
                            {
                                if (nValidar == 4)
                                {
                                    Response.Redirect("MainAdmin.aspx");
                                }
                                else
                                {
                                    lbErrorValidar.Text = +nValidar+"";
                                }
                            }
                        }
                    }
                }
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
    }
}