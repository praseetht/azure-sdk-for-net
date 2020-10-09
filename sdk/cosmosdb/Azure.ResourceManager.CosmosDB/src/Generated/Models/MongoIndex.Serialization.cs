// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoIndex : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key");
                writer.WriteObjectValue(Key);
            }
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options");
                writer.WriteObjectValue(Options);
            }
            writer.WriteEndObject();
        }

        internal static MongoIndex DeserializeMongoIndex(JsonElement element)
        {
            Optional<MongoIndexKeys> key = default;
            Optional<MongoIndexOptions> options = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = MongoIndexKeys.DeserializeMongoIndexKeys(property.Value);
                    continue;
                }
                if (property.NameEquals("options"))
                {
                    options = MongoIndexOptions.DeserializeMongoIndexOptions(property.Value);
                    continue;
                }
            }
            return new MongoIndex(key.Value, options.Value);
        }
    }
}
