// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SessionDtoState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SessionDtoState
    {
        [EnumMember(Value = "Available")]
        Available,
        [EnumMember(Value = "Busy")]
        Busy,
        [EnumMember(Value = "Disconnected")]
        Disconnected,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    internal static class SessionDtoStateEnumExtension
    {
        internal static string ToSerializedValue(this SessionDtoState? value)
        {
            return value == null ? null : ((SessionDtoState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SessionDtoState value)
        {
            switch( value )
            {
                case SessionDtoState.Available:
                    return "Available";
                case SessionDtoState.Busy:
                    return "Busy";
                case SessionDtoState.Disconnected:
                    return "Disconnected";
                case SessionDtoState.Unknown:
                    return "Unknown";
            }
            return null;
        }

        internal static SessionDtoState? ParseSessionDtoState(this string value)
        {
            switch( value )
            {
                case "Available":
                    return SessionDtoState.Available;
                case "Busy":
                    return SessionDtoState.Busy;
                case "Disconnected":
                    return SessionDtoState.Disconnected;
                case "Unknown":
                    return SessionDtoState.Unknown;
            }
            return null;
        }
    }
}