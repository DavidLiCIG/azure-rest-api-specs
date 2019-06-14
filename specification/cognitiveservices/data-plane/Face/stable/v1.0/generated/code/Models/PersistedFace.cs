// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace foo.bar.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// PersonFace object.
    /// </summary>
    public partial class PersistedFace
    {
        /// <summary>
        /// Initializes a new instance of the PersistedFace class.
        /// </summary>
        public PersistedFace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PersistedFace class.
        /// </summary>
        /// <param name="persistedFaceId">The persistedFaceId of the target
        /// face, which is persisted and will not expire. Different from faceId
        /// created by Face - Detect and will expire in 24 hours after the
        /// detection call.</param>
        /// <param name="userData">User-provided data attached to the face. The
        /// size limit is 1KB.</param>
        public PersistedFace(System.Guid persistedFaceId, string userData = default(string))
        {
            PersistedFaceId = persistedFaceId;
            UserData = userData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the persistedFaceId of the target face, which is
        /// persisted and will not expire. Different from faceId created by
        /// Face - Detect and will expire in 24 hours after the detection call.
        /// </summary>
        [JsonProperty(PropertyName = "persistedFaceId")]
        public System.Guid PersistedFaceId { get; set; }

        /// <summary>
        /// Gets or sets user-provided data attached to the face. The size
        /// limit is 1KB.
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
                if (UserData.Length > 1024)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserData", 1024);
                }
            }
        }
    }
}
