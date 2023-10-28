using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa.Data
{
    public static class CompradorDataManager
    {
        public static void saveComprador(Comprador comprador) { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(comprador.Nombre);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void UpdateComprador(Comprador comprador)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(comprador.Nombre);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static List<Comprador> GetAll()
        {
            return new List<Comprador>();
        }
        public static Comprador GetComprador(int id)
        {
            Comprador comprador = new Comprador("Grabriel ", "Garcia Marquez ", new DateTime(2023, 9, 19));
            return comprador;
        }
        public static bool DeleteComprador(int id)
        {
           return true;
        }
    }
}
