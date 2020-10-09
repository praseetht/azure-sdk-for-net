// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class MetricSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TimeGrain))
            {
                writer.WritePropertyName("timeGrain");
                writer.WriteStringValue(TimeGrain.Value, "P");
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category");
                writer.WriteStringValue(Category);
            }
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy");
                writer.WriteObjectValue(RetentionPolicy);
            }
            writer.WriteEndObject();
        }

        internal static MetricSettings DeserializeMetricSettings(JsonElement element)
        {
            Optional<TimeSpan> timeGrain = default;
            Optional<string> category = default;
            bool enabled = default;
            Optional<RetentionPolicy> retentionPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeGrain"))
                {
                    timeGrain = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retentionPolicy"))
                {
                    retentionPolicy = RetentionPolicy.DeserializeRetentionPolicy(property.Value);
                    continue;
                }
            }
            return new MetricSettings(Optional.ToNullable(timeGrain), category.Value, enabled, retentionPolicy.Value);
        }
    }
}
