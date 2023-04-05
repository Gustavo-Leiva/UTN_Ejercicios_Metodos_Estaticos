using Biblioteca;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int resultado;
            Console.WriteLine("Ingresa un numero");
            num = int.Parse(Console.ReadLine());

            resultado = CalculoMatematico.CalcularFactorial(num);

            Console.WriteLine($"El factorial de {num}, es {resultado}");
        }
    }
}