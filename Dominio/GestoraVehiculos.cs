using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Serializable]
    public class GestoraVehiculos:ISerializable
    {
        private List<Vehiculo> colVehiculos;
        private List<TipoVehiculo> colTipoVehiculos;
        private static GestoraVehiculos instanciaGestora = null;

        public GestoraVehiculos()
        {
            colVehiculos = new List<Vehiculo>();
            colTipoVehiculos = new List<TipoVehiculo>();
        }       

        public static GestoraVehiculos Instancia
        {
            get
            {
                if (instanciaGestora == null)
                {
                    instanciaGestora = new GestoraVehiculos();
                }
                return instanciaGestora;
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return new List<Vehiculo>(colVehiculos);

            }
        }

        public List<TipoVehiculo> TipoVehiculos
        {
            get
            {
                return new List<TipoVehiculo>(colTipoVehiculos);

            }
        }

        public GestoraVehiculos(SerializationInfo info, StreamingContext context)
        {
            this.colVehiculos = info.GetValue("listaVehiculos", typeof(List<Vehiculo>)) as List<Vehiculo>;
            instanciaGestora = this;
        }
        
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("listaVehiculos", this.Vehiculos, typeof(List<Vehiculo>));
        }

        public Vehiculo BuscarVehiculo(string matricula)
        {
            foreach (Vehiculo v in colVehiculos)
            {
                if (v.matricula == matricula)
                {
                    return v;
                }
            }
            return null;
        }      

        public bool AgregarTipoVehiculo(string marca, string modelo, float precioDiario)
        {
            foreach (TipoVehiculo tv in colTipoVehiculos)
            {
                if (tv.marca == marca && tv.modelo == modelo)
                {
                    return false;
                }
                else
                {
                    TipoVehiculo tipo = new TipoVehiculo(marca, modelo, precioDiario);
                    colTipoVehiculos.Add(tipo);
                    return true;
                }
            }
            return false;          
        }

        public bool AgregarVehiculo(string matricula, string anio, float kilometraje, TipoVehiculo tipo, List<string> imagenes)
        {
            foreach (Vehiculo v in colVehiculos)
            {
                if (v.matricula == matricula)
                {
                    return false;
                }
                else
                {
                    Vehiculo vehiculo = new Vehiculo(matricula, anio, kilometraje, tipo, imagenes);
                    colVehiculos.Add(vehiculo);
                    return true;
                }
            }
            return false;           
        }
        
        public List<string> CargarMarcasVehiculos()
        {
            List<string> marcas = new List<string>();
            foreach(TipoVehiculo tv in colTipoVehiculos)
            {
                if(!marcas.Contains(tv.marca))
                {
                    marcas.Add(tv.marca);
                }
            }
            return marcas;
        }


    }

   
}
