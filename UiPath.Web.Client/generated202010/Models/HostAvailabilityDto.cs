// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class HostAvailabilityDto
    {
        /// <summary>
        /// Initializes a new instance of the HostAvailabilityDto class.
        /// </summary>
        public HostAvailabilityDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HostAvailabilityDto class.
        /// </summary>
        /// <param name="canConnect">Target host is reachable and a succesful
        /// TCP connection could be made on the specified port</param>
        /// <param name="hasBadSsl">Any error occurred during SSL/TLS
        /// authentication.
        /// Includes bad certificates (name mismatch, expired certificates),
        /// unsupported protocol versions or cyphersuites</param>
        /// <param name="connectionError">An error code that further describes
        /// the type of connection error.
        /// Does not include TLS/SSL errors</param>
        public HostAvailabilityDto(bool? canConnect = default(bool?), bool? hasBadSsl = default(bool?), string connectionError = default(string))
        {
            CanConnect = canConnect;
            HasBadSsl = hasBadSsl;
            ConnectionError = connectionError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target host is reachable and a succesful TCP
        /// connection could be made on the specified port
        /// </summary>
        [JsonProperty(PropertyName = "canConnect")]
        public bool? CanConnect { get; set; }

        /// <summary>
        /// Gets or sets any error occurred during SSL/TLS authentication.
        /// Includes bad certificates (name mismatch, expired certificates),
        /// unsupported protocol versions or cyphersuites
        /// </summary>
        [JsonProperty(PropertyName = "hasBadSsl")]
        public bool? HasBadSsl { get; set; }

        /// <summary>
        /// Gets or sets an error code that further describes the type of
        /// connection error.
        /// Does not include TLS/SSL errors
        /// </summary>
        [JsonProperty(PropertyName = "connectionError")]
        public string ConnectionError { get; set; }

    }
}
