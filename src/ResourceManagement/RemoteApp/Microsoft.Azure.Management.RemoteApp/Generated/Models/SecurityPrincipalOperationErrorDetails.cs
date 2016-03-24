// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Operational results of adding or removing a security principal.
    /// </summary>
    public partial class SecurityPrincipalOperationErrorDetails : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SecurityPrincipalOperationErrorDetails class.
        /// </summary>
        public SecurityPrincipalOperationErrorDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SecurityPrincipalOperationErrorDetails class.
        /// </summary>
        public SecurityPrincipalOperationErrorDetails(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string nextLink = default(string), string securityPrincipal = default(string), SecurityPrincipalOperationError? error = default(SecurityPrincipalOperationError?), string errorDetails = default(string))
            : base(location, id, name, type, tags)
        {
            Etag = etag;
            NextLink = nextLink;
            SecurityPrincipal = securityPrincipal;
            Error = error;
            ErrorDetails = errorDetails;
        }

        /// <summary>
        /// The etag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// The URL for requesting next page of resources.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// The security principal name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityPrincipal")]
        public string SecurityPrincipal { get; set; }

        /// <summary>
        /// The security principal operation result error code, if any.
        /// Possible values for this property include: 'CouldNotBeResolved',
        /// 'NotFound', 'AlreadyExists', 'NotSupported', 'NotDirsynced',
        /// 'AssignedToAnotherCollection'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.error")]
        public SecurityPrincipalOperationError? Error { get; set; }

        /// <summary>
        /// Additional details about the error code, if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorDetails")]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
