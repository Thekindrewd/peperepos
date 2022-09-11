using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Entidades;
using Negocios;

namespace ProyectoArquitectura
{
    public partial class Registro : System.Web.UI.Page
    {
        public E_Usuarios ObjUsuario = new E_Usuarios();
        public N_Usuario ObjNegocio = new N_Usuario(); 

        private void Limpiar()
        {
            lbNombre.Text = "";
            lbAP.Text = "";
            lbAM.Text = "";
            lbemail.Text = "";
            lbPassword.Text = "";
            lbemail.Text = "";
            lbConfiPassword.Text = "";

        }

        private void TextObj()
        {
            ObjUsuario.NombreUsuario = lbNombre.Text;
            ObjUsuario.APaterno = lbAP.Text;
            ObjUsuario.AMaterno = lbAM.Text;
            ObjUsuario.EmailUsuario = lbemail.Text;
            ObjUsuario.PassWordUsuario = lbPassword.Text;
            ObjUsuario.IdTipoUsuario = DLTipoUsuario.SelectedIndex;
            ObjUsuario.CodigoRecuperacion = 123;
            //ObjUsuario.IdEstadoUsuario = ;
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(lbNombre.Text == "")
            {
                LblError.Text = "Ingrese su nombre";
            }
            else
            {
                if (lbAP.Text == "")
                {
                    LblError.Text = "Ingrese su Apellido Paterno";
                }
                else
                {
                    if(lbAM.Text == "")
                    {
                        LblError.Text = "Ingrese su Apellido Materno";
                    }
                    else
                    {
                        if(lbemail.Text == "")//hay que pensar en alguna forma de hacer que los usuarios solo puedan ingresar correos institucionales
                        {
                            LblError.Text = "Ingrese su correo institucional";
                        }
                        else
                        {
                            if(lbPassword.Text == "")
                            {
                                LblError.Text = "Ingrese su contraseña";
                            }
                            else
                            {
                                if(lbConfiPassword.Text != lbPassword.Text)
                                {
                                    LblError.Text = "La contraseña no coinciden";
                                }
                                else
                                {
                                    int nGrabar = -1;

                                    TextObj();
                                    nGrabar = ObjNegocio.IBMUsuario("Insertar", ObjUsuario);
                                    if(nGrabar != -1)
                                    {
                                        LblError.Text="Haz sido registrado";
                                    }
                                    else
                                    {
                                        LblError.Text = "ERROR, no se a podido registrar tu informacion";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }

    
    }
}