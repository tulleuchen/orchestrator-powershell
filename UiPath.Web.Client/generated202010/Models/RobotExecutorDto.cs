// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores information about a robot on which a process will be executed.
    /// </summary>
    public partial class RobotExecutorDto
    {
        /// <summary>
        /// Initializes a new instance of the RobotExecutorDto class.
        /// </summary>
        public RobotExecutorDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotExecutorDto class.
        /// </summary>
        /// <param name="machineName">The name of the machine on which the
        /// robot runs the job.</param>
        /// <param name="name">The name of the robot that runs the job.</param>
        /// <param name="description">The description of the robot that runs
        /// the job.</param>
        public RobotExecutorDto(string machineName = default(string), string name = default(string), string description = default(string), long? id = default(long?))
        {
            MachineName = machineName;
            Name = name;
            Description = description;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the machine on which the robot runs the
        /// job.
        /// </summary>
        [JsonProperty(PropertyName = "MachineName")]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or sets the name of the robot that runs the job.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the robot that runs the job.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
