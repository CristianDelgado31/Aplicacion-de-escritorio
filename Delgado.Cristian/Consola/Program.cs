using LibreriaDeClases;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Alimento.MostrarFechaHora());
        Console.WriteLine(Alimento.MostrarFechaHora("hora"));
    }

    public static DateOnly MostrarFechaHora()
    {
        DateOnly fecha = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        return fecha;
    }
    public static string MostrarFechaHora(string hora)
    {
        return hora = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
    }
}