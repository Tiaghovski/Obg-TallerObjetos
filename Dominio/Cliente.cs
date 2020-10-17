using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente{
        
        public string documento { get; set; }

        public Cliente(string documento)
        {
            this.documento = documento;           
        }

        public virtual string Datos { get; set; }

    }
}
