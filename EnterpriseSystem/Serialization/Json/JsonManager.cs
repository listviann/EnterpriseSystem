using EnterpriseSystem.Serialization.Abstract;
using EnterpriseSystem.Service;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace EnterpriseSystem.Serialization.Json
{
    // class that contains logic for json serialization/deserialization
    public class JsonManager<T> : ISerializer<T>
    {
        private readonly JsonSerializerSettings _settings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };

        public List<T> DeserializeData(string filename) => JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filename), _settings)!;

        public void SerializeData(List<T> objects, string filename) => File.WriteAllText(filename, JsonConvert.SerializeObject(objects, Formatting.Indented, _settings));
    }
}
