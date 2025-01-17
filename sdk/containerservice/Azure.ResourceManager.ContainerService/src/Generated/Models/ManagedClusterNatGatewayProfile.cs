// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Profile of the managed cluster NAT gateway. </summary>
    public partial class ManagedClusterNatGatewayProfile
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterNatGatewayProfile"/>. </summary>
        public ManagedClusterNatGatewayProfile()
        {
            EffectiveOutboundIPs = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterNatGatewayProfile"/>. </summary>
        /// <param name="managedOutboundIPProfile"> Profile of the managed outbound IP resources of the cluster NAT gateway. </param>
        /// <param name="effectiveOutboundIPs"> The effective outbound IP resources of the cluster NAT gateway. </param>
        /// <param name="idleTimeoutInMinutes"> Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120 (inclusive). The default value is 4 minutes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterNatGatewayProfile(ManagedClusterManagedOutboundIPProfile managedOutboundIPProfile, IList<WritableSubResource> effectiveOutboundIPs, int? idleTimeoutInMinutes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ManagedOutboundIPProfile = managedOutboundIPProfile;
            EffectiveOutboundIPs = effectiveOutboundIPs;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Profile of the managed outbound IP resources of the cluster NAT gateway. </summary>
        internal ManagedClusterManagedOutboundIPProfile ManagedOutboundIPProfile { get; set; }
        /// <summary> The desired number of outbound IPs created/managed by Azure. Allowed values must be in the range of 1 to 16 (inclusive). The default value is 1. </summary>
        public int? ManagedOutboundIPCount
        {
            get => ManagedOutboundIPProfile is null ? default : ManagedOutboundIPProfile.Count;
            set
            {
                if (ManagedOutboundIPProfile is null)
                    ManagedOutboundIPProfile = new ManagedClusterManagedOutboundIPProfile();
                ManagedOutboundIPProfile.Count = value;
            }
        }

        /// <summary> The effective outbound IP resources of the cluster NAT gateway. </summary>
        public IList<WritableSubResource> EffectiveOutboundIPs { get; }
        /// <summary> Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120 (inclusive). The default value is 4 minutes. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
    }
}
