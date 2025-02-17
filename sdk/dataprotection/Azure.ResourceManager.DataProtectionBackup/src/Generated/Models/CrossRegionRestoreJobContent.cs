// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Details of CRR Job to be fetched. </summary>
    public partial class CrossRegionRestoreJobContent
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

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreJobContent"/>. </summary>
        /// <param name="sourceRegion"></param>
        /// <param name="sourceBackupVaultId"></param>
        /// <param name="jobId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceBackupVaultId"/> is null. </exception>
        public CrossRegionRestoreJobContent(AzureLocation sourceRegion, ResourceIdentifier sourceBackupVaultId, Guid jobId)
        {
            Argument.AssertNotNull(sourceBackupVaultId, nameof(sourceBackupVaultId));

            SourceRegion = sourceRegion;
            SourceBackupVaultId = sourceBackupVaultId;
            JobId = jobId;
        }

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreJobContent"/>. </summary>
        /// <param name="sourceRegion"></param>
        /// <param name="sourceBackupVaultId"></param>
        /// <param name="jobId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CrossRegionRestoreJobContent(AzureLocation sourceRegion, ResourceIdentifier sourceBackupVaultId, Guid jobId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceRegion = sourceRegion;
            SourceBackupVaultId = sourceBackupVaultId;
            JobId = jobId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreJobContent"/> for deserialization. </summary>
        internal CrossRegionRestoreJobContent()
        {
        }

        /// <summary> Gets the source region. </summary>
        public AzureLocation SourceRegion { get; }
        /// <summary> Gets the source backup vault id. </summary>
        public ResourceIdentifier SourceBackupVaultId { get; }
        /// <summary> Gets the job id. </summary>
        public Guid JobId { get; }
    }
}
