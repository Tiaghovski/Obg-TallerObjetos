using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class AdministrarSistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["Usuario"] != null)                   
                {
                    Usuario usu = (Usuario)Session["Usuario"];
                    if (usu is Administrador)
                    {
                        HyperLink8.Visible = true;
                        HyperLink9.Visible = true;
                        Image1.Visible = true;
                        Image2.Visible = true;
                        HyperLink3.Visible = false;
                        HyperLink4.Visible = false;
                        HyperLink5.Visible = false;
                        HyperLink6.Visible = false;
                        HyperLink7.Visible = false;
                    }
                    else
                    {
                        HyperLink8.Visible = false;
                        HyperLink9.Visible = false;
                        Image1.Visible = false;
                        Image2.Visible = false;
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

            }
        }
    }
}
