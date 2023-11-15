using BaseDeDatos;
using LibreriaDeClases;
internal class Program
{
    private static void Main(string[] args)
    {
        //Color color = Color.Rojo;
        //int numColor = (int)color;
        //Console.WriteLine(numColor);
        //Color NuevoColor = (Color)numColor;
        //Console.WriteLine(NuevoColor.GetType());

        //bool bol1 = true;
        //string convert = bol1.ToString();
        //Console.WriteLine(convert);
        //Console.WriteLine(convert.GetType());

        //bool convertBool = convert.Equals("False");
        //Console.WriteLine(convertBool);

        AccesoDatos accesoDatos = new AccesoDatos();
        List<Alimento> listaGenerica = new List<Alimento>();
        List<Alimento>  listFrutas = accesoDatos.ObtenerListaDatos("fruta");
        List<Alimento> listaVerduras = accesoDatos.ObtenerListaDatos("verdura");
        List<Alimento> listaCarnes = accesoDatos.ObtenerListaDatos("carne");
        foreach (var item in listFrutas)
        {
            listaGenerica.Add(item);
        }
        foreach (var item in listaVerduras)
        {
            listaGenerica.Add(item);
        }
        foreach (var item in listaCarnes)
        {
            listaGenerica.Add(item);
        }

        foreach(var item in listaGenerica)
        {
            Console.WriteLine(item.Nombre);
        }
    }
}