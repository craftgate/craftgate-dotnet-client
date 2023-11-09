using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Craftgate.Request.Common
{
    public static class RequestQueryParamsBuilder
    {
        public static string BuildQueryParam(object request)
        {
            var fields = Enumerable.ToList(request.GetType().GetRuntimeProperties());
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
            if (value is DateTime time) return FormatDateValue(time);
            if (value is Decimal @decimal) return @decimal.ToString(new CultureInfo("en-US"));
            if (IsICollection(value.GetType())) return FormatCollection(value as IEnumerable);
            return value.ToString();
        }
        
        private static string FormatCollection(IEnumerable enumerable)
        {
            var values = (from object o in enumerable select FormatValue(o)).ToList();
            return string.Join(",", values);
        }

        private static string FormatDateValue(DateTime date)
        {
            return date.ToString("yyyy-MM-dd'T'HH:mm:ss");
        }
        
        private static bool IsICollection(Type type)
        {
            return Array.Exists(type.GetInterfaces(), interfaceType => 
                typeof(ICollection) == interfaceType || 
                (interfaceType.GetTypeInfo().IsGenericType && typeof(ICollection<>) == interfaceType.GetGenericTypeDefinition())
            );
        }
    }
}