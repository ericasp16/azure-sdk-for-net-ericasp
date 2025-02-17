// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> BackupAndExport API Request. </summary>
    public partial class MySqlFlexibleServerBackupAndExportContent : MySqlFlexibleServerBackupContentBase
    {
        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerBackupAndExportContent"/>. </summary>
        /// <param name="backupSettings"> Backup Settings. </param>
        /// <param name="targetDetails">
        /// Backup Target Store Details
        /// Please note <see cref="MySqlFlexibleServerBackupStoreDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MySqlFlexibleServerFullBackupStoreDetails"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupSettings"/> or <paramref name="targetDetails"/> is null. </exception>
        public MySqlFlexibleServerBackupAndExportContent(MySqlFlexibleServerBackupSettings backupSettings, MySqlFlexibleServerBackupStoreDetails targetDetails) : base(backupSettings)
        {
            Argument.AssertNotNull(backupSettings, nameof(backupSettings));
            Argument.AssertNotNull(targetDetails, nameof(targetDetails));

            TargetDetails = targetDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerBackupAndExportContent"/>. </summary>
        /// <param name="backupSettings"> Backup Settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="targetDetails">
        /// Backup Target Store Details
        /// Please note <see cref="MySqlFlexibleServerBackupStoreDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MySqlFlexibleServerFullBackupStoreDetails"/>.
        /// </param>
        internal MySqlFlexibleServerBackupAndExportContent(MySqlFlexibleServerBackupSettings backupSettings, IDictionary<string, BinaryData> serializedAdditionalRawData, MySqlFlexibleServerBackupStoreDetails targetDetails) : base(backupSettings, serializedAdditionalRawData)
        {
            TargetDetails = targetDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerBackupAndExportContent"/> for deserialization. </summary>
        internal MySqlFlexibleServerBackupAndExportContent()
        {
        }

        /// <summary>
        /// Backup Target Store Details
        /// Please note <see cref="MySqlFlexibleServerBackupStoreDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MySqlFlexibleServerFullBackupStoreDetails"/>.
        /// </summary>
        public MySqlFlexibleServerBackupStoreDetails TargetDetails { get; }
    }
}
