// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(RedisPatchingCompletedEventDataConverter))]
    public partial class RedisPatchingCompletedEventData
    {
        internal static RedisPatchingCompletedEventData DeserializeRedisPatchingCompletedEventData(JsonElement element)
        {
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> name = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new RedisPatchingCompletedEventData(Optional.ToNullable(timestamp), name.Value, status.Value);
        }

        internal partial class RedisPatchingCompletedEventDataConverter : JsonConverter<RedisPatchingCompletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, RedisPatchingCompletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override RedisPatchingCompletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRedisPatchingCompletedEventData(document.RootElement);
            }
        }
    }
}
