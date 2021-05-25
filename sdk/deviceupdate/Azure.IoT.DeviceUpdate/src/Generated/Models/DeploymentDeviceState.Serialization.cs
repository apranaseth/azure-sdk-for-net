// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate.Models
{
    public partial class DeploymentDeviceState
    {
        internal static DeploymentDeviceState DeserializeDeploymentDeviceState(JsonElement element)
        {
            string deviceId = default;
            int retryCount = default;
            bool movedOnToNewDeployment = default;
            DeviceDeploymentState deviceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retryCount"))
                {
                    retryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("movedOnToNewDeployment"))
                {
                    movedOnToNewDeployment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("deviceState"))
                {
                    deviceState = new DeviceDeploymentState(property.Value.GetString());
                    continue;
                }
            }
            return new DeploymentDeviceState(deviceId, retryCount, movedOnToNewDeployment, deviceState);
        }
    }
}
