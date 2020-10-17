using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            LstClientes.DataSource = GestoraClientes.Instancia.Clientes;
            LstClientes.DataTextField = "Datos";
            LstClientes.DataValueField = "Documento";
            LstClientes.DataBind();
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

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (rbtnParticular.Checked)
            {
                try
                {
                    TipoDocumento td = (TipoDocumento)Enum.Parse(typeof(TipoDocumento), DDLTipoDocumento.SelectedValue);
                    ClienteParticular cp = new ClienteParticular(TxtDocumento.Text, TxtPaisDocumento.Text, td, TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, Convert.ToInt32(DateTime.Now.Year));
                    if (GestoraClientes.Instancia.AgregarCliente(cp))
                    {

                        MostarMensaje("Cliente Particular agregado!", true);
                    }
                    else
                    {
                        MostarMensaje("No se pudo agregar el cliente", false);
                    }
                }
                catch (DatException ex)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = ex.Message;
                }
                catch (Exception ex)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = "No se pudo procesar. Consulte al tecnico";
                }
                ListarClientes();
            }
            else
            {
                try
                {
                    ClienteEmpresa ce = new ClienteEmpresa(TxtRUT.Text, TxtRazonSocial.Text, TxtTel.Text, TxtNomPerContacto.Text, Convert.ToInt32(DateTime.Now.Year));
                    if (GestoraClientes.Instancia.AgregarCliente(ce))
                    {

                        MostarMensaje("Cliente Empresa agregado!", true);
                    }
                    else
                    {
                        MostarMensaje("No se pudo agregar el cliente", false);
                    }
                }
                catch (DatException ex)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = ex.Message;
                }
                catch (Exception ex)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = "No se pudo procesar. Consulte al tecnico";
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
