using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5; // Cambia el número para calcular el factorial de otro valor
            long resultado = CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es {resultado}");
        }

        static long CalcularFactorial(int n)
        {
            // Caso base: El factorial de 0 es 1
            if (n == 0)
                return 1;

            // Caso recursivo: n! = n * (n-1)!
            return n * CalcularFactorial(n - 1);
        }
    }
    
}
