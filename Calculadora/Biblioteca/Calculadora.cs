namespace Biblioteca
{
    public class Calculadora
    {
        public static float Calcular(float operando1, float operando2, string operacion)
        {
            float resultado = 0;

            if (Validar(operando2))
            {
                if (operacion == "+")
                {
                    resultado = operando1 + operando2;
                }

                else if (operacion == "-")
                {
                    resultado = operando1 - operando2;
                }

                else if (operacion == "*")
                {
                    resultado = operando1 * operando2;
                }


                else if (operacion == "/")
                {
                    resultado = operando1 / operando2;
                }


            }


            return resultado;


        }


        private static bool Validar(float operando2)
        {
            bool respuesta = true;

            if (operando2 == 0)
            {
                respuesta = false;
            }

            return respuesta;
        }

    }
}