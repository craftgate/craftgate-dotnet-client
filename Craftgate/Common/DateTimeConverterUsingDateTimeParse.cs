using System;
namespace Craftgate.Common
{
    public class DateTimeConverterUsingDateTimeParse
    {
        private readonly string _format;
        public DateTimeConverterUsingDateTimeParse(string format)
        {
            _format = format;
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => DateTime.Parse(reader.GetString()!);

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(_format));
    }
}