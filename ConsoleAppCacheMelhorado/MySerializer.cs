using Estudo_Cache_Redis_Melhorado.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCacheMelhorado
{
    public class MySerializer : ISerializer
    {
        public T Deserializer<T>(string data)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
            return JsonConvert.DeserializeObject<T>(data, settings);
        }

        public string Serializer<T>(T data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
