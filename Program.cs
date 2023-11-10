using Rifa;
using Rifa.Data;
using System;

namespace Rifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rifa rifa = new Rifa(fechaSorteo);
            
            Console.WriteLine("Bienvenido al programa de rifas");

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Comprar boleta");
                Console.WriteLine("2. Mostrar rifa ganada");
                Console.WriteLine("3. Salir");

                int opcion = LeerEntero();

                switch (opcion)
                {
                    case 1:
                        if (rifa.Puestos.Any(p => !comprador.Any(c => c.numero == p.numero)))
                        {
                            int numeroBoleta = BoletaDisponible(rifa);
                            CompradoDataManager.addComprador (new Comprador("Grabriel", "Garcia Marquez", new DateTime(2023, 9, 19),Comprador.MetodoPago, 200));
                            Console.WriteLine($"Boleta {numeroBoleta} comprada exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("No hay boletas disponibles.");
                        }
                        break;
                    case 2:
                        if (rifa.Ganador != null)
                        {
                            Console.WriteLine($"Ganador: {rifa.Ganador.Nombre}");
                        }
                        else
                        {
                            Console.WriteLine("Aún no se ha realizado el sorteo de la rifa ganada.");
                        }
                        break;
                    case 3:
                        return;
                }
            }

           // Comprador comprador = new Comprador("Grabriel ", "Garcia Marquez ", new DateTime(2023, 9, 19));
           // CompradorDataManager.saveComprador(comprador);
           // private static List<Comprador> compradores = new List<Comprador>();
            }

}
