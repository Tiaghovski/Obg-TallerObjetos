using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteEmpresa : Cliente
    {
        public string razonSocial { get; set; }
        public string tel { get; set; }
        public string nomPerContacto { get; set; }
        public int anio { get; set; }
        
        public ClienteEmpresa(string documento, string razonSocial, string tel, string nomPerCotacto, int anio)
            :base(documento)
        {            
            this.razonSocial = razonSocial;
            this.tel = tel;
            this.nomPerContacto = nomPerContacto;
            this.anio = anio;
        }

        public override string ToString()
        {

            return "RUT: " + documento + " - " + "Razón Social: " + razonSocial + " - " + "Teléfono: " + tel + " - " + "Nombre Persona Contacto: " + nomPerContacto + " - " + "Año: " + anio;
        }

        public override string Datos
        {
            get
            {
                return ToString();

            }
        }
    }
}
