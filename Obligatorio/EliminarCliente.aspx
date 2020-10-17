<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EliminarCliente.aspx.cs" Inherits="Obligatorio.EliminarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Eliminar Cliente</h1>
    <asp:Label ID="Label1" runat="server" Text="Ingrese el Documento del cliente a eliminar"></asp:Label>
     <asp:TextBox ID="TxtDocumento" runat="server"></asp:TextBox>   
      <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Lista de Clientes"></asp:Label>
   <asp:DropDownList ID="DDLClientes" runat="server">
    </asp:DropDownList>
      <br />
      <br />
    <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar Cliente" OnClick="BtnEliminar_Click" />
    &nbsp;<asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
    <br />
    <br />
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
   
</asp:Content>
