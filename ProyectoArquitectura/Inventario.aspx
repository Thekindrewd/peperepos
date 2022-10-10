<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.Master" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="ProyectoArquitectura.Inventario" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            float: left;
            width: 262px;
            height: 30px;
            position: absolute;
            top: 421px;
            left: 159px;
        }
        .auto-style2 {
            width: 132px;
            height: 25px;
            position: absolute;
            top: 422px;
            left: 10px;
        }
        .auto-style3 {
            width: 108px;
            height: 30px;
            float: left;
            position: absolute;
            top: 467px;
            left: 13px;
        }
        .auto-style4 {
            float: left;
            width: 363px;
            height: 100px;
            position: absolute;
            top: 464px;
            left: 123px;
            right: 1324px;
        }
        .auto-style5 {
            width: 140px;
            height: 40px;
            float: left;
            position: absolute;
            top: 584px;
            left: 12px;
        }
        .auto-style6 {
            float: left;
            width: 439px;
            height: 30px;
            position: absolute;
            top: 579px;
            left: 166px;
        }
        .auto-style7 {
            float: left;
            width: 120px;
            height: 30px;
            position: absolute;
            top: 626px;
            left: 103px;
        }
        .auto-style8 {
            width: 75px;
            height: 34px;
            float: left;
            position: absolute;
            top: 630px;
            left: 13px;
        }
        .auto-style9 {
            position: absolute;
            width: 236px;
            height: 42px;
            top: 510px;
            left: 673px;
        }
        .auto-style10 {
            position: absolute;
            top: 421px;
            left: 674px;
            width: 236px;
            height: 42px;
            z-index: 1;
        }
        .auto-style11 {
            width: 175px;
            height: 56px;
            float: left;
            position: absolute;
            top: 429px;
            left: 956px;
            right: 687px;
        }
        .auto-style12 {
            margin-left: 1px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="pnlGrid" runat="server" Direction="LeftToRight" ForeColor="#0066CC" Height="231px" HorizontalAlign="Center" BackColor="Blue" BorderColor="#000099" BorderStyle="Inset" BorderWidth="50px" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Size="Medium">   
    
        &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="grvListadoInventario" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdArticulo" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grvListadoInventario_SelectedIndexChanged" Width="1420px" CssClass="auto-style12">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="IdArticulo" HeaderText="IdArticulo" SortExpression="IdArticulo" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="NombreArticulo" HeaderText="NombreArticulo" SortExpression="NombreArticulo" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                <asp:BoundField DataField="ClaveLaboratorio" HeaderText="ClaveLaboratorio" SortExpression="ClaveLaboratorio" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </asp:Panel>


    <asp:Button ID="btnAgregarInv" runat="server" OnClick="btnAgregarInv_Click" Text="Agregar Inventario" />

    <asp:Button ID="btnBorrarInv" runat="server" OnClick="btnBorrarInv_Click" Text="Borrar Inventario" />

    <asp:Button ID="btnModificarInv" runat="server" Text="Modificar Inventario" OnClick="btnModificarInv_Click" />

    <asp:Button ID="btnListadoInv" runat="server" OnClick="btnListado_Click" Text="Alistar Inventario" Width="212px" />

    <asp:Panel ID="pnlAltas" runat="server" BackColor="#FFFF66" Font-Bold="False" Height="390px" width="1400px" >
         <asp:Label ID="lblMensaje" runat="server" CssClass="auto-style11"></asp:Label>
         <asp:TextBox ID="tbDescripcion" runat="server" CssClass="auto-style4"></asp:TextBox>
         <asp:TextBox ID="tbCantidad" runat="server" CssClass="auto-style7"></asp:TextBox>
         <asp:TextBox ID="tbClaveLab" runat="server" CssClass="auto-style6"></asp:TextBox>
         <asp:Label ID="lblClaveLab" runat="server" CssClass="auto-style5" Text="Clave Laboratorio:"></asp:Label>
         <asp:Label ID="lblCantidad" runat="server" CssClass="auto-style8" Text="Cantidad:"></asp:Label>
         <asp:Label ID="lblDescripcion" runat="server" CssClass="auto-style3" Text="Descripcion:"></asp:Label>
         <asp:Button ID="btnGrabar" runat="server" CssClass="auto-style10" OnClick="btnGrabar_Click" Text="Grabar" />
         <asp:TextBox ID="tbNombreArt" runat="server" CssClass="auto-style1"></asp:TextBox>
         <asp:Button ID="btnCancelar" runat="server" CssClass="auto-style9" OnClick="btnCancelar_Click" Text="Cancelar" />
         <asp:Label ID="lblNombreArt" runat="server" CssClass="auto-style2" Text="Nombre Articulo:"></asp:Label>
    </asp:Panel>


    </asp:Content>
