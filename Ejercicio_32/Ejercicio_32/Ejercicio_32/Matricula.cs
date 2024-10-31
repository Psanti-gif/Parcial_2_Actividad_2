using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    public class Matricula
    {
        public const int ValorCreditoNormal = 50000;
        public static decimal CalcularValorMatricula(Estudiante estudiante)
        {
            decimal valorMatricula;
            int creditosExtras = estudiante.Creditos > 20 ? estudiante.Creditos - 20 : 0;
        }
    }
}
