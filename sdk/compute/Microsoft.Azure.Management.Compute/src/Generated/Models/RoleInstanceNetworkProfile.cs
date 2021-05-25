// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the network profile for the role instance.
    /// </summary>
    public partial class RoleInstanceNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the RoleInstanceNetworkProfile class.
        /// </summary>
        public RoleInstanceNetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleInstanceNetworkProfile class.
        /// </summary>
        /// <param name="networkInterfaces">Specifies the list of resource Ids
        /// for the network interfaces associated with the role
        /// instance.</param>
        public RoleInstanceNetworkProfile(IList<SubResource> networkInterfaces = default(IList<SubResource>))
        {
            NetworkInterfaces = networkInterfaces;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets specifies the list of resource Ids for the network interfaces
        /// associated with the role instance.
        /// </summary>
        [JsonProperty(PropertyName = "networkInterfaces")]
        public IList<SubResource> NetworkInterfaces { get; private set; }

    }
}
