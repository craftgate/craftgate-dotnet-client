using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Craftgate.Common
{
    public class CraftgateJsonSerializerSettings
    {
        public static JsonSerializerSettings Settings { get; set; } = new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore,
            Converters = new List<JsonConverter>
            {
                new StringEnumConverter()
            }
        };
    }
}