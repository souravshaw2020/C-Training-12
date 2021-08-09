using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Json
    {
        public void read(string url)
        {
            try
            {
                using (var reader = new StreamReader(url))
                {
                    string json = reader.ReadToEnd();
                    Dictionary<string, object> deserializedDictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                    Console.WriteLine(deserializedDictionary);
                    foreach (KeyValuePair<string, object> key in deserializedDictionary)
                    {
                        Console.WriteLine("Key : {0}, Value : {1}", key.Key, key.Value);
                    }
                    Console.ReadKey();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Main(string[] args)
        {
            Json ob = new Json();
            Console.Write("Enter the Path of the Json file : ");
            string url = Console.ReadLine();
            ob.read(url);
        }
    }
}
