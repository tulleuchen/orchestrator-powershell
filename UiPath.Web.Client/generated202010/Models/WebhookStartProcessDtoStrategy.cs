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
    /// Defines values for WebhookStartProcessDtoStrategy.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookStartProcessDtoStrategy
    {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Specific")]
        Specific,
        [EnumMember(Value = "RobotCount")]
        RobotCount,
        [EnumMember(Value = "JobsCount")]
        JobsCount,
        [EnumMember(Value = "ModernJobsCount")]
        ModernJobsCount
    }
    internal static class WebhookStartProcessDtoStrategyEnumExtension
    {
        internal static string ToSerializedValue(this WebhookStartProcessDtoStrategy? value)
        {
            return value == null ? null : ((WebhookStartProcessDtoStrategy)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookStartProcessDtoStrategy value)
        {
            switch( value )
            {
                case WebhookStartProcessDtoStrategy.All:
                    return "All";
                case WebhookStartProcessDtoStrategy.Specific:
                    return "Specific";
                case WebhookStartProcessDtoStrategy.RobotCount:
                    return "RobotCount";
                case WebhookStartProcessDtoStrategy.JobsCount:
                    return "JobsCount";
                case WebhookStartProcessDtoStrategy.ModernJobsCount:
                    return "ModernJobsCount";
            }
            return null;
        }

        internal static WebhookStartProcessDtoStrategy? ParseWebhookStartProcessDtoStrategy(this string value)
        {
            switch( value )
            {
                case "All":
                    return WebhookStartProcessDtoStrategy.All;
                case "Specific":
                    return WebhookStartProcessDtoStrategy.Specific;
                case "RobotCount":
                    return WebhookStartProcessDtoStrategy.RobotCount;
                case "JobsCount":
                    return WebhookStartProcessDtoStrategy.JobsCount;
                case "ModernJobsCount":
                    return WebhookStartProcessDtoStrategy.ModernJobsCount;
            }
            return null;
        }
    }
}
