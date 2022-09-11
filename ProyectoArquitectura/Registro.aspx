<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ProyectoArquitectura.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nombre<br />
    <asp:TextBox ID="lbNombre" runat="server"></asp:TextBox>
    <br />
    Apellido Paterno<br />
    <asp:TextBox ID="lbAP" runat="server"></asp:TextBox>
    <br />
    Apellido Materno<br />
    <asp:TextBox ID="lbAM" runat="server"></asp:TextBox>
    <br />
    Correo institucional:<br />
    <asp:TextBox ID="lbemail" runat="server" Width="169px"></asp:TextBox>
    <br />
    Contraseña:<br />
    <asp:TextBox ID="lbPassword" runat="server" Width="167px"></asp:TextBox>
    <br />
    Confirmacion de contraseña:<br />
    <asp:TextBox ID="lbConfiPassword" runat="server" Width="166px"></asp:TextBox>
    <br />
    <br />
    <asp:DropDownList ID="DLTipoUsuario" runat="server" >
        <asp:ListItem Value="0">Alumno</asp:ListItem>
        <asp:ListItem Value="1">Maestro</asp:ListItem>
        <asp:ListItem Value="2">Pasante</asp:ListItem>
        <asp:ListItem Value="3">Admin</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="Button1_Click" />
    <br />
</asp:Content>
