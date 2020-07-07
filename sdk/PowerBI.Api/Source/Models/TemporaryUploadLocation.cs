// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI update report content request
    /// </summary>
    public partial class TemporaryUploadLocation
    {
        /// <summary>
        /// Initializes a new instance of the TemporaryUploadLocation class.
        /// </summary>
        public TemporaryUploadLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemporaryUploadLocation class.
        /// </summary>
        /// <param name="url">The shared access signature (SAS) url for the
        /// temporary blob storage</param>
        /// <param name="expirationTime">The expiration time of the shared
        /// access signature (SAS) url</param>
        public TemporaryUploadLocation(string url, System.DateTime expirationTime)
        {
            Url = url;
            ExpirationTime = expirationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the shared access signature (SAS) url for the
        /// temporary blob storage
        /// </summary>
        [JsonProperty(PropertyName = "Url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the expiration time of the shared access signature
        /// (SAS) url
        /// </summary>
        [JsonProperty(PropertyName = "ExpirationTime")]
        public System.DateTime ExpirationTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}