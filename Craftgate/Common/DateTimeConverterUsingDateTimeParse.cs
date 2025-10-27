using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Craftgate.Common
{
    public class DateTimeConverterUsingDateTimeParse : IsoDateTimeConverter
    {
        public DateTimeConverterUsingDateTimeParse(string format)
        {
            DateTimeFormat = format;
        }
    }
}