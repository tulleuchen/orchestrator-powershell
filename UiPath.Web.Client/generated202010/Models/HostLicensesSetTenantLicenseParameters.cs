// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class HostLicensesSetTenantLicenseParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HostLicensesSetTenantLicenseParameters class.
        /// </summary>
        public HostLicensesSetTenantLicenseParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HostLicensesSetTenantLicenseParameters class.
        /// </summary>
        public HostLicensesSetTenantLicenseParameters(HostLicensePerTenantDto license = default(HostLicensePerTenantDto))
        {
            License = license;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "license")]
        public HostLicensePerTenantDto License { get; set; }

    }
}
