
using System;
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
            DateFormatString = "yyyy-MM-dd'T'HH:mm:ss",
            DateTimeZoneHandling = DateTimeZoneHandling.Unspecified,
            Converters = new List<JsonConverter>
            {
                new StringEnumConverter(),
                new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss" }
            }
        };
    }
}