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

    /// <summary>
    /// Entity derived from RobotDto. Is shares all the properties of the base
    /// entity and includes the license field.
    /// </summary>
    public partial class RobotWithLicenseDto
    {
        /// <summary>
        /// Initializes a new instance of the RobotWithLicenseDto class.
        /// </summary>
        public RobotWithLicenseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotWithLicenseDto class.
        /// </summary>
        /// <param name="name">A custom name for the robot.</param>
        /// <param name="username">The machine username. If the user is under a
        /// domain, you are required to also specify it in a DOMAIN\username
        /// format.
        /// &lt;para /&gt;Note: You must use short domain names, such as
        /// desktop\administrator and NOT desktop.local/administrator.</param>
        /// <param name="type">The Robot type. Possible values include:
        /// 'NonProduction', 'Attended', 'Unattended', 'Studio', 'Development',
        /// 'StudioX', 'Headless', 'StudioPro', 'TestAutomation'</param>
        /// <param name="hostingType">The Robot hosting type (Standard /
        /// Floating). Possible values include: 'Standard', 'Floating'</param>
        /// <param name="licenseKey">The key is automatically generated from
        /// the server for the Robot machine.
        /// &lt;para /&gt;For the robot to work, the same key must exist on
        /// both the robot and Orchestrator.
        /// &lt;para /&gt;All robots on a machine must have the same license
        /// key in order to register correctly.</param>
        /// <param name="machineName">The name of the machine a Robot is hosted
        /// on.</param>
        /// <param name="machineId">The Id of the machine a Robot is hosted
        /// on</param>
        /// <param name="externalName">Contains the value of the key in the
        /// external store used to store the password.</param>
        /// <param name="description">Used to add additional information about
        /// a robot in order to better identify it.</param>
        /// <param name="provisionType">The Robot provision type. Possible
        /// values include: 'Manual', 'Automatic'</param>
        /// <param name="password">The Windows password associated with the
        /// machine username.</param>
        /// <param name="credentialStoreId">The Credential Store used to store
        /// the password.</param>
        /// <param name="userId">The associated user's Id.</param>
        /// <param name="enabled">Specificies the state of the Robot
        /// (enabled/disabled) - a disabled robot cannot connect to
        /// Orchestrator</param>
        /// <param name="credentialType">The robot credentials type (Default/
        /// SmartCard). Possible values include: 'Default', 'SmartCard',
        /// 'NCipher', 'SafeNet'</param>
        /// <param name="environments">The collection of environments the robot
        /// is part of.</param>
        /// <param name="robotEnvironments">The comma separated textual
        /// representation of environment names the robot is part of.</param>
        /// <param name="executionSettings">A collection of key value pairs
        /// containing execution settings for this robot.</param>
        /// <param name="isExternalLicensed">Flag to indicate if the robot uses
        /// an external license</param>
        /// <param name="limitConcurrentExecution">Specifies if the robot can
        /// be used concurrently on multiple machines</param>
        public RobotWithLicenseDto(string name, string username, RobotDtoType type, RobotDtoHostingType hostingType, RobotLicenseDto license = default(RobotLicenseDto), string licenseKey = default(string), string machineName = default(string), long? machineId = default(long?), string externalName = default(string), string description = default(string), RobotDtoProvisionType? provisionType = default(RobotDtoProvisionType?), string password = default(string), long? credentialStoreId = default(long?), long? userId = default(long?), bool? enabled = default(bool?), RobotDtoCredentialType? credentialType = default(RobotDtoCredentialType?), IList<EnvironmentDto> environments = default(IList<EnvironmentDto>), string robotEnvironments = default(string), IDictionary<string, object> executionSettings = default(IDictionary<string, object>), bool? isExternalLicensed = default(bool?), bool? limitConcurrentExecution = default(bool?), long? id = default(long?))
        {
            License = license;
            LicenseKey = licenseKey;
            MachineName = machineName;
            MachineId = machineId;
            Name = name;
            Username = username;
            ExternalName = externalName;
            Description = description;
            Type = type;
            HostingType = hostingType;
            ProvisionType = provisionType;
            Password = password;
            CredentialStoreId = credentialStoreId;
            UserId = userId;
            Enabled = enabled;
            CredentialType = credentialType;
            Environments = environments;
            RobotEnvironments = robotEnvironments;
            ExecutionSettings = executionSettings;
            IsExternalLicensed = isExternalLicensed;
            LimitConcurrentExecution = limitConcurrentExecution;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "License")]
        public RobotLicenseDto License { get; set; }

        /// <summary>
        /// Gets or sets the key is automatically generated from the server for
        /// the Robot machine.
        /// &amp;lt;para /&amp;gt;For the robot to work, the same key must
        /// exist on both the robot and Orchestrator.
        /// &amp;lt;para /&amp;gt;All robots on a machine must have the same
        /// license key in order to register correctly.
        /// </summary>
        [JsonProperty(PropertyName = "LicenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine a Robot is hosted on.
        /// </summary>
        [JsonProperty(PropertyName = "MachineName")]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or sets the Id of the machine a Robot is hosted on
        /// </summary>
        [JsonProperty(PropertyName = "MachineId")]
        public long? MachineId { get; set; }

        /// <summary>
        /// Gets or sets a custom name for the robot.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the machine username. If the user is under a domain,
        /// you are required to also specify it in a DOMAIN\username format.
        /// &amp;lt;para /&amp;gt;Note: You must use short domain names, such
        /// as desktop\administrator and NOT desktop.local/administrator.
        /// </summary>
        [JsonProperty(PropertyName = "Username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets contains the value of the key in the external store
        /// used to store the password.
        /// </summary>
        [JsonProperty(PropertyName = "ExternalName")]
        public string ExternalName { get; set; }

        /// <summary>
        /// Gets or sets used to add additional information about a robot in
        /// order to better identify it.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Robot type. Possible values include:
        /// 'NonProduction', 'Attended', 'Unattended', 'Studio', 'Development',
        /// 'StudioX', 'Headless', 'StudioPro', 'TestAutomation'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public RobotDtoType Type { get; set; }

        /// <summary>
        /// Gets or sets the Robot hosting type (Standard / Floating). Possible
        /// values include: 'Standard', 'Floating'
        /// </summary>
        [JsonProperty(PropertyName = "HostingType")]
        public RobotDtoHostingType HostingType { get; set; }

        /// <summary>
        /// Gets or sets the Robot provision type. Possible values include:
        /// 'Manual', 'Automatic'
        /// </summary>
        [JsonProperty(PropertyName = "ProvisionType")]
        public RobotDtoProvisionType? ProvisionType { get; set; }

        /// <summary>
        /// Gets or sets the Windows password associated with the machine
        /// username.
        /// </summary>
        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the Credential Store used to store the password.
        /// </summary>
        [JsonProperty(PropertyName = "CredentialStoreId")]
        public long? CredentialStoreId { get; set; }

        /// <summary>
        /// Gets or sets the associated user's Id.
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or sets specificies the state of the Robot (enabled/disabled)
        /// - a disabled robot cannot connect to Orchestrator
        /// </summary>
        [JsonProperty(PropertyName = "Enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the robot credentials type (Default/ SmartCard).
        /// Possible values include: 'Default', 'SmartCard', 'NCipher',
        /// 'SafeNet'
        /// </summary>
        [JsonProperty(PropertyName = "CredentialType")]
        public RobotDtoCredentialType? CredentialType { get; set; }

        /// <summary>
        /// Gets or sets the collection of environments the robot is part of.
        /// </summary>
        [JsonProperty(PropertyName = "Environments")]
        public IList<EnvironmentDto> Environments { get; set; }

        /// <summary>
        /// Gets or sets the comma separated textual representation of
        /// environment names the robot is part of.
        /// </summary>
        [JsonProperty(PropertyName = "RobotEnvironments")]
        public string RobotEnvironments { get; set; }

        /// <summary>
        /// Gets or sets a collection of key value pairs containing execution
        /// settings for this robot.
        /// </summary>
        [JsonProperty(PropertyName = "ExecutionSettings")]
        public IDictionary<string, object> ExecutionSettings { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate if the robot uses an external license
        /// </summary>
        [JsonProperty(PropertyName = "IsExternalLicensed")]
        public bool? IsExternalLicensed { get; set; }

        /// <summary>
        /// Gets or sets specifies if the robot can be used concurrently on
        /// multiple machines
        /// </summary>
        [JsonProperty(PropertyName = "LimitConcurrentExecution")]
        public bool? LimitConcurrentExecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
            if (LicenseKey != null)
            {
                if (LicenseKey.Length > 255)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "LicenseKey", 255);
                }
                if (LicenseKey.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "LicenseKey", 0);
                }
            }
            if (MachineName != null)
            {
                if (MachineName.Length > 450)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "MachineName", 450);
                }
                if (MachineName.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "MachineName", 0);
                }
            }
            if (Name != null)
            {
                if (Name.Length > 19)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 19);
                }
                if (Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
            }
            if (Username != null)
            {
                if (Username.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Username", 100);
                }
                if (Username.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Username", 0);
                }
            }
            if (ExternalName != null)
            {
                if (ExternalName.Length > 450)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ExternalName", 450);
                }
                if (ExternalName.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ExternalName", 0);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 500)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 500);
                }
                if (Description.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Description", 0);
                }
            }
            if (Password != null)
            {
                if (Password.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Password", 100);
                }
                if (Password.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Password", 0);
                }
            }
            if (Environments != null)
            {
                foreach (var element in Environments)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
