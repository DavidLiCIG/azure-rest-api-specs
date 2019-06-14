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
    /// Snapshot object.
    /// </summary>
    public partial class Snapshot
    {
        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        public Snapshot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        /// <param name="id">Snapshot id.</param>
        /// <param name="account">Azure Cognitive Service Face account id of
        /// the subscriber who created the snapshot by Snapshot - Take.</param>
        /// <param name="type">Type of the source object in the snapshot,
        /// specified by the subscriber who created the snapshot when calling
        /// Snapshot - Take. Currently FaceList, PersonGroup, LargeFaceList and
        /// LargePersonGroup are supported. Possible values include:
        /// 'FaceList', 'LargeFaceList', 'LargePersonGroup',
        /// 'PersonGroup'</param>
        /// <param name="applyScope">Array of the target Face subscription ids
        /// for the snapshot, specified by the user who created the snapshot
        /// when calling Snapshot - Take. For each snapshot, only subscriptions
        /// included in the applyScope of Snapshot - Take can apply it.</param>
        /// <param name="createdTime">A combined UTC date and time string that
        /// describes the created time of the snapshot. E.g.
        /// 2018-12-25T11:41:02.2331413Z.</param>
        /// <param name="lastUpdateTime">A combined UTC date and time string
        /// that describes the last time when the snapshot was created or
        /// updated by Snapshot - Update. E.g.
        /// 2018-12-25T11:51:27.8705696Z.</param>
        /// <param name="userData">User specified data about the snapshot for
        /// any purpose. Length should not exceed 16KB.</param>
        public Snapshot(System.Guid id, string account, SnapshotObjectType type, IList<System.Guid> applyScope, System.DateTime createdTime, System.DateTime lastUpdateTime, string userData = default(string))
        {
            Id = id;
            Account = account;
            Type = type;
            ApplyScope = applyScope;
            UserData = userData;
            CreatedTime = createdTime;
            LastUpdateTime = lastUpdateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets snapshot id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets azure Cognitive Service Face account id of the
        /// subscriber who created the snapshot by Snapshot - Take.
        /// </summary>
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets type of the source object in the snapshot, specified
        /// by the subscriber who created the snapshot when calling Snapshot -
        /// Take. Currently FaceList, PersonGroup, LargeFaceList and
        /// LargePersonGroup are supported. Possible values include:
        /// 'FaceList', 'LargeFaceList', 'LargePersonGroup', 'PersonGroup'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SnapshotObjectType Type { get; set; }

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
        /// Gets or sets a combined UTC date and time string that describes the
        /// created time of the snapshot. E.g. 2018-12-25T11:41:02.2331413Z.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets a combined UTC date and time string that describes the
        /// last time when the snapshot was created or updated by Snapshot -
        /// Update. E.g. 2018-12-25T11:51:27.8705696Z.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Account == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Account");
            }
            if (ApplyScope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApplyScope");
            }
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
