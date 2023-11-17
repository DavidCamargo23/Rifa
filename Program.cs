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
             DateTime fechaSorteo = DateTime.Now;
             Rifa rifa = new Rifa(fechaSorteo,"Esta rifa es el sorteo anual de fin de año", (TipoRifa)numeroRifa);
             Console.WriteLine("La rifa de hoy es: ");
             Console.WriteLine($"Fecha del sorteo: {rifa.FechaSorteo}");
            
             if (numeroRifa == 0)
             {
                 Console.WriteLine("Descripción: Esta rifa no está disponible hoy. Lamentamos el inconveniente");
             }
             else if (numeroRifa == 1)
             {
                 Console.WriteLine($"Descripción: la rifa de hoy es {rifa.TipoRifa} la cual contará hasta con 100 boletas.");
                 int numeroBoletas = 100;
                 Console.WriteLine($"Número de rifa al azar: {numeroBoletas}");
             }
             else if (numeroRifa == 2)
             {
                 Console.WriteLine($"Descripción: la rifa de hoy es {rifa.TipoRifa} la cual contará hasta con 200 boletas.");
                 int numeroBoletas = 200;
                 Console.WriteLine($"Número de rifa al azar: {numeroBoletas}");
             }
             else if (numeroRifa == 3)
             {
                 Console.WriteLine($"Descripción: la rifa de hoy es {rifa.TipoRifa} la cual contará hasta con 300 boletas.");
                 int numeroBoletas = 300;
                 Console.WriteLine($"Número de rifa al azar: {numeroBoletas}");
             }

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
