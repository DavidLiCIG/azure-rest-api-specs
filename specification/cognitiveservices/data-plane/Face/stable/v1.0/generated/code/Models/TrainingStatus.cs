// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace foo.bar.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Training status object.
    /// </summary>
    public partial class TrainingStatus
    {
        /// <summary>
        /// Initializes a new instance of the TrainingStatus class.
        /// </summary>
        public TrainingStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrainingStatus class.
        /// </summary>
        /// <param name="status">Training status: notstarted, running,
        /// succeeded, failed. If the training process is waiting to perform,
        /// the status is notstarted. If the training is ongoing, the status is
        /// running. Status succeed means this person group or large person
        /// group is ready for Face - Identify, or this large face list is
        /// ready for Face - Find Similar. Status failed is often caused by no
        /// person or no persisted face exist in the person group or large
        /// person group, or no persisted face exist in the large face list.
        /// Possible values include: 'nonstarted', 'running', 'succeeded',
        /// 'failed'</param>
        /// <param name="created">A combined UTC date and time string that
        /// describes the created time of the person group, large person group
        /// or large face list.</param>
        /// <param name="lastAction">A combined UTC date and time string that
        /// describes the last modify time of the person group, large person
        /// group or large face list, could be null value when the group is not
        /// successfully trained.</param>
        /// <param name="lastSuccessfulTraining">A combined UTC date and time
        /// string that describes the last successful training time of the
        /// person group, large person group or large face list.</param>
        /// <param name="message">Show failure message when training failed
        /// (omitted when training succeed).</param>
        public TrainingStatus(TrainingStatusType status, System.DateTime created, System.DateTime? lastAction = default(System.DateTime?), System.DateTime? lastSuccessfulTraining = default(System.DateTime?), string message = default(string))
        {
            Status = status;
            Created = created;
            LastAction = lastAction;
            LastSuccessfulTraining = lastSuccessfulTraining;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets training status: notstarted, running, succeeded,
        /// failed. If the training process is waiting to perform, the status
        /// is notstarted. If the training is ongoing, the status is running.
        /// Status succeed means this person group or large person group is
        /// ready for Face - Identify, or this large face list is ready for
        /// Face - Find Similar. Status failed is often caused by no person or
        /// no persisted face exist in the person group or large person group,
        /// or no persisted face exist in the large face list. Possible values
        /// include: 'nonstarted', 'running', 'succeeded', 'failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public TrainingStatusType Status { get; set; }

        /// <summary>
        /// Gets or sets a combined UTC date and time string that describes the
        /// created time of the person group, large person group or large face
        /// list.
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets a combined UTC date and time string that describes the
        /// last modify time of the person group, large person group or large
        /// face list, could be null value when the group is not successfully
        /// trained.
        /// </summary>
        [JsonProperty(PropertyName = "lastActionDateTime")]
        public System.DateTime? LastAction { get; set; }

        /// <summary>
        /// Gets or sets a combined UTC date and time string that describes the
        /// last successful training time of the person group, large person
        /// group or large face list.
        /// </summary>
        [JsonProperty(PropertyName = "lastSuccessfulTrainingDateTime")]
        public System.DateTime? LastSuccessfulTraining { get; set; }

        /// <summary>
        /// Gets or sets show failure message when training failed (omitted
        /// when training succeed).
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
