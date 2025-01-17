// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The observed status of the agent pool. </summary>
    public partial class AgentPoolProvisioningStatus
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningStatus"/>. </summary>
        public AgentPoolProvisioningStatus()
        {
            ReadyReplicas = new ChangeTrackingList<AgentPoolUpdateProfile>();
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningStatus"/>. </summary>
        /// <param name="currentState"> The current state of the agent pool. </param>
        /// <param name="errorMessage"> Error messages during an agent pool operation or steady state. </param>
        /// <param name="readyReplicas"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolProvisioningStatus(HybridContainerServiceResourceProvisioningState? currentState, string errorMessage, IList<AgentPoolUpdateProfile> readyReplicas, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CurrentState = currentState;
            ErrorMessage = errorMessage;
            ReadyReplicas = readyReplicas;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The current state of the agent pool. </summary>
        public HybridContainerServiceResourceProvisioningState? CurrentState { get; }
        /// <summary> Error messages during an agent pool operation or steady state. </summary>
        public string ErrorMessage { get; set; }
        /// <summary> Gets the ready replicas. </summary>
        public IList<AgentPoolUpdateProfile> ReadyReplicas { get; }
    }
}
