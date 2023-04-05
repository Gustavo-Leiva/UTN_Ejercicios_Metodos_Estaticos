using System.Text;
using Biblioteca;

namespace Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"El area de un cuadrado de valor 5m es {CalculadoraDeArea.CalcularAreaCuadrado(5)}");
            sb.AppendLine($"El area de un triangulo de 3m de base y 4m de altura es {CalculadoraDeArea.CalcularAreaTriangulo(3, 4)}");
            Console.WriteLine(sb.AppendLine($"El area de un circulo es 3m de diametro es {CalculadoraDeArea.CalcularAreaCirculo(3).ToString("0.0000")}"));


        }
    }
}