// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RobotIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the RobotIdentifier class.
        /// </summary>
        public RobotIdentifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotIdentifier class.
        /// </summary>
        public RobotIdentifier(string robotKey = default(string), string userName = default(string))
        {
            RobotKey = robotKey;
            UserName = userName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotKey")]
        public string RobotKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

    }
}
