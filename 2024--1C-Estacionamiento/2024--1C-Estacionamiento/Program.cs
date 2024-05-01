namespace _2024__1C_Estacionamiento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = Startup.InicializarApp(args); // Pasamos los argunmentos que son recibidos en la ejecucion


            app.Run();
        }
    }
}
