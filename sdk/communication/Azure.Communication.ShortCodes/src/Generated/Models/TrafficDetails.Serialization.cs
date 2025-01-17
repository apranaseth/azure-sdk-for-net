// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class TrafficDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (TotalMonthlyVolume.HasValue)
            {
                writer.WritePropertyName("totalMonthlyVolume"u8);
                writer.WriteNumberValue(TotalMonthlyVolume.Value);
            }
            if (MonthlyAverageMessagesFromUser.HasValue)
            {
                writer.WritePropertyName("monthlyAverageMessagesFromUser"u8);
                writer.WriteNumberValue(MonthlyAverageMessagesFromUser.Value);
            }
            if (MonthlyAverageMessagesToUser.HasValue)
            {
                writer.WritePropertyName("monthlyAverageMessagesToUser"u8);
                writer.WriteNumberValue(MonthlyAverageMessagesToUser.Value);
            }
            if (IsSpiky.HasValue)
            {
                writer.WritePropertyName("isSpiky"u8);
                writer.WriteBooleanValue(IsSpiky.Value);
            }
            if (SpikeDetails != null)
            {
                writer.WritePropertyName("spikeDetails"u8);
                writer.WriteStringValue(SpikeDetails);
            }
            if (EstimatedRampUpTimeInDays.HasValue)
            {
                writer.WritePropertyName("estimatedRampUpTimeInDays"u8);
                writer.WriteNumberValue(EstimatedRampUpTimeInDays.Value);
            }
            writer.WriteEndObject();
        }

        internal static TrafficDetails DeserializeTrafficDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> totalMonthlyVolume = default;
            Optional<int> monthlyAverageMessagesFromUser = default;
            Optional<int> monthlyAverageMessagesToUser = default;
            Optional<bool> isSpiky = default;
            Optional<string> spikeDetails = default;
            Optional<int> estimatedRampUpTimeInDays = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalMonthlyVolume"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMonthlyVolume = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monthlyAverageMessagesFromUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyAverageMessagesFromUser = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monthlyAverageMessagesToUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyAverageMessagesToUser = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isSpiky"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSpiky = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("spikeDetails"u8))
                {
                    spikeDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("estimatedRampUpTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedRampUpTimeInDays = property.Value.GetInt32();
                    continue;
                }
            }
            return new TrafficDetails(Optional.ToNullable(totalMonthlyVolume), Optional.ToNullable(monthlyAverageMessagesFromUser), Optional.ToNullable(monthlyAverageMessagesToUser), Optional.ToNullable(isSpiky), spikeDetails.Value, Optional.ToNullable(estimatedRampUpTimeInDays));
        }
    }
}
