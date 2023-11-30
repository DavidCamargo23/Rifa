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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************************** Bienvenido al programa de rifas ******************************");
            Console.ForegroundColor = ConsoleColor.White;
            RifaDataManager.DeleteRifa("1") ;
            RifaDataManager.DeleteRifa("2");
            RifaDataManager.DeleteRifa("3");
            Random random = new Random();
            int numeroRifa = random.Next(1,4);
            DateTime fechaSorteo = DateTime.Now;
            int Qboletas = 0;
            RifaDataManager.AddRifa(new Rifa(fechaSorteo, "********** La rifa de hoy es pequeña la cual contará hasta con 5 boletas. **********", (TipoRifa)1, 5));
            RifaDataManager.AddRifa(new Rifa(fechaSorteo, "********** La rifa de hoy es Mediana la cual contará hasta con 10 boletas. **********", (TipoRifa)2, 10));
            RifaDataManager.AddRifa(new Rifa(fechaSorteo, "********** La rifa de hoy es Grande la cual contará hasta con 20 boletas. **********", (TipoRifa)3, 20));
            Console.WriteLine("Por favor seleccione el tipo de rifa en la que desea participar.");
            Console.WriteLine("1. Rifa pequeña.");
            Console.WriteLine("2. Rifa Mediana");
            Console.WriteLine("3. Rifa Grande");
            Console.WriteLine("La sugerencia automatica del programa es: "+numeroRifa);
            int NRifa = int.Parse(Console.ReadLine());
            Rifa todayRifa = new Rifa();
     
            if (NRifa == 0)
             {
                 Console.WriteLine("Descripción: Esta rifa no está disponible hoy. Lamentamos el inconveniente");
             }
             else if (NRifa == 1)
             {
                todayRifa = RifaDataManager.GetRifa(1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(todayRifa.Descripcion);
                Console.ForegroundColor = ConsoleColor.White;

            }
             else if (NRifa == 2)
             {
                todayRifa = RifaDataManager.GetRifa(2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(todayRifa.Descripcion);
                Console.ForegroundColor = ConsoleColor.White;
            }
             else if (NRifa == 3)
             {
                todayRifa = RifaDataManager.GetRifa(3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(todayRifa.Descripcion);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Número erróneo. Por favor, selecciona un número válido.");
                return;
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
                        Console.WriteLine("Digite su primer nombre");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Digite su apellido");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Seleccione su metodo de pago:");
                        Console.WriteLine("Efectivo = 1");
                        Console.WriteLine("Tarjeta = 2");
                        Console.WriteLine("PSE = 3");
                        int MetodoPago = int.Parse(Console.ReadLine());
                        Random randomb = new Random();
                        int numeroBoleto = randomb.Next(1, todayRifa.QBoletas);
                        var Compradorx = CompradorDataManager.AddComprador(new Comprador(firstName, lastName, fechaSorteo, (MetodoPago)MetodoPago, numeroBoleto));
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("|                                                |");
                        Console.WriteLine("|                 BOLETO DE RIFA                 |");
                        Console.WriteLine("|                                                |");
                        Console.WriteLine("|  Número de Rifa: " + numeroBoleto + "         |");
                        Console.WriteLine("|  Nombre: " + firstName + lastName + "        |");
                        Console.WriteLine("|  Metodo de pago: " + MetodoPago + "            |");
                        Console.WriteLine("|                                                |");
                        Console.WriteLine("|  ¡Gracias por participar en nuestra rifa!      |");
                        Console.WriteLine("|  Mantén este boleto seguro hasta el sorteo.    |");
                        Console.WriteLine("|                                                |");
                        Console.WriteLine("|  Su ID: " + Compradorx.Id + "                     |");
                        Console.WriteLine("|                                                |");
                        Console.WriteLine("--------------------------------------------------");

                        Console.WriteLine($"Boleta {numeroBoleto} comprada exitosamente.");

                        break;
                    case 2:
                        Console.WriteLine("¿Qué numero de {ID] requiere cambiar?");
                        Comprador co;
                    //    CompradorDataManager.UpdateComprador(Compradorx);
                        break;
                    case 3:
                        CompradorDataManager.DeleteComprador("1");
                        break;
                    case 4:
                 //      var getComprador = CompradorDataManager.GetComprador(Compradorx.Id);
                       Console.WriteLine($"el comprador es: {getComprador.Nombre}");
                        break;
             ////       case 5:
             //           if ( != null)
             //           {
             //               Console.WriteLine($"Ganador: {rifa.Ganador.Nombre}");
             //           }
             //           else
             //           {
             //               Console.WriteLine("Aún no se ha realizado el sorteo de la rifa ganada.");
             //           }
             // //          break;
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
