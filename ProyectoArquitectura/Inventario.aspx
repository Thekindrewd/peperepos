<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.Master" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="ProyectoArquitectura.Inventario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="234px" Width="332px" DataSourceID="Sqlinventario" AutoGenerateColumns="False" DataKeyNames="IdArticulo">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="IdArticulo" HeaderText="IdArticulo" InsertVisible="False" ReadOnly="True" SortExpression="IdArticulo" />
            <asp:BoundField DataField="NombreArticulo" HeaderText="NombreArticulo" SortExpression="NombreArticulo" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
            <asp:BoundField DataField="ClaveLaboratorio" HeaderText="ClaveLaboratorio" SortExpression="ClaveLaboratorio" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
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


    <asp:SqlDataSource ID="Sqlinventario" runat="server" ConnectionString="<%$ ConnectionStrings:SQLPrestamosConnectionString %>" SelectCommand="SELECT [IdArticulo], [NombreArticulo], [Descripcion], [ClaveLaboratorio], [Cantidad] FROM [T_Articulo]"></asp:SqlDataSource>
    <br />


</asp:Content>
