<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Obligatorio.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>   
    <asp:TextBox ID="TxtNombreUsuario" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
    <asp:TextBox ID="TxtClave" runat="server" TextMode="Password"></asp:TextBox> 
    <asp:Button ID="BtnIngresar" runat="server" OnClick="BtnIngresar_Click" Text="Ingresar" />
    <br />
    <asp:Label ID="LblMensaje" runat="server"></asp:Label>
    <h3 style="color:darkred; font-family:Century" >Para administrar el sistema debe loguearse</h3>
     <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/Candado.jpg"  Width="400" Height="350"/>
</asp:Content>
