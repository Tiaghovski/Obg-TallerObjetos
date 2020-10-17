using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{    
    public class Alquiler
    {
        public Vehiculo vehiculo { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public float monto { get; set; }
        public Cliente cliente { get; set; }

        public Alquiler(Vehiculo vehiculo, DateTime fechaInicio, DateTime fechaFin, DateTime horaInicio, DateTime horaFin, float monto, Cliente cliente)
        {
            this.vehiculo = vehiculo;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.monto = monto;
            this.cliente = cliente;
        }
    }
}