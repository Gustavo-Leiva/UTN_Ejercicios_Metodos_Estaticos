using System.ComponentModel.DataAnnotations;
using Biblioteca;
using System.Text;

namespace Continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int num = 0;
            bool esNumero;
            string respuesta;



            do
            {
                Console.WriteLine("Ingresa un numero");
                esNumero = int.TryParse(Console.ReadLine(), out num);

                while (!esNumero)
                {
                    Console.WriteLine("El valor ingresado NO es numero. Reingrese:");
                    esNumero = int.TryParse(Console.ReadLine(), out num);
                }
                suma = suma + num;

                Console.WriteLine("Desea Continuar?");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));


            Console.WriteLine("La suma de los numeros es {0}", suma);
        }
    }
}