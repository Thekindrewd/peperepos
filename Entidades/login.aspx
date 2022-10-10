<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProyectoArquitectura.login" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Correo electronico institucional:<br />
    <asp:TextBox ID="tbEmail" runat="server" Width="193px"></asp:TextBox>
    <br />
    Contraseña:<br />
    <asp:TextBox ID="tbClave" runat="server" Width="188px"></asp:TextBox>
    <br />
    <asp:Label ID="lbErrorValidar" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnInicioSesion" runat="server" OnClick="btnInicioSesion_Click" Text="Ingresar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnRegistrar" runat="server" Text="Crear Cuenta" OnClick="btnRegistrar_Click" />
&nbsp;
</asp:Content>
