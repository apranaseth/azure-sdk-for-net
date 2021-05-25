// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LogStorageSettingsConverter))]
    public partial class LogStorageSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteObjectValue(Path);
            }
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel");
                writer.WriteObjectValue(LogLevel);
            }
            if (Optional.IsDefined(EnableReliableLogging))
            {
                writer.WritePropertyName("enableReliableLogging");
                writer.WriteObjectValue(EnableReliableLogging);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static LogStorageSettings DeserializeLogStorageSettings(JsonElement element)
        {
            LinkedServiceReference linkedServiceName = default;
            Optional<object> path = default;
            Optional<object> logLevel = default;
            Optional<object> enableReliableLogging = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    path = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("logLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logLevel = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enableReliableLogging"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableReliableLogging = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new LogStorageSettings(linkedServiceName, path.Value, logLevel.Value, enableReliableLogging.Value, additionalProperties);
        }

        internal partial class LogStorageSettingsConverter : JsonConverter<LogStorageSettings>
        {
            public override void Write(Utf8JsonWriter writer, LogStorageSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LogStorageSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLogStorageSettings(document.RootElement);
            }
        }
    }
}
