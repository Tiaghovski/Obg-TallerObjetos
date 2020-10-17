using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Serializable]
    public class Vehiculo
    {
        public string matricula { get; set; }
        public string anio { get; set; }
        public float kilometraje { get; set; }
        public TipoVehiculo tipo { get; set; }
        public List<string> colImagenes;

        public Vehiculo (string matricula, string anio, float kilometraje, TipoVehiculo tipo, List<string> imagenes)
        {
            this.matricula = matricula;
            this.anio = anio;
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            colImagenes = imagenes;
        }

        public List<string> Imagenes
        {
            get
            {
                return new List<string>(colImagenes);
            }
        }
    }
}
