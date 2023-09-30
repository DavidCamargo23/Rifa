namespace Rifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Bienvenido al programa de rifas");
            Console.WriteLine("Ingrese la informaciòn referente a la rifa");
           
            Console.WriteLine("Digite la fecha de la rifa");
            string descrip = Console.ReadLine();
            Console.WriteLine("El número siguiente es: " + descrip);
    }
}