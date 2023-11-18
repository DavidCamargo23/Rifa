using Microsoft.VisualBasic;
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
            RifaDataManager.DeleteRifa("1");
            Random random = new Random();
            int numeroRifa = random.Next(4);
            DateTime fechaSorteo = DateTime.Now;
            int Qboletas = 0;
            RifaDataManager.AddRifa(new Rifa(fechaSorteo, "Descripción: la rifa de hoy es Grande la cual contará hasta con 20 boletas.", (TipoRifa)1, 20));
            RifaDataManager.AddRifa(new Rifa(fechaSorteo, "Descripción: la rifa de hoy es Mediana la cual contará hasta con 10 boletas.", (TipoRifa)1, 10));
            RifaDataManager.AddRifa(new Rifa(fechaSorteo, "Descripción: la rifa de hoy es pequeña la cual contará hasta con 5 boletas.", (TipoRifa)1, 5));
            Console.WriteLine("Por favor seleccione el tipo de rifa en la que desea participar.");
            Console.WriteLine("1. Rifa pequeña.");
            Console.WriteLine("2. Rifa Mediana");
            Console.WriteLine("3. Rifa Grande");
            Console.WriteLine("La sugerencia automatica del prgrama es: "+numeroRifa);
            int NRifa = int.Parse(Console.ReadLine());

            if (NRifa == 0)
             {
                 Console.WriteLine("Descripción: Esta rifa no está disponible hoy. Lamentamos el inconveniente");
             }
             else if (NRifa == 1)
             {
                RifaDataManager.GetRifa(3);
                Qboletas = 5;

            }
             else if (NRifa == 2)
             {
                RifaDataManager.GetRifa(2);
                Qboletas = 10;
            }
             else if (NRifa == 3)
             {
                RifaDataManager.GetRifa(1);
                Qboletas = 20;
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

                //switch (opcion)
                //{
                //    case 1:
                //            Console.WriteLine("Digite su primer nombre");
                //            string firstName = Console.ReadLine();
                //            Console.WriteLine("Digite su apellido");
                //            string lastName = Console.ReadLine();
                //            Console.WriteLine("Seleccione su metodo de pago:");
                //            Console.WriteLine("Efectivo = 1");
                //            Console.WriteLine("Tarjeta = 2");
                //            Console.WriteLine("PSE = 3");
                //            int MetodoPago = int.Parse(Console.ReadLine());
                //            Random random = new Random();
                //            int numeroRifa = random.Next(4);
                //            CompradorDataManager.AddComprador (new Comprador(firstName, lastName, fechaSorteo,(MetodoPago)MetodoPago, numeroSeleccionado));
                //            Console.WriteLine($"Boleta {numeroSeleccionado} comprada exitosamente.");

                //             break;
                //    case 2:
                //        CompradorDataManager.UpdateComprador(CompradorUpd);
                //        break;
                //    case 3:
                //        CompradorDataManager.DeleteComprador("7");
                //        break;
                //    case 4:
                //        var getComprador = CompradorDataManager.GetComprador("5");
                //        Console.WriteLine($"el comprador es: {getComprador.Nombre}");
                //        break;
                //    case 5:
                //        if (rifa.Ganador != null)
                //        {
                //            Console.WriteLine($"Ganador: {rifa.Ganador.Nombre}");
                //        }
                //        else
                //        {
                //            Console.WriteLine("Aún no se ha realizado el sorteo de la rifa ganada.");
                //        }
                //        break;
                //    case 6:
                //        return;
                //}
            }

           // Comprador comprador = new Comprador("Grabriel ", "Garcia Marquez ", new DateTime(2023, 9, 19));
           // CompradorDataManager.saveComprador(comprador);
           // private static List<Comprador> compradores = new List<Comprador>();
            }

}
}
