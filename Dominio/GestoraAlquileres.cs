using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{   
    public class GestoraAlquileres
    {
        private List<Alquiler> colAlquileres;
        private static GestoraAlquileres instanciaGestora = null;

        public GestoraAlquileres()
        {
            colAlquileres = new List<Alquiler>();
        }

        public static GestoraAlquileres Instancia
        {
            get
            {
                if (instanciaGestora == null)
                {
                    instanciaGestora = new GestoraAlquileres();
                }
                return instanciaGestora;
            }
        }
     
    }
}
