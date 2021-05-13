// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for feature object
    /// </summary>
    [Newtonsoft.Json.JsonObject("FeatureValidationRequest")]
    public partial class FeatureValidationRequest : FeatureValidationRequestBase
    {
        /// <summary>
        /// Initializes a new instance of the FeatureValidationRequest class.
        /// </summary>
        public FeatureValidationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FeatureValidationRequest class.
        /// </summary>
        /// <param name="featureType">backup support feature type. Possible
        /// values include: 'Invalid', 'DataSourceType'</param>
        /// <param name="featureName">backup support feature name.</param>
        public FeatureValidationRequest(string featureType = default(string), string featureName = default(string))
        {
            FeatureType = featureType;
            FeatureName = featureName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup support feature type. Possible values include:
        /// 'Invalid', 'DataSourceType'
        /// </summary>
        [JsonProperty(PropertyName = "featureType")]
        public string FeatureType { get; set; }

        /// <summary>
        /// Gets or sets backup support feature name.
        /// </summary>
        [JsonProperty(PropertyName = "featureName")]
        public string FeatureName { get; set; }

    }
}
