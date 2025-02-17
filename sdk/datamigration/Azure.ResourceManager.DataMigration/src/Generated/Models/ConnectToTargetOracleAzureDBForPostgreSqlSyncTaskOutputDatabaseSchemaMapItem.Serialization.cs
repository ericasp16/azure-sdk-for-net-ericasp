// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem : IUtf8JsonSerializable, IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            if (Optional.IsCollectionDefined(Schemas))
            {
                writer.WritePropertyName("schemas"u8);
                writer.WriteStartArray();
                foreach (var item in Schemas)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem(document.RootElement, options);
        }

        internal static ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string database = default;
            IReadOnlyList<string> schemas = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("database"u8))
                {
                    database = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    schemas = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem(database, schemas ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem)} does not support '{options.Format}' format.");
            }
        }

        ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
