using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class ModificarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            DDLClientes.DataSource = GestoraClientes.Instancia.Clientes;
            DDLClientes.DataTextField = "Datos";
            DDLClientes.DataValueField = "Documento";
            DDLClientes.DataBind();
        }

        private void MostarMensaje(string mensaje, bool correcto)
        {
            lblMensaje.Text = mensaje;
            if (correcto)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if (rbtnParticular.Checked)
            {
                if (GestoraClientes.Instancia.BuscarClientePorDocumento(TxtDocumento.Text) != null)
                {
                    GestoraClientes.Instancia.ModificarClienteParticular(TxtDocumento.Text, TxtNuevoPaisDocumento.Text, TxtNuevoTelefono.Text);
                    MostarMensaje("Cliente modificado!", true);
                }
                else
                {
                    MostarMensaje("No se encontró el Cliente", false);
                }
                ListarClientes();
            }
            else
            {
                if (GestoraClientes.Instancia.BuscarClientePorDocumento(TxtRUT.Text) != null)
                {
                    GestoraClientes.Instancia.ModificarClienteEmpresa(TxtRUT.Text, TxtNuevaRazonSocial.Text, TxtNuevoTel.Text, TxtNuevoNomPerContacto.Text);
                    MostarMensaje("Cliente modificado!", true);
                }
                else
                {
                    MostarMensaje("No se encontró el Cliente", false);
                }
                ListarClientes();
            }
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministrarSistema.aspx");
        }
    }
}