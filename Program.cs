using Rifa;
using Rifa.Data;
using System;

namespace Rifa
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Bienvenido al programa de rifas");
            Random random = new Random();
            int numeroRifa = random.Next(4);
            Console.WriteLine(numeroRifa);
            new Rifa(numeroRifa);
            Console.WriteLine("La rifa de hoy es: "); 

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Comprar boleta");
                Console.WriteLine("2. Actualizar datos boleta");
                Console.WriteLine("3. Eliminar datos boleta");
                Console.WriteLine("4. Buscar datos boleta");
                Console.WriteLine("5. Mostrar rifa ganada");
                Console.WriteLine("6. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if 
                        {
                            int numeroBoleta = BoletaDisponible(rifa);
                            CompradorDataManager.AddComprador (new Comprador("Grabriel", "Garcia Marquez", new DateTime(2023, 9, 19),1, 200));
                            Console.WriteLine($"Boleta {numeroBoleta} comprada exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("No hay boletas disponibles.");
                        }
                        break;
                    case 2:
                        CompradorDataManager.UpdateComprador(CompradorUpd);
                        break;
                    case 3:
                        CompradorDataManager.DeleteComprador("7");
                        break;
                    case 4:
                        var getComprador = CompradorDataManager.GetComprador("5");
                        Console.WriteLine($"el comprador es: {getComprador.Nombre}");
                        break;
                    case 5:
                        if (rifa.Ganador != null)
                        {
                            Console.WriteLine($"Ganador: {rifa.Ganador.Nombre}");
                        }
                        else
                        {
                            Console.WriteLine("Aún no se ha realizado el sorteo de la rifa ganada.");
                        }
                        break;
                    case 6:
                        return;
                }
            }

           // Comprador comprador = new Comprador("Grabriel ", "Garcia Marquez ", new DateTime(2023, 9, 19));
           // CompradorDataManager.saveComprador(comprador);
           // private static List<Comprador> compradores = new List<Comprador>();
            }

}
}
