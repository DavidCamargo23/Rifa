using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        private const string DATA_FILE = "C:\\Users\\USUARIO\\Source\\Repos\\DavidCamargo23\\Rifa\\Data\\Comprador.json";
        public static Comprador AddComprador( Comprador comprador)
        {
            try
            {
                string currentCompradorState = GetFileInfo();
                var jObjet = JObject.Parse (currentCompradorState);
                comprador.Id = $"{jObjet.Properties().Count()+1}";
                string CompradorJson = JsonConvert.SerializeObject(comprador);
                jObjet.Add(comprador.Id, CompradorJson);
                string outputjson = JsonConvert.SerializeObject(jObjet, Formatting.Indented);
                WriteFileInfo(outputjson);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return comprador;
        }
        private static string GetFileInfo()
        {
            return File.ReadAllText(DATA_FILE);
        }   
        private static void WriteFileInfo(string json)
        {
            File.WriteAllText(DATA_FILE, json);
        }
        public static void saveComprador(Comprador comprador) { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(comprador.Nombre);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void UpdateComprador(Comprador comprador)
        {
            try
            {
                logger.logInformation($"Starting Update.. {comprador.Id}");
                string currentCompradorState = GetFileInfo();
                var jObjet = JObject.Parse(currentCompradorState);
                string CompradorJson = JsonConvert.SerializeObject(comprador);
                jObjet[$"{comprador.Id}"] = CompradorJson;
                string outputjson = JsonConvert.SerializeObject(jObjet, Formatting.Indented);
                WriteFileInfo(outputjson);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return comprador;
        }
        public static List<Comprador> GetAll()
        {
            return new List<Comprador>();
        }
        public static Comprador GetComprador(int id)
        {
            Comprador comprador = new Comprador("Grabriel ", "Garcia Marquez ", new DateTime(2023, 9, 19), Comprador.MetodoPago 2,200);
            return comprador;
        }
        public static bool DeleteComprador(int id)
        {
           return true;
        }
    }
}
