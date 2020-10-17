<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarAlquiler.aspx.cs" Inherits="Obligatorio.AgregarAlquiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ingrese el Documento del Cliente"></asp:Label>
&nbsp;<asp:TextBox ID="TxtDocumento" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="BtnBuscar" runat="server" Text="Buscar Cliente" OnClick="BtnBuscar_Click" />
&nbsp;<br />
    <br />
&nbsp;<asp:DropDownList ID="DDLClientes" runat="server">
    </asp:DropDownList>
&nbsp;<br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Seleccione Fecha Inicio"></asp:Label>
&nbsp;<asp:TextBox ID="TxtFechaIni" runat="server" TextMode="Date" ></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Seleccione Fecha Fin"></asp:Label>
&nbsp;<asp:TextBox ID="TxtFechaFin" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Seleccione Hora Inicio"></asp:Label>
&nbsp;<asp:TextBox ID="TxtHoraIni" runat="server" TextMode="Time"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Seleccione Hora Fin"></asp:Label>
&nbsp;<asp:TextBox ID="TxtHoraFin" runat="server" TextMode="Time"></asp:TextBox>
    &nbsp;<br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Seleccione Marca"></asp:Label>
&nbsp;<asp:DropDownList ID="DDLMarcas" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Seleccione Modelo"></asp:Label>
&nbsp;<asp:DropDownList ID="DDLModelos" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <br />
    <br />
&nbsp;
</asp:Content>
