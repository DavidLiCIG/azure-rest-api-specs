// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace foo.bar.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Face Attributes
    /// </summary>
    public partial class FaceAttributes
    {
        /// <summary>
        /// Initializes a new instance of the FaceAttributes class.
        /// </summary>
        public FaceAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FaceAttributes class.
        /// </summary>
        /// <param name="age">Age in years</param>
        /// <param name="gender">Possible gender of the face. Possible values
        /// include: 'male', 'female'</param>
        /// <param name="smile">Smile intensity, a number between [0,1]
        /// </param>
        /// <param name="facialHair">Properties describing facial hair
        /// attributes.</param>
        /// <param name="glasses">Glasses type if any of the face. Possible
        /// values include: 'noGlasses', 'readingGlasses', 'sunglasses',
        /// 'swimmingGoggles'</param>
        /// <param name="headPose">Properties indicating head pose of the
        /// face.</param>
        /// <param name="emotion">Properties describing facial emotion in form
        /// of confidence ranging from 0 to 1.</param>
        /// <param name="hair">Properties describing hair attributes.</param>
        /// <param name="makeup">Properties describing present makeups on a
        /// given face.</param>
        /// <param name="occlusion">Properties describing occlusions on a given
        /// face.</param>
        /// <param name="accessories">Properties describing any accessories on
        /// a given face.</param>
        /// <param name="blur">Properties describing any presence of blur
        /// within the image.</param>
        /// <param name="exposure">Properties describing exposure level of the
        /// image.</param>
        /// <param name="noise">Properties describing noise level of the
        /// image.</param>
        public FaceAttributes(double? age = default(double?), Gender? gender = default(Gender?), double? smile = default(double?), FacialHair facialHair = default(FacialHair), GlassesType? glasses = default(GlassesType?), HeadPose headPose = default(HeadPose), Emotion emotion = default(Emotion), Hair hair = default(Hair), Makeup makeup = default(Makeup), Occlusion occlusion = default(Occlusion), IList<Accessory> accessories = default(IList<Accessory>), Blur blur = default(Blur), Exposure exposure = default(Exposure), Noise noise = default(Noise))
        {
            Age = age;
            Gender = gender;
            Smile = smile;
            FacialHair = facialHair;
            Glasses = glasses;
            HeadPose = headPose;
            Emotion = emotion;
            Hair = hair;
            Makeup = makeup;
            Occlusion = occlusion;
            Accessories = accessories;
            Blur = blur;
            Exposure = exposure;
            Noise = noise;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets age in years
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public double? Age { get; set; }

        /// <summary>
        /// Gets or sets possible gender of the face. Possible values include:
        /// 'male', 'female'
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public Gender? Gender { get; set; }

        /// <summary>
        /// Gets or sets smile intensity, a number between [0,1]
        /// </summary>
        [JsonProperty(PropertyName = "smile")]
        public double? Smile { get; set; }

        /// <summary>
        /// Gets or sets properties describing facial hair attributes.
        /// </summary>
        [JsonProperty(PropertyName = "facialHair")]
        public FacialHair FacialHair { get; set; }

        /// <summary>
        /// Gets or sets glasses type if any of the face. Possible values
        /// include: 'noGlasses', 'readingGlasses', 'sunglasses',
        /// 'swimmingGoggles'
        /// </summary>
        [JsonProperty(PropertyName = "glasses")]
        public GlassesType? Glasses { get; set; }

        /// <summary>
        /// Gets or sets properties indicating head pose of the face.
        /// </summary>
        [JsonProperty(PropertyName = "headPose")]
        public HeadPose HeadPose { get; set; }

        /// <summary>
        /// Gets or sets properties describing facial emotion in form of
        /// confidence ranging from 0 to 1.
        /// </summary>
        [JsonProperty(PropertyName = "emotion")]
        public Emotion Emotion { get; set; }

        /// <summary>
        /// Gets or sets properties describing hair attributes.
        /// </summary>
        [JsonProperty(PropertyName = "hair")]
        public Hair Hair { get; set; }

        /// <summary>
        /// Gets or sets properties describing present makeups on a given face.
        /// </summary>
        [JsonProperty(PropertyName = "makeup")]
        public Makeup Makeup { get; set; }

        /// <summary>
        /// Gets or sets properties describing occlusions on a given face.
        /// </summary>
        [JsonProperty(PropertyName = "occlusion")]
        public Occlusion Occlusion { get; set; }

        /// <summary>
        /// Gets or sets properties describing any accessories on a given face.
        /// </summary>
        [JsonProperty(PropertyName = "accessories")]
        public IList<Accessory> Accessories { get; set; }

        /// <summary>
        /// Gets or sets properties describing any presence of blur within the
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "blur")]
        public Blur Blur { get; set; }

        /// <summary>
        /// Gets or sets properties describing exposure level of the image.
        /// </summary>
        [JsonProperty(PropertyName = "exposure")]
        public Exposure Exposure { get; set; }

        /// <summary>
        /// Gets or sets properties describing noise level of the image.
        /// </summary>
        [JsonProperty(PropertyName = "noise")]
        public Noise Noise { get; set; }

    }
}
