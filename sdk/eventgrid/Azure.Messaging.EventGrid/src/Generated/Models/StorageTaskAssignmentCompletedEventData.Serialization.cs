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
    [JsonConverter(typeof(StorageTaskAssignmentCompletedEventDataConverter))]
    public partial class StorageTaskAssignmentCompletedEventData
    {
        internal static StorageTaskAssignmentCompletedEventData DeserializeStorageTaskAssignmentCompletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageTaskAssignmentCompletedStatus> status = default;
            Optional<DateTimeOffset> completedDateTime = default;
            Optional<string> taskExecutionId = default;
            Optional<string> taskName = default;
            Optional<Uri> summaryReportBlobUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new StorageTaskAssignmentCompletedStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("completedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskExecutionId"u8))
                {
                    taskExecutionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summaryReportBlobUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summaryReportBlobUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new StorageTaskAssignmentCompletedEventData(Optional.ToNullable(status), Optional.ToNullable(completedDateTime), taskExecutionId.Value, taskName.Value, summaryReportBlobUrl.Value);
        }

        internal partial class StorageTaskAssignmentCompletedEventDataConverter : JsonConverter<StorageTaskAssignmentCompletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageTaskAssignmentCompletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override StorageTaskAssignmentCompletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageTaskAssignmentCompletedEventData(document.RootElement);
            }
        }
    }
}
