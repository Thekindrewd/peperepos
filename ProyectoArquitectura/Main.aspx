<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ProyectoArquitectura.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="IdUsuario">
                <Columns>
                    <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" ReadOnly="True" SortExpression="IdUsuario" />
                    <asp:BoundField DataField="IdEstadoUsuario" HeaderText="IdEstadoUsuario" SortExpression="IdEstadoUsuario" />
                    <asp:BoundField DataField="IdTipoUsuario" HeaderText="IdTipoUsuario" SortExpression="IdTipoUsuario" />
                    <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario" />
                    <asp:BoundField DataField="APaterno" HeaderText="APaterno" SortExpression="APaterno" />
                    <asp:BoundField DataField="AMaterno" HeaderText="AMaterno" SortExpression="AMaterno" />
                    <asp:BoundField DataField="EmailUsuario" HeaderText="EmailUsuario" SortExpression="EmailUsuario" />
                    <asp:BoundField DataField="PassWordUsuario" HeaderText="PassWordUsuario" SortExpression="PassWordUsuario" />
                    <asp:BoundField DataField="CodigoRecuperacion" HeaderText="CodigoRecuperacion" SortExpression="CodigoRecuperacion" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conexionBD %>" SelectCommand="SELECT [IdUsuario], [IdEstadoUsuario], [IdTipoUsuario], [NombreUsuario], [APaterno], [AMaterno], [EmailUsuario], [PassWordUsuario], [CodigoRecuperacion] FROM [T_Usuario]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
