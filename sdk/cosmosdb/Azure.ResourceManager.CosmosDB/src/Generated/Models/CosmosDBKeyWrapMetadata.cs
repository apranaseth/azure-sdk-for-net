// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Represents key wrap metadata that a key wrapping provider can use to wrap/unwrap a client encryption key. </summary>
    public partial class CosmosDBKeyWrapMetadata
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

        /// <summary> Initializes a new instance of <see cref="CosmosDBKeyWrapMetadata"/>. </summary>
        public CosmosDBKeyWrapMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBKeyWrapMetadata"/>. </summary>
        /// <param name="name"> The name of associated KeyEncryptionKey (aka CustomerManagedKey). </param>
        /// <param name="cosmosDBKeyWrapMetadataType"> ProviderName of KeyStoreProvider. </param>
        /// <param name="value"> Reference / link to the KeyEncryptionKey. </param>
        /// <param name="algorithm"> Algorithm used in wrapping and unwrapping of the data encryption key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBKeyWrapMetadata(string name, string cosmosDBKeyWrapMetadataType, string value, string algorithm, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            CosmosDBKeyWrapMetadataType = cosmosDBKeyWrapMetadataType;
            Value = value;
            Algorithm = algorithm;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of associated KeyEncryptionKey (aka CustomerManagedKey). </summary>
        public string Name { get; set; }
        /// <summary> ProviderName of KeyStoreProvider. </summary>
        public string CosmosDBKeyWrapMetadataType { get; set; }
        /// <summary> Reference / link to the KeyEncryptionKey. </summary>
        public string Value { get; set; }
        /// <summary> Algorithm used in wrapping and unwrapping of the data encryption key. </summary>
        public string Algorithm { get; set; }
    }
}
