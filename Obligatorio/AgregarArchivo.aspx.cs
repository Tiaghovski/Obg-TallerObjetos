using Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class AgregarArchivo : System.Web.UI.Page
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

        protected void BtnSubir_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            if (FileUpload1.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                String[] allowedExtensions = { ".txt" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true; break;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    String path = Server.MapPath("~/documentos/");
                    FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);                   
                    foreach (string line in File.ReadLines(path + FileUpload1.FileName))
                    {                        
                        TextBox1.Text += line + "\n";                    
                     
                    }      
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    lblMensaje.Text = "Archivo subido!";                   
                }
                catch (Exception ex)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = "El archivo no puede ser subido";
                }

            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "No se puede aceptar archivos de este tipo";
            }            
        }

        protected void BtnSubir2_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            if (FileUpload2.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(FileUpload2.FileName).ToLower();
                String[] allowedExtensions = { ".txt" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true; break;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    String path = Server.MapPath("~/documentos/");
                    FileUpload2.PostedFile.SaveAs(path + FileUpload2.FileName);                    
                    foreach (string line in File.ReadLines(path + FileUpload2.FileName))
                    {                        
                        TextBox2.Text += line + "\n";                        
                    }                   
                    lblMensaje2.ForeColor = System.Drawing.Color.Green;
                    lblMensaje2.Text = "Archivo subido!";
                }
                catch (Exception ex)
                {
                    lblMensaje2.ForeColor = System.Drawing.Color.Red;
                    lblMensaje2.Text = "El archivo no puede ser subido";
                }

            }
            else
            {
                lblMensaje2.ForeColor = System.Drawing.Color.Red;
                lblMensaje2.Text = "No se puede aceptar archivos de este tipo";
            }
        }

        public static void ProcesarLineasTipoVehiculo(string nombreArchivo)
        {
            foreach (string line in File.ReadLines("~/documentos/" + nombreArchivo))
            {
                String[] arr = line.Split('@');                
                GestoraVehiculos.Instancia.AgregarTipoVehiculo(arr[0], arr[1], Convert.ToSingle(arr[2]));           
            }
        }

        public static void ProcesarLineasVehiculosRegistrados(string nombreArchivo)
        {
            foreach (string line in File.ReadLines("~/documentos/" + nombreArchivo))
            {
                String[] arr = line.Split('@');               
                //Vehiculo Vehiculo = new Vehiculo(arr[0], arr[1], Convert.ToSingle(arr[2]), arr[3], arr[4]);

            }
        }
      
    }
}