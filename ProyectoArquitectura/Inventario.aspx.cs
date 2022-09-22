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
         
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            //ObjInventario.IdArticulo = Convert.ToString(grvListadoInventario.DataKeys[grvListadoInventario.SelectedIndex].Value.ToString());

            //ds = ObjNegocio.SeleccionarProducto(ObjInventario.IdProducto);

            //ObjValidarText(ds);
            btnBorrarInv.Visible = true;
            btnModificarInv.Visible = true;
           // EscondeControl();
        }

        private void EscondeControl()
        {
            pnlAltas.Visible = false;
            
        }
        private void VaciaTextbox()
        {
            tbArticulo.Text = String.Empty;
            tbNombreArt.Text = String.Empty;
            tbDescripcion.Text = String.Empty;
            tbClaveLab.Text = String.Empty;
            tbCantidad.Text = String.Empty;
        }

        private void PonMsg(string pTipo, string pMsg)
        {
            lblMensaje.Text = pTipo + ": " + pMsg;
            if (pTipo == "AVISO")
                lblMensaje.ForeColor = System.Drawing.Color.DarkBlue;
            else
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            lblMensaje.Visible = true;
        }

        private void TextObjValidar()
        {
            
            ObjInventario.NombreArticulo = tbNombreArt.Text;
            ObjInventario.Descripcion = tbDescripcion.Text;
            ObjInventario.ClaveLaboratorio = Convert.ToInt16(tbClaveLab.Text);
            ObjInventario.Cantidad = Convert.ToInt16(tbCantidad.Text) ;
            
        }

        //private void ObjValidarText(DataSet ds)
       //{
            //tbArticulo.Text = ds.Tables[0].Rows[0]["IdArticulo"].ToString();
            //tbNombreArt.Text = ds.Tables[0].Rows[0]["NombreArticulo"].ToString();
            //tbDescripcion.Text = ds.Tables[0].Rows[0]["Descripcion"].ToString();
            //tbClaveLab.Text = ds.Tables[0].Rows[0]["ClaveLaboratorio"].ToString();
            //tbCantidad.Text = ds.Tables[0].Rows[0]["Cantidad"].ToString();
        //}


        protected void btnAgregarInv_Click(object sender, EventArgs e)
        {
           // btnGrabar_Click.Visible = true;
            VaciaTextbox();
            pnlAltas.Visible = true;
            lblMensaje.Text = String.Empty;
        }

        protected void btnBorrarInv_Click(object sender, EventArgs e)
        {

        }

        protected void btnModificarInv_Click(object sender, EventArgs e)
        {

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {

            int nGrabados = -1;

            TextObjValidar();
            nGrabados = ObjNegocio.IBMInventario("Insertar", ObjInventario);
            if (nGrabados != 1)
                lblMensaje.Text = "AVISO, El inventario ha sido grabado correctamente";
            else
                lblMensaje.Text = "ERROR, El Inventario no fue grabado";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            VaciaTextbox();
            EscondeControl();
        }

        protected void G_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}