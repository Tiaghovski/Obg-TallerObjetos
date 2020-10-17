using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuario unUsuario = GestoraUsuarios.Instancia.BuscarUsuario(TxtNombreUsuario.Text, TxtClave.Text);
            if (unUsuario != null)
            {
                Session["Usuario"] = unUsuario;
                Response.Redirect("Inicio.aspx");

            }
            else
            {
                LblMensaje.Text = "Nombre de usuario o contraseña incorrecta";
                LblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}