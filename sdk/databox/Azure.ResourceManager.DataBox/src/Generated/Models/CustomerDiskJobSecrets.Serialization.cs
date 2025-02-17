// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class CustomerDiskJobSecrets : IUtf8JsonSerializable, IJsonModel<CustomerDiskJobSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomerDiskJobSecrets>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomerDiskJobSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerDiskJobSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerDiskJobSecrets)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(DiskSecrets))
            {
                writer.WritePropertyName("diskSecrets"u8);
                writer.WriteStartArray();
                foreach (var item in DiskSecrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CarrierAccountNumber))
            {
                writer.WritePropertyName("carrierAccountNumber"u8);
                writer.WriteStringValue(CarrierAccountNumber);
            }
            writer.WritePropertyName("jobSecretsType"u8);
            writer.WriteStringValue(JobSecretsType.ToSerialString());
            if (options.Format != "W" && Optional.IsDefined(DataCenterAccessSecurityCode))
            {
                writer.WritePropertyName("dcAccessSecurityCode"u8);
                writer.WriteObjectValue(DataCenterAccessSecurityCode);
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
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

        CustomerDiskJobSecrets IJsonModel<CustomerDiskJobSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerDiskJobSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerDiskJobSecrets)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomerDiskJobSecrets(document.RootElement, options);
        }

        internal static CustomerDiskJobSecrets DeserializeCustomerDiskJobSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataBoxDiskSecret> diskSecrets = default;
            string carrierAccountNumber = default;
            DataBoxOrderType jobSecretsType = default;
            DataCenterAccessSecurityCode dcAccessSecurityCode = default;
            ResponseError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSecrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxDiskSecret> array = new List<DataBoxDiskSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxDiskSecret.DeserializeDataBoxDiskSecret(item, options));
                    }
                    diskSecrets = array;
                    continue;
                }
                if (property.NameEquals("carrierAccountNumber"u8))
                {
                    carrierAccountNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobSecretsType"u8))
                {
                    jobSecretsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("dcAccessSecurityCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dcAccessSecurityCode = DataCenterAccessSecurityCode.DeserializeDataCenterAccessSecurityCode(property.Value, options);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomerDiskJobSecrets(
                jobSecretsType,
                dcAccessSecurityCode,
                error,
                serializedAdditionalRawData,
                diskSecrets ?? new ChangeTrackingList<DataBoxDiskSecret>(),
                carrierAccountNumber);
        }

        BinaryData IPersistableModel<CustomerDiskJobSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerDiskJobSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomerDiskJobSecrets)} does not support '{options.Format}' format.");
            }
        }

        CustomerDiskJobSecrets IPersistableModel<CustomerDiskJobSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerDiskJobSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomerDiskJobSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomerDiskJobSecrets)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomerDiskJobSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
