// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SimpleRoleDto
    {
        /// <summary>
        /// Initializes a new instance of the SimpleRoleDto class.
        /// </summary>
        public SimpleRoleDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleRoleDto class.
        /// </summary>
        /// <param name="origin">Possible values include: 'Assigned',
        /// 'Inherited'</param>
        public SimpleRoleDto(SimpleRoleDtoOrigin? origin = default(SimpleRoleDtoOrigin?), SimpleFolderDto inheritedFromFolder = default(SimpleFolderDto), string name = default(string), int? id = default(int?))
        {
            Origin = origin;
            InheritedFromFolder = inheritedFromFolder;
            Name = name;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Assigned', 'Inherited'
        /// </summary>
        [JsonProperty(PropertyName = "Origin")]
        public SimpleRoleDtoOrigin? Origin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InheritedFromFolder")]
        public SimpleFolderDto InheritedFromFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

    }
}
