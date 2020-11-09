// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TenantDto
    {
        /// <summary>
        /// Initializes a new instance of the TenantDto class.
        /// </summary>
        public TenantDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantDto class.
        /// </summary>
        /// <param name="name">Name of the tenant.</param>
        /// <param name="key">Unique Key of the tenant.</param>
        /// <param name="displayName">Display name of the the tenant</param>
        /// <param name="adminEmailAddress">Default tenant's admin user account
        /// email address.</param>
        /// <param name="adminName">Default tenant's admin user account
        /// name.</param>
        /// <param name="adminSurname">Default tenant's admin user account
        /// surname.</param>
        /// <param name="adminUserKey">Default tenant's admin user account
        /// key.</param>
        /// <param name="adminPassword">Default tenant's admin user account
        /// password. Only valid for create/update operations.</param>
        /// <param name="lastLoginTime">The last time a user logged in this
        /// tenant.</param>
        /// <param name="isActive">Specifies if the tenant is active or
        /// not.</param>
        /// <param name="acceptedDomainsList">Accepted DNS list.</param>
        /// <param name="hasConnectionString">Specifies if the the tenant has a
        /// connection string defined</param>
        /// <param name="connectionString">DB connection string</param>
        public TenantDto(string name = default(string), string key = default(string), string displayName = default(string), string adminEmailAddress = default(string), string adminName = default(string), string adminSurname = default(string), string adminUserKey = default(string), string adminPassword = default(string), System.DateTime? lastLoginTime = default(System.DateTime?), bool? isActive = default(bool?), IList<string> acceptedDomainsList = default(IList<string>), bool? hasConnectionString = default(bool?), string connectionString = default(string), TenantLicenseDto license = default(TenantLicenseDto), int? id = default(int?))
        {
            Name = name;
            Key = key;
            DisplayName = displayName;
            AdminEmailAddress = adminEmailAddress;
            AdminName = adminName;
            AdminSurname = adminSurname;
            AdminUserKey = adminUserKey;
            AdminPassword = adminPassword;
            LastLoginTime = lastLoginTime;
            IsActive = isActive;
            AcceptedDomainsList = acceptedDomainsList;
            HasConnectionString = hasConnectionString;
            ConnectionString = connectionString;
            License = license;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique Key of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets display name of the the tenant
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account email address.
        /// </summary>
        [JsonProperty(PropertyName = "AdminEmailAddress")]
        public string AdminEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account name.
        /// </summary>
        [JsonProperty(PropertyName = "AdminName")]
        public string AdminName { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account surname.
        /// </summary>
        [JsonProperty(PropertyName = "AdminSurname")]
        public string AdminSurname { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account key.
        /// </summary>
        [JsonProperty(PropertyName = "AdminUserKey")]
        public string AdminUserKey { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account password. Only
        /// valid for create/update operations.
        /// </summary>
        [JsonProperty(PropertyName = "AdminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Gets or sets the last time a user logged in this tenant.
        /// </summary>
        [JsonProperty(PropertyName = "LastLoginTime")]
        public System.DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// Gets or sets specifies if the tenant is active or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets accepted DNS list.
        /// </summary>
        [JsonProperty(PropertyName = "AcceptedDomainsList")]
        public IList<string> AcceptedDomainsList { get; set; }

        /// <summary>
        /// Gets or sets specifies if the the tenant has a connection string
        /// defined
        /// </summary>
        [JsonProperty(PropertyName = "HasConnectionString")]
        public bool? HasConnectionString { get; set; }

        /// <summary>
        /// Gets or sets DB connection string
        /// </summary>
        [JsonProperty(PropertyName = "ConnectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "License")]
        public TenantLicenseDto License { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name != null)
            {
                if (Name.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 64);
                }
                if (Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[\\p{L}][\\p{L}0-9-_]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[\\p{L}][\\p{L}0-9-_]+$");
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 128);
                }
                if (DisplayName.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 0);
                }
            }
            if (AdminEmailAddress != null)
            {
                if (AdminEmailAddress.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdminEmailAddress", 256);
                }
                if (AdminEmailAddress.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdminEmailAddress", 0);
                }
            }
            if (AdminName != null)
            {
                if (AdminName.Length > 32)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdminName", 32);
                }
                if (AdminName.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdminName", 0);
                }
            }
            if (AdminSurname != null)
            {
                if (AdminSurname.Length > 32)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdminSurname", 32);
                }
                if (AdminSurname.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdminSurname", 0);
                }
            }
            if (AdminPassword != null)
            {
                if (AdminPassword.Length > 32)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdminPassword", 32);
                }
                if (AdminPassword.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdminPassword", 0);
                }
            }
            if (ConnectionString != null)
            {
                if (ConnectionString.Length > 1024)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ConnectionString", 1024);
                }
                if (ConnectionString.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ConnectionString", 0);
                }
            }
        }
    }
}
