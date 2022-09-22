<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.Master" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="ProyectoArquitectura.Inventario" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="pnlGrid" runat="server" Direction="LeftToRight" ForeColor="#0066CC" Height="231px" HorizontalAlign="Center" BackColor="Blue" BorderColor="#000099" BorderStyle="Inset" BorderWidth="50px" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Size="Medium">   
    
    <asp:GridView ID="grvListadoInventario" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdArticulo" DataSourceID="G" ForeColor="#333333" GridLines="None"  OnSelectedIndexChangeD="Page_Load"  Width="1383px" Height="189px" HorizontalAlign="Center" style="margin-left: 0px">
        
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="IdArticulo" HeaderText="IdArticulo" InsertVisible="False" ReadOnly="True" SortExpression="IdArticulo" />
            <asp:BoundField DataField="NombreArticulo" HeaderText="NombreArticulo" SortExpression="NombreArticulo" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
            <asp:BoundField DataField="ClaveLaboratorio" HeaderText="ClaveLaboratorio" SortExpression="ClaveLaboratorio" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" BorderStyle="Groove" CssClass="90%" HorizontalAlign="Center" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
        
    </asp:GridView>
    </asp:Panel>


    <asp:Button ID="btnAgregarInv" runat="server" OnClick="btnAgregarInv_Click" Text="Agregar Inventario" />

    <asp:Button ID="btnBorrarInv" runat="server" OnClick="btnBorrarInv_Click" Text="Borrar Inventario" />

    <asp:Button ID="btnModificarInv" runat="server" Text="Modificar Inventario" OnClick="btnModificarInv_Click" />

    <asp:Panel ID="pnlAltas" runat="server" BackColor="#FFFF66" Font-Bold="False" Height="398px">
         <asp:Label ID="lblNombreArt" runat="server" style="width: 170px; height: 22px; position: absolute; top: 514px; left: 10px" Text="Nombre Articulo:" Height="259px"></asp:Label>
         <asp:Label ID="lblMensaje" runat="server" style="width: 107px; height: 22px; float: left; position: absolute; top: 486px; left: 1221px" Height="259px"></asp:Label>
         <asp:TextBox ID="tbArticulo" runat="server" CssClass="float-start" style="width: 238px; height: 30px; position: absolute; top: 465px; left: 109px" Height="259px"></asp:TextBox>
         <asp:TextBox ID="tbDescripcion" runat="server" CssClass="float-start" style="width: 363px; height: 97px; position: absolute; top: 558px; left: 123px" Height="259px"></asp:TextBox>
         <asp:TextBox ID="tbCantidad" runat="server" CssClass="float-start" style="width: 120px; height: 30px; position: absolute; top: 711px; left: 103px" Height="259px"></asp:TextBox>
         <asp:TextBox ID="tbNombreArt" runat="server" CssClass="float-start" style="width: 262px; height: 30px; position: absolute; top: 511px; left: 159px" Height="259px"></asp:TextBox>
         <asp:TextBox ID="tbClaveLab" runat="server" CssClass="float-start" style="width: 441px; height: 30px; position: absolute; top: 667px; left: 166px" Height="259px"></asp:TextBox>
         <asp:Label ID="lblClaveLab" runat="server" style="width: 153px; height: 22px; float: left; position: absolute; top: 668px; left: 12px" Text="Clave Laboratorio:" Height="259px"></asp:Label>
         <asp:Label ID="lblCantidad" runat="server" style="width: 107px; height: 23px; float: left; position: absolute; top: 711px; left: 13px" Text="Cantidad:" Height="259px"></asp:Label>
         <asp:Label ID="lblDescripcion" runat="server" style="width: 108px; height: 30px; float: left; position: absolute; top: 560px; left: 13px" Text="Descripcion:" Height="259px"></asp:Label>
         <asp:Button ID="btnCancelar" runat="server" CssClass="position-absolute" style="width: 246px; height: 35px; top: 480px; left: 927px" Text="Cancelar" OnClick="btnCancelar_Click" Height="259px" />
         <asp:Button ID="btnGrabar" runat="server" CssClass="position-absolute" style="width: 246px; height: 35px; top: 480px; left: 672px" Text="Grabar" OnClick="btnGrabar_Click" Height="259px" />
         <asp:Label ID="lblIdArt" runat="server" CssClass="float-end" Height="259px" style="width: 107px; height: 22px; position: absolute; top: 465px; left: 11px" Text="Id Articulo:"></asp:Label>
    </asp:Panel>


    <asp:SqlDataSource ID="G" runat="server" ConnectionString="<%$ ConnectionStrings:conexionBD %>" SelectCommand="SELECT [IdArticulo], [NombreArticulo], [Descripcion], [ClaveLaboratorio], [Cantidad] FROM [T_Articulo]" OnSelecting="G_Selecting"></asp:SqlDataSource>

    </asp:Content>
