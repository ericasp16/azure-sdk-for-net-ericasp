// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging. </summary>
    public partial class IotHubRoutingProperties
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

        /// <summary> Initializes a new instance of <see cref="IotHubRoutingProperties"/>. </summary>
        public IotHubRoutingProperties()
        {
            Routes = new ChangeTrackingList<RoutingRuleProperties>();
            Enrichments = new ChangeTrackingList<IotHubEnrichmentProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="IotHubRoutingProperties"/>. </summary>
        /// <param name="endpoints"> The properties related to the custom endpoints to which your IoT hub routes messages based on the routing rules. A maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint is allowed across all endpoint types for free hubs. </param>
        /// <param name="routes"> The list of user-provided routing rules that the IoT hub uses to route messages to built-in and custom endpoints. A maximum of 100 routing rules are allowed for paid hubs and a maximum of 5 routing rules are allowed for free hubs. </param>
        /// <param name="fallbackRoute"> The properties of the route that is used as a fall-back route when none of the conditions specified in the 'routes' section are met. This is an optional parameter. When this property is not present in the template, the fallback route is disabled by default. </param>
        /// <param name="enrichments"> The list of user-provided enrichments that the IoT hub applies to messages to be delivered to built-in and custom endpoints. See: https://aka.ms/telemetryoneventgrid. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubRoutingProperties(RoutingEndpoints endpoints, IList<RoutingRuleProperties> routes, IotHubFallbackRouteProperties fallbackRoute, IList<IotHubEnrichmentProperties> enrichments, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Endpoints = endpoints;
            Routes = routes;
            FallbackRoute = fallbackRoute;
            Enrichments = enrichments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The properties related to the custom endpoints to which your IoT hub routes messages based on the routing rules. A maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint is allowed across all endpoint types for free hubs. </summary>
        public RoutingEndpoints Endpoints { get; set; }
        /// <summary> The list of user-provided routing rules that the IoT hub uses to route messages to built-in and custom endpoints. A maximum of 100 routing rules are allowed for paid hubs and a maximum of 5 routing rules are allowed for free hubs. </summary>
        public IList<RoutingRuleProperties> Routes { get; }
        /// <summary> The properties of the route that is used as a fall-back route when none of the conditions specified in the 'routes' section are met. This is an optional parameter. When this property is not present in the template, the fallback route is disabled by default. </summary>
        public IotHubFallbackRouteProperties FallbackRoute { get; set; }
        /// <summary> The list of user-provided enrichments that the IoT hub applies to messages to be delivered to built-in and custom endpoints. See: https://aka.ms/telemetryoneventgrid. </summary>
        public IList<IotHubEnrichmentProperties> Enrichments { get; }
    }
}
