using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace VehiclesApp.Data
{
    public class Storage<T> : IData<T> where T : class
    {
        public static JsonSerializerSettings settings = new()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Formatting = Formatting.Indented,
            Converters = new[] { new StringEnumConverter() },
            TypeNameHandling = TypeNameHandling.All
        };

        public IEnumerable<T>? LoadData()
        {
            using StreamReader reader = new($"{typeof(T).Name}.json");
            var json = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<IEnumerable<T>>(json, settings);
        }

        public void WriteData(IEnumerable<T> data)
        {
            using StreamWriter writetext = new($"{typeof(T).Name}.json");
            var json = JsonConvert.SerializeObject(data, settings);
            writetext.WriteLine(json);
        }
    }
}
