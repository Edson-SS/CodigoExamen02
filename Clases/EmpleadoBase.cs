using CodigoExamen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoExamen02.Clases
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }
        public String Puesto { get; set; }
        public abstract int SueldoBase { get; }

        public abstract decimal CalcularSueldo();
        public void MostrarDetalle()
        {
            Console.WriteLine($"Id: {IdEmpleado}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Puesto: {Puesto}");
        }
    }
}
