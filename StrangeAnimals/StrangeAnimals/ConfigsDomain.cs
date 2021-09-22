using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StrangeAnimals
{
    public static class ConfigsDomain
    {
        static public List<String> GetWordsArrayFromFile(String path)
        {
            var words = new List<String>();

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                words = JsonConvert.DeserializeObject<List<String>>(json);
            }

            return words;
        }
    }
}
