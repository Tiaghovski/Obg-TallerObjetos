using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class AgregarAlquiler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarMarcas();
        }

        private void ListarMarcas()
        {
            DDLMarcas.DataSource = GestoraVehiculos.Instancia.CargarMarcasVehiculos();
            DDLMarcas.DataBind();
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            GestoraClientes cli = GestoraClientes.Instancia;
            DDLClientes.Items.Clear();
            Cliente c = cli.BuscarClientePorDocumento(TxtDocumento.Text);
            if (c != null)
            {
                DDLClientes.Items.Add(new ListItem(c.Datos, c.documento));
            }
            else
            {
                Response.Redirect("AgregarCliente.aspx");
            }
        }
    }
}