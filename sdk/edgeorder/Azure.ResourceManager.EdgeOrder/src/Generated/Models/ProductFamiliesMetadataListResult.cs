// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.EdgeOrder;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Holds details about product family metadata. </summary>
    internal partial class ProductFamiliesMetadataListResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProductFamiliesMetadataListResult"/>. </summary>
        internal ProductFamiliesMetadataListResult()
        {
            Value = new ChangeTrackingList<ProductFamiliesMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="ProductFamiliesMetadataListResult"/>. </summary>
        /// <param name="value"> List of product family metadata details. </param>
        /// <param name="nextLink"> Link for the next set of product families. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProductFamiliesMetadataListResult(IReadOnlyList<ProductFamiliesMetadata> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of product family metadata details. </summary>
        public IReadOnlyList<ProductFamiliesMetadata> Value { get; }
        /// <summary> Link for the next set of product families. </summary>
        public string NextLink { get; }
    }
}
