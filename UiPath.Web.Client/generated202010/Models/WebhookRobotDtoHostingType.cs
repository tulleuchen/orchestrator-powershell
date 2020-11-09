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
    /// Defines values for WebhookRobotDtoHostingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookRobotDtoHostingType
    {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Floating")]
        Floating
    }
    internal static class WebhookRobotDtoHostingTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookRobotDtoHostingType? value)
        {
            return value == null ? null : ((WebhookRobotDtoHostingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookRobotDtoHostingType value)
        {
            switch( value )
            {
                case WebhookRobotDtoHostingType.Standard:
                    return "Standard";
                case WebhookRobotDtoHostingType.Floating:
                    return "Floating";
            }
            return null;
        }

        internal static WebhookRobotDtoHostingType? ParseWebhookRobotDtoHostingType(this string value)
        {
            switch( value )
            {
                case "Standard":
                    return WebhookRobotDtoHostingType.Standard;
                case "Floating":
                    return WebhookRobotDtoHostingType.Floating;
            }
            return null;
        }
    }
}
