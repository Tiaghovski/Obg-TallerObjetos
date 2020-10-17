using System;
using Dominio;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Aplicacion;

namespace Obligatorio
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {         
                string rutaArchivo = HttpRuntime.AppDomainAppPath + @"binario\serial.bin";
                if (File.Exists(rutaArchivo))
                {
                    Repositorio rep = new Repositorio(rutaArchivo);
                    rep.Deserealizar();
                }
                else
                {
                    //GestoraVehiculos.Instancia.CargarDatos();
                }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Repositorio rep = new Repositorio(HttpRuntime.AppDomainAppPath + @"binario\serial.bin");
            rep.Serializar();
        }
    }

}
