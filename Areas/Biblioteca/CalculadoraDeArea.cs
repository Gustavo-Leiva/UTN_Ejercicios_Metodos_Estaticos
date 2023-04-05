namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado;
            areaCuadrado = longitudLado * 2;
            return areaCuadrado;

        }

        public static double CalcularAreaTriangulo(double baseT, double altura)
        {
            double areaTriangulo;
            areaTriangulo = baseT * altura;
            return areaTriangulo;

        }

        public static double CalcularAreaCirculo(double radio)
        {
            double areaCirculo;
            areaCirculo = radio * Math.PI;
            return areaCirculo;

        }
    }
}