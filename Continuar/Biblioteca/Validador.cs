namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool rta = false;
            respuesta = respuesta.ToUpper();

            if (respuesta == "S")
            {
                rta = true;
            }

            return rta;
        }
    }
}