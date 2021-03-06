// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Encryption keys information
    /// </summary>
    public partial class TenantKeys
    {
        /// <summary>
        /// Initializes a new instance of the TenantKeys class.
        /// </summary>
        public TenantKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantKeys class.
        /// </summary>
        /// <param name="value">Encryption keys</param>
        public TenantKeys(string odatacontext = default(string), IList<TenantKey> value = default(IList<TenantKey>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets encryption keys
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<TenantKey> Value { get; set; }

    }
}
