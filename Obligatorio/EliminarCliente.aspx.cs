using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class EliminarCliente : System.Web.UI.Page
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


        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (GestoraClientes.Instancia.EliminarCliente(TxtDocumento.Text))
            {
                MostarMensaje("Cliente eliminado!", true);
            }
            else
            {
                MostarMensaje("No se encontró el Cliente", false);
            }
            ListarClientes();
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministrarSistema.aspx");
        }
    }
}