using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using Biblioteca;

namespace La_Calculadora
{
    internal class Program
    { 
        
      /*
       Consigna
        
        Realizar un programa que permita realizar operaciones matemáticas simples(suma, resta, multiplicación y división).

        Crear una clase llamada Calculadora que posea dos métodos estáticos(de clase):

        Calcular(público) : Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.El método devolverá el resultado de la operación.

        Validar(privado): Recibirá como parámetro el segundo operando.Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

        Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

        El usuario decidirá cuándo finalizar el programa.

      */
       
            static void Main(string[] args)
            {
                float num1;
                float num2;
                bool esNumero;
                bool esOperando;
                string operando;
                float rdo;
                string respuesta;


                do
                {
                    Console.WriteLine("ingrese un numero");
                    esNumero = float.TryParse(Console.ReadLine(), out num1);

                    while (!esNumero)
                    {
                        Console.WriteLine("Error!! Reingrese un numero");
                        esNumero = float.TryParse(Console.ReadLine(), out num1);
                    }

                    Console.WriteLine("ingrese otro numero");
                    esNumero = float.TryParse(Console.ReadLine(), out num2);
                    while (!esNumero)
                    {
                        Console.WriteLine("Error!! Reingrese un numero");
                        esNumero = float.TryParse(Console.ReadLine(), out num2);
                    }

                    Console.WriteLine("ingrese la operacion ('+', '-' , '*' , '/')");
                    operando = Console.ReadLine();

                    while ((operando != "+") && (operando != "-") && (operando != "*") && (operando != "/"))
                    {
                        Console.WriteLine("Error!!! Reingrese la operacion ('+', '-' , '*' , '/')");
                        operando = Console.ReadLine();

                    }


                    rdo = Calculadora.Calcular(num1, num2, operando);

                    if (rdo == 0)
                    {
                        Console.WriteLine("Error no se puede dividir por cero");
                    }

                    else
                    {

                        Console.WriteLine("El rdo es: {0}", rdo);
                    }

                    Console.WriteLine("Desea continuar? si(s) no(n)");
                    respuesta = (Console.ReadLine().ToUpper());

                } while (respuesta == "S");

            }

        }
    }
