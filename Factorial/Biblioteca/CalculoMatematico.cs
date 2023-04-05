namespace Biblioteca
{
    public class CalculoMatematico
    {
        public static int CalcularFactorial(int numero)
        {
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                //resultado = resultado * i;
                resultado *= i;

            }

            return resultado;
        }
    }
}