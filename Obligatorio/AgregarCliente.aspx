<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="Obligatorio.AgregarCliente"  ClientIDMode ="Static"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Agregar Cliente</h1>
    <p>
    <asp:RadioButton ID="rbtnParticular" runat="server" Checked="True" GroupName="Tipo" Text="Cliente Particular"/>
    <asp:RadioButton ID="rbtnEmpresa" runat="server" GroupName="Tipo" Text="Cliente Empresa"/>
    </p>
    <asp:Panel ID="pnlParticular" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Documento"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtDocumento" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="País Documento"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtPaisDocumento" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Tipo Documento"></asp:Label>
        &nbsp;<asp:DropDownList ID="DDLTipoDocumento" runat="server">
            <asp:ListItem Selected="True">Cédula</asp:ListItem>
            <asp:ListItem>DNI</asp:ListItem>
            <asp:ListItem>Pasaporte</asp:ListItem>
            <asp:ListItem>RUT</asp:ListItem>           
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Text="Nombre"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" Text="Apellido"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server" Text="Teléfono"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
        <br />      

    </asp:Panel>
    <asp:Panel ID="pnlEmpresa" runat="server">
        <asp:Label ID="Label7" runat="server" Text="RUT"></asp:Label>
        &nbsp;&nbsp;<asp:TextBox ID="TxtRUT" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Text="Razón Social"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtRazonSocial" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label20" runat="server" Text="Teléfono"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtTel" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label21" runat="server" Text="Nombre Persona Contacto"></asp:Label>
        &nbsp;<asp:TextBox ID="TxtNomPerContacto" runat="server"></asp:TextBox>
        <br />
    </asp:Panel>
    <p>
        <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label11" runat="server" Text="Lista de Clientes:"></asp:Label>
    </p>
    <p>
        <asp:ListBox ID="LstClientes" runat="server"></asp:ListBox>
    </p>
    <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />

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
