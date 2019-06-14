// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace foo.bar.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for OperationStatusType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperationStatusType
    {
        [EnumMember(Value = "notstarted")]
        Notstarted,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed
    }
    internal static class OperationStatusTypeEnumExtension
    {
        internal static string ToSerializedValue(this OperationStatusType? value)
        {
            return value == null ? null : ((OperationStatusType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OperationStatusType value)
        {
            switch( value )
            {
                case OperationStatusType.Notstarted:
                    return "notstarted";
                case OperationStatusType.Running:
                    return "running";
                case OperationStatusType.Succeeded:
                    return "succeeded";
                case OperationStatusType.Failed:
                    return "failed";
            }
            return null;
        }

        internal static OperationStatusType? ParseOperationStatusType(this string value)
        {
            switch( value )
            {
                case "notstarted":
                    return OperationStatusType.Notstarted;
                case "running":
                    return OperationStatusType.Running;
                case "succeeded":
                    return OperationStatusType.Succeeded;
                case "failed":
                    return OperationStatusType.Failed;
            }
            return null;
        }
    }
}
