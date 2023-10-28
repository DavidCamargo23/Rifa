using System;
using System.Collections.Generic;
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
    }
}
