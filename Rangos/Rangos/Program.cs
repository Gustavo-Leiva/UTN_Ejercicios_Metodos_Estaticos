using Biblioteca;


namespace Rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            bool esNumero;
            int acumNumero = 0;
            int valorMaximo = 100;
            int valorMinimo = -100;
            int contNumeros = 0;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            float promedio = 0.00F;



            while (contNumeros < 3)
            {
                Console.WriteLine("Ingrese un numero:");
                esNumero = int.TryParse(Console.ReadLine(), out valor);

                if (esNumero)
                {
                    if (Validador.Validar(valor, valorMinimo, valorMaximo))
                    {
                        if (valor > maximo)
                        {
                            maximo = valor;
                        }

                        if (valor < minimo) //no funciona el else if (si el primer numero que ingreso es el menor de todos)
                        {
                            minimo = valor;
                        }


                        contNumeros++;
                        acumNumero += valor;
                    }

                    else
                    {
                        Console.WriteLine("El valor ingresado no es un numero");

                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un numero");
                }


            }

            promedio = acumNumero / contNumeros;

            Console.WriteLine("El numero maximo es: {0}", maximo);
            Console.WriteLine($"El numero minimo es: {minimo}");
            Console.WriteLine("El promedio es:{0} ", (decimal)promedio);
            Console.WriteLine("{0}", valor);

        }
    }
}