<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AdministrarSistema.aspx.cs" Inherits="Obligatorio.AdministrarSistema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1 style="color:darkred; font-family:Century"><u>Administración del Sitio</u></h1>
    <h3 style="color:dodgerblue; font-family:Verdana">Elija una opción:</h3>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/AgregarCliente.aspx">Agregar Cliente</asp:HyperLink>
    &nbsp;•
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ModificarCliente.aspx">Modificar Cliente</asp:HyperLink>
        &nbsp;•
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/EliminarCliente.aspx">Eliminar Cliente</asp:HyperLink>
        &nbsp;•
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/AgregarAlquiler.aspx">Registrar Alquiler</asp:HyperLink>
        &nbsp;•
        <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/DevolucionVehiculo.aspx">Registrar Devolución de Vehículo</asp:HyperLink>
    
      </p>
      <p style="font-family:Verdana">
          &nbsp;</p>
      <p style="font-family:Verdana">
    
         <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/Admin.png" Height="35px" Width="120px" />
        &nbsp;<asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/ListarVehiculos.aspx">Listado de Vehículos Retrasados</asp:HyperLink>
        

      </p>
      <p style="font-family:Verdana">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/Admin.png" Height="35px" Width="120px" />

          &nbsp;<asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/AgregarArchivo.aspx">Subir Archivo</asp:HyperLink>
      </p>
</asp:Content>
