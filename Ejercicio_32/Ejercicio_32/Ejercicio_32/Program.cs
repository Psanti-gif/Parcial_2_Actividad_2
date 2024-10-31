using Ejercicio_32;

class Program
{
    static void Main()
    {
        bool continuar = true;
        
        while (continuar)
        {
            Console.WriteLine("Ingrese el estrato del estudiante (1, 2, o 3): ");
            int estrato = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de créditos: ");
            int creditos = Convert.ToInt32(Console.ReadLine());

            Estudiante estudiante = new Estudiante (estrato, creditos);

            decimal valorMatricula = Matricula.CalcularValorMatricula(estudiante);
            decimal subsidio = Matricula.CalcularSubsidio(estudiante);

            Console.WriteLine($"\nEl costo de la matrícula es: ${valorMatricula}");

            if(subsidio > 0)
            {
                Console.WriteLine($"Subsidio recibido: ${subsidio}");
            }

            Console.WriteLine("\n¿Desea calcular la matrícula de un estudiante nuevo? (s/n)");
            string respuesta = Console.ReadLine();
            continuar = respuesta.ToLower() == "s";
        }
        Console.WriteLine("Programa Finalizado");
    }
}