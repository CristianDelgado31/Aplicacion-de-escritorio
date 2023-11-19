using Entidades;
using LibreriaDeClases;

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "dsa";
        int num;
        try
        {
            if(int.TryParse(str, out num))
            {
                Console.WriteLine(str);
            }
            else
            {
                throw new ExcepcionDatos("Dato ingresado no valido", str);
            }
        }
        catch (ExcepcionDatos ex)
        {
            Console.WriteLine(ex.Message, ex.DatoIngresado);
        }
        finally
        {

        }



    }

   
}