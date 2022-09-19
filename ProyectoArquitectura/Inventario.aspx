<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.Master" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="ProyectoArquitectura.Inventario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="234px" Width="332px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField />
            <asp:BoundField DataField="1" HeaderText="Clave Laboratorio" SortExpression="1" />
            <asp:BoundField DataField="1" HeaderText="IdArticulo" SortExpression="1" />
            <asp:BoundField DataField="1" HeaderText="Nombre Articulo" SortExpression="1" />
            <asp:BoundField DataField="1" HeaderText="Descripcion" SortExpression="1" />
            <asp:BoundField DataField="1" HeaderText="Cantidad" SortExpression="1" />
            <asp:ButtonField Text="Button" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>


</asp:Content>
