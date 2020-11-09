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
    /// Defines values for BulkItemDto1Status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BulkItemDto1Status
    {
        [EnumMember(Value = "Continue")]
        Continue,
        [EnumMember(Value = "SwitchingProtocols")]
        SwitchingProtocols,
        [EnumMember(Value = "Processing")]
        Processing,
        [EnumMember(Value = "EarlyHints")]
        EarlyHints,
        [EnumMember(Value = "OK")]
        OK,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "NonAuthoritativeInformation")]
        NonAuthoritativeInformation,
        [EnumMember(Value = "NoContent")]
        NoContent,
        [EnumMember(Value = "ResetContent")]
        ResetContent,
        [EnumMember(Value = "PartialContent")]
        PartialContent,
        [EnumMember(Value = "MultiStatus")]
        MultiStatus,
        [EnumMember(Value = "AlreadyReported")]
        AlreadyReported,
        [EnumMember(Value = "IMUsed")]
        IMUsed,
        [EnumMember(Value = "MultipleChoices")]
        MultipleChoices,
        [EnumMember(Value = "Ambiguous")]
        Ambiguous,
        [EnumMember(Value = "MovedPermanently")]
        MovedPermanently,
        [EnumMember(Value = "Moved")]
        Moved,
        [EnumMember(Value = "Found")]
        Found,
        [EnumMember(Value = "Redirect")]
        Redirect,
        [EnumMember(Value = "SeeOther")]
        SeeOther,
        [EnumMember(Value = "RedirectMethod")]
        RedirectMethod,
        [EnumMember(Value = "NotModified")]
        NotModified,
        [EnumMember(Value = "UseProxy")]
        UseProxy,
        [EnumMember(Value = "Unused")]
        Unused,
        [EnumMember(Value = "TemporaryRedirect")]
        TemporaryRedirect,
        [EnumMember(Value = "RedirectKeepVerb")]
        RedirectKeepVerb,
        [EnumMember(Value = "PermanentRedirect")]
        PermanentRedirect,
        [EnumMember(Value = "BadRequest")]
        BadRequest,
        [EnumMember(Value = "Unauthorized")]
        Unauthorized,
        [EnumMember(Value = "PaymentRequired")]
        PaymentRequired,
        [EnumMember(Value = "Forbidden")]
        Forbidden,
        [EnumMember(Value = "NotFound")]
        NotFound,
        [EnumMember(Value = "MethodNotAllowed")]
        MethodNotAllowed,
        [EnumMember(Value = "NotAcceptable")]
        NotAcceptable,
        [EnumMember(Value = "ProxyAuthenticationRequired")]
        ProxyAuthenticationRequired,
        [EnumMember(Value = "RequestTimeout")]
        RequestTimeout,
        [EnumMember(Value = "Conflict")]
        Conflict,
        [EnumMember(Value = "Gone")]
        Gone,
        [EnumMember(Value = "LengthRequired")]
        LengthRequired,
        [EnumMember(Value = "PreconditionFailed")]
        PreconditionFailed,
        [EnumMember(Value = "RequestEntityTooLarge")]
        RequestEntityTooLarge,
        [EnumMember(Value = "RequestUriTooLong")]
        RequestUriTooLong,
        [EnumMember(Value = "UnsupportedMediaType")]
        UnsupportedMediaType,
        [EnumMember(Value = "RequestedRangeNotSatisfiable")]
        RequestedRangeNotSatisfiable,
        [EnumMember(Value = "ExpectationFailed")]
        ExpectationFailed,
        [EnumMember(Value = "MisdirectedRequest")]
        MisdirectedRequest,
        [EnumMember(Value = "UnprocessableEntity")]
        UnprocessableEntity,
        [EnumMember(Value = "Locked")]
        Locked,
        [EnumMember(Value = "FailedDependency")]
        FailedDependency,
        [EnumMember(Value = "UpgradeRequired")]
        UpgradeRequired,
        [EnumMember(Value = "PreconditionRequired")]
        PreconditionRequired,
        [EnumMember(Value = "TooManyRequests")]
        TooManyRequests,
        [EnumMember(Value = "RequestHeaderFieldsTooLarge")]
        RequestHeaderFieldsTooLarge,
        [EnumMember(Value = "UnavailableForLegalReasons")]
        UnavailableForLegalReasons,
        [EnumMember(Value = "InternalServerError")]
        InternalServerError,
        [EnumMember(Value = "NotImplemented")]
        NotImplemented,
        [EnumMember(Value = "BadGateway")]
        BadGateway,
        [EnumMember(Value = "ServiceUnavailable")]
        ServiceUnavailable,
        [EnumMember(Value = "GatewayTimeout")]
        GatewayTimeout,
        [EnumMember(Value = "HttpVersionNotSupported")]
        HttpVersionNotSupported,
        [EnumMember(Value = "VariantAlsoNegotiates")]
        VariantAlsoNegotiates,
        [EnumMember(Value = "InsufficientStorage")]
        InsufficientStorage,
        [EnumMember(Value = "LoopDetected")]
        LoopDetected,
        [EnumMember(Value = "NotExtended")]
        NotExtended,
        [EnumMember(Value = "NetworkAuthenticationRequired")]
        NetworkAuthenticationRequired
    }
    internal static class BulkItemDto1StatusEnumExtension
    {
        internal static string ToSerializedValue(this BulkItemDto1Status? value)
        {
            return value == null ? null : ((BulkItemDto1Status)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this BulkItemDto1Status value)
        {
            switch( value )
            {
                case BulkItemDto1Status.Continue:
                    return "Continue";
                case BulkItemDto1Status.SwitchingProtocols:
                    return "SwitchingProtocols";
                case BulkItemDto1Status.Processing:
                    return "Processing";
                case BulkItemDto1Status.EarlyHints:
                    return "EarlyHints";
                case BulkItemDto1Status.OK:
                    return "OK";
                case BulkItemDto1Status.Created:
                    return "Created";
                case BulkItemDto1Status.Accepted:
                    return "Accepted";
                case BulkItemDto1Status.NonAuthoritativeInformation:
                    return "NonAuthoritativeInformation";
                case BulkItemDto1Status.NoContent:
                    return "NoContent";
                case BulkItemDto1Status.ResetContent:
                    return "ResetContent";
                case BulkItemDto1Status.PartialContent:
                    return "PartialContent";
                case BulkItemDto1Status.MultiStatus:
                    return "MultiStatus";
                case BulkItemDto1Status.AlreadyReported:
                    return "AlreadyReported";
                case BulkItemDto1Status.IMUsed:
                    return "IMUsed";
                case BulkItemDto1Status.MultipleChoices:
                    return "MultipleChoices";
                case BulkItemDto1Status.Ambiguous:
                    return "Ambiguous";
                case BulkItemDto1Status.MovedPermanently:
                    return "MovedPermanently";
                case BulkItemDto1Status.Moved:
                    return "Moved";
                case BulkItemDto1Status.Found:
                    return "Found";
                case BulkItemDto1Status.Redirect:
                    return "Redirect";
                case BulkItemDto1Status.SeeOther:
                    return "SeeOther";
                case BulkItemDto1Status.RedirectMethod:
                    return "RedirectMethod";
                case BulkItemDto1Status.NotModified:
                    return "NotModified";
                case BulkItemDto1Status.UseProxy:
                    return "UseProxy";
                case BulkItemDto1Status.Unused:
                    return "Unused";
                case BulkItemDto1Status.TemporaryRedirect:
                    return "TemporaryRedirect";
                case BulkItemDto1Status.RedirectKeepVerb:
                    return "RedirectKeepVerb";
                case BulkItemDto1Status.PermanentRedirect:
                    return "PermanentRedirect";
                case BulkItemDto1Status.BadRequest:
                    return "BadRequest";
                case BulkItemDto1Status.Unauthorized:
                    return "Unauthorized";
                case BulkItemDto1Status.PaymentRequired:
                    return "PaymentRequired";
                case BulkItemDto1Status.Forbidden:
                    return "Forbidden";
                case BulkItemDto1Status.NotFound:
                    return "NotFound";
                case BulkItemDto1Status.MethodNotAllowed:
                    return "MethodNotAllowed";
                case BulkItemDto1Status.NotAcceptable:
                    return "NotAcceptable";
                case BulkItemDto1Status.ProxyAuthenticationRequired:
                    return "ProxyAuthenticationRequired";
                case BulkItemDto1Status.RequestTimeout:
                    return "RequestTimeout";
                case BulkItemDto1Status.Conflict:
                    return "Conflict";
                case BulkItemDto1Status.Gone:
                    return "Gone";
                case BulkItemDto1Status.LengthRequired:
                    return "LengthRequired";
                case BulkItemDto1Status.PreconditionFailed:
                    return "PreconditionFailed";
                case BulkItemDto1Status.RequestEntityTooLarge:
                    return "RequestEntityTooLarge";
                case BulkItemDto1Status.RequestUriTooLong:
                    return "RequestUriTooLong";
                case BulkItemDto1Status.UnsupportedMediaType:
                    return "UnsupportedMediaType";
                case BulkItemDto1Status.RequestedRangeNotSatisfiable:
                    return "RequestedRangeNotSatisfiable";
                case BulkItemDto1Status.ExpectationFailed:
                    return "ExpectationFailed";
                case BulkItemDto1Status.MisdirectedRequest:
                    return "MisdirectedRequest";
                case BulkItemDto1Status.UnprocessableEntity:
                    return "UnprocessableEntity";
                case BulkItemDto1Status.Locked:
                    return "Locked";
                case BulkItemDto1Status.FailedDependency:
                    return "FailedDependency";
                case BulkItemDto1Status.UpgradeRequired:
                    return "UpgradeRequired";
                case BulkItemDto1Status.PreconditionRequired:
                    return "PreconditionRequired";
                case BulkItemDto1Status.TooManyRequests:
                    return "TooManyRequests";
                case BulkItemDto1Status.RequestHeaderFieldsTooLarge:
                    return "RequestHeaderFieldsTooLarge";
                case BulkItemDto1Status.UnavailableForLegalReasons:
                    return "UnavailableForLegalReasons";
                case BulkItemDto1Status.InternalServerError:
                    return "InternalServerError";
                case BulkItemDto1Status.NotImplemented:
                    return "NotImplemented";
                case BulkItemDto1Status.BadGateway:
                    return "BadGateway";
                case BulkItemDto1Status.ServiceUnavailable:
                    return "ServiceUnavailable";
                case BulkItemDto1Status.GatewayTimeout:
                    return "GatewayTimeout";
                case BulkItemDto1Status.HttpVersionNotSupported:
                    return "HttpVersionNotSupported";
                case BulkItemDto1Status.VariantAlsoNegotiates:
                    return "VariantAlsoNegotiates";
                case BulkItemDto1Status.InsufficientStorage:
                    return "InsufficientStorage";
                case BulkItemDto1Status.LoopDetected:
                    return "LoopDetected";
                case BulkItemDto1Status.NotExtended:
                    return "NotExtended";
                case BulkItemDto1Status.NetworkAuthenticationRequired:
                    return "NetworkAuthenticationRequired";
            }
            return null;
        }

        internal static BulkItemDto1Status? ParseBulkItemDto1Status(this string value)
        {
            switch( value )
            {
                case "Continue":
                    return BulkItemDto1Status.Continue;
                case "SwitchingProtocols":
                    return BulkItemDto1Status.SwitchingProtocols;
                case "Processing":
                    return BulkItemDto1Status.Processing;
                case "EarlyHints":
                    return BulkItemDto1Status.EarlyHints;
                case "OK":
                    return BulkItemDto1Status.OK;
                case "Created":
                    return BulkItemDto1Status.Created;
                case "Accepted":
                    return BulkItemDto1Status.Accepted;
                case "NonAuthoritativeInformation":
                    return BulkItemDto1Status.NonAuthoritativeInformation;
                case "NoContent":
                    return BulkItemDto1Status.NoContent;
                case "ResetContent":
                    return BulkItemDto1Status.ResetContent;
                case "PartialContent":
                    return BulkItemDto1Status.PartialContent;
                case "MultiStatus":
                    return BulkItemDto1Status.MultiStatus;
                case "AlreadyReported":
                    return BulkItemDto1Status.AlreadyReported;
                case "IMUsed":
                    return BulkItemDto1Status.IMUsed;
                case "MultipleChoices":
                    return BulkItemDto1Status.MultipleChoices;
                case "Ambiguous":
                    return BulkItemDto1Status.Ambiguous;
                case "MovedPermanently":
                    return BulkItemDto1Status.MovedPermanently;
                case "Moved":
                    return BulkItemDto1Status.Moved;
                case "Found":
                    return BulkItemDto1Status.Found;
                case "Redirect":
                    return BulkItemDto1Status.Redirect;
                case "SeeOther":
                    return BulkItemDto1Status.SeeOther;
                case "RedirectMethod":
                    return BulkItemDto1Status.RedirectMethod;
                case "NotModified":
                    return BulkItemDto1Status.NotModified;
                case "UseProxy":
                    return BulkItemDto1Status.UseProxy;
                case "Unused":
                    return BulkItemDto1Status.Unused;
                case "TemporaryRedirect":
                    return BulkItemDto1Status.TemporaryRedirect;
                case "RedirectKeepVerb":
                    return BulkItemDto1Status.RedirectKeepVerb;
                case "PermanentRedirect":
                    return BulkItemDto1Status.PermanentRedirect;
                case "BadRequest":
                    return BulkItemDto1Status.BadRequest;
                case "Unauthorized":
                    return BulkItemDto1Status.Unauthorized;
                case "PaymentRequired":
                    return BulkItemDto1Status.PaymentRequired;
                case "Forbidden":
                    return BulkItemDto1Status.Forbidden;
                case "NotFound":
                    return BulkItemDto1Status.NotFound;
                case "MethodNotAllowed":
                    return BulkItemDto1Status.MethodNotAllowed;
                case "NotAcceptable":
                    return BulkItemDto1Status.NotAcceptable;
                case "ProxyAuthenticationRequired":
                    return BulkItemDto1Status.ProxyAuthenticationRequired;
                case "RequestTimeout":
                    return BulkItemDto1Status.RequestTimeout;
                case "Conflict":
                    return BulkItemDto1Status.Conflict;
                case "Gone":
                    return BulkItemDto1Status.Gone;
                case "LengthRequired":
                    return BulkItemDto1Status.LengthRequired;
                case "PreconditionFailed":
                    return BulkItemDto1Status.PreconditionFailed;
                case "RequestEntityTooLarge":
                    return BulkItemDto1Status.RequestEntityTooLarge;
                case "RequestUriTooLong":
                    return BulkItemDto1Status.RequestUriTooLong;
                case "UnsupportedMediaType":
                    return BulkItemDto1Status.UnsupportedMediaType;
                case "RequestedRangeNotSatisfiable":
                    return BulkItemDto1Status.RequestedRangeNotSatisfiable;
                case "ExpectationFailed":
                    return BulkItemDto1Status.ExpectationFailed;
                case "MisdirectedRequest":
                    return BulkItemDto1Status.MisdirectedRequest;
                case "UnprocessableEntity":
                    return BulkItemDto1Status.UnprocessableEntity;
                case "Locked":
                    return BulkItemDto1Status.Locked;
                case "FailedDependency":
                    return BulkItemDto1Status.FailedDependency;
                case "UpgradeRequired":
                    return BulkItemDto1Status.UpgradeRequired;
                case "PreconditionRequired":
                    return BulkItemDto1Status.PreconditionRequired;
                case "TooManyRequests":
                    return BulkItemDto1Status.TooManyRequests;
                case "RequestHeaderFieldsTooLarge":
                    return BulkItemDto1Status.RequestHeaderFieldsTooLarge;
                case "UnavailableForLegalReasons":
                    return BulkItemDto1Status.UnavailableForLegalReasons;
                case "InternalServerError":
                    return BulkItemDto1Status.InternalServerError;
                case "NotImplemented":
                    return BulkItemDto1Status.NotImplemented;
                case "BadGateway":
                    return BulkItemDto1Status.BadGateway;
                case "ServiceUnavailable":
                    return BulkItemDto1Status.ServiceUnavailable;
                case "GatewayTimeout":
                    return BulkItemDto1Status.GatewayTimeout;
                case "HttpVersionNotSupported":
                    return BulkItemDto1Status.HttpVersionNotSupported;
                case "VariantAlsoNegotiates":
                    return BulkItemDto1Status.VariantAlsoNegotiates;
                case "InsufficientStorage":
                    return BulkItemDto1Status.InsufficientStorage;
                case "LoopDetected":
                    return BulkItemDto1Status.LoopDetected;
                case "NotExtended":
                    return BulkItemDto1Status.NotExtended;
                case "NetworkAuthenticationRequired":
                    return BulkItemDto1Status.NetworkAuthenticationRequired;
            }
            return null;
        }
    }
}
