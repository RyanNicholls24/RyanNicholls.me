using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorApp1.wwwroot.json
{
    public class Serializer
    {

        public string go(string id) {
            JObject o1 = JObject.Parse(File.ReadAllText("../../json/Intro.json"));
            string text;
            // read JSON directly from a file
            using (StreamReader file = File.OpenText("../../json/Intro.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
                JObject jo = jo.Parse(o2);
                string text = (string)jo.SelectToken(id);
            }
            return text;
        }

            
    }
}

