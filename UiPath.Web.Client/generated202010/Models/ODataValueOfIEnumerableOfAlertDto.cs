// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataValueOfIEnumerableOfAlertDto
    {
        /// <summary>
        /// Initializes a new instance of the ODataValueOfIEnumerableOfAlertDto
        /// class.
        /// </summary>
        public ODataValueOfIEnumerableOfAlertDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataValueOfIEnumerableOfAlertDto
        /// class.
        /// </summary>
        public ODataValueOfIEnumerableOfAlertDto(IList<AlertDto> value = default(IList<AlertDto>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AlertDto> Value { get; set; }

    }
}
