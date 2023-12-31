﻿using Newtonsoft.Json;
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
                logger.LogError(ex);
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
        public static void SaveComprador(Comprador comprador) { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(comprador.Nombre);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void UpdateComprador(Comprador comprador)
        {
            try
            {
                logger.LogInformation($"Starting Update.. {comprador.Id}");
                string currentCompradorState = GetFileInfo();
                var jObjet = JObject.Parse(currentCompradorState);
                string CompradorJson = JsonConvert.SerializeObject(comprador);
                jObjet[$"{comprador.Id}"] = CompradorJson;
                string outputjson = JsonConvert.SerializeObject(jObjet, Formatting.Indented);
                WriteFileInfo(outputjson);

            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }
            
        }
        public static List<Comprador> GetAll()
        {
            return new List<Comprador>();
        }
        public static Comprador GetComprador(string Id)
        {
            try
            {
                logger.LogInformation($"Starting search... {Id}");
                string currentCompradorState = GetFileInfo();
                var jObjet = JObject.Parse(currentCompradorState);
                var compradorJsonValue = (string)jObjet[Id];
                var jObjetValue = JObject.Parse(compradorJsonValue);

                return new Comprador (jObjetValue);

            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }
            return null;
        }
        public static bool DeleteComprador(string Id)
        {
            try
            {
                logger.LogInformation($"Starting Deleiting... {Id}");
                string currentCompradorState = GetFileInfo();
                var jObjet = JObject.Parse(currentCompradorState);
                jObjet.Remove(Id);
                string outputjson = JsonConvert.SerializeObject(jObjet, Formatting.Indented);
                WriteFileInfo(outputjson);

            }
            catch (Exception ex)
            {
               logger.LogError(ex);
            }
            return true;
        }
    }
}
