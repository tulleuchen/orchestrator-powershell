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

    public partial class FolderDto
    {
        /// <summary>
        /// Initializes a new instance of the FolderDto class.
        /// </summary>
        public FolderDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FolderDto class.
        /// </summary>
        /// <param name="displayName">Display name for the folder.</param>
        /// <param name="key">Unique key for the folder</param>
        /// <param name="fullyQualifiedName">Name of folder prepended by the
        /// names of its ancestors.</param>
        /// <param name="description">Description of folder</param>
        /// <param name="isPersonal">True if Personal</param>
        /// <param name="provisionType">Robot provisioning type. Possible
        /// values include: 'Manual', 'Automatic'</param>
        /// <param name="permissionModel">Folder permissions model. Possible
        /// values include: 'InheritFromTenant', 'FineGrained'</param>
        /// <param name="parentId">Id of parent folder in the folders
        /// hierarchy</param>
        /// <param name="parentKey">Unique key for the parent folder</param>
        /// <param name="feedType">Folder feed type. Possible values include:
        /// 'Undefined', 'Processes', 'Libraries', 'PersonalWorkspace',
        /// 'FolderHierarchy'</param>
        public FolderDto(string displayName, System.Guid? key = default(System.Guid?), string fullyQualifiedName = default(string), string description = default(string), bool? isPersonal = default(bool?), FolderDtoProvisionType? provisionType = default(FolderDtoProvisionType?), FolderDtoPermissionModel? permissionModel = default(FolderDtoPermissionModel?), long? parentId = default(long?), System.Guid? parentKey = default(System.Guid?), FolderDtoFeedType? feedType = default(FolderDtoFeedType?), long? id = default(long?))
        {
            Key = key;
            DisplayName = displayName;
            FullyQualifiedName = fullyQualifiedName;
            Description = description;
            IsPersonal = isPersonal;
            ProvisionType = provisionType;
            PermissionModel = permissionModel;
            ParentId = parentId;
            ParentKey = parentKey;
            FeedType = feedType;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique key for the folder
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public System.Guid? Key { get; set; }

        /// <summary>
        /// Gets or sets display name for the folder.
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets name of folder prepended by the names of its
        /// ancestors.
        /// </summary>
        [JsonProperty(PropertyName = "FullyQualifiedName")]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// Gets or sets description of folder
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets true if Personal
        /// </summary>
        [JsonProperty(PropertyName = "IsPersonal")]
        public bool? IsPersonal { get; private set; }

        /// <summary>
        /// Gets or sets robot provisioning type. Possible values include:
        /// 'Manual', 'Automatic'
        /// </summary>
        [JsonProperty(PropertyName = "ProvisionType")]
        public FolderDtoProvisionType? ProvisionType { get; set; }

        /// <summary>
        /// Gets or sets folder permissions model. Possible values include:
        /// 'InheritFromTenant', 'FineGrained'
        /// </summary>
        [JsonProperty(PropertyName = "PermissionModel")]
        public FolderDtoPermissionModel? PermissionModel { get; set; }

        /// <summary>
        /// Gets or sets id of parent folder in the folders hierarchy
        /// </summary>
        [JsonProperty(PropertyName = "ParentId")]
        public long? ParentId { get; set; }

        /// <summary>
        /// Gets or sets unique key for the parent folder
        /// </summary>
        [JsonProperty(PropertyName = "ParentKey")]
        public System.Guid? ParentKey { get; set; }

        /// <summary>
        /// Gets or sets folder feed type. Possible values include:
        /// 'Undefined', 'Processes', 'Libraries', 'PersonalWorkspace',
        /// 'FolderHierarchy'
        /// </summary>
        [JsonProperty(PropertyName = "FeedType")]
        public FolderDtoFeedType? FeedType { get; set; }

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
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 115)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 115);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 500)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 500);
                }
            }
        }
    }
}
