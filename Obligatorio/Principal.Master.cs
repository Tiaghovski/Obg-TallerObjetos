using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
        public partial class Principal : System.Web.UI.MasterPage
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (Session["Usuario"] != null)
                {
                    Usuario usu = (Usuario)Session["Usuario"];
                    lblUsuario.Text = usu.NombreUsuario;
                    lblUsuario.ForeColor = System.Drawing.Color.Green;
                    lblMsjBienvenida.Visible = true;
                    lbtnCerrarSesion.Visible = true;
                }
                else
                {
                    lblMsjBienvenida.Visible = false;
                    lbtnCerrarSesion.Visible = false;
                }
            }

            protected void lbtnCerrarSesion_Click(object sender, EventArgs e)
            {
                if (Session["Usuario"] != null)
                {
                    Session.Abandon();
                    Response.Redirect("Login.aspx");
                }
            }
        }
}
    
