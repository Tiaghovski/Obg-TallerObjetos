<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ModificarCliente.aspx.cs" Inherits="Obligatorio.ModificarCliente" ClientIDMode ="Static"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Modificar Cliente</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Seleccione el tipo de cliente a modificar:"></asp:Label>

    </p>
    <p>

        <asp:RadioButton ID="rbtnParticular" runat="server" Checked="True" GroupName="Tipo" Text="Cliente Particular"/>
    <asp:RadioButton ID="rbtnEmpresa" runat="server" GroupName="Tipo" Text="Cliente Empresa"/>
    </p>
    <asp:Panel ID="pnlParticular" runat="server">
        <asp:Label ID="Label2" runat="server" Text="Ingrese Cédula a modificar"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtDocumento" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Ingrese NUEVO País Documento"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtNuevoPaisDocumento" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server" Text="Ingrese NUEVO Teléfono"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtNuevoTelefono" runat="server"></asp:TextBox>
        &nbsp;<br />      

    </asp:Panel>
    <asp:Panel ID="pnlEmpresa" runat="server">
        <asp:Label ID="Label7" runat="server" Text="Ingrese RUT a modificar"></asp:Label>
        &nbsp;&nbsp;<asp:TextBox ID="TxtRUT" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Text="Ingrese NUEVA Razón Social"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtNuevaRazonSocial" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label20" runat="server" Text="Ingrese NUEVO Teléfono"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtNuevoTel" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label21" runat="server" Text="Ingrese NUEVO Nombre Persona de Contacto"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtNuevoNomPerContacto" runat="server"></asp:TextBox>
        &nbsp;<br />
    </asp:Panel>

    <p>
    <asp:Button ID="BtnModificar" runat="server" Text="Modificar Cliente" OnClick="BtnModificar_Click"/>
    &nbsp;&nbsp;</p>
    <p>
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

    </p>
    <asp:Label ID="Label3" runat="server" Text="Lista de Clientes"></asp:Label>
   &nbsp;<asp:DropDownList ID="DDLClientes" runat="server">
    </asp:DropDownList>
      <br />
    <br />
    <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
    <br />

   <script>        
        window.onload = function () {
            if (document.getElementById("rbtnParticular").hasAttribute("checked")) {
                document.getElementById("pnlParticular").setAttribute("style", "display:block");
                document.getElementById("pnlEmpresa").setAttribute("style", "display:none");
            } else {
                document.getElementById("pnlEmpresa").setAttribute("style", "display:block");
                document.getElementById("pnlParticular").setAttribute("style", "display:none");
            }
            document.getElementById("rbtnEmpresa").onchange = function () {
                document.getElementById("pnlEmpresa").setAttribute("style", "display:block");
                document.getElementById("pnlParticular").setAttribute("style", "display:none");
            }
            document.getElementById("rbtnParticular").onchange = function () {
                document.getElementById("pnlParticular").setAttribute("style", "display:block");
                document.getElementById("pnlEmpresa").setAttribute("style", "display:none");
            }
        }
       
    </script> 
    

</asp:Content>
