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
            Random random = new Random();
            int numeroRifa = random.Next(4);
            Console.WriteLine(numeroRifa);
            DateTime fechaSorteo = DateTime.Now;
            Console.WriteLine("La rifa de hoy es: ");
            int Qboletas = 0;
                        
             if (numeroRifa == 0)
             {
                 Console.WriteLine("Descripción: Esta rifa no está disponible hoy. Lamentamos el inconveniente");
             }
             else if (numeroRifa == 1)
             {
                 Console.WriteLine($"Fecha del sorteo: {fechaSorteo}");
                 Console.WriteLine($"Descripción: la rifa de hoy es pequeña la cual contará hasta con 5 boletas.");
                 Qboletas = 5;
             }
             else if (numeroRifa == 2)
             {
                 Console.WriteLine($"Fecha del sorteo: {fechaSorteo}");
                 Console.WriteLine($"Descripción: la rifa de hoy es Mediana la cual contará hasta con 10 boletas.");
                 Qboletas = 10;
             }
             else if (numeroRifa == 3)
             {
                 Console.WriteLine($"Fecha del sorteo: {fechaSorteo}");
                 Console.WriteLine($"Descripción: la rifa de hoy es Grande la cual contará hasta con 20 boletas.");
                 Qboletas = 20;
             }

            while (true)
            {
                Rifa rifa = new Rifa(fechaSorteo,"Esta rifa es el sorteo anual de fin de año", (TipoRifa)numeroRifa);
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Comprar boleta");
                Console.WriteLine("2. Actualizar datos boleta");
                Console.WriteLine("3. Eliminar datos boleta");
                Console.WriteLine("4. Buscar datos boleta");
                Console.WriteLine("5. Mostrar rifa ganada");
                Console.WriteLine("6. Salir");

                int opcion = int.Parse(Console.ReadLine());

                CompradorDataManager.AddComprador(new Comprador("david", "gonzales", fechaSorteo, MetodoPago.PSE, 200));

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
                            Random random1 = new Random();
                            List<int> numerosSeleccionados = new List<int>();
                            int numeroSeleccionado = ObtenerNumeroAleatorioNoRepetido(random1, numerosSeleccionados);
                            Console.WriteLine("El numero de la boleta es: " + numeroSeleccionado);
                            int ObtenerNumeroAleatorioNoRepetido(Random random1, List<int> numerosSeleccionados) {
                            List<int> numerosPosibles = new List<int> {Qboletas};
                            numerosPosibles.RemoveAll(n => numerosSeleccionados.Contains(n));
                            int indice = random1.Next(0, numerosPosibles.Count);
                            int numeroAleatorio = numerosPosibles[indice];
                            numerosSeleccionados.Add(numeroAleatorio);    
                            return numeroAleatorio;      
                            CompradorDataManager.AddComprador (new Comprador(firstName, lastName, fechaSorteo,(MetodoPago)MetodoPago, numeroSeleccionado));
                            Console.WriteLine($"Boleta {numeroSeleccionado} comprada exitosamente.");
                        
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
