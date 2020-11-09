// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BucketDto
    {
        /// <summary>
        /// Initializes a new instance of the BucketDto class.
        /// </summary>
        public BucketDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BucketDto class.
        /// </summary>
        /// <param name="name">Display name of the Bucket</param>
        /// <param name="identifier">A stable unique identifier</param>
        /// <param name="description">Description of the Bucket</param>
        /// <param name="storageProvider">Provider Name.
        /// Otherwise one of the supported providers:
        /// - FileSystem
        /// - Azure
        /// - Amazon
        /// - Minio
        /// Leave null for built-in Orchestrator host provider.</param>
        /// <param name="storageParameters">Provider specific initalization
        /// parameters.
        /// Use a $Password for where the password should be inserted.
        /// Leave null for built-in Orchestrator host provider.</param>
        /// <param name="storageContainer">Provider specific Container name
        /// (AWS, WASB).
        /// Leave null for built-in Orchestrator host provider.</param>
        /// <param name="options">Bucket options. Possible values include:
        /// 'None', 'ReadOnly', 'AuditReadAccess'</param>
        /// <param name="credentialStoreId">Credential store used to keep the
        /// provider access password.
        /// Leave null for built-in Orchestrator host provider.</param>
        /// <param name="password">Provider specific password/secret.
        /// It is inserted as a replacemnt of the $PAssword token in the
        /// StorageParameters.
        /// Leave null for built-in Orchestrator host provider.</param>
        public BucketDto(string name, System.Guid identifier, string description = default(string), string storageProvider = default(string), string storageParameters = default(string), string storageContainer = default(string), BucketDtoOptions? options = default(BucketDtoOptions?), long? credentialStoreId = default(long?), string password = default(string), long? id = default(long?))
        {
            Name = name;
            Description = description;
            Identifier = identifier;
            StorageProvider = storageProvider;
            StorageParameters = storageParameters;
            StorageContainer = storageContainer;
            Options = options;
            CredentialStoreId = credentialStoreId;
            Password = password;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of the Bucket
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the Bucket
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a stable unique identifier
        /// </summary>
        [JsonProperty(PropertyName = "Identifier")]
        public System.Guid Identifier { get; set; }

        /// <summary>
        /// Gets or sets provider Name.
        /// Otherwise one of the supported providers:
        /// - FileSystem
        /// - Azure
        /// - Amazon
        /// - Minio
        /// Leave null for built-in Orchestrator host provider.
        /// </summary>
        [JsonProperty(PropertyName = "StorageProvider")]
        public string StorageProvider { get; set; }

        /// <summary>
        /// Gets or sets provider specific initalization parameters.
        /// Use a $Password for where the password should be inserted.
        /// Leave null for built-in Orchestrator host provider.
        /// </summary>
        [JsonProperty(PropertyName = "StorageParameters")]
        public string StorageParameters { get; set; }

        /// <summary>
        /// Gets or sets provider specific Container name (AWS, WASB).
        /// Leave null for built-in Orchestrator host provider.
        /// </summary>
        [JsonProperty(PropertyName = "StorageContainer")]
        public string StorageContainer { get; set; }

        /// <summary>
        /// Gets or sets bucket options. Possible values include: 'None',
        /// 'ReadOnly', 'AuditReadAccess'
        /// </summary>
        [JsonProperty(PropertyName = "Options")]
        public BucketDtoOptions? Options { get; set; }

        /// <summary>
        /// Gets or sets credential store used to keep the provider access
        /// password.
        /// Leave null for built-in Orchestrator host provider.
        /// </summary>
        [JsonProperty(PropertyName = "CredentialStoreId")]
        public long? CredentialStoreId { get; set; }

        /// <summary>
        /// Gets or sets provider specific password/secret.
        /// It is inserted as a replacemnt of the $PAssword token in the
        /// StorageParameters.
        /// Leave null for built-in Orchestrator host provider.
        /// </summary>
        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }

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
            if (Name != null)
            {
                if (Name.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 128);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 512)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 512);
                }
            }
        }
    }
}
