using System.Linq;
using System.Reflection;

namespace Craftgate.Common
{
    public static class ClientVersion
    {
        private const string MetadataKey = "CraftgateClientVersion";
        private const string Unknown = "unknown";

        public static string Value { get; } = Read();

        // The release workflow builds with -p:Version=<tag>, which Craftgate.csproj writes into the assembly metadata.
        private static string Read()
        {
            var version = typeof(ClientVersion).GetTypeInfo().Assembly
                .GetCustomAttributes<AssemblyMetadataAttribute>()
                .FirstOrDefault(attribute => attribute.Key == MetadataKey)?.Value;
            return string.IsNullOrEmpty(version) ? Unknown : version;
        }
    }
}
