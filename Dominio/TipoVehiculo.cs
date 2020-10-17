using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Serializable]
    public class TipoVehiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public float precioDiario { get; set; }

        public TipoVehiculo(string marca, string modelo, float precioDiario )
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precioDiario = precioDiario;
        }
    }

    
   
}
