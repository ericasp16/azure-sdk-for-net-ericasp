// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment dependency information. </summary>
    public partial class ArmDependency
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

        /// <summary> Initializes a new instance of <see cref="ArmDependency"/>. </summary>
        internal ArmDependency()
        {
            DependsOn = new ChangeTrackingList<BasicArmDependency>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmDependency"/>. </summary>
        /// <param name="dependsOn"> The list of dependencies. </param>
        /// <param name="id"> The ID of the dependency. </param>
        /// <param name="resourceType"> The dependency resource type. </param>
        /// <param name="resourceName"> The dependency resource name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmDependency(IReadOnlyList<BasicArmDependency> dependsOn, string id, ResourceType? resourceType, string resourceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DependsOn = dependsOn;
            Id = id;
            ResourceType = resourceType;
            ResourceName = resourceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of dependencies. </summary>
        public IReadOnlyList<BasicArmDependency> DependsOn { get; }
        /// <summary> The ID of the dependency. </summary>
        public string Id { get; }
        /// <summary> The dependency resource type. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The dependency resource name. </summary>
        public string ResourceName { get; }
    }
}
