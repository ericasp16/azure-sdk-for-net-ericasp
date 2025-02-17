// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Defines a health policy used to evaluate the health of an application or one of its children entities.
    ///
    /// </summary>
    public partial class ApplicationHealthPolicy
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

        /// <summary> Initializes a new instance of <see cref="ApplicationHealthPolicy"/>. </summary>
        public ApplicationHealthPolicy()
        {
            ServiceTypeHealthPolicies = new ChangeTrackingDictionary<string, ServiceTypeHealthPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationHealthPolicy"/>. </summary>
        /// <param name="defaultServiceTypeHealthPolicy"> The health policy used by default to evaluate the health of a service type. </param>
        /// <param name="serviceTypeHealthPolicies"> The map with service type health policy per service type name. The map is empty by default. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationHealthPolicy(ServiceTypeHealthPolicy defaultServiceTypeHealthPolicy, IDictionary<string, ServiceTypeHealthPolicy> serviceTypeHealthPolicies, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DefaultServiceTypeHealthPolicy = defaultServiceTypeHealthPolicy;
            ServiceTypeHealthPolicies = serviceTypeHealthPolicies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The health policy used by default to evaluate the health of a service type. </summary>
        internal ServiceTypeHealthPolicy DefaultServiceTypeHealthPolicy { get; set; }
        /// <summary>
        /// The maximum percentage of services allowed to be unhealthy before your application is considered in error.
        ///
        /// </summary>
        public int? MaxPercentUnhealthyServices
        {
            get => DefaultServiceTypeHealthPolicy is null ? default : DefaultServiceTypeHealthPolicy.MaxPercentUnhealthyServices;
            set
            {
                if (DefaultServiceTypeHealthPolicy is null)
                    DefaultServiceTypeHealthPolicy = new ServiceTypeHealthPolicy();
                DefaultServiceTypeHealthPolicy.MaxPercentUnhealthyServices = value;
            }
        }

        /// <summary> The map with service type health policy per service type name. The map is empty by default. </summary>
        public IDictionary<string, ServiceTypeHealthPolicy> ServiceTypeHealthPolicies { get; }
    }
}
