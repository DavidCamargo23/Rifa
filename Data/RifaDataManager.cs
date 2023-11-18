using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa.Data
{
    public class RifaDataManager
    {

        private const string DATA_FILE = "C:\\Users\\USUARIO\\Source\\Repos\\DavidCamargo23\\Rifa\\Data\\Rifa.json";
        public static Rifa AddRifa(Rifa rifa)
        {
            try
            {
                string currentRifaState = GetFileInfo();
                var jObjet = JObject.Parse(currentRifaState);
                rifa.Id = $"{jObjet.Properties().Count() + 1}";
                string RifaJson = JsonConvert.SerializeObject(rifa);
                jObjet.Add(rifa.Id, RifaJson);
                string outputjson = JsonConvert.SerializeObject(jObjet, Formatting.Indented);
                WriteFileInfo(outputjson);

            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }
            return rifa;
        }
        private static string GetFileInfo()
        {
            return File.ReadAllText(DATA_FILE);
        }
        private static void WriteFileInfo(string json)
        {
            File.WriteAllText(DATA_FILE, json);
        }
        public static void SaveRifa(Rifa rifa)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(rifa.Id);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void UpdateRifa(Rifa rifa)
        {
            try
            {
                logger.LogInformation($"Starting Update.. {rifa.Id}");
                string currentRifaState = GetFileInfo();
                var jObjet = JObject.Parse(currentRifaState);
                string RifaJson = JsonConvert.SerializeObject(rifa);
                jObjet[$"{rifa.Id}"] = RifaJson;
                string outputjson = JsonConvert.SerializeObject(jObjet, Formatting.Indented);
                WriteFileInfo(outputjson);

            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }

        }
        public static List<Rifa> GetAll()
        {
            return new List<Rifa>();
        }
        public static Rifa GetRifa(int Id)
        {
            try
            {
                logger.LogInformation($"Starting search... {Id}");
                string currentRifaState = GetFileInfo();
                var jObjet = JObject.Parse(currentRifaState);
                var RifaJsonValue = (string)jObjet[Id];
                var jObjetValue = JObject.Parse(RifaJsonValue);

                return new Rifa(jObjetValue);

            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }
            return null;
        }
        public static bool DeleteRifa(string Id)
        {
            try
            {
                logger.LogInformation($"Starting Deleiting... {Id}");
                string currentRifaState = GetFileInfo();
                var jObjet = JObject.Parse(currentRifaState);
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
