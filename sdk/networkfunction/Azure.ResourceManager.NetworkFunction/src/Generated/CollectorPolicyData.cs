// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkFunction.Models;

namespace Azure.ResourceManager.NetworkFunction
{
    /// <summary>
    /// A class representing the CollectorPolicy data model.
    /// Collector policy resource.
    /// </summary>
    public partial class CollectorPolicyData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="CollectorPolicyData"/>. </summary>
        /// <param name="location"> The location. </param>
        public CollectorPolicyData(AzureLocation location) : base(location)
        {
            EmissionPolicies = new ChangeTrackingList<EmissionPoliciesPropertiesFormat>();
        }

        /// <summary> Initializes a new instance of <see cref="CollectorPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ingestionPolicy"> Ingestion policies. </param>
        /// <param name="emissionPolicies"> Emission policies. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CollectorPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, IngestionPolicyPropertiesFormat ingestionPolicy, IList<EmissionPoliciesPropertiesFormat> emissionPolicies, CollectorProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            IngestionPolicy = ingestionPolicy;
            EmissionPolicies = emissionPolicies;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CollectorPolicyData"/> for deserialization. </summary>
        internal CollectorPolicyData()
        {
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Ingestion policies. </summary>
        public IngestionPolicyPropertiesFormat IngestionPolicy { get; set; }
        /// <summary> Emission policies. </summary>
        public IList<EmissionPoliciesPropertiesFormat> EmissionPolicies { get; }
        /// <summary> The provisioning state. </summary>
        public CollectorProvisioningState? ProvisioningState { get; }
    }
}
