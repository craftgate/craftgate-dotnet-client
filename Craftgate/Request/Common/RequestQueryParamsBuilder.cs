using System;
using System.Collections;
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
            switch (value)
            {
                case DateTime time:
                    return FormatDateValue(time);
                case decimal @decimal:
                    return @decimal.ToString(new CultureInfo("en-EN"));
                case IEnumerable enumerable:
                    return FormatEnumerable(enumerable);
                default:
                    return value.ToString();
            }
        }

        private static string FormatEnumerable(IEnumerable enumerable)
        {
            var values = (from object o in enumerable select FormatValue(o)).ToList();
            return string.Join(",", values);
        }
        
        private static string FormatDateValue(DateTime date)
        {
            return date.ToString("yyyy-MM-dd'T'HH:mm:ss");
        }
    }
}