using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PROBA.Class
{
    static class JsonHandler
    {
        static public void ClearFile()
        {
            File.WriteAllText(@"C:\Users\godzi\source\repos\PROBA\prob.json", string.Empty);
            Console.WriteLine("Data cleared successfully.");
        }

        static public void SaveData(Dictionary<int, Depositor> peopleDictionary)
        {
            ClearFile();
            // Сериализуем словарь в JSON
            string json = JsonConvert.SerializeObject(peopleDictionary, Newtonsoft.Json.Formatting.Indented);

            // Сохраняем JSON в файл
            File.WriteAllText(@"C:\Users\godzi\source\repos\PROBA\prob.json", json);
            Console.WriteLine("Data saved to person.json");
        }

        static public Dictionary<int, Depositor> LoadData()
        {
            string jsonFromFile = File.ReadAllText(@"C:\Users\godzi\source\repos\PROBA\prob.json");
            Dictionary<int, Depositor> deserializedDictionary = JsonConvert.DeserializeObject<Dictionary<int, Depositor>>(jsonFromFile);
            if (deserializedDictionary == null || deserializedDictionary.Count == 0)
            {
                MessageBox.Show("Словарь пустой или данные не были загружены.");
                return new Dictionary<int, Depositor>();
            }
            return deserializedDictionary;
        }
    }
}
