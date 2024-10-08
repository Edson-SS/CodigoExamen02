using CodigoExamen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoExamen02.Clases
{
    public class Gerente : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override int SueldoBase => 8000;

        public decimal CalcularBonificacion()
        {
            return 1000;
        }

        public decimal DescontarSueldo()
        {
            return SueldoBase*Constantes.DescuentoGerente;
        }
        public override decimal CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion()-DescontarSueldo();
        }
    }
}
