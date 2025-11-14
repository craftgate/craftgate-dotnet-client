using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum ReportFileType
    {
        [EnumMember(Value = "CSV")] CSV,
        [EnumMember(Value = "XLSX")] XLSX
    }
}