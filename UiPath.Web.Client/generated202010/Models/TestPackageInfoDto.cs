// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TestPackageInfoDto
    {
        /// <summary>
        /// Initializes a new instance of the TestPackageInfoDto class.
        /// </summary>
        public TestPackageInfoDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestPackageInfoDto class.
        /// </summary>
        public TestPackageInfoDto(string packageIdentifier = default(string), string latestVersion = default(string), string latestPrereleaseVersion = default(string))
        {
            PackageIdentifier = packageIdentifier;
            LatestVersion = latestVersion;
            LatestPrereleaseVersion = latestPrereleaseVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packageIdentifier")]
        public string PackageIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latestVersion")]
        public string LatestVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latestPrereleaseVersion")]
        public string LatestPrereleaseVersion { get; set; }

    }
}
