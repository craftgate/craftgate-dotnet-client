using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Craftgate.Request.Common
{
    public static class RequestQueryParamsBuilder
    {
        public static string BuildQueryParam(object request)
        {
            var fields = request.GetType().GetRuntimeProperties().ToList();
            var query = new StringBuilder(fields.Any() ? "?" : "");
            foreach (var field in fields)
            {
                var value = field.GetValue(request);
                var name = char.ToLowerInvariant(field.Name[0]) + field.Name.Substring(1);

                if (value != null)
                    query.Append(name).Append("=").Append(Uri.EscapeDataString(FormatValue(value))).Append("&");
            }

            return query.ToString();
        }

        private static string FormatValue(object value)
        {
            switch (value)
            {
                case DateTime time:
                    return FormatDateValue(time);
                case ISet<long> enumerable:
                    return FormatListValue<long>(enumerable);
                case ISet<string> enumerable:
                    return FormatListValue<string>(enumerable);
                case Enum @enum:
                    return GetEnumMemberAttrValue(@enum);
                default:
                    return value.ToString();
            }
        }

        private static string FormatDateValue(DateTime date)
        {
            return date.ToString("yyyy-MM-dd'T'HH:mm:ss");
        }

        private static string FormatListValue<T>(ISet<T> value)
        {
            return string.Join(",", value);
        }

        private static string GetEnumMemberAttrValue<T>(T enumVal)
        {
            var attr = (EnumMemberAttribute) enumVal.GetType().GetRuntimeField(enumVal.ToString())
                .GetCustomAttribute(typeof(EnumMemberAttribute));
            if (attr != null) return attr.Value;

            return null;
        }
    }
}