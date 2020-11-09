// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobDtoState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobDtoState
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Stopping")]
        Stopping,
        [EnumMember(Value = "Terminating")]
        Terminating,
        [EnumMember(Value = "Faulted")]
        Faulted,
        [EnumMember(Value = "Successful")]
        Successful,
        [EnumMember(Value = "Stopped")]
        Stopped,
        [EnumMember(Value = "Suspended")]
        Suspended,
        [EnumMember(Value = "Resumed")]
        Resumed
    }
    internal static class JobDtoStateEnumExtension
    {
        internal static string ToSerializedValue(this JobDtoState? value)
        {
            return value == null ? null : ((JobDtoState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobDtoState value)
        {
            switch( value )
            {
                case JobDtoState.Pending:
                    return "Pending";
                case JobDtoState.Running:
                    return "Running";
                case JobDtoState.Stopping:
                    return "Stopping";
                case JobDtoState.Terminating:
                    return "Terminating";
                case JobDtoState.Faulted:
                    return "Faulted";
                case JobDtoState.Successful:
                    return "Successful";
                case JobDtoState.Stopped:
                    return "Stopped";
                case JobDtoState.Suspended:
                    return "Suspended";
                case JobDtoState.Resumed:
                    return "Resumed";
            }
            return null;
        }

        internal static JobDtoState? ParseJobDtoState(this string value)
        {
            switch( value )
            {
                case "Pending":
                    return JobDtoState.Pending;
                case "Running":
                    return JobDtoState.Running;
                case "Stopping":
                    return JobDtoState.Stopping;
                case "Terminating":
                    return JobDtoState.Terminating;
                case "Faulted":
                    return JobDtoState.Faulted;
                case "Successful":
                    return JobDtoState.Successful;
                case "Stopped":
                    return JobDtoState.Stopped;
                case "Suspended":
                    return JobDtoState.Suspended;
                case "Resumed":
                    return JobDtoState.Resumed;
            }
            return null;
        }
    }
}
