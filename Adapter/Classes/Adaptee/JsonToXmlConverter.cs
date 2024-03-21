using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Adapter.Classes.Adaptee
{
    internal class JsonToXmlConverter(string json)
    {
        public string JsonString { get; } = json;

        public string? ConvertToXml()
        {
            if (IsValidJson(JsonString))
            {
                var jsonObject = JObject.Parse(JsonString);
                var xml = JsonConvert.DeserializeXNode(jsonObject.ToString()!, "Root")!;
                return xml?.ToString();
            }
            return default;
        }

        private static bool IsValidJson(string jsonString)
        {
            try
            {
                JToken.Parse(jsonString);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
    }
}
