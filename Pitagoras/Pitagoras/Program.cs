using Biblioteca;

namespace Pitagoras
{
    /*
     Consigna
       Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

       El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

       Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

       Mostrar el resultado en la consola.

   */

    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double resultado;

            Console.WriteLine("ingrese la base");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la altura");
            num2 = float.Parse(Console.ReadLine());

            resultado = CalculoMatematico.calcularHipotenusa(num1, num2);

            Console.WriteLine($" Los catetos de un triángulo rectángulo de {num1} y {num2} su hipotenusa es {resultado}");


        }
    }
}