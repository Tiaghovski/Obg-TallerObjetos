using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Aplicacion
{
    [Serializable]
    public class Repositorio
    {
        private string rutaArchivo;
        private GestoraVehiculos _gVehiculos;        

        public Repositorio(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
            _gVehiculos = GestoraVehiculos.Instancia;            
        }

        public void Serializar()
        {          
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
            }
        }

        public void Deserealizar()
        {
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Repositorio rep = bf.Deserialize(fs) as Repositorio;
            }
        }
    }
}

