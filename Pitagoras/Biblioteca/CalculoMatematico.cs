namespace Biblioteca
{
  
        public static class CalculoMatematico
        {
            public static double calcularHipotenusa(double cat1, double cat2)
            {
                double hipotenusa;

                hipotenusa = Math.Sqrt((Math.Pow(cat1, 2) + Math.Pow(cat2, 2)));


                return hipotenusa;
            }


        }

    
}