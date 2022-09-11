<%@ Page Title="" Language="C#" MasterPageFile="~/MainMP.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProyectoArquitectura.login" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Correo electronico institucional:<br />
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="193px"></asp:TextBox>
    <br />
    Contraseña:<br />
    <asp:TextBox ID="TextBox2" runat="server" Width="188px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" />
&nbsp;
</asp:Content>
