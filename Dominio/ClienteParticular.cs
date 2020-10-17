using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteParticular : Cliente
    {
        public string paisDocumento { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public int anio { get; set; }

        public ClienteParticular(string documento, string paisDocumento, TipoDocumento tipoDocuento, string nombre, string apellido, string telefono, int anio)
            :base(documento)
        {
            
            this.paisDocumento = paisDocumento;
            this.tipoDocumento = tipoDocumento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.anio = anio;
        }

        public override string ToString()
        {

            return "Documento: " + documento + " - " + "País Documento: " + paisDocumento + " - " + "Tipo Documento: " + tipoDocumento + " - " + "Nombre: " + nombre + " - " + "Apellido: " + apellido + " - " + "Teléfono: " + telefono + " - " + "Año: " + anio;

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
