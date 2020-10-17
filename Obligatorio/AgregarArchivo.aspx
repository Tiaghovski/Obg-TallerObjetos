<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarArchivo.aspx.cs" Inherits="Obligatorio.AgregarArchivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Agregar Tipos de Vehiculos:</h1>
    <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnSubir" runat="server" Text="Subir Archivo" OnClick="BtnSubir_Click" />
&nbsp;<asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="100px" ReadOnly="True" Width="280px"></asp:TextBox>
    &nbsp;<asp:DropDownList ID="DDLMarcas" runat="server">
    </asp:DropDownList>
    <br />
    <br />
<h1>Agregar Vehículos Registrados:</h1>
     <asp:FileUpload ID="FileUpload2" runat="server" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnSubir2" runat="server" Text="Subir Archivo" OnClick="BtnSubir2_Click"/>
&nbsp;<asp:Label ID="lblMensaje2" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="100px" ReadOnly="True" Width="280px"></asp:TextBox>
</asp:Content>
