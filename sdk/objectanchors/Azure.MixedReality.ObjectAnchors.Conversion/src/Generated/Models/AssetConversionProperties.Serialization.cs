// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.MixedReality.ObjectAnchors.Conversion.Models;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    public partial class AssetConversionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConversionStatus))
            {
                writer.WritePropertyName("jobStatus");
                writer.WriteStringValue(ConversionStatus.Value.ToSerialString());
            }
            if (Optional.IsDefined(AssetFileTypeString))
            {
                writer.WritePropertyName("assetFileType");
                writer.WriteStringValue(AssetFileTypeString);
            }
            if (Optional.IsDefined(InputAssetUriString))
            {
                writer.WritePropertyName("inputAssetUri");
                writer.WriteStringValue(InputAssetUriString);
            }
            if (Optional.IsDefined(ConversionConfiguration))
            {
                writer.WritePropertyName("ingestionConfiguration");
                writer.WriteObjectValue(ConversionConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static AssetConversionProperties DeserializeAssetConversionProperties(JsonElement element)
        {
            Optional<string> clientErrorDetails = default;
            Optional<string> serverErrorDetails = default;
            Optional<ConversionErrorCode> errorCode = default;
            Optional<Guid> jobId = default;
            Optional<string> outputModelUri = default;
            Optional<AssetConversionStatus> jobStatus = default;
            Optional<string> assetFileType = default;
            Optional<string> inputAssetUri = default;
            Optional<Guid> accountId = default;
            Optional<AssetConversionConfiguration> ingestionConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientErrorDetails"))
                {
                    clientErrorDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverErrorDetails"))
                {
                    serverErrorDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    errorCode = new ConversionErrorCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("outputModelUri"))
                {
                    outputModelUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobStatus = property.Value.GetString().ToAssetConversionStatus();
                    continue;
                }
                if (property.NameEquals("assetFileType"))
                {
                    assetFileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputAssetUri"))
                {
                    inputAssetUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accountId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("ingestionConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ingestionConfiguration = AssetConversionConfiguration.DeserializeAssetConversionConfiguration(property.Value);
                    continue;
                }
            }
            return new AssetConversionProperties(clientErrorDetails.Value, serverErrorDetails.Value, errorCode, Optional.ToNullable(jobId), outputModelUri.Value, Optional.ToNullable(jobStatus), assetFileType.Value, inputAssetUri.Value, Optional.ToNullable(accountId), ingestionConfiguration.Value);
        }
    }
}
