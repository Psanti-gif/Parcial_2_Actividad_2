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

            //Valor de los creditos
            valorMatricula = (estudiante.Creditos - creditosExtras) * ValorCreditoNormal +
                             (creditosExtras * ValorCreditoNormal * 2);

            switch (estudiante.Estrato)
            {
                case 1:
                    valorMatricula *= 0.2m;
                    break;
                case 2:
                    valorMatricula *= 0.5m;
                    break;
                case 3:
                    valorMatricula *= 0.7m;
                    break;
            }
            return valorMatricula;

        }
        public static decimal CalcularSubsidio(Estudiante estudiante)
        {
            decimal subsidio = 0;

            switch (estudiante.Estrato)
            {
                case 1:
                    subsidio = 200000;
                    break;
                case 2:
                    subsidio = 100000;
                    break;
            }

            return subsidio;
        }

    }
}
