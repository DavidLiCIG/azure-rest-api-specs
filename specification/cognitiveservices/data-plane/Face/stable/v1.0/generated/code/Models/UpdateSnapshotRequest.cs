// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace foo.bar.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request body for updating a snapshot, with a combination of user
    /// defined apply scope and user specified data.
    /// </summary>
    public partial class UpdateSnapshotRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSnapshotRequest class.
        /// </summary>
        public UpdateSnapshotRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateSnapshotRequest class.
        /// </summary>
        /// <param name="applyScope">Array of the target Face subscription ids
        /// for the snapshot, specified by the user who created the snapshot
        /// when calling Snapshot - Take. For each snapshot, only subscriptions
        /// included in the applyScope of Snapshot - Take can apply it.</param>
        /// <param name="userData">User specified data about the snapshot for
        /// any purpose. Length should not exceed 16KB.</param>
        public UpdateSnapshotRequest(IList<System.Guid> applyScope = default(IList<System.Guid>), string userData = default(string))
        {
            ApplyScope = applyScope;
            UserData = userData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of the target Face subscription ids for the
        /// snapshot, specified by the user who created the snapshot when
        /// calling Snapshot - Take. For each snapshot, only subscriptions
        /// included in the applyScope of Snapshot - Take can apply it.
        /// </summary>
        [JsonProperty(PropertyName = "applyScope")]
        public IList<System.Guid> ApplyScope { get; set; }

        /// <summary>
        /// Gets or sets user specified data about the snapshot for any
        /// purpose. Length should not exceed 16KB.
        /// </summary>
        [JsonProperty(PropertyName = "userData")]
        public string UserData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserData != null)
            {
                if (UserData.Length > 16384)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserData", 16384);
                }
            }
        }
    }
}
