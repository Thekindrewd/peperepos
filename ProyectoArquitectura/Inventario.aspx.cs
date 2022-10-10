using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Negocios;
using Entidades;
using System.Data.SqlClient;



namespace ProyectoArquitectura
{
    public partial class Inventario : System.Web.UI.Page
    {
        public E_Inventario ObjInventario = new E_Inventario();
        public N_Inventario ObjNegocio = new N_Inventario();


        protected void grvListadoInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ObjInventario.IdArticulo = Convert.ToInt16(grvListadoInventario.DataKeys[grvListadoInventario.SelectedIndex].Value.ToString());

            ds = ObjNegocio.IBMSeleccionarInventario(ObjInventario.IdArticulo);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ObjValidarText(ds);
                Borrar();
                btnBorrarInv.Visible = true;
                btnModificarInv.Visible = true;
            }
        }


        private void EscondeControl()
        {
            pnlAltas.Visible = false;
            
        }

        private void VaciaTextbox()
        {
            tbNombreArt.Text = String.Empty;
            tbDescripcion.Text = String.Empty;
            tbClaveLab.Text = String.Empty;
            tbCantidad.Text = String.Empty;
        }

        /*private void PonMsg(string pTipo, string pMsg)
        {
            lblMensaje.Text = pTipo + ": " + pMsg;
            if (pTipo == "AVISO")
                lblMensaje.ForeColor = System.Drawing.Color.DarkBlue;
            else
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            lblMensaje.Visible = true;
        }*/

        private void TextObjValidar()
        {

            ObjInventario.NombreArticulo = tbNombreArt.Text;
            ObjInventario.Descripcion = tbDescripcion.Text;
            ObjInventario.ClaveLaboratorio = tbClaveLab.Text;
            ObjInventario.Cantidad = tbCantidad.Text;
            
        }
     

        private void ObjValidarText(DataSet ds)
       {
            
            tbNombreArt.Text = ds.Tables[0].Rows[0]["NombreArticulo"].ToString();
            tbDescripcion.Text = ds.Tables[0].Rows[0]["Descripcion"].ToString();
            tbClaveLab.Text = ds.Tables[0].Rows[0]["ClaveLaboratorio"].ToString();
            tbCantidad.Text = ds.Tables[0].Rows[0]["Cantidad"].ToString();

        }


        protected void btnAgregarInv_Click(object sender, EventArgs e)
        {

            // btnGrabar_Click.Visible = true;
            VaciaTextbox();
            pnlAltas.Visible = true;
            
        }

        protected void Borrar()
        {
            int nResultado = -1;

            TextObjValidar();
            ObjInventario.IdArticulo = Convert.ToInt16(grvListadoInventario.DataKeys[grvListadoInventario.SelectedIndex].Value.ToString());

            nResultado = ObjNegocio.IBMInventario("Borrar", ObjInventario);
            if (nResultado != -1)
                Response.Write("<script>.Window.alert('AVISO: El Inventario fue Borrado.')</script>");
            else
                Response.Write("<script>.Window.alert('AVISO: El inventario no pudo ser Borrado.')</script>");

        }

        protected void btnBorrarInv_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        protected void btnModificarInv_Click(object sender, EventArgs e)
        {
            int nResultado = -1;

            TextObjValidar();
            ObjInventario.IdArticulo = Convert.ToInt16(grvListadoInventario.DataKeys[grvListadoInventario.SelectedIndex].Value.ToString());

            nResultado = ObjNegocio.IBMInventario("Modificar", ObjInventario);
            if (nResultado != -1)
                Response.Write("<script>.Window.alert('AVISO: El Inventario fue modificado.')</script>");
            else
                Response.Write("<script>.Window.alert('AVISO: El inventario no pudo ser modificado.')</script>");
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {

            int nGrabados ;

            TextObjValidar();
            nGrabados = ObjNegocio.IBMInventario("Insertar", ObjInventario);
            if (nGrabados != 1)
                lblMensaje.Text = " ERROR, El Inventario no fue grabado ";
            else
                lblMensaje.Text = "AVISO, El inventario ha sido grabado correctamente ";

            Listado();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            VaciaTextbox();
            EscondeControl();
        }

        protected void Listado()
        {
            DataSet ds = new DataSet();

            ds = ObjNegocio.IBMListadoInventario();

            if (ds.Tables[0].Rows.Count > 0)
            {
                grvListadoInventario.DataSource = ds.Tables[0];
                grvListadoInventario.DataBind();

            }
            else
                lblMensaje.Text = "AVISO: No existen productos en el sistema.";

        }

        protected void btnListado_Click(object sender, EventArgs e)
        {
            Listado();
        }
    }
}