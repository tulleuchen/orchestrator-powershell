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
    /// Defines values for PermissionDtoScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PermissionDtoScope
    {
        [EnumMember(Value = "Global")]
        Global,
        [EnumMember(Value = "Folder")]
        Folder,
        [EnumMember(Value = "GlobalOrFolder")]
        GlobalOrFolder
    }
    internal static class PermissionDtoScopeEnumExtension
    {
        internal static string ToSerializedValue(this PermissionDtoScope? value)
        {
            return value == null ? null : ((PermissionDtoScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PermissionDtoScope value)
        {
            switch( value )
            {
                case PermissionDtoScope.Global:
                    return "Global";
                case PermissionDtoScope.Folder:
                    return "Folder";
                case PermissionDtoScope.GlobalOrFolder:
                    return "GlobalOrFolder";
            }
            return null;
        }

        internal static PermissionDtoScope? ParsePermissionDtoScope(this string value)
        {
            switch( value )
            {
                case "Global":
                    return PermissionDtoScope.Global;
                case "Folder":
                    return PermissionDtoScope.Folder;
                case "GlobalOrFolder":
                    return PermissionDtoScope.GlobalOrFolder;
            }
            return null;
        }
    }
}
