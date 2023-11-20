internal class Program
{
    private static void Main(string[] args)
    {
        var task = new Task(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("la tarea interna del task");

        });
        task.Start();

        Console.WriteLine("He terminado la tarea");


    }
}